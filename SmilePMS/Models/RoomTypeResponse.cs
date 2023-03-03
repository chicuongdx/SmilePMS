namespace SmilePMS.Models
{
    public class RoomTypeResponse
    {
        public RoomTypeResponse()
        {
            RoomTypeCode = string.Empty;
            Description= string.Empty;
        }
        public string RoomTypeCode { get; set; }
        public string Description { get; set; }
    }
}
