using Jupiter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Title> Titles { get; set; }

        public Title Title { get; set; }

        public IEnumerable<Category> Categories;

        public Category Category { get; set; }


    }
}
