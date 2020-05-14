using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            label2.Text = myString;

        }

        private void btnAddWithDueDate_Click(object sender, EventArgs e)
        { 
            //Conversion of any text to DateTime and throwws a FormatException if the date can't be parsed
            try
            {
                //Makes sure the date is not today or in the past
                DateTime dateDue = DateTime.Parse(dteDue.Text);
                if (dateDue <= DateTime.Today)
                {
                    throw new FormatException("Due date Must be in the future");
                }

            }
            //A catch that handles all the different types of error
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Invalid date");
            }
            Tag = dteDue.Value; //tags the value of the dteDue to and then closes it
            Close();
        }

        private void SetUrgencyForm_Load(object sender, EventArgs e)
        {
            //Sets the the dteDue do today's date, formatted as MM/DD/YYYY
            DateTime today = DateTime.Today;
            dteDue.Text = $"{today:d}";
        }
    }
}
