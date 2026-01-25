namespace PortfolioHub.API.DTO
{
    public class ConferenceDTO: AchievementDTO
    {
        public string Organizer { get; set; } = ""; // Организатор конференции
        public string Topic { get; set; } = ""; // Тема доклада / участия
        public string Role { get; set; } = ""; // Роль (докладчик, участник)
    }
}
