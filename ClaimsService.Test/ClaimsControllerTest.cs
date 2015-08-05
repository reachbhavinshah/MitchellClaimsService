using Claims.Repository;
using ClaimsService.Controllers;
using ClaimsService.Test.XML;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Hosting;

namespace ClaimsService.Test
{
    [TestClass]
    public class ClaimsControllerTest
    {
        private ClaimsController _ClaimsController;

        [TestInitialize()]
        public void Initialize()
        {
            _ClaimsController = new ClaimsController(new DummyClaimsRepository(), new TestServerPath());
            _ClaimsController.Request = new HttpRequestMessage();
            _ClaimsController.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
        }

        [TestMethod]
        public void GetClaimByClaimNumber()
        {   
            // Act
            HttpResponseMessage response = this._ClaimsController.Get("22c9c23bac142856018ce14a26b6c299");
            
            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void GetClaimByNonExistentClaimNumber()
        {
            // Act
            HttpResponseMessage response = this._ClaimsController.Get("22c9c23bac142856018ce14a26b6c288");

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void GetClaimsBetweenStartAndEndLossDate()
        {   
            // Act
            HttpResponseMessage response = this._ClaimsController.GetClaimsList("2014-07-02", "2014-08-10");

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void GetClaimsBetweenOutofRangeStartAndEndLossDate()
        {   
            // Act
            HttpResponseMessage response = this._ClaimsController.GetClaimsList("2014-07-02", "2014-07-03");

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void CreateClaim()
        {
            string content = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                                <cla:MitchellClaim xmlns:cla=""http://www.mitchell.com/examples/claim"">
                                    <cla:ClaimNumber>22c9c23bac142856018ce14a26b6c299</cla:ClaimNumber>
                                    <cla:ClaimantFirstName>George</cla:ClaimantFirstName>
                                    <cla:ClaimantLastName>Washington</cla:ClaimantLastName>
                                    <cla:Status>OPEN</cla:Status>
                                    <cla:LossDate>2014-07-09T17:19:13.631-07:00</cla:LossDate>
                                    <cla:LossInfo>
                                    <cla:CauseOfLoss>Collision</cla:CauseOfLoss>
                                    <cla:ReportedDate>2014-07-10T17:19:13.676-07:00</cla:ReportedDate>
                                    <cla:LossDescription>Crashed into an apple tree.</cla:LossDescription>
                                    </cla:LossInfo>
                                    <cla:AssignedAdjusterID>12345</cla:AssignedAdjusterID>
                                    <cla:Vehicles>
                                    <cla:VehicleDetails>
                                        <cla:Vin>1M8GDM9AXKP042788</cla:Vin>
                                        <cla:ModelYear>2015</cla:ModelYear>
                                        <cla:MakeDescription>Ford</cla:MakeDescription>
                                        <cla:ModelDescription>Mustang</cla:ModelDescription>
                                        <cla:EngineDescription>EcoBoost</cla:EngineDescription>
                                        <cla:ExteriorColor>Deep Impact Blue</cla:ExteriorColor>
                                        <cla:LicPlate>NO1PRES</cla:LicPlate>
                                        <cla:LicPlateState>VA</cla:LicPlateState>
                                        <cla:LicPlateExpDate>2015-03-10-07:00</cla:LicPlateExpDate>
                      -                   <cla:DamageDescription>Front end smashed in. Apple dents in roof.</cla:DamageDescription>
                                        <cla:Mileage>1776</cla:Mileage>
                                    </cla:VehicleDetails>
                                    </cla:Vehicles>
                                </cla:MitchellClaim>";
            // Arrange
            var requestMessage = new HttpRequestMessage();
            requestMessage.Content = new StringContent(content, Encoding.UTF8, "application/xml");

            // Act
            HttpResponseMessage message = this._ClaimsController.Create(requestMessage);
            
            // Assert
            Assert.AreEqual(HttpStatusCode.OK, message.StatusCode);
        }
    }
}