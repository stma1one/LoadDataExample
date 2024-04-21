using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDataExample.Models
{

    public class Question
    {
        public int QuestionId { get; set; }
        public Questiontopic QuestionTopic { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAnswer1Text { get; set; }
        public string QuestionAnswer2Text { get; set; }
        public string QuestionAnswer3Text { get; set; }
        public string QuestionAnswer4Text { get; set; }
    }

    

}
