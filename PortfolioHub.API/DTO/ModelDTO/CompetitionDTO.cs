using PortfolioHub.Domain;

namespace PortfolioHub.API.DTO
{
    public class CompetitionDTO : AchievementDTO
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
        public List<StageDTO> StageDTOs { get; set; } = new List<StageDTO>();
    }
}
