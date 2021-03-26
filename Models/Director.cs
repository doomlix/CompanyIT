using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CompanyApplication.Models
{

    public partial class Director
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        //nujno li e DateTimeOffSet
        public DateTimeOffset Created { get; set; }
        public Employees Employees { get; set; }
        public Candidates Candidates { get; set; }

    }
}