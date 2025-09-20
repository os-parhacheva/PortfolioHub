using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{

    /// <summary>
    /// Участник этапа конкурса
    /// </summary>
    public class Participant : Person
    {
        public Guid StageId { get; set; }
        public Stage Stage { get; set; }
    }

}
