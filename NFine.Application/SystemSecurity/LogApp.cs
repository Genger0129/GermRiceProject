﻿/*******************************************************************************
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

namespace NFine.Application.SystemSecurity
{
    public class LogApp
    {
        private ILogRepository service = new LogRepository();

        public List<Sys_Log> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<Sys_Log>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Account.Contains(keyword));
            }
            if (!queryParam["timeType"].IsEmpty())
            {
                string timeType = queryParam["timeType"].ToString();
                DateTime startTime = DateTime.Now.ToString("yyyy-MM-dd").ToDate();
                DateTime endTime = DateTime.Now.ToString("yyyy-MM-dd").ToDate().AddDays(1);
                switch (timeType)
                {
                    case "1":
                        break;
                    case "2":
                        startTime = DateTime.Now.AddDays(-7);
                        break;
                    case "3":
                        startTime = DateTime.Now.AddMonths(-1);
                        break;
                    case "4":
                        startTime = DateTime.Now.AddMonths(-3);
                        break;
                    default:
                        break;
                }
                expression = expression.And(t => t.F_Date >= startTime && t.F_Date <= endTime);
            }
            return service.FindList(expression, pagination);
        }
        public void RemoveLog(string keepTime)
        {
            DateTime operateTime = DateTime.Now;
            if (keepTime == "7")            //保留近一周
            {
                operateTime = DateTime.Now.AddDays(-7);
            }
            else if (keepTime == "1")       //保留近一个月
            {
                operateTime = DateTime.Now.AddMonths(-1);
            }
            else if (keepTime == "3")       //保留近三个月
            {
                operateTime = DateTime.Now.AddMonths(-3);
            }
            var expression = ExtLinq.True<Sys_Log>();
            expression = expression.And(t => t.F_Date <= operateTime);
            service.Delete(expression);
        }
        public void WriteDbLog(bool result, string resultLog)
        {
            Sys_Log Sys_Log = new Sys_Log();
            Sys_Log.F_Id = Common.GuId();
            Sys_Log.F_Date = DateTime.Now;
            Sys_Log.F_IPAddress = Net.Ip;
            Sys_Log.F_IPAddressName = Net.GetLocation(Sys_Log.F_IPAddress);
            Sys_Log.F_Result = result;
            Sys_Log.F_Description = resultLog;
            service.Insert(Sys_Log);
        }
        public void WriteDbLog(Sys_Log Sys_Log)
        {
            Sys_Log.F_Id = Common.GuId();
            Sys_Log.F_Date = DateTime.Now;
            Sys_Log.F_IPAddress = "117.81.192.182";
            Sys_Log.F_IPAddressName = Net.GetLocation(Sys_Log.F_IPAddress);
            service.Insert(Sys_Log);
        }
        public async void WriteDbAsyncLog(bool result, string resultLog)
        {
            Sys_Log Sys_Log = new Sys_Log();
            Sys_Log.F_Id = Common.GuId();
            Sys_Log.F_Date = DateTime.Now;
            Sys_Log.F_IPAddress = Net.Ip;
            Sys_Log.F_IPAddressName = Net.GetLocation(Sys_Log.F_IPAddress);
            Sys_Log.F_Result = result;
            Sys_Log.F_Description = resultLog;
            service.Insert(Sys_Log);
        }
        public async void WriteDbAsyncLog(bool result, string ModuleName, string resultLog)
        {
            Sys_Log Sys_Log = new Sys_Log();
            Sys_Log.F_Id = Common.GuId();
            Sys_Log.F_Date = DateTime.Now;
            Sys_Log.F_IPAddress = Net.Ip;
            Sys_Log.F_IPAddressName = Net.GetLocation(Sys_Log.F_IPAddress);
            Sys_Log.F_Result = result;
            Sys_Log.F_ModuleName = ModuleName;
            if (resultLog.Length > 490)
                Sys_Log.F_Description = resultLog.Substring(0, 490);
            else
                Sys_Log.F_Description = resultLog;

            service.Insert(Sys_Log);
        }
    }
}
