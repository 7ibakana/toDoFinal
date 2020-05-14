using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoFinal
{
    class ToDo
    {
        public ToDo(string text, bool urgent)
        {
            Text = Text; //set the Text property
            Urgent = urgent; //set the Urgent property
        }
        //A property, text, c# creates a text field to store data
        public string Text { get; set; }
        //Another auto property, c# creates an urgent field
        public bool Urgent { get; set; }
        public DateTime DateDue { get; set; }
        //Another property with an initial value
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public override string ToString()
        {
            string displayText = $"{Text} - Created on {DateCreated:f}";
            if (Urgent)
            {
                displayText += "URGENT!";
            }
            return displayText;
        }
    }
}
