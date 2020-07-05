using Jupiter.Enums;
using Jupiter.Repository;
using Jupiter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jupiter.Controllers
{
    public class TitlesController : Controller
    {


        private readonly ICategoryRepository _categoryRepo;

        private readonly ITitleRepository _titleRepo;

        public TitlesController(ICategoryRepository categoryRepository, ITitleRepository titleRepository)
        { 
            _categoryRepo = categoryRepository;
            _titleRepo = titleRepository;
        }



        public IActionResult FilteredGrid(int categoryNumber) //get id
        {
            EGameCategory e_category = (EGameCategory)categoryNumber;
            var categorizedTitles = _titleRepo.GetTitleByCategory(e_category);

            //  Assign to ViewModel
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            categoryViewModel.filteredTitles = categorizedTitles;
            categoryViewModel.e_Category = e_category;
            var categoryList = _categoryRepo.AllCategories;
            categoryViewModel.Categories = categoryList;
            return View(categoryViewModel);
        }

        public IActionResult FilteredList(int categoryNumber) //get id
        {
            EGameCategory e_category = (EGameCategory)categoryNumber;
            var categorizedTitles = _titleRepo.GetTitleByCategory(e_category);

            //  Assign to ViewModel
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            categoryViewModel.filteredTitles = categorizedTitles;
            categoryViewModel.e_Category = e_category;
            var categoryList = _categoryRepo.AllCategories;
            categoryViewModel.Categories = categoryList;
            return View(categoryViewModel);
        }





    }
}
