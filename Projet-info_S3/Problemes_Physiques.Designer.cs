﻿namespace Projet_info_S3
{
    partial class Problemes_Physiques
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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Demo = new System.Windows.Forms.Button();
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.AutoSize = true;
            this.Btn_Start.Location = new System.Drawing.Point(205, 186);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(98, 23);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Débuter exercice";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(450, 156);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Instructions : \r\n";
            // 
            // Btn_Demo
            // 
            this.Btn_Demo.AutoSize = true;
            this.Btn_Demo.Location = new System.Drawing.Point(37, 186);
            this.Btn_Demo.Name = "Btn_Demo";
            this.Btn_Demo.Size = new System.Drawing.Size(85, 23);
            this.Btn_Demo.TabIndex = 3;
            this.Btn_Demo.Text = "Démonstration";
            this.Btn_Demo.UseVisualStyleBackColor = true;
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.AutoSize = true;
            this.Btn_Menu.Location = new System.Drawing.Point(401, 186);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(86, 23);
            this.Btn_Menu.TabIndex = 4;
            this.Btn_Menu.Text = "Menu principal";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Problemes_Physiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 274);
            this.Controls.Add(this.Btn_Menu);
            this.Controls.Add(this.Btn_Demo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Btn_Start);
            this.Name = "Problemes_Physiques";
            this.Text = "Problemes_Physiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_Demo;
        private System.Windows.Forms.Button Btn_Menu;
    }
}