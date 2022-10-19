using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewTestApp.BusinessLogic
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
    }
}
