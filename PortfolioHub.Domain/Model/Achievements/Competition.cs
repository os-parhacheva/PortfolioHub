using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Конкурс / соревнование
    /// </summary>
    public class Competition : Achievement
    {
        // Организатор конкурса
        public string Organizer { get; set; } = "";
        // Тип конкурса
        public string Type { get; set; } = "";
        // Формат проведения
        public string View { get; set; } = "";
        // Результат (победитель, призер, участник)
        public string Result { get; set; } = "";
        // Сертификат/документ
        public string Certificate { get; set; } = ""; 

        // Этапы конкурса
        public List<Stage> Stages { get; set; } = new();
    }
}
