using System.ComponentModel.DataAnnotations;

namespace PMApplication.Dtos
{

    public partial class PartTypeDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public PartTypeDto(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
