using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jupiter.Repository;
using Jupiter.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter.Controllers
{
    public class HomeController : Controller
    {

        private readonly ITitleRepository _titleRepo;
        private readonly ICategoryRepository _categoryRepository;
        public bool listViewEnabled;

        public HomeController(ITitleRepository titleRepository, ICategoryRepository categoryRepository)
        {
            _titleRepo = titleRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Titles = _titleRepo.GetAllTitles;
            homeViewModel.Categories = _categoryRepository.AllCategories;


            return View(homeViewModel);

        }

        public IActionResult IndexList(bool listView)
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Titles = _titleRepo.GetAllTitles;
            homeViewModel.Categories = _categoryRepository.AllCategories;
            return View(homeViewModel);

        }



        public IActionResult IndexSearch(string searchString)
        {
            var titles = _titleRepo.SearchTitleByName(searchString);

            if (String.IsNullOrEmpty(searchString))
            {
                titles = _titleRepo.GetAllTitles;
            }

            var homeViewModel = new HomeViewModel();
            homeViewModel.Titles = titles;
            homeViewModel.Categories = _categoryRepository.AllCategories;

            return View(homeViewModel);
        }




        //public IActionResult Index(bool? ListViewEnabled)
        //{
        //    var homeViewModel = new HomeViewModel();

        //    homeViewModel.ListViewEnabled = 
        //    homeViewModel.Titles = _titleRepo.GetAllTitles;
        //    return View(homeViewModel);

        //}





        public IActionResult Details(int? titleId)
        {
            if (titleId == null)
            {
                return NotFound();
            }

            var viewItem = _titleRepo.GetTitle(titleId);
                
            if (titleId == null)
            {
                return NotFound();
            }


            var homeViewModel = new HomeViewModel();

            homeViewModel.Title = viewItem;

            return View(homeViewModel);
        }



    }
}