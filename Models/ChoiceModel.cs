using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fluentify.Models
{
    public class ChoiceModel
    {
        public int ChoiceId { get; set; }
        public int QuestionId { get; set; }
        public string ChoiceText { get; set; }
        public int Correct { get; set; }
    }
}