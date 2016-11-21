namespace Projet_info_S3
{
    partial class Form_Soustraction
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
            this.label_Titre = new System.Windows.Forms.Label();
            this.label_Operateur = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Resultat = new System.Windows.Forms.Label();
            this.textBox_Resultat = new System.Windows.Forms.TextBox();
            this.textBox_Operande2 = new System.Windows.Forms.TextBox();
            this.textBox_Operande1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Titre
            // 
            this.label_Titre.AutoSize = true;
            this.label_Titre.Location = new System.Drawing.Point(17, 11);
            this.label_Titre.Name = "label_Titre";
            this.label_Titre.Size = new System.Drawing.Size(66, 13);
            this.label_Titre.TabIndex = 13;
            this.label_Titre.Text = "Soustraction";
            this.label_Titre.Click += new System.EventHandler(this.label_Titre_Click);
            // 
            // label_Operateur
            // 
            this.label_Operateur.AutoSize = true;
            this.label_Operateur.Location = new System.Drawing.Point(12, 93);
            this.label_Operateur.Name = "label_Operateur";
            this.label_Operateur.Size = new System.Drawing.Size(10, 13);
            this.label_Operateur.TabIndex = 12;
            this.label_Operateur.Text = "-";
            this.label_Operateur.Click += new System.EventHandler(this.label_Operateur_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(197, 229);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 11;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label_Resultat
            // 
            this.label_Resultat.AutoSize = true;
            this.label_Resultat.Location = new System.Drawing.Point(12, 179);
            this.label_Resultat.Name = "label_Resultat";
            this.label_Resultat.Size = new System.Drawing.Size(153, 13);
            this.label_Resultat.TabIndex = 10;
            this.label_Resultat.Text = "Veuillez taper votre résultat ici :";
            this.label_Resultat.Click += new System.EventHandler(this.label_Resultat_Click);
            // 
            // textBox_Resultat
            // 
            this.textBox_Resultat.Location = new System.Drawing.Point(15, 195);
            this.textBox_Resultat.Name = "textBox_Resultat";
            this.textBox_Resultat.Size = new System.Drawing.Size(202, 20);
            this.textBox_Resultat.TabIndex = 9;
            this.textBox_Resultat.TextChanged += new System.EventHandler(this.textBox_Resultat_TextChanged);
            // 
            // textBox_Operande2
            // 
            this.textBox_Operande2.Location = new System.Drawing.Point(15, 115);
            this.textBox_Operande2.Name = "textBox_Operande2";
            this.textBox_Operande2.Size = new System.Drawing.Size(135, 20);
            this.textBox_Operande2.TabIndex = 8;
            this.textBox_Operande2.TextChanged += new System.EventHandler(this.textBox_Operande2_TextChanged);
            // 
            // textBox_Operande1
            // 
            this.textBox_Operande1.Location = new System.Drawing.Point(13, 66);
            this.textBox_Operande1.Name = "textBox_Operande1";
            this.textBox_Operande1.Size = new System.Drawing.Size(135, 20);
            this.textBox_Operande1.TabIndex = 7;
            this.textBox_Operande1.TextChanged += new System.EventHandler(this.textBox_Operande1_TextChanged);
            // 
            // Form_Soustraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label_Titre);
            this.Controls.Add(this.label_Operateur);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Resultat);
            this.Controls.Add(this.textBox_Resultat);
            this.Controls.Add(this.textBox_Operande2);
            this.Controls.Add(this.textBox_Operande1);
            this.Name = "Form_Soustraction";
            this.Text = "Form_Soustraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titre;
        private System.Windows.Forms.Label label_Operateur;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Resultat;
        private System.Windows.Forms.TextBox textBox_Resultat;
        private System.Windows.Forms.TextBox textBox_Operande2;
        private System.Windows.Forms.TextBox textBox_Operande1;
    }
}