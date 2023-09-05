namespace ArellanoSysDevExam.Models.Domain
{
    public class Branch
    {
        public Guid branchid { get; set; }
        public string branchname { get; set; }
        public string branchcode { get; set; }
        public string address { get; set; }
        public string barangay { get; set; }
        public string city { get; set; }
        public string permitnumber { get; set; }
        public string branch_manager { get; set; }
        public DateTime dateopened { get; set; }
        public Boolean isactive { get; set; }
    }
}
