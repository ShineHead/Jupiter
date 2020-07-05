using Jupiter.Context;
using Jupiter.Enums;
using Jupiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Repository
{
    public class TitleRepository : ITitleRepository
    {

        private readonly AppDbContext _context;



        public TitleRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }



        public IEnumerable<Title> GetAllTitles
        {
            get
            {
                return _context.Titles;
            }
        }


        public Title GetTitle(int? titleId)
        {
            var title = _context.Titles.FirstOrDefault(t => t.Id == titleId);
            return title;
        }



        public IEnumerable<Title> GetTitleByCategory(EGameCategory EGameCategory)
        {
            var categorizedQuotes = _context.Titles.Where(q => q.GameCategory == EGameCategory);
            return categorizedQuotes;
        }






        public IEnumerable<Title> SearchTitleByName(string name = null)
        {
            var titles = _context.Titles;

            return from t in titles
                   where string.IsNullOrEmpty(name) || t.Name.StartsWith(name)
                   orderby t.Name
                   select t;

        }




        public IEnumerable<Title> FeaturedTitles => throw new NotImplementedException();


  
    }
}
