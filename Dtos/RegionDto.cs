namespace PMApplication.Dtos
{
    public class RegionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ZoneId { get; set; }
        public int? BrandId { get; set; }
        public string CountryList { get; set; }

        public RegionDto(string name)
        {
            Name = name;
        }
    }
}
