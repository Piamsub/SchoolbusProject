using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public static class ServiceAdmin
    {
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
