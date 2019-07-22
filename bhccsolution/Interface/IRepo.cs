/// 
///  IRepo is the interface that defines the expected funcionality for
///  this webapp, through DI
///

using System.Collections.Generic;
using System.Threading.Tasks;
using bhccsolution.Models;

namespace bhccsolution.Interface
{
    public interface IRepo
    {
        Task<IEnumerable<ReasonViewModel>> GetAll();
        Task<ReasonViewModel> GetById(uint id); 
    }
}