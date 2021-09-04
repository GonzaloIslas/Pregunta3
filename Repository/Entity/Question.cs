using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Utilities.Enums;

namespace Tesis.Repository.Entity
{
    public class Question
    {
        public int QuestionId { get; set; }

        public string QuestionName { get; set; }

        public string FinalInfo { get; set; }

        public CategoryType QuestionType { get; set; }

        public List<Answer> AnswerList { get; set; }
    }
}
