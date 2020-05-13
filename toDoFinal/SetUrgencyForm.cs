using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoFinal
{
    public partial class SetUrgencyForm : Form
    {
        private object urgency;
        private object urgent;
        private object clsToDo;

        public SetUrgencyForm(string myString)
        {
            InitializeComponent();
            label2.Text = myString;

        }

        private void btnAddWithDueDate_Click(object sender, EventArgs e)
        {
            foreach (DateDue in SetUrgencyForm)
            {
                urgent.Add(urgentItemInList);
            }
            foreach (urgent)
            {
                clsToDo.Add(urgentItemInList);
            }
        }

        private void SetUrgencyForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dteDue.Text = $"{today:d}";
        }
        private bool DateDue(SetUrgencyForm Date)
        {
            foreach (DateTime in dteDue.Day)
            {
                if (dteDue.Value.AddDays(+4))
                {
                    return true;
                }
            }
            
        }
    }
}
