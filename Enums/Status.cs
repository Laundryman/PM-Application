using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Enums
{
    public class StatusEnums
    {

        public enum PlanogramStatusEnum : int
        {
            Edit = 1,
            Submitted = 2,
            Ordered = 3,
            Deleted = 4,
            Approved = 5,
            Validated = 6,
            Archived = 7
        }
    }

    public class LoggingAction
    {
        public enum LogActionEnum : int
        {
            Login = 1,
            Logout = 2,
            SessionEnd = 3,
            Activate = 4,
            CreatePlano = 5,
            SubmitPlano = 6,
            ApprovePlano = 7,
            EditPlano = 8,
            CreateOrder = 9,
            EditOrder = 10,
            SubmitOrder = 11,
            ApproveOrder = 12,
            DeletePlano = 13,
            CopyPlano = 14,
            ValidatePlano = 15,
            UnValidatePlano = 16

        }
    }
}
