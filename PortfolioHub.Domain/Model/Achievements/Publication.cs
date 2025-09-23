using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Публикация
    /// </summary>
    public class Publication : Achievement
    {
        // Журнал/издание
        public string Journal { get; set; } = ""; 
        // DOI
        public string Doi { get; set; } = "";
        // Список авторов
        public List<Author> Authors { get; set; } = new();
    }
}
