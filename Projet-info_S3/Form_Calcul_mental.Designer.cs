namespace Projet_info_S3
{
    partial class Form_Calcul_mental
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
            this.button_Addiction = new System.Windows.Forms.Button();
            this.button_Soustraction = new System.Windows.Forms.Button();
            this.button_Multiplication = new System.Windows.Forms.Button();
            this.button_Division = new System.Windows.Forms.Button();
            this.button_Menu = new System.Windows.Forms.Button();
            this.textBoxInstructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Addiction
            // 
            this.button_Addiction.Location = new System.Drawing.Point(23, 12);
            this.button_Addiction.Name = "button_Addiction";
            this.button_Addiction.Size = new System.Drawing.Size(89, 23);
            this.button_Addiction.TabIndex = 0;
            this.button_Addiction.Text = "Addition";
            this.button_Addiction.UseVisualStyleBackColor = true;
            this.button_Addiction.Click += new System.EventHandler(this.button_Addiction_Click);
            // 
            // button_Soustraction
            // 
            this.button_Soustraction.Location = new System.Drawing.Point(23, 41);
            this.button_Soustraction.Name = "button_Soustraction";
            this.button_Soustraction.Size = new System.Drawing.Size(89, 23);
            this.button_Soustraction.TabIndex = 1;
            this.button_Soustraction.Text = "Soustraction";
            this.button_Soustraction.UseVisualStyleBackColor = true;
            // 
            // button_Multiplication
            // 
            this.button_Multiplication.Location = new System.Drawing.Point(23, 70);
            this.button_Multiplication.Name = "button_Multiplication";
            this.button_Multiplication.Size = new System.Drawing.Size(89, 23);
            this.button_Multiplication.TabIndex = 2;
            this.button_Multiplication.Text = "Multiplication";
            this.button_Multiplication.UseVisualStyleBackColor = true;
            // 
            // button_Division
            // 
            this.button_Division.Location = new System.Drawing.Point(23, 99);
            this.button_Division.Name = "button_Division";
            this.button_Division.Size = new System.Drawing.Size(89, 23);
            this.button_Division.TabIndex = 3;
            this.button_Division.Text = "Division";
            this.button_Division.UseVisualStyleBackColor = true;
            // 
            // button_Menu
            // 
            this.button_Menu.Location = new System.Drawing.Point(17, 141);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(95, 23);
            this.button_Menu.TabIndex = 4;
            this.button_Menu.Text = "Menu principal";
            this.button_Menu.UseVisualStyleBackColor = true;
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Location = new System.Drawing.Point(196, 25);
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.Size = new System.Drawing.Size(257, 20);
            this.textBoxInstructions.TabIndex = 5;
            this.textBoxInstructions.Text = "Ici il y aura les instructions";
            // 
            // Form_Calcul_mental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 202);
            this.Controls.Add(this.textBoxInstructions);
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.button_Division);
            this.Controls.Add(this.button_Multiplication);
            this.Controls.Add(this.button_Soustraction);
            this.Controls.Add(this.button_Addiction);
            this.Name = "Form_Calcul_mental";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Addiction;
        private System.Windows.Forms.Button button_Soustraction;
        private System.Windows.Forms.Button button_Multiplication;
        private System.Windows.Forms.Button button_Division;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.TextBox textBoxInstructions;
    }
}