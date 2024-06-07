using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fluentify.Models
{
    public class QuizViewModel
    {
        public List<SectionViewModel> Sections { get; set; }
        public string Title { get; set; }
    }

    public class SectionViewModel
    {
        public string SectionTitle { get; set; }
        public List<QuestionAnswerViewModel> QAs { get; set; }
    }
    public class QuestionAnswerViewModel
    {
        public QuestionViewModel Question { get; set; }
        public AnswerViewModel SelectedAnswer { get; set; }
        public List<QuestionAnswerViewModel> ChildQuestions { get; set; }
    }
    public class QuestionViewModel
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public List<AnswerViewModel> PossibleAnswers { get; set; }
        public string SelctedAnswer { get; set; }
        public int QuestionNumber { get; set; }
    }
    public class AnswerViewModel
    {
        public Guid Id { get; set; }
        public string AnswerText { get; set; }
    }
}