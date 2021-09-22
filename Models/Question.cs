using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollAPI.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }

    }
    public class Answer
    {
        public int AnswerID { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
        public int SelectedTime { get; set; }
    }
}
