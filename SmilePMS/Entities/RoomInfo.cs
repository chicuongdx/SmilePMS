using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SmilePMS.Entities
{
    public class RoomInfo
    {
        public int RoomCode { get; set; }

        [Display(Name = "Floor")]
        public int FloorNum { get; set; }
        public string RoomTypeCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? IsAvailability { get; set; }
        public int? Inspected { get; set; }

        public virtual RoomType RoomTypeCodeNavigation { get; set; } = null!;
    }
}
