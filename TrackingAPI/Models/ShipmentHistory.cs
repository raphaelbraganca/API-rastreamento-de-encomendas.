using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TrackingAPI.Models
{
    public partial class ShipmentHistory
    {
        public Guid HisPk { get; set; }
        public string HisShipmentNumber { get; set; }
        public string HisTransportMode { get; set; }
        public string HisDeliverAddress { get; set; }
        public string HisConsolNumber { get; set; }
        public string HisOrigin { get; set; }
        public string HisDestination { get; set; }
        public string HisWeight { get; set; }
        public string HisVolume { get; set; }
        public string HisEtd { get; set; }
        public string HisEta { get; set; }
        public string HisClientFullName { get; set; }
        public string HisShipper { get; set; }
        public string HisConsignee { get; set; }
        public string HisLocalClient { get; set; }
        public string HisNotifyParty { get; set; }
        public string HisVoyage { get; set; }
        public DateTime? HisInsertDate { get; set; }
        public DateTime? HisUpdateDate { get; set; }
        public string HisStatus { get; set; }
    }

    [NotMapped]
    public partial class ShipmentHistoryJs
    {
        public Guid HisPk { get; set; }
        public string HisShipmentNumber { get; set; }
        public string HisTransportMode { get; set; }
        public string HisDeliverAddress { get; set; }
        public string HisConsolNumber { get; set; }
        public string HisOrigin { get; set; }
        public string HisDestination { get; set; }
        public string HisWeight { get; set; }
        public string HisVolume { get; set; }
        public string HisEtd { get; set; }
        public string HisEta { get; set; }
        public string HisClientFullName { get; set; }
        public string HisShipper { get; set; }
        public string HisConsignee { get; set; }
        public string HisLocalClient { get; set; }
        public string HisNotifyParty { get; set; }
        public string HisVoyage { get; set; }
        public DateTime? HisInsertDate { get; set; }
        public DateTime? HisUpdateDate { get; set; }
        public string HisStatus { get; set; }
        public long HiiId { get; set; }
        public Guid HiiHis { get; set; }
        public string HiiEventCode { get; set; }
        public DateTime? HiiEventDate { get; set; }
        public string HiiStatusDetail { get; set; }
        public string HiiObservation { get; set; }
        public string HiiLocation { get; set; }
    }
}
