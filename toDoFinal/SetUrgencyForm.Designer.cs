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
            this.lblUrgencyLevel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the due date for this item?";
            // 
            // dteDue
            // 
            this.dteDue.Location = new System.Drawing.Point(148, 107);
            this.dteDue.Name = "dteDue";
            this.dteDue.Size = new System.Drawing.Size(200, 20);
            this.dteDue.TabIndex = 1;
            // 
            // btnAddWithDueDate
            // 
            this.btnAddWithDueDate.Location = new System.Drawing.Point(213, 133);
            this.btnAddWithDueDate.Name = "btnAddWithDueDate";
            this.btnAddWithDueDate.Size = new System.Drawing.Size(75, 23);
            this.btnAddWithDueDate.TabIndex = 2;
            this.btnAddWithDueDate.Text = "Add item";
            this.btnAddWithDueDate.UseVisualStyleBackColor = true;
            this.btnAddWithDueDate.Click += new System.EventHandler(this.btnAddWithDueDate_Click);
            // 
            // lblUrgencyLevel
            // 
            this.lblUrgencyLevel.AutoSize = true;
            this.lblUrgencyLevel.Location = new System.Drawing.Point(12, 27);
            this.lblUrgencyLevel.Name = "lblUrgencyLevel";
            this.lblUrgencyLevel.Size = new System.Drawing.Size(479, 13);
            this.lblUrgencyLevel.TabIndex = 12;
            this.lblUrgencyLevel.Text = "On a scale of 1 to 5, with 1 being the highest and 5 the lowest, how high is the " +
    "urgency for this item?";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(107, 43);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(301, 45);
            this.trackBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 11);
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
            this.ClientSize = new System.Drawing.Size(500, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblUrgencyLevel);
            this.Controls.Add(this.btnAddWithDueDate);
            this.Controls.Add(this.dteDue);
            this.Controls.Add(this.label1);
            this.Name = "SetUrgencyForm";
            this.Text = "SetUrgencyForm";
            this.Load += new System.EventHandler(this.SetUrgencyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dteDue;
        private System.Windows.Forms.Button btnAddWithDueDate;
        private System.Windows.Forms.Label lblUrgencyLevel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
    }
}