using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Kinagod.Enterprise.WebApp.MVCWebForm.Startup))]

namespace Kinagod.Enterprise.WebApp.MVCWebForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
