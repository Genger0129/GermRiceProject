﻿using NFine.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NFine.Web.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务  
            config.MessageHandlers.Add(new RequestHandler());
            // Web API 路由  
            config.MapHttpAttributeRoutes();
        }
    }  
}