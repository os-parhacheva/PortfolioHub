using PortfolioHub.API.DTO;
using PortfolioHub.API.DTO.ModelDTO;
using PortfolioHub.Domain;

namespace PortfolioHub.API
{
    public static class ToolsDTO
    {
        public static UserDTO ConvertUserToUserDTO(User user)
        {
            return new UserDTO()
            {
                Id         = user.Id,
                FirstName  = user.FirstName,
                MiddleName = user.MiddleName,
                LastName   = user.LastName,
                Phone      = user.Phone,
                Email      = user.Email,
                BirthDate  = user.BirthDate,
                University = user.University,
                Faculty    = user.Faculty,
                Speciality = user.Speciality,
                Graid      = user.Graid,
                CompetitionDTOs = GetCompetitionDto(user.Competitions),
                ConferenceDTOs = GetConferenceDto(user.Conferences),
                CourseDTOs = GetCoursesDTO(user.Courses),
                PublicationDTOs = GetPublicationDto(user.Publications)
            };
        }
        private static List<CompetitionDTO> GetCompetitionDto(List<Competition> competitions)
        {
            List<CompetitionDTO> competitionDTOs = new List<CompetitionDTO>();

            foreach (Competition comp in competitions)
            {
                competitionDTOs.Add(new CompetitionDTO()
                {
                    Id = comp.Id,
                    Title = comp.Title,
                    Description = comp.Description,
                    Date = comp.Date,
                    EditBy = comp.EditBy,
                    EditDate = comp.EditDate,
                    Url = comp.Url,
                    Certificate = comp.Certificate,
                    Organizer = comp.Organizer,
                    Result = comp.Result,
                    Type = comp.Type,
                    View = comp.View,
                    StageDTOs = GetStageDto(comp.Stages)
                });
            }
            return competitionDTOs;
        }
        private static List<ParticipantDTO> GetParticipantDto(List<Participant> participants)
        {
            List<ParticipantDTO> participantDTOs = new List<ParticipantDTO>();

            foreach (Participant auth in participants)
            {
                participantDTOs.Add(new ParticipantDTO()
                {
                    Id = auth.Id,
                    Name = auth.Name,
                    MiddleName = auth.MiddleName,
                    Role = auth.Role,
                    Surname = auth.Surname,
                    UserId = auth.UserId
                });
            }
            return participantDTOs;
        }
        private static List<StageDTO> GetStageDto(List<Stage> stages)
        {
            List<StageDTO> stageDTOs = new List<StageDTO>();

            foreach (Stage st in stages)
            {
                stageDTOs.Add(new StageDTO()
                {
                    Id = st.Id,
                    Number = st.Number,
                    Fund = st.Fund,
                    Deadline = st.Deadline,
                    Result = st.Result,
                    ParticipantDTOs = GetParticipantDto(st.Participants)

                });
            }
            return stageDTOs;
        }

        private static List<PublicationDTO> GetPublicationDto(List<Publication> publications)
        {
            List<PublicationDTO> publicationDTOs = new List<PublicationDTO>();

            foreach (Publication pub in publications)
            {
                publicationDTOs.Add(new PublicationDTO()
                {
                    Id = pub.Id,
                    Title = pub.Title,
                    Description = pub.Description,
                    Date = pub.Date,
                    EditBy = pub.EditBy,
                    EditDate = pub.EditDate,
                    Url = pub.Url,                   
                    Doi= pub.Doi,
                    Journal = pub.Journal,
                    AuthorDTOs = GetAuthorDto(pub.Authors)
                });
            }
            return publicationDTOs;
        }

        private static List<AuthorDTO> GetAuthorDto(List<Author> authors)
        {
            List<AuthorDTO> authorDTOs = new List<AuthorDTO>();

            foreach (Author auth in authors)
            {
                authorDTOs.Add(new AuthorDTO()
                {
                    Id= auth.Id,
                    Name = auth.Name,
                    MiddleName = auth.MiddleName,
                    Role = auth.Role,
                    Surname = auth.Surname,
                    UserId = auth.UserId
                });
            }
            return authorDTOs;
        }

        private static List<ConferenceDTO> GetConferenceDto(List<Conference> conferences) 
        { 
            List<ConferenceDTO> conferenceDTOs = new List<ConferenceDTO>();

            foreach (Conference conf in conferences) {
                conferenceDTOs.Add(new ConferenceDTO() { 
                    Id = conf.Id,
                    Title = conf.Title,
                    Description = conf.Description,
                    Topic = conf.Topic,
                    Date = conf.Date,
                    EditBy = conf.EditBy,
                    EditDate = conf.EditDate,
                    Organizer = conf.Organizer,
                    Role = conf.Role,
                    Url = conf.Url
                });
            }
            return conferenceDTOs;
        }

        public static List<CourseDTO> GetCoursesDTO(List<Course> courses)
        {
            List<CourseDTO> courseDTOs = new List<CourseDTO>();

            foreach (Course cour in courses)
            {
                courseDTOs.Add(new CourseDTO()
                {
                    Id = cour.Id,
                    Title = cour.Title,
                    Description = cour.Description,
                    Date = cour.Date,
                    EditBy = cour.EditBy,
                    EditDate = cour.EditDate,
                    Url = cour.Url,
                    Certificate = cour.Certificate,
                    Hours = cour.Hours,
                    Platform = cour.Platform,
                    UserId = cour.UserId                    
                });
            }
            return courseDTOs;
        }


    }
}
