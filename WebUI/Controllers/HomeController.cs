using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller, ICarService
    {
        ICarDal _icarDal;
        private object entity;

       
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var liste = carManager.GetAll();
            return View(liste);
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
