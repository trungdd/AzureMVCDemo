﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMVCDemo.Startup))]
namespace AzureMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //test commit
        }
    }
}
