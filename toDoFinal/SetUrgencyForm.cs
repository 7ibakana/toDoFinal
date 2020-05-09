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
        SortedList<string[]>urgencyDate;
    {
        public SetUrgencyForm()
        {
            InitializeComponent();
        }

        public void SetUrgencyForm_Load(object sender, EventArgs e)
        {
            urgencyDate = new SortedList,< string[] >
            string[] = DateTime;
        }
    }
}
