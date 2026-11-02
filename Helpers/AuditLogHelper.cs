using PMApplication.Dtos;
using PMApplication.Entities;
using PMApplication.Enums;

namespace PMApplication.Helpers
{
    public static class AuditLogHelper
    {
        public static AuditLog BuildPlanoAuditLog<TActionEnum>(
            string? userId,
            CurrentUser? userProfile,
            int? brandId,
            string? brandName,
            string? countryName,
            string? regionName,
            long planogramId,
            string? planogramName,
            TActionEnum action,
            LogActionTypeEnum actionType,
            string message)
            where TActionEnum : struct, Enum
        {
            var roleId = int.TryParse(userProfile?.RoleId, out var parsedRoleId) ? parsedRoleId : 0;
            List<PermissionEnum> permissionList= PermissionEnum.GetValues(typeof(PermissionEnum)).Cast<PermissionEnum>().ToList();
            var permissions = string.Join(",", permissionList);
            if (roleId != (int)RoleEnum.Administrator)
            {
                permissions = userProfile.Permissions;
            }
            return new AuditLog
            {
                UserId = userId,
                Date = DateTime.Now,
                BrandId = brandId,
                Permissions = permissions,
                RoleId = roleId,
                RoleName = ((RoleEnum)roleId).ToString(),
                UserName = userProfile?.DisplayName,
                Action = Convert.ToInt32(action),
                ActionName = action.ToString(),
                ActionType = (int)actionType,
                Message = message,
                PlanoId = planogramId,
                PlanoName = planogramName,
                BrandName = brandName,
                CountryName = countryName,
                RegionName = regionName
            };
        }
    }
}