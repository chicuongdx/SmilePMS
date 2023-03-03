using System.ComponentModel.DataAnnotations;

namespace SmilePMS.Models
{
    public class RoomResponse
    {
        public int RoomId { get; set;}

        public string? RoomType { get; set;}

        public string? Description { get; set;}

        // if 0 mean true, 1 mean available, null string will empty
        public bool? isAvailability { get; set;}

        public int? Inspected { get; set;}
    }
}
