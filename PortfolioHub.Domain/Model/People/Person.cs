using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    public abstract class Person
    {
        public Guid Id { get; set; } 
        public string Surname { get; set; } = "";
        public string Name { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public Guid UserId { get; set; }
        public string Role { get; set; } = ""; // Роль (участник, лидер, автор, докладчик)
    }
}
