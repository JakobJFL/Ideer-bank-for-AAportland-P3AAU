using DataBaseLib.DataAccess;
using DataBaseLib.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLib.Implementations
{
    public class CommentsRepository : ICommentsRepository
    {
        public CommentsRepository(Context context)
        {
            Context = context;
        }
        public Context Context { get; }
        public async Task<IEnumerable<CommentsTbl>> ListAsync(int ideaId)
        {
            return await Context.CommentsTbl
                .Where(c => c.Idea.Id == ideaId)
                .OrderByDescending(s => s.Id)
                .ToListAsync();
        }
        public async Task AddAsync(CommentsTbl model, int ideaId)
        {
            model.Idea = await Context.IdeasTbl
              .Where(i => i.Id == ideaId)
              .FirstOrDefaultAsync();
            await Context.CommentsTbl.AddAsync(model);
            await Context.SaveChangesAsync();
        }

        public async Task RemoveByIdAsync(int id)
        {
            CommentsTbl c = await Context.CommentsTbl.FindAsync(id);
            Context.CommentsTbl.Remove(c);
            await Context.SaveChangesAsync();
        }

        public async Task<int> CountAsync(int ideaId)
        {
            return await Context.CommentsTbl
                .Where(c => ideaId == 0 || c.Idea.Id == ideaId)
                .CountAsync();
        }

        public Task UpdateAsync(IdeasTbl model)
        {
            throw new NotImplementedException();
        }

        public Task<IdeasTbl> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(FilterSortIdea filter)
        {
            throw new NotImplementedException();
        }
    }
}
