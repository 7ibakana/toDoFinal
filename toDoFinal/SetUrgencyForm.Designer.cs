namespace toDoFinal
{
    partial class SetUrgencyForm
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
            this.dteDue = new System.Windows.Forms.DateTimePicker();
            this.btnAddWithDueDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the due date for this item?";
            // 
            // dteDue
            // 
            this.dteDue.Location = new System.Drawing.Point(46, 71);
            this.dteDue.Name = "dteDue";
            this.dteDue.Size = new System.Drawing.Size(200, 20);
            this.dteDue.TabIndex = 1;
            // 
            // btnAddWithDueDate
            // 
            this.btnAddWithDueDate.Location = new System.Drawing.Point(105, 97);
            this.btnAddWithDueDate.Name = "btnAddWithDueDate";
            this.btnAddWithDueDate.Size = new System.Drawing.Size(75, 23);
            this.btnAddWithDueDate.TabIndex = 2;
            this.btnAddWithDueDate.Text = "Add item";
            this.btnAddWithDueDate.UseVisualStyleBackColor = true;
            this.btnAddWithDueDate.Click += new System.EventHandler(this.btnAddWithDueDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // SetUrgencyForm
            // 
            this.AcceptButton = this.btnAddWithDueDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddWithDueDate);
            this.Controls.Add(this.dteDue);
            this.Controls.Add(this.label1);
            this.Name = "SetUrgencyForm";
            this.Text = "SetUrgencyForm";
            this.Load += new System.EventHandler(this.SetUrgencyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteDue;
        private System.Windows.Forms.Button btnAddWithDueDate;
        private System.Windows.Forms.Label label2;
    }
}