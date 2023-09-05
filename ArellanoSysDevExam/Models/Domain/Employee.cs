using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
namespace ArellanoSysDevExam.Models.Domain
{
    public class Employee
    {
        public Guid employeeid { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set;}
        public string middle_name { get; set; }
        public DateTime datehired { get; set; }
        public Boolean isactive { get; set; }
        public string imagepath { get; set; }

        //public Employee()
        //{
        //    last_name = "";
        //    first_name = "";
        //    middle_name = "";
        //    imagepath = "~/AppFiles/Images/default.png";
        //}

    }


}
