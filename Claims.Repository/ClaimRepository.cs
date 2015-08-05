using Claims.Model;
using System;
using System.Collections.Generic;

namespace Claims.Repository
{
    public class ClaimsRepository : IClaimsRepository
    {
        public MitchellClaim Get(string claimNumber)
        {
            //Get claim by claim number from the database
            
            //Implement and return MitchellClaim object read from database 

            return new MitchellClaim();
        }

        public IEnumerable<MitchellClaim> GetList(DateTime startDate, DateTime endDate)
        {
            //Get a list of claims from the database for the date range passed in the parameters

            //Implement and return a list of MitchellClaim objects read from database for the date range passed

            return new List<MitchellClaim>();
        }

        public void Create(MitchellClaim claim)
        {
            //Add claim object to database
        }
    }
}