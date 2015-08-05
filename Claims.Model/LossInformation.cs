using System;
using System.ComponentModel;

namespace Claims.Model
{
    public class LossInformation
    {
        public CauseOfLossCode CauseOfLoss { get; set; }
        public DateTime ReportedDate { get; set; }
        public string LossDescription { get; set; }
    }

    public enum CauseOfLossCode
    {
        Collision,
        Explosion,
        Fire,
        Hail,
        [Description("Mechanical Breakdown")]
        MechanicalBreakdown,
        Other
    }
}
