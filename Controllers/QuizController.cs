﻿using Fluentify.Models;
using Fluentify.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluentify.Controllers
{
    public class QuizController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Quiz
        public ActionResult Quiz()
        {
            QuizViewModel vm = new QuizViewModel();
            vm.Modules = (from x in db.Modules select x).ToList();
            vm.Question = db.Questions.ToList();
            vm.Choices = db.Choices.ToList();
            return View(vm);
        }
    }
}