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
            this.Commencer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Commencer
            // 
            this.Commencer.Location = new System.Drawing.Point(422, 302);
            this.Commencer.Name = "Commencer";
            this.Commencer.Size = new System.Drawing.Size(75, 23);
            this.Commencer.TabIndex = 0;
            this.Commencer.Text = "button1";
            this.Commencer.UseVisualStyleBackColor = true;
            // 
            // Problemes_Physiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 517);
            this.Controls.Add(this.Commencer);
            this.Name = "Problemes_Physiques";
            this.Text = "Problemes_Physiques";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Commencer;
    }
}