using PortfolioHub.API.DTO.ModelDTO;
namespace PortfolioHub.API.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public DateTime BirthDate { get; set; }

        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        // Университет
        public string University { get; set; } = "";
        // Факультет
        public string Faculty { get; set; } = "";
        // Специальность
        public string Speciality { get; set; } = "";
        // Номер курса
        public int Graid { get; set; }

        // Список всех достижений пользователя (конкурсы, публикации, курсы, конференции)
        public List<CompetitionDTO> CompetitionDTOs { get; set; } = new();
        public List<ConferenceDTO> ConferenceDTOs { get; set; } = new();
        public List<CourseDTO> CourseDTOs { get; set; } = new();
        public List<PublicationDTO> PublicationDTOs { get; set; } = new();
    }
}
