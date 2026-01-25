using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Этап конкурса
    /// </summary>
    public class Stage
    {
        public Guid Id { get; set; }
        // Номер этапа
        public uint Number { get; set; }
        // Результат этапа (пройден/не пройден)
        public string Result { get; set; } = "";
        // Фонд этапа (например, призовой фонд)
        public int Fund { get; set; }
        // Дата проведения этапа
        public DateTime Deadline { get; set; } = DateTime.Today; 

        // Связь с конкурсом
        public Guid CompetitionId { get; set; }
        public Competition Competition { get; set; } = new Competition();

        // Список участников этапа
        public List<Participant> Participants { get; set; } = new();
    }
}
