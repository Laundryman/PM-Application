namespace PMApplication.Dtos
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? RegionId { get; set; }
        public string ThreeLetterIsoCode { get; set; }
        public string TwoLetterIsoCode { get; set; }
        public bool? Active { get; set; }
        public string? FlagFileName { get; set; }

        public CountryDto(string name)
        {
            Name = name;
        }
    }
}
