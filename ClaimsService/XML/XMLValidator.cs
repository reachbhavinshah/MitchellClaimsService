using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml;
using System.Xml.Schema;

namespace ClaimsService.XML
{
    /// <summary>
    /// This class validates claim xml input against the MitchellClaim.xsd.
    /// </summary>
    public class XsdValidator
    {
        private IServerPath _ServerPath;

        public List<String> Errors { get; set; }
        public List<String> Warnings { get; set; }

        public XsdValidator(IServerPath serverPath)
        {
            this._ServerPath = serverPath;
        }

        public bool IsValidXml(Stream xmlStream)
        {
            // Reset the Error/Warning collections
            Errors = new List<string>();
            Warnings = new List<string>();

            var settings = new XmlReaderSettings
            {
                ValidationType = ValidationType.Schema
            };
            settings.ValidationEventHandler += ValidationEventHandler;
            settings.Schemas.Add(ConfigurationManager.AppSettings["XMLNamespace"], this._ServerPath.MapPath("~\\XML\\MitchellClaim.xsd"));
           
            using (var xmlFile = XmlReader.Create(xmlStream, settings))
            {
                try
                {
                    while (xmlFile.Read()) { }
                }
                catch (XmlException xmlException)
                {
                    Errors.Add(xmlException.Message);
                }
            }

            return !Errors.Any() && !Warnings.Any();
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Errors.Add(e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Warnings.Add(e.Message);
                    break;
            }
        }
    }
}