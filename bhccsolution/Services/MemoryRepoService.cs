/// 
///  MemoryRepoService is in-memory implemantation of IRepo,
///  the actual storage of reasons to join BHHC.
///


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bhccsolution.Interface;
using bhccsolution.Models;

namespace bhccsolution.Services
{
    public class MemoryRepoService : IRepo
    {
        private readonly IEnumerable<ReasonViewModel> _memoryRepo;                                         //in memory "reasons" repository 
        
        public MemoryRepoService ()
        {
            _memoryRepo = new List<ReasonViewModel>
            {
                new ReasonViewModel
                {
                    Id = 1,
                    Title = "Newest cool technologies",
                    Explanation= "The job description mentioned not just Microsoft stack, but .net/core technology. I've been a Microsoft developer my whole carrer " +
                                 "and I have almost used each of their platform & technology. The .net/core framework is the future, is getting mature to catch up with the " +
                                 "competition (to my experience will do things better). It's multiplatform, crossplatform, so it's the best choice to invest time & effort " +
                                 "to use it. And there is no better way to master it than working in an enterprise level, dealing with all kinds of development scenarios. " +
                                 "BHHC offers such an environment."
                },
                new ReasonViewModel
                {
                    Id = 2,
                    Title = "Project diversity",
                    Explanation = "BHHC maintains a vast variety of systems. This is a great opportunity to master the technologies, use their full potential under different "+
                                  "scenarios, learn new ones, how they can work together and maybe discover new ways to do things, ways nobody has thought of before."
                }, 
                new ReasonViewModel
                {
                    Id = 3,
                    Title = "Opportunity to grow",
                    Explanation = "All technologies require an investment of good effort to learn it, and this is more than true for the new ones. It's even more true for .net/core, " +
                                  "a platform still evolving, rapidly. I believe BHHC can provide the necessary enviroment, resources, opportunities, motivation for a developer to stay " +
                                  "not just current, but at their edge."
                }
            };
        }

        /// <summary>
        ///     Get all entries from the repo
        /// </summary>
        /// <returns>the collection of reasons</returns>
        /// <remarks>it may seem unnecessary this is an async method for a memory repo,
        ///          however the same interface could be used for a db implementation
        ///          or (anything) without having to have different signatures or interfaces</remarks>
        public Task<IEnumerable<ReasonViewModel>> GetAll()
        {
            return Task.FromResult(_memoryRepo);
        }
        
        /// <summary>
        ///     Get an entry from the repo 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a matching id reason</returns>
        /// <remarks>same as GetAll</remarks>
        public Task<ReasonViewModel> GetById(uint id)
        {
            return Task.FromResult(_memoryRepo.SingleOrDefault(r => r.Id == id));
        }
    }
}