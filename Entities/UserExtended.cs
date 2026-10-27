using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Graph.Models.Security;

namespace PMApplication.Entities
{
    public class UserExtended : User
    {
        public int? extension_ff5105e3fc0248fbad7979cfe9b62e1a_DiamCountryId {get; set;}
        public int? extension_ff5105e3fc0248fbad7979cfe9b62e1a_Brands {get; set;}
        public int? extension_ff5105e3fc0248fbad7979cfe9b62e1a_DiamRoles {get; set;}
        public int? extension_ff5105e3fc0248fbad7979cfe9b62e1a_RoleId {get; set;}
        public int? extension_ff5105e3fc0248fbad7979cfe9b62e1a_Permissions {get; set;}
        public bool? extension_ff5105e3fc0248fbad7979cfe9b62e1a_Shopper {get; set;}
        public bool? extension_ff5105e3fc0248fbad7979cfe9b62e1a_OrderManager {get; set;}

        public string? extension_ff5105e3fc0248fbad7979cfe9b62e1a_UserEmailAddress {get; set;}
        public string? extension_ff5105e3fc0248fbad7979cfe9b62e1a_RegionList {get; set;}
        public string? extension_ff5105e3fc0248fbad7979cfe9b62e1a_CountryList {get; set;}
    }
}
