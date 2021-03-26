using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CompanyApplication.Models
{
    public partial class Employees
    {
        public Employees()
        {
            //promenihme pacienta na employee, obiknovenata promenliva e v edinstweno chislo, obecta e za vsichki
            Employee = new HashSet<Employees>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        //dali salary trqbva da e private
        public decimal Salary { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Employees> Employee{ get; set; }
        public virtual ICollection<Director> Directors { get; set; }
    }
}