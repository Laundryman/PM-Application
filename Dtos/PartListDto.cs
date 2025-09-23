using System.ComponentModel.DataAnnotations;

namespace PMApplication.Dtos
{
    public partial class PartListDto
    {


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public short Facings { get; set; }
        public short Height { get; set; }
        public short Width { get; set; }
        public short Depth { get; set; }
        public short Stock { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string CustomerRefNo { get; set; }
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ParentCategoryName { get; set; }
        public int PartTypeId { get; set; }
        public string PartTypeName { get; set; }
        public short ShoppingHeight { get; set; }
        public int BrandId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Published { get; set; }
    }
}
