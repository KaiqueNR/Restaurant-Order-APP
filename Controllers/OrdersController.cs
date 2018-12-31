using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GFTTest.Models;
using GFTTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace GFTTest.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IDishServices _services;

        public OrdersController(IDishServices services)
        {
            _services = services;
        }

        [HttpGet]
        public ActionResult<Dictionary<int, List<Dish>>> Home()
        {
            var Dishes = _services.GetOrdersHistory();

            return View(Dishes);
        }

        [HttpGet]
        public ActionResult<Dictionary<int, List<Dish>>> GetOrdersHistory()
        {
            var Dishes = _services.GetOrdersHistory();
            
            return Json(Dishes);
        }

        [HttpPost]
        public ActionResult AddOrder(string inputOrder)
        {
            try
            {
                var dishes = _services.AddOrder(inputOrder);

                return Ok(new
                {
                    success = true,
                    result = string.Concat(dishes.FirstOrDefault().Period, ", ", string.Join(",", dishes.GroupBy(g => g.DishType)
                                                                                                                .Select(s => string.Format("{0}{1}",
                                                                                                                            s.FirstOrDefault().Name
                                                                                                                            , s.Count() > 1 ? string.Concat("(", s.Count(), ")") : string.Empty))))
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}