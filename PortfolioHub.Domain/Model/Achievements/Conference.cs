using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Конференция / семинар
    /// </summary>
    public class Conference : Achievement
    {
        public string Organizer { get; set; } = ""; // Организатор конференции
        public string Topic { get; set; } = ""; // Тема доклада / участия
        public string Role { get; set; } = ""; // Роль (докладчик, участник)
    }
}
