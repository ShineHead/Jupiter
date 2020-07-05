using Jupiter.Enums;
using Jupiter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jupiter.Repository
{
    public interface ITitleRepository
    {

        IEnumerable<Title> GetAllTitles { get; }

        public Title GetTitle(int? titleId);

        public IEnumerable<Title> GetTitleByCategory(EGameCategory EGameCategory);

        public IEnumerable<Title> SearchTitleByName(string name = null);

        public IEnumerable<Title> FeaturedTitles { get; }

    }
}
