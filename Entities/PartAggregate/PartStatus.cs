using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.PartAggregate
{

    public enum PlanoItemStatusEnum : int
    {
        NewModule = 1,
        MovedModule = 2,
        NewGraphic = 3,
        NewSticker = 4,
        NotChanged = 0
    }

    public partial class PartStatus
    {
        [Key]
        public int PartStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Hex { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }
    }
}
