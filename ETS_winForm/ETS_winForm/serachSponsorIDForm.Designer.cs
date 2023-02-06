namespace ETS_winForm
{
    partial class serachSponsorIDForm
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
            this.textSearchSponsorID = new System.Windows.Forms.TextBox();
            this.buttonSearchSponsorID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelSearchSponsorID = new System.Windows.Forms.Button();
            this.richTextBoxSearchSponsorID = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textSearchSponsorID
            // 
            this.textSearchSponsorID.Location = new System.Drawing.Point(276, 330);
            this.textSearchSponsorID.Name = "textSearchSponsorID";
            this.textSearchSponsorID.Size = new System.Drawing.Size(100, 29);
            this.textSearchSponsorID.TabIndex = 0;
            // 
            // buttonSearchSponsorID
            // 
            this.buttonSearchSponsorID.Location = new System.Drawing.Point(120, 403);
            this.buttonSearchSponsorID.Name = "buttonSearchSponsorID";
            this.buttonSearchSponsorID.Size = new System.Drawing.Size(104, 40);
            this.buttonSearchSponsorID.TabIndex = 1;
            this.buttonSearchSponsorID.Text = "Search";
            this.buttonSearchSponsorID.UseVisualStyleBackColor = true;
            this.buttonSearchSponsorID.Click += new System.EventHandler(this.buttonSearchSponsorID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Sponsor ID:";
            // 
            // buttonCancelSearchSponsorID
            // 
            this.buttonCancelSearchSponsorID.Location = new System.Drawing.Point(255, 403);
            this.buttonCancelSearchSponsorID.Name = "buttonCancelSearchSponsorID";
            this.buttonCancelSearchSponsorID.Size = new System.Drawing.Size(104, 40);
            this.buttonCancelSearchSponsorID.TabIndex = 3;
            this.buttonCancelSearchSponsorID.Text = "Cancel";
            this.buttonCancelSearchSponsorID.UseVisualStyleBackColor = true;
            this.buttonCancelSearchSponsorID.Click += new System.EventHandler(this.buttonCancelSearchSponsorID_Click);
            // 
            // richTextBoxSearchSponsorID
            // 
            this.richTextBoxSearchSponsorID.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxSearchSponsorID.Name = "richTextBoxSearchSponsorID";
            this.richTextBoxSearchSponsorID.Size = new System.Drawing.Size(480, 275);
            this.richTextBoxSearchSponsorID.TabIndex = 4;
            this.richTextBoxSearchSponsorID.Text = "";
            // 
            // serachSponsorIIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(504, 484);
            this.Controls.Add(this.richTextBoxSearchSponsorID);
            this.Controls.Add(this.buttonCancelSearchSponsorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchSponsorID);
            this.Controls.Add(this.textSearchSponsorID);
            this.Name = "serachSponsorIIDForm";
            this.Text = "Search Sponsor ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearchSponsorID;
        private System.Windows.Forms.Button buttonSearchSponsorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelSearchSponsorID;
        private System.Windows.Forms.RichTextBox richTextBoxSearchSponsorID;
    }
}