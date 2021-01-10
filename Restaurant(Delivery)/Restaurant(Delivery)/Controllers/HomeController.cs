using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant_Delivery_.Data.interfaces;
using Restaurant_Delivery_.Data.Models;
using Restaurant_Delivery_.ViewModels;

namespace Restaurant_Delivery_.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                HotDeals = _productRepository.HotDeals
            };
            return View(homeViewModel);
        }
    }
}
