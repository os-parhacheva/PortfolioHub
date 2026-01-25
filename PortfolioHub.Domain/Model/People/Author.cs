using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioHub.Domain
{
    /// <summary>
    /// Автор публикации
    /// </summary>
    public class Author : Person
    {
        public Guid PublicationId { get; set; } 
        public Publication Publication { get; set; } = new Publication();
    }
}
