using Claims.Model;
using System;
using System.Collections.Generic;

namespace Claims.Repository
{
    public interface IClaimsRepository
    {
        MitchellClaim Get(string claimNumber);
        IEnumerable<MitchellClaim> GetList(DateTime startDate, DateTime endDate);
        void Create(MitchellClaim claim);
    }
}
