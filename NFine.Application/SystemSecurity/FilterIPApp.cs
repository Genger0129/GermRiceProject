/*******************************************************************************
 * Copyright © 2016 NFine.Framework 版权所有
 * Author: NFine
 * Description: NFine快速开发平台
 * Website：http://www.nfine.cn
*********************************************************************************/
using NFine.Code;
using NFine.Data;
using NFine.Domain.IRepository.SystemSecurity;
using NFine.Repository.SystemSecurity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Application.SystemSecurity
{
    public class FilterIPApp
    {
        private IFilterIPRepository service = new FilterIPRepository();

        public List<Sys_FilterIP> GetList(string keyword)
        {
            var expression = ExtLinq.True<Sys_FilterIP>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_StartIP.Contains(keyword));
            }
            return service.IQueryable(expression).OrderByDescending(t => t.F_DeleteTime).ToList();
        }
        public Sys_FilterIP GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }
        public void SubmitForm(Sys_FilterIP filterIPEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                filterIPEntity.F_Id = keyValue;
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    filterIPEntity.F_LastModifyUserId = LoginInfo.UserId;
                }
                filterIPEntity.F_LastModifyTime = DateTime.Now;
                service.Update(filterIPEntity);
            }
            else
            {
                filterIPEntity.F_Id = Common.GuId();
                var LoginInfo = OperatorProvider.Provider.GetCurrent();
                if (LoginInfo != null)
                {
                    filterIPEntity.F_CreatorUserId = LoginInfo.UserId;
                }
                filterIPEntity.F_CreatorTime = DateTime.Now;
                service.Insert(filterIPEntity);
            }
        }
    }
}
