using Fluentify.Models;
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
        public ActionResult Quiz(int moduleId)
        {
            ViewBag.ModuleId = moduleId;
            QuizViewModel vm = new QuizViewModel();
            vm.Modules = (from x in db.Modules select x).ToList();
            vm.Question = db.Questions.ToList();
            vm.Choices = db.Choices.ToList();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Score(FormCollection frm)
        {
            Database1Entities db = new Database1Entities();
            int score = 0;
            int lastQuestionId = (from x in db.Questions orderby x.QuestionId descending select x.QuestionId).FirstOrDefault();
            for (int i = 0; i < lastQuestionId; i++) 
            {
                string choiceRadio = frm[i];
                score += Convert.ToInt32(choiceRadio);
            }
            ScoreViewModel scoreViewModel = new ScoreViewModel();
            scoreViewModel.Score = score*10;
            return View(scoreViewModel);
        }
    }
}