using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_03.Models
{
    internal class Grade
    {
        public int Value { get; set; }
        public DateTime dateTime { get; set; }
        public string Course { get; set; }

        public Grade(int value, string course)
        {

            Value = value;
            Course = course;
            dateTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Course}: {Value} exam grade according to date {dateTime}";
        }
    }
}
