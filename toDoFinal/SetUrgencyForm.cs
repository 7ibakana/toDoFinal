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
        public SetUrgencyForm(string myString)
        {
            InitializeComponent();
            label1.Text = $"When is {myString} due?";  
        }

        private void btnAddWithDueDate_Click(object sender, EventArgs e)
        {
            if(urgent = urgent.AddDays(+4))
            {
                lstUrgent.Items.Add(todoItem);
            }
            else
            {
                clsToDo.Items.Add(todoItem);
            }
        }

        private void SetUrgencyForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dteDue.Text = $"{today:d}";
        }
        public string urgent(string SetUrgencyForm, string ToDoManagerForm)
        {
            DateTimePicker urgent = DateTimePicker.dteDue;
        }
    }
}
