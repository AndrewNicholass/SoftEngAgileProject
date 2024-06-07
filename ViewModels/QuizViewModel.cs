using Fluentify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fluentify.ViewModels
{
    public class QuizViewModel
    {
        public List<Module> Modules { get; set; }
        public List<Question> Question { get; set; }
        public List<Choice> Choices { get; set; }
    }
}