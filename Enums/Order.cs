using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Enums
{
    public enum OrderStatusEnum : int
    {
        [Display(Name = "Open")]
        Open = 1,
        [Display(Name = "Submitted")]
        Submitted = 2,
        [Display(Name = "Cancelled")]
        Cancelled = 3,
        [Display(Name = "Received")]
        Received = 4,
        [Display(Name = "Approved")]
        Approved = 5
    }
}
