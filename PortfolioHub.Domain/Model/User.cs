using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Основной агрегат – студент / пользователь системы
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public DateTime BirthDate { get; set; }

        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        // Университет
        public string University { get; set; } = ""; 
        // Факультет
        public string Faculty { get; set; } = "";
        // Специальность
        public string Speciality { get; set; } = "";

        // Список всех достижений пользователя (конкурсы, публикации, курсы, конференции)
        public List<Achievement> Achievements { get; set; } = new();
    }
}
