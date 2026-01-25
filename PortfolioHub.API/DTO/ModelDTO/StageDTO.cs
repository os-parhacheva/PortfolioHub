
namespace PortfolioHub.API.DTO
{
    public class StageDTO
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

        // Список участников этапа
        public List<ParticipantDTO> ParticipantDTOs { get; set; } = new();
    }
}
