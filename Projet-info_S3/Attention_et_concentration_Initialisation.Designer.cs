namespace Projet_info_S3
{
    partial class Attention_et_Concentration_Initialisation
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
            this.Btn_Menu = new System.Windows.Forms.Button();
            this.TexBox_Instruction = new System.Windows.Forms.TextBox();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_Demo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.Location = new System.Drawing.Point(402, 189);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(89, 23);
            this.Btn_Menu.TabIndex = 1;
            this.Btn_Menu.Text = "Menu principal";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Retour_menu_Click);
            // 
            // TexBox_Instruction
            // 
            this.TexBox_Instruction.Location = new System.Drawing.Point(64, 27);
            this.TexBox_Instruction.Multiline = true;
            this.TexBox_Instruction.Name = "TexBox_Instruction";
            this.TexBox_Instruction.Size = new System.Drawing.Size(427, 156);
            this.TexBox_Instruction.TabIndex = 3;
            this.TexBox_Instruction.Text = "Instructions : \r\n";
            // 
            // Btn_Start
            // 
            this.Btn_Start.AutoSize = true;
            this.Btn_Start.Location = new System.Drawing.Point(231, 189);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(98, 23);
            this.Btn_Start.TabIndex = 4;
            this.Btn_Start.Text = "Débuter exercice";
            this.Btn_Start.UseVisualStyleBackColor = true;
            // 
            // Btn_Demo
            // 
            this.Btn_Demo.AutoSize = true;
            this.Btn_Demo.Location = new System.Drawing.Point(64, 189);
            this.Btn_Demo.Name = "Btn_Demo";
            this.Btn_Demo.Size = new System.Drawing.Size(85, 23);
            this.Btn_Demo.TabIndex = 5;
            this.Btn_Demo.Text = "Démonstration";
            this.Btn_Demo.UseVisualStyleBackColor = true;
            // 
            // Attention_et_Concentration_Initialisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 262);
            this.Controls.Add(this.Btn_Demo);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.TexBox_Instruction);
            this.Controls.Add(this.Btn_Menu);
            this.Name = "Attention_et_Concentration_Initialisation";
            this.Text = "Attention_et_Concentration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Menu;
        private System.Windows.Forms.TextBox TexBox_Instruction;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_Demo;
    }
}