namespace JiaJiao.Bus
{
    using JiaJiao.Data;
    using System;
    using System.Data;

    public class AccountsTool
    {
        public static DataSet GetAllCategories()
        {
            PermissionCategory category = new PermissionCategory();
            return category.GetCategoryList();
        }

        public static DataSet GetAllPermissions()
        {
            Permission permission = new Permission();
            return permission.GetPermissionList();
        }

        public static DataSet GetPermissionsByCategory(int categoryID)
        {
            PermissionCategory category = new PermissionCategory();
            return category.GetPermissionsInCategory(categoryID);
        }

        public static DataSet GetRoleList()
        {
            JiaJiao.Data.Role role = new JiaJiao.Data.Role();
            return role.GetRoleList();
        }
    }
}

