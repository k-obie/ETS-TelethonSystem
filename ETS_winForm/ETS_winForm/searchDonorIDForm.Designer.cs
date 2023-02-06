namespace ETS_winForm
{
    partial class searchDonorIDForm
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
            this.richTextBoxSearchDonorID = new System.Windows.Forms.RichTextBox();
            this.buttonCancelSearchDonorID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchDonorID = new System.Windows.Forms.Button();
            this.textSearcDonorID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxSearchDonorID
            // 
            this.richTextBoxSearchDonorID.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxSearchDonorID.Name = "richTextBoxSearchDonorID";
            this.richTextBoxSearchDonorID.Size = new System.Drawing.Size(480, 296);
            this.richTextBoxSearchDonorID.TabIndex = 0;
            this.richTextBoxSearchDonorID.Text = "";
            // 
            // buttonCancelSearchDonorID
            // 
            this.buttonCancelSearchDonorID.Location = new System.Drawing.Point(260, 411);
            this.buttonCancelSearchDonorID.Name = "buttonCancelSearchDonorID";
            this.buttonCancelSearchDonorID.Size = new System.Drawing.Size(104, 40);
            this.buttonCancelSearchDonorID.TabIndex = 7;
            this.buttonCancelSearchDonorID.Text = "Cancel";
            this.buttonCancelSearchDonorID.UseVisualStyleBackColor = true;
            this.buttonCancelSearchDonorID.Click += new System.EventHandler(this.buttonCancelSearchDonorID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Donor ID:";
            // 
            // buttonSearchDonorID
            // 
            this.buttonSearchDonorID.Location = new System.Drawing.Point(125, 411);
            this.buttonSearchDonorID.Name = "buttonSearchDonorID";
            this.buttonSearchDonorID.Size = new System.Drawing.Size(104, 40);
            this.buttonSearchDonorID.TabIndex = 5;
            this.buttonSearchDonorID.Text = "Search";
            this.buttonSearchDonorID.UseVisualStyleBackColor = true;
            this.buttonSearchDonorID.Click += new System.EventHandler(this.buttonSearchDonorID_Click);
            // 
            // textSearcDonorID
            // 
            this.textSearcDonorID.Location = new System.Drawing.Point(281, 338);
            this.textSearcDonorID.Name = "textSearcDonorID";
            this.textSearcDonorID.Size = new System.Drawing.Size(100, 29);
            this.textSearcDonorID.TabIndex = 4;
            // 
            // searchDonorIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(504, 484);
            this.Controls.Add(this.buttonCancelSearchDonorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchDonorID);
            this.Controls.Add(this.textSearcDonorID);
            this.Controls.Add(this.richTextBoxSearchDonorID);
            this.Name = "searchDonorIDForm";
            this.Text = "Search Donor ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSearchDonorID;
        private System.Windows.Forms.Button buttonCancelSearchDonorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchDonorID;
        private System.Windows.Forms.TextBox textSearcDonorID;
    }
}