namespace ETS_winForm
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSponsors = new System.Windows.Forms.TabPage();
            this.textPrizeMinimumDonation = new System.Windows.Forms.TextBox();
            this.textPrizeQuantity = new System.Windows.Forms.TextBox();
            this.textPrizeValue = new System.Windows.Forms.TextBox();
            this.textPrizeDescription = new System.Windows.Forms.TextBox();
            this.textPrizeID = new System.Windows.Forms.TextBox();
            this.textSponsorID = new System.Windows.Forms.TextBox();
            this.textSponsorLastName = new System.Windows.Forms.TextBox();
            this.textSponsorFirstName = new System.Windows.Forms.TextBox();
            this.buttonListPrizes = new System.Windows.Forms.Button();
            this.buttonListSponsors = new System.Windows.Forms.Button();
            this.buttonAddPrize = new System.Windows.Forms.Button();
            this.buttonAddSponsor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDonors = new System.Windows.Forms.TabPage();
            this.buttonSaveDonorInfo = new System.Windows.Forms.Button();
            this.buttonListDonor = new System.Windows.Forms.Button();
            this.buttonListDonations = new System.Windows.Forms.Button();
            this.buttonAddDonation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonQualifiedPrizes = new System.Windows.Forms.Button();
            this.textDonationNumberPrize = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textDonationPrizeId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioDonorCardTypeAMEX = new System.Windows.Forms.RadioButton();
            this.radioDonorCardTypeMC = new System.Windows.Forms.RadioButton();
            this.radioDonorCardTypeVisa = new System.Windows.Forms.RadioButton();
            this.textDonorCardExpiry = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textDonorCardNumber = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textDonationAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textDonationID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textDonorPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textDonorAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textDonorLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textDonorFirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDonorID = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odonationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osponsorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oprizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdonationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ssponsorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sprizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSearchSponsorIDMain = new System.Windows.Forms.Button();
            this.buttonSearchDonorIDMain = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSponsors.SuspendLayout();
            this.tabDonors.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSponsors);
            this.tabControl1.Controls.Add(this.tabDonors);
            this.tabControl1.Location = new System.Drawing.Point(1, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(818, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSponsors
            // 
            this.tabSponsors.BackColor = System.Drawing.Color.DarkGray;
            this.tabSponsors.Controls.Add(this.textPrizeMinimumDonation);
            this.tabSponsors.Controls.Add(this.textPrizeQuantity);
            this.tabSponsors.Controls.Add(this.textPrizeValue);
            this.tabSponsors.Controls.Add(this.textPrizeDescription);
            this.tabSponsors.Controls.Add(this.textPrizeID);
            this.tabSponsors.Controls.Add(this.textSponsorID);
            this.tabSponsors.Controls.Add(this.textSponsorLastName);
            this.tabSponsors.Controls.Add(this.textSponsorFirstName);
            this.tabSponsors.Controls.Add(this.buttonListPrizes);
            this.tabSponsors.Controls.Add(this.buttonListSponsors);
            this.tabSponsors.Controls.Add(this.buttonAddPrize);
            this.tabSponsors.Controls.Add(this.buttonAddSponsor);
            this.tabSponsors.Controls.Add(this.label10);
            this.tabSponsors.Controls.Add(this.label11);
            this.tabSponsors.Controls.Add(this.label6);
            this.tabSponsors.Controls.Add(this.label7);
            this.tabSponsors.Controls.Add(this.label8);
            this.tabSponsors.Controls.Add(this.label5);
            this.tabSponsors.Controls.Add(this.label4);
            this.tabSponsors.Controls.Add(this.label3);
            this.tabSponsors.Controls.Add(this.label2);
            this.tabSponsors.Controls.Add(this.label1);
            this.tabSponsors.Location = new System.Drawing.Point(4, 33);
            this.tabSponsors.Name = "tabSponsors";
            this.tabSponsors.Padding = new System.Windows.Forms.Padding(3);
            this.tabSponsors.Size = new System.Drawing.Size(810, 441);
            this.tabSponsors.TabIndex = 0;
            this.tabSponsors.Text = "Sponsors";
            // 
            // textPrizeMinimumDonation
            // 
            this.textPrizeMinimumDonation.Location = new System.Drawing.Point(628, 260);
            this.textPrizeMinimumDonation.Name = "textPrizeMinimumDonation";
            this.textPrizeMinimumDonation.Size = new System.Drawing.Size(117, 29);
            this.textPrizeMinimumDonation.TabIndex = 21;
            // 
            // textPrizeQuantity
            // 
            this.textPrizeQuantity.Location = new System.Drawing.Point(628, 215);
            this.textPrizeQuantity.Name = "textPrizeQuantity";
            this.textPrizeQuantity.Size = new System.Drawing.Size(117, 29);
            this.textPrizeQuantity.TabIndex = 20;
            // 
            // textPrizeValue
            // 
            this.textPrizeValue.Location = new System.Drawing.Point(628, 171);
            this.textPrizeValue.Name = "textPrizeValue";
            this.textPrizeValue.Size = new System.Drawing.Size(117, 29);
            this.textPrizeValue.TabIndex = 19;
            // 
            // textPrizeDescription
            // 
            this.textPrizeDescription.Location = new System.Drawing.Point(560, 127);
            this.textPrizeDescription.Name = "textPrizeDescription";
            this.textPrizeDescription.Size = new System.Drawing.Size(185, 29);
            this.textPrizeDescription.TabIndex = 18;
            // 
            // textPrizeID
            // 
            this.textPrizeID.Location = new System.Drawing.Point(560, 80);
            this.textPrizeID.Name = "textPrizeID";
            this.textPrizeID.Size = new System.Drawing.Size(185, 29);
            this.textPrizeID.TabIndex = 17;
            // 
            // textSponsorID
            // 
            this.textSponsorID.Location = new System.Drawing.Point(156, 171);
            this.textSponsorID.Name = "textSponsorID";
            this.textSponsorID.Size = new System.Drawing.Size(185, 29);
            this.textSponsorID.TabIndex = 16;
            // 
            // textSponsorLastName
            // 
            this.textSponsorLastName.Location = new System.Drawing.Point(156, 127);
            this.textSponsorLastName.Name = "textSponsorLastName";
            this.textSponsorLastName.Size = new System.Drawing.Size(185, 29);
            this.textSponsorLastName.TabIndex = 15;
            // 
            // textSponsorFirstName
            // 
            this.textSponsorFirstName.Location = new System.Drawing.Point(156, 79);
            this.textSponsorFirstName.Name = "textSponsorFirstName";
            this.textSponsorFirstName.Size = new System.Drawing.Size(185, 29);
            this.textSponsorFirstName.TabIndex = 14;
            // 
            // buttonListPrizes
            // 
            this.buttonListPrizes.Location = new System.Drawing.Point(588, 382);
            this.buttonListPrizes.Name = "buttonListPrizes";
            this.buttonListPrizes.Size = new System.Drawing.Size(157, 40);
            this.buttonListPrizes.TabIndex = 13;
            this.buttonListPrizes.Text = "View Prizes";
            this.buttonListPrizes.UseVisualStyleBackColor = true;
            this.buttonListPrizes.Click += new System.EventHandler(this.buttonListPrizes_Click);
            // 
            // buttonListSponsors
            // 
            this.buttonListSponsors.Location = new System.Drawing.Point(411, 382);
            this.buttonListSponsors.Name = "buttonListSponsors";
            this.buttonListSponsors.Size = new System.Drawing.Size(157, 40);
            this.buttonListSponsors.TabIndex = 12;
            this.buttonListSponsors.Text = "View Sponsors";
            this.buttonListSponsors.UseVisualStyleBackColor = true;
            this.buttonListSponsors.Click += new System.EventHandler(this.buttonListSponsors_Click);
            // 
            // buttonAddPrize
            // 
            this.buttonAddPrize.Location = new System.Drawing.Point(588, 332);
            this.buttonAddPrize.Name = "buttonAddPrize";
            this.buttonAddPrize.Size = new System.Drawing.Size(157, 40);
            this.buttonAddPrize.TabIndex = 11;
            this.buttonAddPrize.Text = "Add Prize";
            this.buttonAddPrize.UseVisualStyleBackColor = true;
            this.buttonAddPrize.Click += new System.EventHandler(this.buttonAddPrize_Click);
            // 
            // buttonAddSponsor
            // 
            this.buttonAddSponsor.Location = new System.Drawing.Point(411, 332);
            this.buttonAddSponsor.Name = "buttonAddSponsor";
            this.buttonAddSponsor.Size = new System.Drawing.Size(157, 40);
            this.buttonAddSponsor.TabIndex = 10;
            this.buttonAddSponsor.Text = "Add Sponsor";
            this.buttonAddSponsor.UseVisualStyleBackColor = true;
            this.buttonAddSponsor.Click += new System.EventHandler(this.buttonAddSponsor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 50);
            this.label10.TabIndex = 9;
            this.label10.Text = "Minimum donation \r\nlimit?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "How many?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Value per Prize:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Prize ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prize Information:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sponsor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sponsor Information:";
            // 
            // tabDonors
            // 
            this.tabDonors.BackColor = System.Drawing.Color.DarkGray;
            this.tabDonors.Controls.Add(this.buttonSaveDonorInfo);
            this.tabDonors.Controls.Add(this.buttonListDonor);
            this.tabDonors.Controls.Add(this.buttonListDonations);
            this.tabDonors.Controls.Add(this.buttonAddDonation);
            this.tabDonors.Controls.Add(this.groupBox3);
            this.tabDonors.Controls.Add(this.groupBox1);
            this.tabDonors.Controls.Add(this.label17);
            this.tabDonors.Controls.Add(this.textDonationAmount);
            this.tabDonors.Controls.Add(this.label18);
            this.tabDonors.Controls.Add(this.label19);
            this.tabDonors.Controls.Add(this.textDonationID);
            this.tabDonors.Controls.Add(this.label16);
            this.tabDonors.Controls.Add(this.textDonorPhone);
            this.tabDonors.Controls.Add(this.label14);
            this.tabDonors.Controls.Add(this.textDonorAddress);
            this.tabDonors.Controls.Add(this.label15);
            this.tabDonors.Controls.Add(this.textDonorLastName);
            this.tabDonors.Controls.Add(this.label13);
            this.tabDonors.Controls.Add(this.textDonorFirstName);
            this.tabDonors.Controls.Add(this.label12);
            this.tabDonors.Controls.Add(this.label9);
            this.tabDonors.Controls.Add(this.textDonorID);
            this.tabDonors.Location = new System.Drawing.Point(4, 33);
            this.tabDonors.Name = "tabDonors";
            this.tabDonors.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonors.Size = new System.Drawing.Size(810, 441);
            this.tabDonors.TabIndex = 1;
            this.tabDonors.Text = "Donors";
            // 
            // buttonSaveDonorInfo
            // 
            this.buttonSaveDonorInfo.Location = new System.Drawing.Point(591, 389);
            this.buttonSaveDonorInfo.Name = "buttonSaveDonorInfo";
            this.buttonSaveDonorInfo.Size = new System.Drawing.Size(199, 40);
            this.buttonSaveDonorInfo.TabIndex = 22;
            this.buttonSaveDonorInfo.Text = "Save Donor Info";
            this.buttonSaveDonorInfo.UseVisualStyleBackColor = true;
            this.buttonSaveDonorInfo.Click += new System.EventHandler(this.buttonSaveDonorInfo_Click);
            // 
            // buttonListDonor
            // 
            this.buttonListDonor.Location = new System.Drawing.Point(591, 345);
            this.buttonListDonor.Name = "buttonListDonor";
            this.buttonListDonor.Size = new System.Drawing.Size(199, 40);
            this.buttonListDonor.TabIndex = 21;
            this.buttonListDonor.Text = "List Donors";
            this.buttonListDonor.UseVisualStyleBackColor = true;
            this.buttonListDonor.Click += new System.EventHandler(this.buttonListDonor_Click);
            // 
            // buttonListDonations
            // 
            this.buttonListDonations.Location = new System.Drawing.Point(591, 306);
            this.buttonListDonations.Name = "buttonListDonations";
            this.buttonListDonations.Size = new System.Drawing.Size(199, 40);
            this.buttonListDonations.TabIndex = 20;
            this.buttonListDonations.Text = "List Donations";
            this.buttonListDonations.UseVisualStyleBackColor = true;
            this.buttonListDonations.Click += new System.EventHandler(this.buttonListDonations_Click);
            // 
            // buttonAddDonation
            // 
            this.buttonAddDonation.Location = new System.Drawing.Point(591, 267);
            this.buttonAddDonation.Name = "buttonAddDonation";
            this.buttonAddDonation.Size = new System.Drawing.Size(199, 40);
            this.buttonAddDonation.TabIndex = 19;
            this.buttonAddDonation.Text = "Add Donation";
            this.buttonAddDonation.UseVisualStyleBackColor = true;
            this.buttonAddDonation.Click += new System.EventHandler(this.buttonAddDonation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.buttonQualifiedPrizes);
            this.groupBox3.Controls.Add(this.textDonationNumberPrize);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.textDonationPrizeId);
            this.groupBox3.Location = new System.Drawing.Point(388, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 165);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Award Prize:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 25);
            this.label22.TabIndex = 26;
            this.label22.Text = "Number:";
            // 
            // buttonQualifiedPrizes
            // 
            this.buttonQualifiedPrizes.Location = new System.Drawing.Point(19, 32);
            this.buttonQualifiedPrizes.Name = "buttonQualifiedPrizes";
            this.buttonQualifiedPrizes.Size = new System.Drawing.Size(158, 44);
            this.buttonQualifiedPrizes.TabIndex = 23;
            this.buttonQualifiedPrizes.Text = "Show Prizes";
            this.buttonQualifiedPrizes.UseVisualStyleBackColor = true;
            this.buttonQualifiedPrizes.Click += new System.EventHandler(this.buttonQualifiedPrizes_Click);
            // 
            // textDonationNumberPrize
            // 
            this.textDonationNumberPrize.Location = new System.Drawing.Point(99, 128);
            this.textDonationNumberPrize.Name = "textDonationNumberPrize";
            this.textDonationNumberPrize.Size = new System.Drawing.Size(78, 29);
            this.textDonationNumberPrize.TabIndex = 25;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 25);
            this.label23.TabIndex = 24;
            this.label23.Text = "Prize ID:";
            // 
            // textDonationPrizeId
            // 
            this.textDonationPrizeId.Location = new System.Drawing.Point(99, 82);
            this.textDonationPrizeId.Name = "textDonationPrizeId";
            this.textDonationPrizeId.Size = new System.Drawing.Size(78, 29);
            this.textDonationPrizeId.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textDonorCardExpiry);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.textDonorCardNumber);
            this.groupBox1.Location = new System.Drawing.Point(388, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 236);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit Card Information:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(258, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 25);
            this.label24.TabIndex = 21;
            this.label24.Text = "mm/yyyy";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = "Expiry:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.radioDonorCardTypeAMEX);
            this.groupBox2.Controls.Add(this.radioDonorCardTypeMC);
            this.groupBox2.Controls.Add(this.radioDonorCardTypeVisa);
            this.groupBox2.Location = new System.Drawing.Point(19, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 93);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Card Type:";
            // 
            // radioDonorCardTypeAMEX
            // 
            this.radioDonorCardTypeAMEX.AutoSize = true;
            this.radioDonorCardTypeAMEX.Location = new System.Drawing.Point(225, 43);
            this.radioDonorCardTypeAMEX.Name = "radioDonorCardTypeAMEX";
            this.radioDonorCardTypeAMEX.Size = new System.Drawing.Size(95, 29);
            this.radioDonorCardTypeAMEX.TabIndex = 2;
            this.radioDonorCardTypeAMEX.TabStop = true;
            this.radioDonorCardTypeAMEX.Text = "AMEX";
            this.radioDonorCardTypeAMEX.UseVisualStyleBackColor = true;
            // 
            // radioDonorCardTypeMC
            // 
            this.radioDonorCardTypeMC.AutoSize = true;
            this.radioDonorCardTypeMC.Location = new System.Drawing.Point(135, 43);
            this.radioDonorCardTypeMC.Name = "radioDonorCardTypeMC";
            this.radioDonorCardTypeMC.Size = new System.Drawing.Size(69, 29);
            this.radioDonorCardTypeMC.TabIndex = 1;
            this.radioDonorCardTypeMC.TabStop = true;
            this.radioDonorCardTypeMC.Text = "MC";
            this.radioDonorCardTypeMC.UseVisualStyleBackColor = true;
            // 
            // radioDonorCardTypeVisa
            // 
            this.radioDonorCardTypeVisa.AutoSize = true;
            this.radioDonorCardTypeVisa.Location = new System.Drawing.Point(22, 43);
            this.radioDonorCardTypeVisa.Name = "radioDonorCardTypeVisa";
            this.radioDonorCardTypeVisa.Size = new System.Drawing.Size(84, 29);
            this.radioDonorCardTypeVisa.TabIndex = 0;
            this.radioDonorCardTypeVisa.TabStop = true;
            this.radioDonorCardTypeVisa.Text = "VISA";
            this.radioDonorCardTypeVisa.UseVisualStyleBackColor = true;
            // 
            // textDonorCardExpiry
            // 
            this.textDonorCardExpiry.Location = new System.Drawing.Point(132, 182);
            this.textDonorCardExpiry.Name = "textDonorCardExpiry";
            this.textDonorCardExpiry.Size = new System.Drawing.Size(114, 29);
            this.textDonorCardExpiry.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 139);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 25);
            this.label21.TabIndex = 18;
            this.label21.Text = "Number:";
            // 
            // textDonorCardNumber
            // 
            this.textDonorCardNumber.Location = new System.Drawing.Point(132, 139);
            this.textDonorCardNumber.Name = "textDonorCardNumber";
            this.textDonorCardNumber.Size = new System.Drawing.Size(198, 29);
            this.textDonorCardNumber.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 389);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 25);
            this.label17.TabIndex = 15;
            this.label17.Text = "Amount:";
            // 
            // textDonationAmount
            // 
            this.textDonationAmount.Location = new System.Drawing.Point(173, 389);
            this.textDonationAmount.Name = "textDonationAmount";
            this.textDonationAmount.Size = new System.Drawing.Size(100, 29);
            this.textDonationAmount.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(30, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(218, 25);
            this.label18.TabIndex = 13;
            this.label18.Text = "Donation Information:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 343);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 25);
            this.label19.TabIndex = 12;
            this.label19.Text = "Donation ID:";
            // 
            // textDonationID
            // 
            this.textDonationID.Location = new System.Drawing.Point(173, 343);
            this.textDonationID.Name = "textDonationID";
            this.textDonationID.Size = new System.Drawing.Size(100, 29);
            this.textDonationID.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Phone";
            // 
            // textDonorPhone
            // 
            this.textDonorPhone.Location = new System.Drawing.Point(173, 248);
            this.textDonorPhone.Name = "textDonorPhone";
            this.textDonorPhone.Size = new System.Drawing.Size(168, 29);
            this.textDonorPhone.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Address:";
            // 
            // textDonorAddress
            // 
            this.textDonorAddress.Location = new System.Drawing.Point(173, 204);
            this.textDonorAddress.Name = "textDonorAddress";
            this.textDonorAddress.Size = new System.Drawing.Size(168, 29);
            this.textDonorAddress.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 6;
            this.label15.Text = "Last name:";
            // 
            // textDonorLastName
            // 
            this.textDonorLastName.Location = new System.Drawing.Point(173, 158);
            this.textDonorLastName.Name = "textDonorLastName";
            this.textDonorLastName.Size = new System.Drawing.Size(168, 29);
            this.textDonorLastName.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "First name:";
            // 
            // textDonorFirstName
            // 
            this.textDonorFirstName.Location = new System.Drawing.Point(173, 115);
            this.textDonorFirstName.Name = "textDonorFirstName";
            this.textDonorFirstName.Size = new System.Drawing.Size(168, 29);
            this.textDonorFirstName.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Donor Informatin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Donor ID:";
            // 
            // textDonorID
            // 
            this.textDonorID.Location = new System.Drawing.Point(173, 69);
            this.textDonorID.Name = "textDonorID";
            this.textDonorID.Size = new System.Drawing.Size(168, 29);
            this.textDonorID.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(825, 476);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 40);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.DarkGray;
            this.richTextBoxInfo.Location = new System.Drawing.Point(9, 523);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(934, 243);
            this.richTextBoxInfo.TabIndex = 13;
            this.richTextBoxInfo.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 38);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 34);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odonorToolStripMenuItem,
            this.odonationToolStripMenuItem,
            this.osponsorToolStripMenuItem,
            this.oprizeToolStripMenuItem,
            this.oallToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 40);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // odonorToolStripMenuItem
            // 
            this.odonorToolStripMenuItem.Name = "odonorToolStripMenuItem";
            this.odonorToolStripMenuItem.Size = new System.Drawing.Size(217, 40);
            this.odonorToolStripMenuItem.Text = "Donor";
            this.odonorToolStripMenuItem.Click += new System.EventHandler(this.odonorToolStripMenuItem_Click);
            // 
            // odonationToolStripMenuItem
            // 
            this.odonationToolStripMenuItem.Name = "odonationToolStripMenuItem";
            this.odonationToolStripMenuItem.Size = new System.Drawing.Size(217, 40);
            this.odonationToolStripMenuItem.Text = "Donation";
            this.odonationToolStripMenuItem.Click += new System.EventHandler(this.odonationToolStripMenuItem_Click);
            // 
            // osponsorToolStripMenuItem
            // 
            this.osponsorToolStripMenuItem.Name = "osponsorToolStripMenuItem";
            this.osponsorToolStripMenuItem.Size = new System.Drawing.Size(217, 40);
            this.osponsorToolStripMenuItem.Text = "Sponsor";
            this.osponsorToolStripMenuItem.Click += new System.EventHandler(this.osponsorToolStripMenuItem_Click);
            // 
            // oprizeToolStripMenuItem
            // 
            this.oprizeToolStripMenuItem.Name = "oprizeToolStripMenuItem";
            this.oprizeToolStripMenuItem.Size = new System.Drawing.Size(217, 40);
            this.oprizeToolStripMenuItem.Text = "Prize";
            this.oprizeToolStripMenuItem.Click += new System.EventHandler(this.oprizeToolStripMenuItem_Click);
            // 
            // oallToolStripMenuItem
            // 
            this.oallToolStripMenuItem.Name = "oallToolStripMenuItem";
            this.oallToolStripMenuItem.Size = new System.Drawing.Size(217, 40);
            this.oallToolStripMenuItem.Text = "All";
            this.oallToolStripMenuItem.Click += new System.EventHandler(this.oallToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdonorToolStripMenuItem,
            this.sdonationToolStripMenuItem1,
            this.ssponsorToolStripMenuItem1,
            this.sprizeToolStripMenuItem1,
            this.sallToolStripMenuItem1});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 40);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // sdonorToolStripMenuItem
            // 
            this.sdonorToolStripMenuItem.Name = "sdonorToolStripMenuItem";
            this.sdonorToolStripMenuItem.Size = new System.Drawing.Size(217, 40);
            this.sdonorToolStripMenuItem.Text = "Donor";
            this.sdonorToolStripMenuItem.Click += new System.EventHandler(this.sdonorToolStripMenuItem_Click);
            // 
            // sdonationToolStripMenuItem1
            // 
            this.sdonationToolStripMenuItem1.Name = "sdonationToolStripMenuItem1";
            this.sdonationToolStripMenuItem1.Size = new System.Drawing.Size(217, 40);
            this.sdonationToolStripMenuItem1.Text = "Donation";
            this.sdonationToolStripMenuItem1.Click += new System.EventHandler(this.sdonationToolStripMenuItem1_Click);
            // 
            // ssponsorToolStripMenuItem1
            // 
            this.ssponsorToolStripMenuItem1.Name = "ssponsorToolStripMenuItem1";
            this.ssponsorToolStripMenuItem1.Size = new System.Drawing.Size(217, 40);
            this.ssponsorToolStripMenuItem1.Text = "Sponsor";
            this.ssponsorToolStripMenuItem1.Click += new System.EventHandler(this.ssponsorToolStripMenuItem1_Click);
            // 
            // sprizeToolStripMenuItem1
            // 
            this.sprizeToolStripMenuItem1.Name = "sprizeToolStripMenuItem1";
            this.sprizeToolStripMenuItem1.Size = new System.Drawing.Size(217, 40);
            this.sprizeToolStripMenuItem1.Text = "Prize";
            this.sprizeToolStripMenuItem1.Click += new System.EventHandler(this.sprizeToolStripMenuItem1_Click);
            // 
            // sallToolStripMenuItem1
            // 
            this.sallToolStripMenuItem1.Name = "sallToolStripMenuItem1";
            this.sallToolStripMenuItem1.Size = new System.Drawing.Size(217, 40);
            this.sallToolStripMenuItem1.Text = "All";
            this.sallToolStripMenuItem1.Click += new System.EventHandler(this.sallToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonSearchSponsorIDMain
            // 
            this.buttonSearchSponsorIDMain.Location = new System.Drawing.Point(829, 278);
            this.buttonSearchSponsorIDMain.Name = "buttonSearchSponsorIDMain";
            this.buttonSearchSponsorIDMain.Size = new System.Drawing.Size(114, 70);
            this.buttonSearchSponsorIDMain.TabIndex = 16;
            this.buttonSearchSponsorIDMain.Text = "Search \r\nSponsor ";
            this.buttonSearchSponsorIDMain.UseVisualStyleBackColor = true;
            this.buttonSearchSponsorIDMain.Click += new System.EventHandler(this.buttonSearchSponsorIDMain_Click);
            // 
            // buttonSearchDonorIDMain
            // 
            this.buttonSearchDonorIDMain.Location = new System.Drawing.Point(829, 202);
            this.buttonSearchDonorIDMain.Name = "buttonSearchDonorIDMain";
            this.buttonSearchDonorIDMain.Size = new System.Drawing.Size(114, 70);
            this.buttonSearchDonorIDMain.TabIndex = 17;
            this.buttonSearchDonorIDMain.Text = "Search \r\nDonor";
            this.buttonSearchDonorIDMain.UseVisualStyleBackColor = true;
            this.buttonSearchDonorIDMain.Click += new System.EventHandler(this.buttonSearchDonorIDMain_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(953, 773);
            this.Controls.Add(this.buttonSearchDonorIDMain);
            this.Controls.Add(this.buttonSearchSponsorIDMain);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "ETS Telethon Systems";
            this.tabControl1.ResumeLayout(false);
            this.tabSponsors.ResumeLayout(false);
            this.tabSponsors.PerformLayout();
            this.tabDonors.ResumeLayout(false);
            this.tabDonors.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabSponsors;
        private System.Windows.Forms.TabPage tabDonors;
        private System.Windows.Forms.TextBox textPrizeMinimumDonation;
        private System.Windows.Forms.TextBox textPrizeQuantity;
        private System.Windows.Forms.TextBox textPrizeValue;
        private System.Windows.Forms.TextBox textPrizeDescription;
        private System.Windows.Forms.TextBox textPrizeID;
        private System.Windows.Forms.TextBox textSponsorID;
        private System.Windows.Forms.TextBox textSponsorLastName;
        private System.Windows.Forms.TextBox textSponsorFirstName;
        private System.Windows.Forms.Button buttonListPrizes;
        private System.Windows.Forms.Button buttonListSponsors;
        private System.Windows.Forms.Button buttonAddPrize;
        private System.Windows.Forms.Button buttonAddSponsor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonSaveDonorInfo;
        private System.Windows.Forms.Button buttonListDonor;
        private System.Windows.Forms.Button buttonListDonations;
        private System.Windows.Forms.Button buttonAddDonation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textDonorCardExpiry;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textDonorCardNumber;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textDonationAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textDonationID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textDonorPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textDonorAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textDonorLastName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textDonorFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDonorID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonQualifiedPrizes;
        private System.Windows.Forms.TextBox textDonationNumberPrize;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textDonationPrizeId;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton radioDonorCardTypeAMEX;
        private System.Windows.Forms.RadioButton radioDonorCardTypeMC;
        private System.Windows.Forms.RadioButton radioDonorCardTypeVisa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odonationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osponsorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oprizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssponsorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sprizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sallToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sdonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdonationToolStripMenuItem1;
        private System.Windows.Forms.Button buttonSearchSponsorIDMain;
        private System.Windows.Forms.Button buttonSearchDonorIDMain;
    }
}