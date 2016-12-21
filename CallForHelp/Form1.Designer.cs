namespace CallForHelp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkboxSms = new System.Windows.Forms.CheckBox();
            this.rBtnFood = new System.Windows.Forms.RadioButton();
            this.rBtnToilet = new System.Windows.Forms.RadioButton();
            this.rBtnSuction = new System.Windows.Forms.RadioButton();
            this.rBtnFreeText = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkboxRingBell = new System.Windows.Forms.CheckBox();
            this.chkboxMail = new System.Windows.Forms.CheckBox();
            this.rBtnHotCold = new System.Windows.Forms.RadioButton();
            this.rBtnUser2 = new System.Windows.Forms.RadioButton();
            this.rBtnUser1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(4, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(395, 231);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(269, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 68);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkboxSms
            // 
            this.chkboxSms.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkboxSms.AutoSize = true;
            this.chkboxSms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxSms.Location = new System.Drawing.Point(4, 249);
            this.chkboxSms.Name = "chkboxSms";
            this.chkboxSms.Size = new System.Drawing.Size(60, 34);
            this.chkboxSms.TabIndex = 3;
            this.chkboxSms.Text = "SMS";
            this.chkboxSms.UseVisualStyleBackColor = true;
            this.chkboxSms.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rBtnFood
            // 
            this.rBtnFood.AutoSize = true;
            this.rBtnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFood.Location = new System.Drawing.Point(4, 289);
            this.rBtnFood.Name = "rBtnFood";
            this.rBtnFood.Size = new System.Drawing.Size(68, 24);
            this.rBtnFood.TabIndex = 4;
            this.rBtnFood.TabStop = true;
            this.rBtnFood.Text = "Food";
            this.rBtnFood.UseVisualStyleBackColor = true;
            this.rBtnFood.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rBtnToilet
            // 
            this.rBtnToilet.AutoSize = true;
            this.rBtnToilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnToilet.Location = new System.Drawing.Point(93, 289);
            this.rBtnToilet.Name = "rBtnToilet";
            this.rBtnToilet.Size = new System.Drawing.Size(71, 24);
            this.rBtnToilet.TabIndex = 5;
            this.rBtnToilet.TabStop = true;
            this.rBtnToilet.Text = "Toilet";
            this.rBtnToilet.UseVisualStyleBackColor = true;
            this.rBtnToilet.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rBtnSuction
            // 
            this.rBtnSuction.AutoSize = true;
            this.rBtnSuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSuction.Location = new System.Drawing.Point(196, 289);
            this.rBtnSuction.Name = "rBtnSuction";
            this.rBtnSuction.Size = new System.Drawing.Size(88, 24);
            this.rBtnSuction.TabIndex = 6;
            this.rBtnSuction.TabStop = true;
            this.rBtnSuction.Text = "Suction";
            this.rBtnSuction.UseVisualStyleBackColor = true;
            this.rBtnSuction.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rBtnFreeText
            // 
            this.rBtnFreeText.AutoSize = true;
            this.rBtnFreeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFreeText.Location = new System.Drawing.Point(4, 318);
            this.rBtnFreeText.Name = "rBtnFreeText";
            this.rBtnFreeText.Size = new System.Drawing.Size(103, 24);
            this.rBtnFreeText.TabIndex = 7;
            this.rBtnFreeText.TabStop = true;
            this.rBtnFreeText.Text = "Free Text";
            this.rBtnFreeText.UseVisualStyleBackColor = true;
            this.rBtnFreeText.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 348);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 68);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // chkboxRingBell
            // 
            this.chkboxRingBell.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkboxRingBell.AutoSize = true;
            this.chkboxRingBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxRingBell.Location = new System.Drawing.Point(304, 249);
            this.chkboxRingBell.Name = "chkboxRingBell";
            this.chkboxRingBell.Size = new System.Drawing.Size(95, 34);
            this.chkboxRingBell.TabIndex = 9;
            this.chkboxRingBell.Text = "Ring Bell";
            this.chkboxRingBell.UseVisualStyleBackColor = true;
            this.chkboxRingBell.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chkboxMail
            // 
            this.chkboxMail.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkboxMail.AutoSize = true;
            this.chkboxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxMail.Location = new System.Drawing.Point(163, 249);
            this.chkboxMail.Name = "chkboxMail";
            this.chkboxMail.Size = new System.Drawing.Size(54, 34);
            this.chkboxMail.TabIndex = 10;
            this.chkboxMail.Text = "Mail";
            this.chkboxMail.UseVisualStyleBackColor = true;
            this.chkboxMail.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rBtnHotCold
            // 
            this.rBtnHotCold.AutoSize = true;
            this.rBtnHotCold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnHotCold.Location = new System.Drawing.Point(311, 289);
            this.rBtnHotCold.Name = "rBtnHotCold";
            this.rBtnHotCold.Size = new System.Drawing.Size(97, 24);
            this.rBtnHotCold.TabIndex = 11;
            this.rBtnHotCold.TabStop = true;
            this.rBtnHotCold.Text = "Hot\\Cold";
            this.rBtnHotCold.UseVisualStyleBackColor = true;
            this.rBtnHotCold.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rBtnUser2
            // 
            this.rBtnUser2.AutoSize = true;
            this.rBtnUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnUser2.Location = new System.Drawing.Point(328, 319);
            this.rBtnUser2.Name = "rBtnUser2";
            this.rBtnUser2.Size = new System.Drawing.Size(75, 24);
            this.rBtnUser2.TabIndex = 12;
            this.rBtnUser2.TabStop = true;
            this.rBtnUser2.Text = "User2";
            this.rBtnUser2.UseVisualStyleBackColor = true;
            this.rBtnUser2.Visible = false;
            this.rBtnUser2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rBtnUser1
            // 
            this.rBtnUser1.AutoSize = true;
            this.rBtnUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnUser1.Location = new System.Drawing.Point(163, 318);
            this.rBtnUser1.Name = "rBtnUser1";
            this.rBtnUser1.Size = new System.Drawing.Size(75, 24);
            this.rBtnUser1.TabIndex = 13;
            this.rBtnUser1.TabStop = true;
            this.rBtnUser1.Text = "User1";
            this.rBtnUser1.UseVisualStyleBackColor = true;
            this.rBtnUser1.Visible = false;
            this.rBtnUser1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 420);
            this.Controls.Add(this.rBtnUser1);
            this.Controls.Add(this.rBtnUser2);
            this.Controls.Add(this.rBtnHotCold);
            this.Controls.Add(this.chkboxMail);
            this.Controls.Add(this.chkboxRingBell);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rBtnFreeText);
            this.Controls.Add(this.rBtnSuction);
            this.Controls.Add(this.rBtnToilet);
            this.Controls.Add(this.rBtnFood);
            this.Controls.Add(this.chkboxSms);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallForHelp";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkboxSms;
        private System.Windows.Forms.RadioButton rBtnFood;
        private System.Windows.Forms.RadioButton rBtnToilet;
        private System.Windows.Forms.RadioButton rBtnSuction;
        private System.Windows.Forms.RadioButton rBtnFreeText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkboxRingBell;
        private System.Windows.Forms.CheckBox chkboxMail;
        private System.Windows.Forms.RadioButton rBtnHotCold;
        private System.Windows.Forms.RadioButton rBtnUser2;
        private System.Windows.Forms.RadioButton rBtnUser1;
    }
}

