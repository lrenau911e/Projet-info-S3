namespace Projet_info_S3
{
    partial class Form_Problemes_mathematiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Problemes_mathematiques));
            this.buttonCommencer = new System.Windows.Forms.Button();
            this.textBox_Instruction = new System.Windows.Forms.TextBox();
            this.checkBox_Rep1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Rep3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Rep2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Rep4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCommencer
            // 
            this.buttonCommencer.Location = new System.Drawing.Point(80, 232);
            this.buttonCommencer.Name = "buttonCommencer";
            this.buttonCommencer.Size = new System.Drawing.Size(148, 23);
            this.buttonCommencer.TabIndex = 0;
            this.buttonCommencer.Text = "Commencer le test";
            this.buttonCommencer.UseVisualStyleBackColor = true;
            this.buttonCommencer.Click += new System.EventHandler(this.buttonCommencer_Click);
            // 
            // textBox_Instruction
            // 
            this.textBox_Instruction.Location = new System.Drawing.Point(33, 12);
            this.textBox_Instruction.Multiline = true;
            this.textBox_Instruction.Name = "textBox_Instruction";
            this.textBox_Instruction.ReadOnly = true;
            this.textBox_Instruction.Size = new System.Drawing.Size(268, 99);
            this.textBox_Instruction.TabIndex = 1;
            this.textBox_Instruction.Text = resources.GetString("textBox_Instruction.Text");
            // 
            // checkBox_Rep1
            // 
            this.checkBox_Rep1.AutoSize = true;
            this.checkBox_Rep1.Location = new System.Drawing.Point(57, 149);
            this.checkBox_Rep1.Name = "checkBox_Rep1";
            this.checkBox_Rep1.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Rep1.TabIndex = 4;
            this.checkBox_Rep1.Text = "checkBox1";
            this.checkBox_Rep1.UseVisualStyleBackColor = true;
            this.checkBox_Rep1.Visible = false;
            this.checkBox_Rep1.CheckedChanged += new System.EventHandler(this.checkBox_Rep1_CheckedChanged);
            // 
            // checkBox_Rep3
            // 
            this.checkBox_Rep3.AutoSize = true;
            this.checkBox_Rep3.Location = new System.Drawing.Point(57, 186);
            this.checkBox_Rep3.Name = "checkBox_Rep3";
            this.checkBox_Rep3.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Rep3.TabIndex = 5;
            this.checkBox_Rep3.Text = "checkBox2";
            this.checkBox_Rep3.UseVisualStyleBackColor = true;
            this.checkBox_Rep3.Visible = false;
            this.checkBox_Rep3.CheckedChanged += new System.EventHandler(this.checkBox_Rep3_CheckedChanged);
            // 
            // checkBox_Rep2
            // 
            this.checkBox_Rep2.AutoSize = true;
            this.checkBox_Rep2.Location = new System.Drawing.Point(182, 149);
            this.checkBox_Rep2.Name = "checkBox_Rep2";
            this.checkBox_Rep2.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Rep2.TabIndex = 6;
            this.checkBox_Rep2.Text = "checkBox3";
            this.checkBox_Rep2.UseVisualStyleBackColor = true;
            this.checkBox_Rep2.Visible = false;
            this.checkBox_Rep2.CheckedChanged += new System.EventHandler(this.checkBox_Rep2_CheckedChanged);
            // 
            // checkBox_Rep4
            // 
            this.checkBox_Rep4.AutoSize = true;
            this.checkBox_Rep4.Location = new System.Drawing.Point(182, 186);
            this.checkBox_Rep4.Name = "checkBox_Rep4";
            this.checkBox_Rep4.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Rep4.TabIndex = 7;
            this.checkBox_Rep4.Text = "checkBox4";
            this.checkBox_Rep4.UseVisualStyleBackColor = true;
            this.checkBox_Rep4.Visible = false;
            this.checkBox_Rep4.CheckedChanged += new System.EventHandler(this.checkBox_Rep4_CheckedChanged);
            // 
            // Form_Problemes_mathematiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 266);
            this.Controls.Add(this.checkBox_Rep4);
            this.Controls.Add(this.checkBox_Rep2);
            this.Controls.Add(this.checkBox_Rep3);
            this.Controls.Add(this.checkBox_Rep1);
            this.Controls.Add(this.textBox_Instruction);
            this.Controls.Add(this.buttonCommencer);
            this.Name = "Form_Problemes_mathematiques";
            this.Text = "Form_Problemes_mathematiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCommencer;
        private System.Windows.Forms.TextBox textBox_Instruction;
        private System.Windows.Forms.CheckBox checkBox_Rep1;
        private System.Windows.Forms.CheckBox checkBox_Rep3;
        private System.Windows.Forms.CheckBox checkBox_Rep2;
        private System.Windows.Forms.CheckBox checkBox_Rep4;
    }
}