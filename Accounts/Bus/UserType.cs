﻿namespace JiaJiao.Bus
{
    using JiaJiao.Data;
    using System;
    using System.Data;

    public class UserType
    {
        private JiaJiao.Data.UserType dal = new JiaJiao.Data.UserType();

        public void Add(string UserType, string Description)
        {
            this.dal.Add(UserType, Description);
        }

        public void Delete(string UserType)
        {
            this.dal.Delete(UserType);
        }

        public bool Exists(string UserType, string Description)
        {
            return this.dal.Exists(UserType, Description);
        }

        public DataSet GetAllList()
        {
            return this.GetList("");
        }

        public string GetDescription(string UserType)
        {
            return this.dal.GetDescription(UserType);
        }

        public DataSet GetList(string strWhere)
        {
            return this.dal.GetList(strWhere);
        }

        public void Update(string UserType, string Description)
        {
            this.dal.Update(UserType, Description);
        }
    }
}

