using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIV.BL;
using UIV.MVC.Models;

namespace UIV.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserInputViewModel model)
        {
            var result = Validator.IsValid(model.InputStr);
            var _model = ProcessModel(model, result);
            
            ModelState.Clear();
            return View(_model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private UserInputViewModel ProcessModel(UserInputViewModel model, bool result)
        {
            var _model = model;
            if (ModelState.IsValid)
            {
                if (result)
                {
                    ProcessSuccessMessage(_model);
                    ProcessResultList(_model);
                }
                else
                    _model.Result = "Oops!  Try Again!";
            }
            else
                _model.Result = "Oops!  Try Again!";

            return _model;
        }

        private static void ProcessSuccessMessage(UserInputViewModel _model)
        {
            if (_model.Counter == null)
            {
                _model.Result = "Bingo!  It Validates!";
                _model.Counter = "two";
            }
            else
            {
                _model.Result = "You are a Winner!";
                _model.Counter = null;
            }
        }

        private static void ProcessResultList(UserInputViewModel model)
        {
            if (model.Result.Contains("Oops")) return;
            var oldList = model.ResultList;
            if (oldList == null)
                oldList += model.InputStr;
            else
                oldList += "," + model.InputStr;
            model.ResultList = oldList;
        }

    }
}