namespace HotelProject.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutUsID { get; set; }
        public string Title1 { get; set; } = string.Empty;
        public string Title2 { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int RoomCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
