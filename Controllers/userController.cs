using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyChoice.Models;

namespace MyChoice.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index()
        {
            return RedirectToAction("ListAllTrees", "Tree");
        }

        public ActionResult AllTree()
        {
            return RedirectToAction("ListAllTrees");
        }

        public string ListAllTrees()
        {
            return @"<ul>
            <li>Maple</li>
            <li>Palm</li>
            <li>Birch</li>
            <li>Cedar</li>
            </ul>";
        }

        public ActionResult NewTree(string TreeName, string State, int Price, int Age, string Season, bool IsFavorite)
        {
            treeModel t = new treeModel()
            {
                treeName = TreeName,
                state = State,
                price = Price,
                age = Age,
                season = Season,
                isFavorite = IsFavorite
            };
            return View("ConfirmTree", t);
        }

        [HttpPost]
        public ActionResult NewTrees(string treeName, string state, int price)
        {
            ViewBag.Message = "Tree Name:" + treeName + " " + "State Name:" + state;
            ViewBag.Message = "The Price" + price;
       
            return View("confirmTree");
        }
        public ActionResult NewTrees()
        {
            return View("NewTree");
        }
        public ActionResult HomePage()
        {
            return View();
        }
    }
}