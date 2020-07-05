using Jupiter.Enums;
using Jupiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jupiter.ViewModels
{
    public class CategoryViewModel
    {

        public int categoryId;

        public IEnumerable<string> List;

        public IEnumerable<Category> Categories;

        public EGameCategory e_Category;

        public IEnumerable<Title> filteredTitles { get; set; }

    }
}
