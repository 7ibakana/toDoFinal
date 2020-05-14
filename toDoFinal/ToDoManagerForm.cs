using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDoFinal
{
    public partial class ToDoManagerForm : Form
    {
        public ToDoManagerForm()
        {
            InitializeComponent();
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            //Remove any spaces start and end of string
            string todoText = txtNewToDo.Text;
            //Used the ShowDialog method to access the urgent form and set up a new instance of the form
            SetUrgencyForm urgent = new SetUrgencyForm(todoText);
            urgent.ShowDialog();
            DateTime dueDate = (DateTime)urgent.Tag;
            MessageBox.Show(dueDate.ToString());
            bool urgency = chkUrgency.Checked;
            if (!String.IsNullOrWhiteSpace(todoText))
            {
                //Create new toDoFinal object using a constructor0 
                ToDo toDoItem = new ToDo(todoText,urgency);
                toDoItem.DateDue = dueDate;
                if (!ToDoItemInList(toDoItem))
                {
                    clsToDo.Items.Add(toDoItem);
                    txtNewToDo.Text = ""; //Clear text
                }
                else
                {
                    MessageBox.Show("You already added that", "Duplicate");

                }
            }

        }

        private bool ToDoItemInList(ToDoManagerForm toDoItem)
        {
            foreach (ToDo ListItem in clsToDo.Items)
            {
                if (toDoItem.Text.ToUpper() == ListItem.Text.ToUpper())
                {
                    return true; //This list item has the same text as toDoItem
                }
            }
            //If the end of the loop is reached without returning,
            //an item with the same text is not in the list. Return false
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Make new list
            List<ToDo> doneItems = new List<ToDo>();
            //Copy all checked items to new List
            foreach (ToDo item in clsToDo.CheckedItems)
            {
                doneItems.Add(item);
            }
            //For each string in doneItems list, remove from clsToDo.Items
            //Add to lstUrgent.items
            foreach (ToDo item in doneItems)
            {
                clsToDo.Items.Remove(item); //Remove by value
                lstUrgent.Items.Add(item);
            
            }
        }
    }
}
