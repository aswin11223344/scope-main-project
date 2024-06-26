using System.ComponentModel.DataAnnotations;

namespace project_ScopeIndia.Models
{
    public class Reg
    {
        public string fullname { get; set; }
        [DataType(DataType.Date)]
        public DateTime birth { get; set; }
        public string gender { get; set; }
        public string course { get; set; }
        public string num { get; set; }
        public string gnum { get; set; }

        public string train { get; set; }
        public string scope { get; set; }
        public string GuardianName { get; set; }
        public string check { get; set; }

        public string Name { get; set; }
    }
}
