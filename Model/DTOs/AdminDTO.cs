using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTOs
{
    public class Checker_AddDTO
    {
        public string id { get; set; }
        public string email { get; set; }
        public string prefix { get; set; }
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string address { get; set; }
        public string subdistrict { get; set; }
        public string district { get; set; }
        public string province { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public string phone2 { get; set; }
        public byte image { get; set; }
        public DateTime hire_date{ get; set; }
        public DateTime end_date { get; set; }
    }
}



