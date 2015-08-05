using Claims.Model;
using Claims.Repository;
using ClaimsService.XML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClaimsService.Controllers
{
    public class ClaimsController : ApiController
    {
        private IClaimsRepository _ClaimRepository;
        private IServerPath _ServerPath;

        public ClaimsController(IClaimsRepository claimRepository, IServerPath serverPath)
        {
            this._ClaimRepository = claimRepository;
            this._ServerPath = serverPath;
        }

        // GET claims/get/{claimNumber}
        [HttpGet]
        public HttpResponseMessage Get(string claimNumber)
        {
            if (String.IsNullOrEmpty(claimNumber))
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid claim number.");
            }

            try
            {
                var claim = this._ClaimRepository.Get(claimNumber);
                if (claim != null)
                {
                    return Request.CreateResponse<MitchellClaim>(HttpStatusCode.OK, claim);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, 
                                                        String.Format("Claim with claim number {0} does not exist.", claimNumber));
                }
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                                                    String.Format("Error finding claim with claim number {0}.", claimNumber));
            }
        }

        // GET claims/list/{startDate}/{endDate}
        [HttpGet]
        [ActionName("list")]
        public HttpResponseMessage GetClaimsList(string startDate, string endDate)
        {
            DateTime startLossDate, endLossDate;
            if (DateTime.TryParse(startDate, out startLossDate) &&
                DateTime.TryParse(endDate, out endLossDate))
            {
                try
                {
                    var claimList = _ClaimRepository.GetList(startLossDate, endLossDate);
                    if (claimList.Count() == 0)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                                                        String.Format("No claims found between loss dates {0} and {1}", startDate, endDate));
                    }
                    else
                    {
                        return Request.CreateResponse<IEnumerable<MitchellClaim>>(HttpStatusCode.OK, claimList);
                    }
                }
                catch
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                                                        String.Format("Error finding claims between loss dates {0} and {1}", startDate, endDate));
                }
            }
            else
            {
                //Error
                return Request.CreateResponse(HttpStatusCode.NotFound, "Invalid date(s).");
            }
        }

        // POST claims/create
        public HttpResponseMessage Create(HttpRequestMessage requestMessage)
        {
            if (requestMessage.Content == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid input XML.");
            }

            var stream = requestMessage.Content.ReadAsStreamAsync().Result;
            //Validate input xml against the xsd
            XsdValidator validator = new XsdValidator(this._ServerPath);
            if (!validator.IsValidXml(stream))
            {
                //Error
                var validationErrors = String.Join(" ", validator.Errors.ToArray());
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, 
                                                    String.Format("Error validating XML input. Details: {0}", validationErrors));
            }

            try
            {
                stream.Position = 0;
                var claim = SerializationHelper.Deserialize<MitchellClaim>(stream, ConfigurationManager.AppSettings["XMLNamespace"]);
                this._ClaimRepository.Create(claim);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch
            {
                //Error
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error in creating new claim.");
            }
        }
    }
}