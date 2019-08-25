using System;
using Microsoft.AspNetCore.Mvc;
using MVCForms.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCForms.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
          //TODO: Implement Realistic Implementation
          return View(ProductRepository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
          ViewBag.Categories=new SelectList(
            new List<string>(){
              "Phone","Tablet","Computer"
            }
          );
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
         public IActionResult Create(Product product)
        {
          //TODO: Implement Realistic Implementation
          ProductRepository.addProduct(product);
          return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
          if(string.IsNullOrWhiteSpace(q))
            return View();
            else
            {
                return View("Index",ProductRepository.Products.Where(i=>i.Name.Contains(q)));
            }
        }
        public IActionResult Edit(int id)
        {

          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}