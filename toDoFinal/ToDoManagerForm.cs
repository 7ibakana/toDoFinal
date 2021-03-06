﻿using System;
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
            this.ActiveControl = txtNewToDo;
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
                ToDo toDoItem = new ToDo(todoText, urgency);
                toDoItem.DateDue = dueDate;
                if (toDoItem.Urgent || toDoItem.DateDue.Date == DateTime.Today)
                {
                    //Add to urgent list
                    lstUrgent.Items.Add(toDoItem);
                    txtNewToDo.Text = ""; //Clear text
                }
                else
                {
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

        }

        private bool ToDoItemInList(ToDo toDoItem)
        {
            foreach (ToDo ListItem in clsToDo.Items)
            {
                if (toDoItem.Text.ToUpper() == ListItem.Text.ToUpper())
                {
                    return true; //This list item has the same text as toDoItem
                }
                continue;
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
            foreach (ToDo item in lstUrgent.CheckedItems)
            {
                doneItems.Add(item);
            }
            //For each string in doneItems list, remove from clsToDo.Items, or lstUrgent
            //Add to lstUrgent.items
            foreach (ToDo item in doneItems)
            {
                clsToDo.Items.Remove(item); //Remove by value from class list
                lstUrgent.Items.Remove(item); //Remove by value from urgent list
                listDone.Items.Add(item); //Add removed values to Done list
            
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();//Closes program
        }
    }
}
