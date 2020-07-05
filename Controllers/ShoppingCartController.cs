using Jupiter.Context;
using Jupiter.Models;
using Jupiter.Repository;
using Jupiter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jupiter.Controllers
{
    public class ShoppingCartController : Controller
    {


        private readonly ITitleRepository _titleRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext _appDbContext;

        public ShoppingCartController(ITitleRepository titleRepository, ShoppingCart shoppingCart, AppDbContext appDbContext)
        {
            _titleRepository = titleRepository;
            _shoppingCart = shoppingCart;
            _appDbContext = appDbContext;
        }



        public ViewResult Index()
        {

            //Error - receives null
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;


            // still no data for quote
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }





        public RedirectToActionResult AddToShoppingCart(int TitleId)
        {

            //  Pass the Quote based on the Id identifier
            var selectedQuote = _titleRepository.GetAllTitles.FirstOrDefault(p => p.Id == TitleId);
            if (selectedQuote != null)
            {
                _shoppingCart.AddToCart(selectedQuote, 1);

            }
            return RedirectToAction("Index");
        }







        public RedirectToActionResult RemoveFromShoppingCart(int quoteId)
        {
            var selectedPie = _titleRepository.GetAllTitles.FirstOrDefault(p => p.Id == quoteId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}

