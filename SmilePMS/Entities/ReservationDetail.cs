using System;
using System.Collections.Generic;

namespace SmilePMS.Entities
{
    public partial class ReservationDetail
    {
        public ReservationDetail()
        {
            ReservationGuests = new HashSet<ReservationGuest>();
        }

        public string ConfirmNum { get; set; } = null!;
        public string FolioNum { get; set; } = null!;
        public string? BookerName { get; set; }
        public DateTime? ArivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string? FolioStatus { get; set; }
        public string? Posted { get; set; }
        public string? RoomTypeCode { get; set; }
        public string? RoomCode { get; set; }
        public DateTime? ReservationTime { get; set; }
        public int? NumGuestAvai { get; set; }
        public int? NumGuestRes { get; set; }
        public int? NumGuestChildRes { get; set; }
        public int? NumEnfRes { get; set; }
        public int? NumEbd { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? CancelNum { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalPay { get; set; }
        public decimal? TotalBalance { get; set; }
        public bool? IncludeBf { get; set; }
        public string? BreakfastCode { get; set; }
        public bool? IsCheckin { get; set; }
        public string? Tacode { get; set; }
        public string? Taname { get; set; }
        public decimal? RateGuestCard { get; set; }

        public virtual ICollection<ReservationGuest> ReservationGuests { get; set; }
    }
}
