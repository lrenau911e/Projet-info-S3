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
            this.label_Operande1 = new System.Windows.Forms.Label();
            this.buttonCommencer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Operande2 = new System.Windows.Forms.Label();
            this.labelOperateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Resultat
            // 
            this.textBox_Resultat.Enabled = false;
            this.textBox_Resultat.Location = new System.Drawing.Point(149, 88);
            this.textBox_Resultat.Name = "textBox_Resultat";
            this.textBox_Resultat.Size = new System.Drawing.Size(96, 20);
            this.textBox_Resultat.TabIndex = 2;
            this.textBox_Resultat.Tag = "";
            this.textBox_Resultat.WordWrap = false;
            this.textBox_Resultat.TextChanged += new System.EventHandler(this.textBox_Resultat_TextChanged);
            // 
            // label_Operande1
            // 
            this.label_Operande1.AutoSize = true;
            this.label_Operande1.Location = new System.Drawing.Point(53, 90);
            this.label_Operande1.Name = "label_Operande1";
            this.label_Operande1.Size = new System.Drawing.Size(14, 13);
            this.label_Operande1.TabIndex = 7;
            this.label_Operande1.Text = "X";
            this.label_Operande1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCommencer
            // 
            this.buttonCommencer.Location = new System.Drawing.Point(56, 136);
            this.buttonCommencer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCommencer.Name = "buttonCommencer";
            this.buttonCommencer.Size = new System.Drawing.Size(181, 19);
            this.buttonCommencer.TabIndex = 9;
            this.buttonCommencer.Text = "Commencer le test d\'addition";
            this.buttonCommencer.UseVisualStyleBackColor = true;
            this.buttonCommencer.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // label_Operande2
            // 
            this.label_Operande2.AutoSize = true;
            this.label_Operande2.Location = new System.Drawing.Point(111, 90);
            this.label_Operande2.Name = "label_Operande2";
            this.label_Operande2.Size = new System.Drawing.Size(14, 13);
            this.label_Operande2.TabIndex = 11;
            this.label_Operande2.Text = "Y";
            this.label_Operande2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOperateur
            // 
            this.labelOperateur.AutoSize = true;
            this.labelOperateur.Location = new System.Drawing.Point(82, 90);
            this.labelOperateur.Name = "labelOperateur";
            this.labelOperateur.Size = new System.Drawing.Size(13, 13);
            this.labelOperateur.TabIndex = 12;
            this.labelOperateur.Text = "+";
            this.labelOperateur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.labelOperateur);
            this.Controls.Add(this.label_Operande2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCommencer);
            this.Controls.Add(this.label_Operande1);
            this.Controls.Add(this.textBox_Resultat);
            this.Name = "Form_Addition";
            this.Text = "Form_Addition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Resultat;
        private System.Windows.Forms.Label label_Operande1;
        private System.Windows.Forms.Button buttonCommencer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Operande2;
        private System.Windows.Forms.Label labelOperateur;
    }
}