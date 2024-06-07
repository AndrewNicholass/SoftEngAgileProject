using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fluentify.Models
{
    public class QuestionModel
    {
        public int QuestionId { get; set; }
        public int ModuleId { get; set; }
        public string QuestionText {  get; set; }
        public int Point {  get; set; }
    }
}