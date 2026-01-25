
namespace PortfolioHub.API.DTO
{
    public class PublicationDTO : AchievementDTO
    {
        // Журнал/издание
        public string Journal { get; set; } = "";
        // DOI
        public string Doi { get; set; } = "";
        // Список авторов
        public List<AuthorDTO> AuthorDTOs { get; set; } = new();
    }
}
