using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CompanyApplication.Models
{
    public partial class Candidates
    {
        public Candidates()
        {
            //da proverim dali da raboti s logika za kandidati  ili obektat tuk da e direktora
            Candidate = new HashSet<Candidates>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string DesiredPosition { get; set; }
        
        public DateTimeOffset Created { get; set; }
        public virtual ICollection<Candidates> Candidate { get; set; }
        public virtual ICollection<Director> Directors{ get; set; }
    }
}