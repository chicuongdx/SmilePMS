using System;
using System.Collections.Generic;

namespace SmilePMS.Entities
{
    public partial class RoomType
    {
        public RoomType()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
            RoomInfos = new HashSet<RoomInfo>();
        }

        public string RoomTypeCode { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; }
        public virtual ICollection<RoomInfo> RoomInfos { get; set; }
    }
}
