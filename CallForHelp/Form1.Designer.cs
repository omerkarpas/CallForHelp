using System;
using System.Windows.Forms;

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
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.Alert = new System.Windows.Forms.Button();
            this.sms = new System.Windows.Forms.Button();
            this.help3 = new System.Windows.Forms.Button();
            this.help4 = new System.Windows.Forms.Button();
            this.help2 = new System.Windows.Forms.Button();
            this.Toilet = new System.Windows.Forms.Button();
            this.help1 = new System.Windows.Forms.Button();
            this.Water = new System.Windows.Forms.Button();
            this.Other = new System.Windows.Forms.Button();
            this.Food = new System.Windows.Forms.Button();
            this.Suction = new System.Windows.Forms.Button();
            this.HotCold = new System.Windows.Forms.Button();
            this.General = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(22, 104);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(547, 47);
            this.textBox.TabIndex = 8;
            this.textBox.Text = "I need something..";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Alert
            // 
            this.Alert.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_alert_selected;
            this.Alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Alert.FlatAppearance.BorderSize = 0;
            this.Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alert.Location = new System.Drawing.Point(22, 198);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(128, 47);
            this.Alert.TabIndex = 27;
            this.Alert.UseVisualStyleBackColor = true;
            this.Alert.Click += new System.EventHandler(this.Alert_Click);
            // 
            // sms
            // 
            this.sms.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_SMS;
            this.sms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sms.FlatAppearance.BorderSize = 0;
            this.sms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sms.Location = new System.Drawing.Point(162, 198);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(128, 47);
            this.sms.TabIndex = 26;
            this.sms.UseVisualStyleBackColor = true;
            this.sms.Click += new System.EventHandler(this.sms_Click);
            // 
            // help3
            // 
            this.help3.BackColor = System.Drawing.Color.Transparent;
            this.help3.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_p3;
            this.help3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help3.FlatAppearance.BorderSize = 0;
            this.help3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help3.Location = new System.Drawing.Point(286, 264);
            this.help3.Margin = new System.Windows.Forms.Padding(0);
            this.help3.Name = "help3";
            this.help3.Size = new System.Drawing.Size(122, 122);
            this.help3.TabIndex = 25;
            this.help3.UseVisualStyleBackColor = false;
            this.help3.Click += new System.EventHandler(this.button10_Click);
            // 
            // help4
            // 
            this.help4.BackColor = System.Drawing.Color.Transparent;
            this.help4.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_p4;
            this.help4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help4.FlatAppearance.BorderSize = 0;
            this.help4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help4.Location = new System.Drawing.Point(419, 264);
            this.help4.Margin = new System.Windows.Forms.Padding(0);
            this.help4.Name = "help4";
            this.help4.Size = new System.Drawing.Size(122, 122);
            this.help4.TabIndex = 24;
            this.help4.UseVisualStyleBackColor = false;
            this.help4.Click += new System.EventHandler(this.button9_Click);
            // 
            // help2
            // 
            this.help2.BackColor = System.Drawing.Color.Transparent;
            this.help2.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_p1;
            this.help2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help2.FlatAppearance.BorderSize = 0;
            this.help2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help2.Location = new System.Drawing.Point(154, 264);
            this.help2.Margin = new System.Windows.Forms.Padding(0);
            this.help2.Name = "help2";
            this.help2.Size = new System.Drawing.Size(122, 122);
            this.help2.TabIndex = 23;
            this.help2.UseVisualStyleBackColor = false;
            this.help2.Click += new System.EventHandler(this.button8_Click);
            // 
            // Toilet
            // 
            this.Toilet.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_toilet;
            this.Toilet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Toilet.FlatAppearance.BorderSize = 0;
            this.Toilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Toilet.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Toilet.Location = new System.Drawing.Point(324, 0);
            this.Toilet.Margin = new System.Windows.Forms.Padding(0);
            this.Toilet.Name = "Toilet";
            this.Toilet.Size = new System.Drawing.Size(80, 80);
            this.Toilet.TabIndex = 21;
            this.Toilet.UseVisualStyleBackColor = true;
            this.Toilet.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // help1
            // 
            this.help1.BackColor = System.Drawing.Color.Transparent;
            this.help1.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_p2;
            this.help1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help1.FlatAppearance.BorderSize = 0;
            this.help1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help1.Location = new System.Drawing.Point(22, 264);
            this.help1.Margin = new System.Windows.Forms.Padding(0);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(122, 122);
            this.help1.TabIndex = 16;
            this.help1.UseVisualStyleBackColor = false;
            this.help1.Click += new System.EventHandler(this.All_Click);
            // 
            // Water
            // 
            this.Water.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_water;
            this.Water.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Water.FlatAppearance.BorderSize = 0;
            this.Water.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Water.Location = new System.Drawing.Point(162, 0);
            this.Water.Margin = new System.Windows.Forms.Padding(0);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(80, 80);
            this.Water.TabIndex = 15;
            this.Water.UseVisualStyleBackColor = true;
            this.Water.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Other
            // 
            this.Other.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_write;
            this.Other.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Other.FlatAppearance.BorderSize = 0;
            this.Other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Other.Location = new System.Drawing.Point(486, 0);
            this.Other.Margin = new System.Windows.Forms.Padding(0);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(80, 80);
            this.Other.TabIndex = 14;
            this.Other.UseVisualStyleBackColor = true;
            this.Other.Click += new System.EventHandler(this.Other_Click);
            // 
            // Food
            // 
            this.Food.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_food;
            this.Food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Food.FlatAppearance.BorderSize = 0;
            this.Food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Food.Location = new System.Drawing.Point(81, 0);
            this.Food.Margin = new System.Windows.Forms.Padding(0);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(80, 80);
            this.Food.TabIndex = 13;
            this.Food.UseVisualStyleBackColor = true;
            this.Food.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Suction
            // 
            this.Suction.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_cleaning;
            this.Suction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Suction.FlatAppearance.BorderSize = 0;
            this.Suction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suction.Location = new System.Drawing.Point(405, 0);
            this.Suction.Margin = new System.Windows.Forms.Padding(0);
            this.Suction.Name = "Suction";
            this.Suction.Size = new System.Drawing.Size(80, 80);
            this.Suction.TabIndex = 12;
            this.Suction.UseVisualStyleBackColor = true;
            this.Suction.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // HotCold
            // 
            this.HotCold.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_temperature;
            this.HotCold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HotCold.FlatAppearance.BorderSize = 0;
            this.HotCold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HotCold.Location = new System.Drawing.Point(243, 0);
            this.HotCold.Margin = new System.Windows.Forms.Padding(0);
            this.HotCold.Name = "HotCold";
            this.HotCold.Size = new System.Drawing.Size(80, 80);
            this.HotCold.TabIndex = 10;
            this.HotCold.UseVisualStyleBackColor = true;
            this.HotCold.Click += new System.EventHandler(this.radioButton_CheckedChanged);
            this.HotCold.MouseLeave += new System.EventHandler(this.FoodBtn_MouseLeave);
            this.HotCold.MouseHover += new System.EventHandler(this.FoodBtn_MouseHover);
            // 
            // General
            // 
            this.General.BackgroundImage = global::CallForHelp.Properties.Resources.alert_family_UI_tab_help_seelcted;
            this.General.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.General.FlatAppearance.BorderSize = 0;
            this.General.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.General.Location = new System.Drawing.Point(0, 0);
            this.General.Margin = new System.Windows.Forms.Padding(0);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(80, 80);
            this.General.TabIndex = 29;
            this.General.UseVisualStyleBackColor = true;
            this.General.Click += new System.EventHandler(this.General_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 170);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(568, 401);
            this.Controls.Add(this.General);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.help3);
            this.Controls.Add(this.help4);
            this.Controls.Add(this.help2);
            this.Controls.Add(this.Toilet);
            this.Controls.Add(this.help1);
            this.Controls.Add(this.Water);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Suction);
            this.Controls.Add(this.HotCold);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CallForHelp";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button HotCold;
        private System.Windows.Forms.Button Suction;
        private System.Windows.Forms.Button Food;
        private System.Windows.Forms.Button Other;
        private System.Windows.Forms.Button Water;
        private System.Windows.Forms.Button help1;
        private System.Windows.Forms.Button Toilet;
        private System.Windows.Forms.Button help2;
        private System.Windows.Forms.Button help4;
        private System.Windows.Forms.Button help3;
        private System.Windows.Forms.Button sms;
        private System.Windows.Forms.Button Alert;
        private Button General;
        private Panel panel1;
    }
}

