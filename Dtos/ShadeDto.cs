namespace PMApplication.Dtos
{
    public class ShadeDto
    {
        public int Id { get; set; }
        public string ShadeNumber { get; set; }
        public string ShadeDescription { get; set; }
        public int ProductId { get; set; }
        public bool Published { get; set; }
        public string CountryList { get; set; }
        public List<CountryDto> Countries { get; set; }
    }
}
