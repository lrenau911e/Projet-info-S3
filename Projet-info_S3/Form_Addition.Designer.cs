namespace Projet_info_S3
{
    partial class Form_Addition
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
            this.textBox_Resultat = new System.Windows.Forms.TextBox();
            this.label_Operateur = new System.Windows.Forms.Label();
            this.label_Operande1 = new System.Windows.Forms.Label();
            this.label_Operande2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Resultat
            // 
            this.textBox_Resultat.Location = new System.Drawing.Point(199, 108);
            this.textBox_Resultat.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Resultat.Name = "textBox_Resultat";
            this.textBox_Resultat.Size = new System.Drawing.Size(127, 22);
            this.textBox_Resultat.TabIndex = 2;
            this.textBox_Resultat.Tag = "";
            this.textBox_Resultat.WordWrap = false;
            this.textBox_Resultat.TextChanged += new System.EventHandler(this.textBox_Resultat_TextChanged);
            // 
            // label_Operateur
            // 
            this.label_Operateur.AutoSize = true;
            this.label_Operateur.Location = new System.Drawing.Point(110, 111);
            this.label_Operateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Operateur.Name = "label_Operateur";
            this.label_Operateur.Size = new System.Drawing.Size(16, 17);
            this.label_Operateur.TabIndex = 5;
            this.label_Operateur.Text = "+";
            // 
            // label_Operande1
            // 
            this.label_Operande1.AutoSize = true;
            this.label_Operande1.Location = new System.Drawing.Point(85, 111);
            this.label_Operande1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Operande1.Name = "label_Operande1";
            this.label_Operande1.Size = new System.Drawing.Size(17, 17);
            this.label_Operande1.TabIndex = 7;
            this.label_Operande1.Text = "X";
            this.label_Operande1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Operande2
            // 
            this.label_Operande2.AutoSize = true;
            this.label_Operande2.Location = new System.Drawing.Point(134, 111);
            this.label_Operande2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Operande2.Name = "label_Operande2";
            this.label_Operande2.Size = new System.Drawing.Size(17, 17);
            this.label_Operande2.TabIndex = 8;
            this.label_Operande2.Text = "Y";
            this.label_Operande2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Commencer le test d\'addition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // Form_Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Operande2);
            this.Controls.Add(this.label_Operande1);
            this.Controls.Add(this.label_Operateur);
            this.Controls.Add(this.textBox_Resultat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Addition";
            this.Text = "Form_Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Resultat;
        private System.Windows.Forms.Label label_Operateur;
        private System.Windows.Forms.Label label_Operande1;
        private System.Windows.Forms.Label label_Operande2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}