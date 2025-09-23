namespace PMApplication.Dtos
{
    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandLogo { get; set; }
        public bool ShelfLock { get; set; }
        public bool Disabled { get; set; }
        public int ThemeId { get; set; }
        public bool BrandShop { get; set; }
        public decimal AppVersion { get; set; }

        public BrandDto()
        {
        }
    }
}
