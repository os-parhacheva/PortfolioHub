
namespace PortfolioHub.API.DTO
{
    public abstract class AchievementDTO
    {
        public Guid Id { get; set; }

        // Название достижения
        public string Title { get; set; } = "";
        // Описание достижения
        public string Description { get; set; } = "";
        // Дата достижения
        public DateTime Date { get; set; } //= DateTime.Today;
        // Ссылка на документ/сайт
        public string Url { get; set; } = "";

        //Дата последнего изменения
        public DateTime EditDate { get; set; }
        //Автор изменения
        public string EditBy { get; set; }
    }
}
