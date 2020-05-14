namespace toDoFinal
{
    partial class ToDoManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clsToDo = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listDone = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkUrgency = new System.Windows.Forms.CheckBox();
            this.lstUrgent = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To do items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Urgent items";
            // 
            // clsToDo
            // 
            this.clsToDo.FormattingEnabled = true;
            this.clsToDo.Location = new System.Drawing.Point(19, 61);
            this.clsToDo.Name = "clsToDo";
            this.clsToDo.Size = new System.Drawing.Size(120, 94);
            this.clsToDo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deleted items";
            // 
            // listDone
            // 
            this.listDone.FormattingEnabled = true;
            this.listDone.Location = new System.Drawing.Point(19, 213);
            this.listDone.Name = "listDone";
            this.listDone.Size = new System.Drawing.Size(279, 56);
            this.listDone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Items to add?";
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(93, 10);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(100, 20);
            this.txtNewToDo.TabIndex = 7;
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(302, 8);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDo.TabIndex = 8;
            this.btnAddToDo.Text = "A&dd";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete checked items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkUrgency
            // 
            this.chkUrgency.AutoSize = true;
            this.chkUrgency.Location = new System.Drawing.Point(199, 12);
            this.chkUrgency.Name = "chkUrgency";
            this.chkUrgency.Size = new System.Drawing.Size(97, 17);
            this.chkUrgency.TabIndex = 11;
            this.chkUrgency.Text = "High Urgency?";
            this.chkUrgency.UseVisualStyleBackColor = true;
            // 
            // lstUrgent
            // 
            this.lstUrgent.FormattingEnabled = true;
            this.lstUrgent.Location = new System.Drawing.Point(262, 55);
            this.lstUrgent.Name = "lstUrgent";
            this.lstUrgent.Size = new System.Drawing.Size(120, 94);
            this.lstUrgent.TabIndex = 12;
            // 
            // ToDoManagerForm
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 281);
            this.Controls.Add(this.lstUrgent);
            this.Controls.Add(this.chkUrgency);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.txtNewToDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clsToDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToDoManagerForm";
            this.Text = "ToDoManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clsToDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkUrgency;
        private System.Windows.Forms.CheckedListBox lstUrgent;
    }
}