using System.Collections.Generic;
using System.Linq;
using BusinessLogicLib.Service;
using DataBaseLib;
using DataBaseLib.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLib.Implementations;
using Xunit;
using System.Threading.Tasks;

namespace Testing.xUnitTest
{
    public class IdeaRepositoryTests
    {
        [Fact]
        public async Task AddAsync_Idea_IdeaAdded()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            IdeasTbl idea = new()
            {
                ProjectName = "Test",
                Description = "Test description",
                Initials = "test",
                Priority = 1,
                Status = 1
            };

            // act
            await repository.AddAsync(idea);

            // assert
            Assert.NotNull(await repository.FindByIdAsync(idea.Id));

            // clean up
            await repository.RemoveByIdAsync(idea.Id);
        }

        [Fact]
        public async Task RemoveById_RemoveIdea_IdeaRemoved()
        {
            // arrange
            IdeaRepository ideasRepository = new(Utilities.GetRepositoryConnection());
            CommentsRepository commentsRepository = new(Utilities.GetRepositoryConnection());
            IdeasTbl idea = new()
            {
                ProjectName = "testRemoveIdea",
                Description = "Test description",
                Initials = "TEST",
                Priority = 1,
                Status = 1
            };

            // act
            await ideasRepository.AddAsync(idea);
            await ideasRepository.RemoveByIdAsync(idea.Id);

            // assert
            Assert.Null(await ideasRepository.FindByIdAsync(idea.Id));
            Assert.Equal(await commentsRepository.ListAsync(idea.Id), new List<CommentsTbl>()); // Is comments removed
        }

        [Fact]
        public async Task Filter_FilterByPriority_PrioritisedIdeas()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            List<IdeasTbl> result;
            FilterSortIdea filter = new()
            {
                ShowHidden = true,
                IdeasShownCount = 0,
            };

            // act
            for (int i = 1; i <= Config.PriorityStrs.Length; i++)
            {
                filter.Priority = i;
                result = (await repository.ListAsync(filter)).ToList();
                foreach (IdeasTbl item in result)
                {
                    // assert
                    Assert.Equal(i, item.Priority);
                }
            }
        }

        [Fact]
        public async Task Filter_FilterByZeroPriority_AllIdeas()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            FilterSortIdea filterListAsync = new()
            {
                ShowHidden = true,
                IdeasShownCount = 0,
                Priority = 0,
                Status = 0,
                BusinessUnit = 0,
                Department = 0
            };
            FilterSortIdea filterCountAsync = new()
            {
                Status = 0,                
                OnlyNewIdeas = false
            };

            // act
            int count = await repository.CountAsync(filterCountAsync);
            int filterResult = (await repository.ListAsync(filterListAsync)).ToList().Count;

            //Assert
            Assert.Equal(count, filterResult);

        }

        [Fact]
        public async Task Filter_FilterByStatus_IdeasWCorrectStatus()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            List<IdeasTbl> result;
            FilterSortIdea filter = new()
            {
                ShowHidden = true,
                IdeasShownCount = 0,
            };

            // act
            for (int i = 1; i <= Config.StatusStrs.Length; i++)
            {
                filter.Status = i;
                result = (await repository.ListAsync(filter)).ToList();
                foreach (IdeasTbl item in result)
                {
                    // assert
                    Assert.Equal(i, item.Status);
                }
            }
        }

        [Fact]
        public async Task Filter_FilterByZeroStatus_AllIdeas()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            List<IdeasTbl> result;
            FilterSortIdea filter = new()
            {
                ShowHidden = true,
                IdeasShownCount = 0,
                Status = 0
            };

            // act
            result = (await repository.ListAsync(filter)).ToList();
            int count = await repository.CountAsync(new FilterSortIdea());
            Assert.Equal(count, result.Count());
        }

        [Fact]
        public async Task Filter_FilterByIsHidden_OnlyPublicIdeas()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            List<IdeasTbl> result;
            FilterSortIdea filter = new()
            {
                ShowHidden = false,
                IdeasShownCount = 0,
            };

            // act
            result = (await repository.ListAsync(filter)).ToList();
            foreach (IdeasTbl idea in result)
            {
                // assert
                Assert.False(idea.IsHidden);
            }
        }

        [Fact]
        public async Task Filter_FilterByShowHidden_AllIdeas()
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            List<IdeasTbl> result;
            FilterSortIdea filter = new()
            {
                ShowHidden = true,
                IdeasShownCount = 0,
            };

            // act
            result = (await repository.ListAsync(filter)).ToList();
            int count = await repository.CountAsync(new FilterSortIdea());
            Assert.Equal(count, result.Count());
        }

        [Theory]
        [InlineData("sdds", 1, 2)]
        public async Task AddAsync_IdeaWBuAndDep_IdeaAdded(string projectName, int buId, int depId)
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            IdeasTbl idea = new()
            {
                ProjectName = projectName,
                Description = "Test description",
                Initials = "test",
                AuthorBusinessUnitId = buId,
                AuthorDepartmentId = depId
            };

            // act
            await repository.AddAsync(idea);

            // assert
            Assert.NotNull(await repository.FindByIdAsync(idea.Id));

            // clean up
            await repository.RemoveByIdAsync(idea.Id);
        }

        [Theory]
        [InlineData("business unit number out of range ", 300, 1)]
        [InlineData("department number out of range", 1, 300)]
        [InlineData("both out of range", 300, 300)]
        [InlineData("text too long text too long text too long text too long text too long text too long", 1, 1)]
        public async Task AddAsync_Idea_throwsDbUpdateException(string projectName, int buId, int depId)
        {
            // arrange
            IdeaRepository repository = new(Utilities.GetRepositoryConnection());
            IdeasTbl idea = new()
            {
                ProjectName = projectName,
                Description = "Test description",
                Initials = "test",
                AuthorBusinessUnitId = buId,
                AuthorDepartmentId = depId
            };

            // act assert
            await Assert.ThrowsAsync<DbUpdateException>(() => repository.AddAsync(idea));

        }
    }
}