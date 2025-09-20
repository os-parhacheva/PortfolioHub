using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Базовый класс для всех достижений (конкурсы, публикации, курсы, конференции)
    /// </summary>
    public abstract class Achievement
    {
        public Guid Id { get; set; }

        // Название достижения
        public string Title { get; set; } = "";
        // Описание достижения
        public string Description { get; set; } = "";
        // Дата достижения
        public DateTime Date { get; set; } = DateTime.Today;
        // Ссылка на документ/сайт
        public string Url { get; set; } = "";

        // Связь с пользователем
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
