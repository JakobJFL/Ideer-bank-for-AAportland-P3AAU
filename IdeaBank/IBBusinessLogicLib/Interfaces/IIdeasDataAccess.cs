using System;
using System.Collections.Generic;
using BusinessLogicLib.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLib.Models;

namespace BusinessLogicLib.Interfaces
{
    public interface IIdeasDataAccess
    {
        public Task<List<ViewIdea>> GetWFilter(FilterSortIdea filter);
        public Task Insert(NewIdea idea);
        public Task Edit(EditIdea idea);
        public Task DeleteByID(int id);
        public Task<int> GetCount(FilterSortIdea filter);
        public int GetIdeasCount();
    }
}
