namespace ArellanoSysDevExam.Models
{
    public class AddEmployeeViewModel
    {
        public string? last_name { get; set; }
        public string? first_name { get; set; }
        public string? middle_name { get; set; }
        public DateTime datehired { get; set; }
        public Boolean isactive { get; set; }
        public string? imagepath { get; set; }

    }
}
