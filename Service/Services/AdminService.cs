using Common.Helpers;
using Model.DTOs;
using Service.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Service.Services
{
    public class AdminService : SqlDataAccess
    {
        public void Staff_Checker_Add(Checker_AddDTO checker)
        {
            using (var command = new SqlCommand())
            {
                command.CommandText = "[Checker_Add]";
                command.Parameters.Add(new SqlParameter("@User_id", checker.id));
                command.Parameters.Add(new SqlParameter("@User_email", checker.email));
                command.Parameters.Add(new SqlParameter("@Info_prefix", checker.prefix));
                command.Parameters.Add(new SqlParameter("@Info_firstname", checker.first_Name));
                command.Parameters.Add(new SqlParameter("@Info_lastname", checker.last_Name));
                command.Parameters.Add(new SqlParameter("@Info_address", checker.address));
                command.Parameters.Add(new SqlParameter("@Info_subdistrict", checker.subdistrict));
                command.Parameters.Add(new SqlParameter("@Info_district", checker.district));
                command.Parameters.Add(new SqlParameter("@Info_province", checker.province));
                command.Parameters.Add(new SqlParameter("@Info_zipcode", checker.zipcode));
                command.Parameters.Add(new SqlParameter("@Info_phone", checker.phone));
                command.Parameters.Add(new SqlParameter("@Info_phone2", checker.phone2));
                command.Parameters.Add(new SqlParameter("@Info_image", checker.image));
                command.Parameters.Add(new SqlParameter("@Checker_hire_date", checker.hire_date.Date));
                command.Parameters.Add(new SqlParameter("@Checker_end_date", checker.end_date.Date));
                command.CommandType = CommandType.StoredProcedure;
                this.ExecuteNonQuery(command);
            }
        }

        public Checker_AddDTO Checker_Add()
        {
            throw new NotImplementedException();
        }
    }
}
