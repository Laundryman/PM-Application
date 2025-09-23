namespace PMApplication.Dtos.PagedLists
{
    public partial class PagedCountriesListDto
    {
        public Page Page { get; set; }
        public List<CountryDto> Data { get; set; }
    }
}
