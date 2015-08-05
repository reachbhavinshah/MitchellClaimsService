using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Claims.Model
{
    public class MitchellClaim
    {
        public string ClaimNumber { get; set; }
        public string ClaimantFirstName { get; set; }
        public string ClaimantLastName { get; set; }
        public ClaimStatus Status { get; set; }
        public DateTime LossDate { get; set; }
        public LossInformation LossInfo { get; set; }
        public long AssignedAdjusterID { get; set; }
        public List<VehicleDetails> Vehicles { get; set; }
    }

    public enum ClaimStatus
    {
        OPEN,
        CLOSED
    }
}