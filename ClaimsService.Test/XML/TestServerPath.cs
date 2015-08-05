using ClaimsService.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsService.Test.XML
{
    public class TestServerPath : IServerPath
    {
        public string MapPath(string path)
        {
            return Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "XML\\MitchellClaim.xsd");
        }
    }
}
