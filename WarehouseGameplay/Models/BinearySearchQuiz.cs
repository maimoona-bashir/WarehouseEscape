using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseGameplay.Models
{
    public class BinearySearchQuiz
    {
        public string Id { get; set; }
		public string Question { get; set; }
		public string Answer1 { get; set; }
		public string Answer2 { get; set; }
		public string Answer3 { get; set; }
		public int CorrectAnswer { get; set; }
    }
}
