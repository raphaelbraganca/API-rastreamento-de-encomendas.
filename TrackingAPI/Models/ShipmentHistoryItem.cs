using System;
using System.Collections.Generic;

namespace TrackingAPI.Models
{
    public partial class ShipmentHistoryItem
    {
        public long HiiId { get; set; }
        public Guid HiiHis { get; set; }
        public string HiiEventCode { get; set; }
        public DateTime? HiiEventDate { get; set; }
        public string HiiStatusDetail { get; set; }
        public string HiiObservation { get; set; }
        public string HiiLocation { get; set; }
    }

    public partial class ShipmentHistoryItemJs
    {
        public long HiiId { get; set; }
        public Guid HiiHis { get; set; }
        public string HiiEventCode { get; set; }
        public string HiiEventDate { get; set; }
        public string HiiStatusDetail { get; set; }
        public string HiiObservation { get; set; }
        public string HiiLocation { get; set; }
    }
}
