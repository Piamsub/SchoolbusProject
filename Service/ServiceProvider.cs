using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public static class ServiceProvider
    {
        private static AuthenticationService authenticationService { get; set; }
        public static AuthenticationService AuthenticationService
        {
            get
            {
                if (authenticationService==null)
                {
                    authenticationService = new AuthenticationService();
                }

                return authenticationService;
            }
        }

        private static AdminService adminService { get; set; }
        public static AdminService AdminService
        {
            get
            {
                if (adminService == null)
                {
                    adminService = new AdminService();
                }

                return adminService;
            }
        }
    }
}
