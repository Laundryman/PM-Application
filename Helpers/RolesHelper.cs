using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using PMApplication.Entities;
using PMApplication.Enums;
namespace PMApplication.Helpers
{
    //public enum Role : int
    //{
    //    Administrator = 1,
    //    Validator = 2,
    //    Editor = 3,
    //    Approver = 4

    //}
    public class RolesHelper
    {
        //public static void Initialize(IConfiguration config)
        //{
        //    Config = config;
        //}
        private static IConfiguration Config { get; set; }

        public RolesHelper()
        {
            Config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        //public static IConfiguration GetConfig()
        //{
        //    var env = System.Environment.GetEnvironmentVariable("ASPNETFRAMEWORK_ENVIRONMENT");
        //    //var settingsFile = "appsettings." + env + ".json";
        //    var settingsFile = "appsettings.json";
        //    Config = new ConfigurationBuilder()
        //        .AddJsonFile(settingsFile)
        //        .Build();
        //    return Config;
        //}
        //

        #region Roles

        public static bool IsAdministrator(int roleId)
        {
            return roleId == (int)RoleEnum.Administrator;
        }

        public static bool IsManager(int roleId)
        {
            return roleId == (int)RoleEnum.Manager;
        }

        public static bool IsDesigner(int roleId)
        {
            return roleId == (int)RoleEnum.Designer;
        }

        public static bool IsAdminUser(int RoleId)
        {
            return RoleId == (int)RoleEnum.Administrator;
        }

        public static RoleEnum GetUserRole(string roleId)
        {
            //Config = config;
            if (IsAdministrator(int.Parse(roleId)))
            {
                return RoleEnum.Administrator;
            }

            if (IsDesigner(int.Parse(roleId)))
            {
                return RoleEnum.Designer;
            }

            if (IsManager(int.Parse(roleId)))
            {
                return RoleEnum.Manager;
            }

            return RoleEnum.Designer;
        }

        #endregion

        #region permissions

        public static bool IsClientEditor(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Edit)
                {
                    return true;
                }
            }

            return false;
        }
        //public static bool IsRegionalUser(string Roles)
        //{
        //    string[] str_diamRoles = Config["DiamRoles:regionalRoles"].Split(new char[] { ',' });
        //    int[] diamRoles = Array.ConvertAll(str_diamRoles, s => int.Parse(s));
        //    string[] str_roles = Roles.Split(new char[] { ',' });
        //    int[] roles = Array.ConvertAll(str_roles, s => int.Parse(s));

        //    // Execute the following logic for Items and Alternating Items.
        //    foreach (int role in roles)
        //    {
        //        if (diamRoles.Contains(role))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}


        public static bool IsClientValidator(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Validate)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsEditor(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Edit)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsApprover(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Approve)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidator(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Validate)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsShopper(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Shop)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsAdminShopper(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Shop)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsArchiver(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Archive)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsCreator(string permissions)
        {
            var permArray = permissions.Split(new char[] { ',' });
            foreach (var perm in permArray)
            {
                if (int.Parse(perm) == (int)PermissionEnum.Create)
                {
                    return true;
                }
            }

            return false;
        }


        #endregion


    }

}