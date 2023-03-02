using System;
using System.Collections.Generic;

namespace SmilePMS.Entities
{
    public partial class ReservationGuest
    {
        public string FolioNum { get; set; } = null!;
        public string IdAddition { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? Gender { get; set; }
        public string? Passport { get; set; }
        public string? Cccd { get; set; }
        public string? Cmnd { get; set; }
        public string? Gplx { get; set; }
        public string? Visa { get; set; }
        public DateTime? ExpDateVisa { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CardNumber { get; set; }
        public string? GuestSn { get; set; }
        public bool? IsChild { get; set; }
        public string? AdtStatus { get; set; }
        public string? NationalCode { get; set; }
        public string? Language { get; set; }
        public bool? IsAutoRes { get; set; }

        public virtual ReservationDetail FolioNumNavigation { get; set; } = null!;
    }
}
