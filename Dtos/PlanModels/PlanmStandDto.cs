using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmStandDto
    {

        public int StandId { get; set; }
        public int StandTypeId { get; set; }
        public int ParentStandTypeId { get; set; }
        public string StandTypeName { get; set; }
        public string ParentStandTypeName { get; set; }
        public int BrandId { get; set; }
        public bool IsUsed { get; set; }
        public bool ShelfLock { get; set; }


        //--------------------- Section 1 GENERAL ----------------------------------
        public string Name { get; set; }
        public string StandAssemblyNumber { get; set; }
        public byte LayoutStyle { get; set; }
        public short Height { get; set; }
        public short Width { get; set; }


        //--------------------- Section 2 MERCHANDISING ---------------------------
        public int MerchHeight { get; set; }
        public int MerchWidth { get; set; }
        public int HeaderHeight { get; set; }
        public int HeaderWidth { get; set; }
        public int FooterHeight { get; set; }
        public int FooterWidth { get; set; }


        //--------------------- Section 3 COLS ------------------------------------
        public int Cols { get; set; }
        public bool EqualCols { get; set; }
        public int DefaultColWidth { get; set; }
        public int HorizontalPitchCount { get; set; }
        public int HorizontalPitchSize { get; set; }

        //--------------------- Section 4 ROWS ------------------------------------
        public int? Rows { get; set; }
        public bool EqualRows { get; set; }
        public int? DefaultRowHeight { get; set; }
        public int shelfIncrement { get; set; }

        //--------------------- Section 5 OTHER -----------------------------------
        public string HeaderGraphic { get; set; }
        public string HeaderGraphicLocation { get; set; }

        public decimal? StandCost { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateAvailable { get; set; }

        public bool Published { get; set; }
        public bool Discontinued { get; set; }
        public int CountryId { get; set; }
        public List<int> CountryIds { get; set; }

        public bool? SpanShelves { get; set; }
        public bool? AllowOverHang { get; set; }

        public virtual IEnumerable<PlanmStandColumnDto> ColumnList { get; set; }
        public virtual IEnumerable<PlanmStandRowDto> RowList { get; set; }
    }
}
