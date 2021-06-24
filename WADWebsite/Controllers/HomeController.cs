using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq; 
using System.Text.Json;
using WADWebsite.Models;

namespace WADAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private IEnumerable<Festival> Festivals;
        const string SessionCart = "_Cart";

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllFestivals() //Used to show all data
        {

            List<Festival> Model = _context.Festivals.ToList();

            return View(Model);
        }


        public IActionResult OneFestival(short ID) //Used to show one festival when the festival image has been pressed
        {
            Festival model = _context.Festivals.Find(ID);

            return View(model);
        }


        public IActionResult Info()
        {
            return View();
        }

        public IActionResult SearchPage(string searchString)
        {
            var foundFestivals = _context.Festivals.Where(f => f.FestivalName.Contains(searchString));
            List<Festival> data = foundFestivals.ToList();
            return View(data);
        }

        public IActionResult SessionDemo()
        {
            if (HttpContext.Session.GetString("Name") == null)
            {
                ViewData["myName"] = "Not Set";
            }
            else
            {
                ViewData["myName"] = HttpContext.Session.GetString("Name"); ;
            }
            return View();
        }


        [HttpPost]
        public IActionResult FestivalDetails(IFormCollection form)
        {
            //Festival form = new Festival;

            int FestivalID = int.Parse(form["FestivalID"]);
            string FestivalName = form["FestivalName"].ToString();
            string TicketType = form["TicketType"].ToString();
            decimal TicketPrice = Decimal.Parse(form["TicketPrice"]);
            string FestivalImage = form["FestivalImage"].ToString();
            int OrderQuantity = 1;
            //int OrderQuantity = int.Parse(form["OrderQuantity"]);
            CartItem newOrder = new CartItem();
            newOrder.FestivalID = FestivalID;
            newOrder.FestivalName = FestivalName;
            newOrder.TicketType = TicketType;
            newOrder.TicketPrice = TicketPrice;
            newOrder.FestivalImage = FestivalImage;
            newOrder.OrderQuantity = OrderQuantity;
            newOrder.OrderDate = DateTime.Now;

            var CartList = new List<CartItem>();
            if (HttpContext.Session.GetString(SessionCart) != null)
            {
                string serialJSON = HttpContext.Session.GetString(SessionCart);
                CartList = JsonSerializer.Deserialize<List<CartItem>>(serialJSON);
                //
                var item = CartList.FirstOrDefault(o => o.FestivalID == FestivalID);
                if (item != null)
                {
                    item.OrderQuantity += OrderQuantity;
                }
                else
                {
                    CartList.Add(newOrder);
                }

            }
            else
            {
                CartList.Add(newOrder);
            }
            HttpContext.Session.SetString(SessionCart, JsonSerializer.Serialize(CartList));
            return RedirectToAction("ManageCart");

        }

        [HttpGet]
        public IActionResult ManageCart()

        {
            List<CartItem> cart = new List<CartItem>();
            if (HttpContext.Session.GetString(SessionCart) != null)
            {
                string serialJSON = HttpContext.Session.GetString(SessionCart);
                cart = JsonSerializer.Deserialize<List<CartItem>>(serialJSON);
            }
            if (TempData["msg"] != null)
            {
                ViewBag.msg = TempData["msg"].ToString();
            }
            return View(cart);

        }


        public IActionResult MinusQuantity(IFormCollection form)
        {
            int FestivalID = int.Parse(form["FestivalID"]);
            var CartList = new List<CartItem>();
            if (HttpContext.Session.GetString(SessionCart) != null)
            {
                string serialJSON = HttpContext.Session.GetString(SessionCart);
                CartList = JsonSerializer.Deserialize<List<CartItem>>(serialJSON);
                var item = CartList.FirstOrDefault(o => o.FestivalID == FestivalID);
                if (item != null && item.OrderQuantity > 1)
                {
                    item.OrderQuantity -= 1;
                }
                else if(item.OrderQuantity == 1)
                {
                    CartList.Remove(item);
                }

            }
            ManageCart();
            HttpContext.Session.SetString(SessionCart, JsonSerializer.Serialize(CartList));
            return RedirectToAction("ManageCart");
            
        }


        public IActionResult AddQuantity(IFormCollection form)
        {
            int FestivalID = int.Parse(form["FestivalID"]);
            var CartList = new List<CartItem>();
            if (HttpContext.Session.GetString(SessionCart) != null)
            {
                string serialJSON = HttpContext.Session.GetString(SessionCart);
                CartList = JsonSerializer.Deserialize<List<CartItem>>(serialJSON);
                var item = CartList.FirstOrDefault(o => o.FestivalID == FestivalID);
                if (item != null)
                {
                    item.OrderQuantity += 1;
                }

            }

            HttpContext.Session.SetString(SessionCart, JsonSerializer.Serialize(CartList));
            return RedirectToAction("ManageCart");
        }


        /*
        [HttpPost]
        public IActionResult RemoveCartItem(IFormCollection form)
        {
            int FestivalID = int.Parse(form["FestivalID"]);
            var CartList = new List<CartItem>();
            if (HttpContext.Session.GetString(SessionCart) != null)
            {
                string serialJSON = HttpContext.Session.GetString(SessionCart);
                CartList = JsonSerializer.Deserialize<List<CartItem>>(serialJSON);
                var item = CartList.FirstOrDefault(o => o.FestivalID == FestivalID);
                if (item != null)
                {
                    CartList.Remove(item);
                }
                        
            }

            HttpContext.Session.SetString(SessionCart, JsonSerializer.Serialize(CartList));
            TempData["msg"] = "Item Removed";
            return RedirectToAction("ManageCart");
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





       
    
    }
}
 
    
