using Claims.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Claims.Repository
{
    /// <summary>
    /// Repository with dummy data
    /// </summary>
    public class DummyClaimsRepository : IClaimsRepository
    {
        public MitchellClaim Get(string claimNumber)
        {   
            var claim = new MitchellClaim()
            {
                ClaimNumber = claimNumber,
                ClaimantFirstName = "George",
                ClaimantLastName = "Washington",
                Status = ClaimStatus.OPEN,
                LossDate = DateTime.Now.AddDays(-1),
                AssignedAdjusterID = 1234567,
                LossInfo = new LossInformation()
                {
                    CauseOfLoss = CauseOfLossCode.Collision,
                    ReportedDate = DateTime.Now,
                    LossDescription = "Crashed into an apple tree."
                },
                Vehicles = new List<VehicleDetails>()
                {
                    new VehicleDetails
                    {
                        Vin = "1M8GDM9AXKP042788",
                        ModelYear = 2005,
                        MakeDescription = "Ford",
                        ModelDescription = "Mustang",
                        EngineDescription = "EcoBoost",
                        ExteriorColor = "Deep Impact Blue",
                        LicPlate = "NO1PRES",
                        LicPlateState = "VA",
                        LicPlateExpDate = DateTime.Now.AddMonths(12),
                        DamageDescription = "Front end smashed in. Apple dents in roof.",
                        Mileage = 1776
                    }
                }
            };

            return claimNumber.Equals("22c9c23bac142856018ce14a26b6c299") ? claim : null;
        }

        public IEnumerable<MitchellClaim> GetList(DateTime startDate, DateTime endDate)
        {
            //Get a list of claims from the database for the date range passed in the parameters
            var claimList = new List<MitchellClaim>
            {
                new MitchellClaim 
                {
                    ClaimNumber = "22c9c23bac142856018ce14a26b6c299",
                    ClaimantFirstName = "George",
                    ClaimantLastName = "Washington",
                    Status = ClaimStatus.OPEN,
                    LossDate = DateTime.Parse("2014-07-09T17:19:13.631-07:00"),
                    AssignedAdjusterID = 1234567,
                    LossInfo = new LossInformation()
                    {
                        CauseOfLoss = CauseOfLossCode.Collision,
                        ReportedDate = DateTime.Now,
                        LossDescription = "Crashed into an apple tree."
                    },
                    Vehicles = new List<VehicleDetails>()
                    {
                        new VehicleDetails
                        {
                            Vin = "1M8GDM9AXKP042788",
                            ModelYear = 2005,
                            MakeDescription = "Ford",
                            ModelDescription = "Mustang",
                            EngineDescription = "EcoBoost",
                            ExteriorColor = "Deep Impact Blue",
                            LicPlate = "NO1PRES",
                            LicPlateState = "VA",
                            LicPlateExpDate = DateTime.Now.AddMonths(12),
                            DamageDescription = "Front end smashed in. Apple dents in roof.",
                            Mileage = 1776
                        }
                    }
                },
                new MitchellClaim 
                {
                    ClaimNumber = "22c9c23bac142856018ce14a26b6c288",
                    ClaimantFirstName = "George",
                    ClaimantLastName = "Washington",
                    Status = ClaimStatus.OPEN,
                    LossDate = DateTime.Parse("2014-08-09T17:19:13.631-07:00"),
                    AssignedAdjusterID = 1234567,
                    LossInfo = new LossInformation()
                    {
                        CauseOfLoss = CauseOfLossCode.Collision,
                        ReportedDate = DateTime.Now,
                        LossDescription = "Crashed into an apple tree."
                    },
                    Vehicles = new List<VehicleDetails>()
                    {
                        new VehicleDetails
                        {
                            Vin = "1M8GDM9AXKP042788",
                            ModelYear = 2005,
                            MakeDescription = "Ford",
                            ModelDescription = "Mustang",
                            EngineDescription = "EcoBoost",
                            ExteriorColor = "Deep Impact Blue",
                            LicPlate = "NO1PRES",
                            LicPlateState = "VA",
                            LicPlateExpDate = DateTime.Now.AddMonths(12),
                            DamageDescription = "Front end smashed in. Apple dents in roof.",
                            Mileage = 1776
                        }
                    }
                }
            };

            return claimList.Where(item => item.LossDate >= startDate && item.LossDate <= endDate);
        }

        public void Create(MitchellClaim claim)
        {
            //Add claim object to database
        }
    }
}
