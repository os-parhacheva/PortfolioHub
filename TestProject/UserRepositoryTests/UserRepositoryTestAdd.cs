using PortfolioHub.Domain;
using PortfolioHub.Infrasrtructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    /*public class UserRepositoryTestAdd
    {
        private TestHelper _helper;
        private UserRepository _userRepository;
        public UserRepositoryTestAdd() 
        {
            _helper = new TestHelper();
            _userRepository = _helper.UserRepository;
        }

        [Fact]
        public async Task TestAddNewUser()
        {
            User user1 = new User { Id = Guid.NewGuid(), FirstName = "Milana" };
            User user2 = new User { Id = Guid.NewGuid(), FirstName = "Milana" };

            await _userRepository.AddAsync(user1);
            await _userRepository.AddAsync(user2);
            

            _userRepository.ChangeTrackerClear();

            Assert.Equal(2, _userRepository.GetAllAsync().Result.Count);

            Assert.Equal("Milana", _userRepository.GetByIdAsync(user1.Id).Result.FirstName);

        }

        [Fact]
        public async Task TestAddNewUserWithCompetition()
        {
            User user = new User { Id = Guid.NewGuid(), FirstName = "Milana" };
            user.Achievements.Add(
                new Competition 
                {
                    Id = Guid.NewGuid(),
                    Title = "Hackathon",
                    Stages = new List<Stage> 
                    { 
                        new Stage 
                        { 
                            Id = Guid.NewGuid(), 
                            Number = 1 ,
                            Participants = new List<Participant> 
                            { 
                                new Participant 
                                { 
                                    Name = "P1" 
                                },
                                new Participant
                                {
                                    Name = "P2"
                                },
                                new Participant
                                {
                                    Name = "P3"
                                }
                            }
                        },
                        new Stage
                        {
                            Id = Guid.NewGuid(),
                            Number = 2 ,
                            Participants = new List<Participant>
                            {
                                new Participant
                                {
                                    Name = "P1"
                                }
                            }
                        }
                     }

                }
            );

            await _userRepository.AddAsync(user);
            _userRepository.ChangeTrackerClear();

            Assert.Equal(1, _userRepository.GetCompetitionsByUserAsync(user.Id).Result.Count);
            Assert.Equal(2, _userRepository.GetCompetitionsByUserAsync(user.Id).Result[0].Stages.Count);
            
            

            Assert.Single(_userRepository.GetCompetitionsByUserAsync(user.Id).Result[0].Stages[1].Participants);

        }
        [Fact]
        public async Task TestAddNewUserWithCourse()
        {
            User user = new User { Id = Guid.NewGuid(), FirstName = "Milana" };
            user.Achievements.Add( new Course
            {
                Id = Guid.NewGuid(),               
                Title = "Math"
            });
            user.Achievements.Add(new Course
            {
                Id = Guid.NewGuid(),               
                Title = "History"
            });

            await _userRepository.AddAsync(user); 
            _userRepository.ChangeTrackerClear();

            Assert.Equal(2, _userRepository.GetCoursesByUserAsync(user.Id).Result.Count);
            Assert.Equal("History", _userRepository.GetCoursesByUserAsync(user.Id).Result[1].Title);

        }
        [Fact]
        public async Task TestAddNewUserWithPublication()
        {
            User user = new User { Id = Guid.NewGuid(), FirstName = "Olga" };
            user.Achievements.Add(new Publication
            {
                Id = Guid.NewGuid(),
                Title = "Research Paper",
                Authors = new List<Author>
                {
                    new Author { Id = Guid.NewGuid(), Name = "Author1" }
                }
            });
            
            await _userRepository.AddAsync(user);
            _userRepository.ChangeTrackerClear();

            Assert.Single(_userRepository.GetPublicationsByUserAsync(user.Id).Result);
            Assert.Equal("Research Paper", _userRepository.GetPublicationsByUserAsync(user.Id).Result[0].Title);

        }
    }*/
}
