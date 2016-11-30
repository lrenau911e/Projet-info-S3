namespace Projet_info_S3
{
    partial class Form_Perception_et_memoire_associative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Perception_et_memoire_associative));
            this.textBox_Instruction = new System.Windows.Forms.TextBox();
            this.buttonCommencer = new System.Windows.Forms.Button();
            this.textBox_Rep2 = new System.Windows.Forms.TextBox();
            this.label_Rep2 = new System.Windows.Forms.Label();
            this.label_ope2 = new System.Windows.Forms.Label();
            this.label_ope3 = new System.Windows.Forms.Label();
            this.label_Rep3 = new System.Windows.Forms.Label();
            this.textBox_Rep3 = new System.Windows.Forms.TextBox();
            this.label_ope1 = new System.Windows.Forms.Label();
            this.label_Rep1 = new System.Windows.Forms.Label();
            this.textBox_Rep1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Instruction
            // 
            this.textBox_Instruction.Location = new System.Drawing.Point(12, 12);
            this.textBox_Instruction.Multiline = true;
            this.textBox_Instruction.Name = "textBox_Instruction";
            this.textBox_Instruction.ReadOnly = true;
            this.textBox_Instruction.Size = new System.Drawing.Size(313, 130);
            this.textBox_Instruction.TabIndex = 9;
            this.textBox_Instruction.Text = resources.GetString("textBox_Instruction.Text");
            // 
            // buttonCommencer
            // 
            this.buttonCommencer.Location = new System.Drawing.Point(90, 249);
            this.buttonCommencer.Name = "buttonCommencer";
            this.buttonCommencer.Size = new System.Drawing.Size(148, 23);
            this.buttonCommencer.TabIndex = 8;
            this.buttonCommencer.Text = "Commencer le test";
            this.buttonCommencer.UseVisualStyleBackColor = true;
            this.buttonCommencer.Click += new System.EventHandler(this.buttonCommencer_Click);
            // 
            // textBox_Rep2
            // 
            this.textBox_Rep2.Location = new System.Drawing.Point(211, 185);
            this.textBox_Rep2.Name = "textBox_Rep2";
            this.textBox_Rep2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rep2.TabIndex = 10;
            this.textBox_Rep2.Visible = false;
            this.textBox_Rep2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_Rep2
            // 
            this.label_Rep2.AutoSize = true;
            this.label_Rep2.Location = new System.Drawing.Point(87, 188);
            this.label_Rep2.Name = "label_Rep2";
            this.label_Rep2.Size = new System.Drawing.Size(35, 13);
            this.label_Rep2.TabIndex = 11;
            this.label_Rep2.Text = "label1";
            this.label_Rep2.Visible = false;
            // 
            // label_ope2
            // 
            this.label_ope2.AutoSize = true;
            this.label_ope2.Location = new System.Drawing.Point(192, 188);
            this.label_ope2.Name = "label_ope2";
            this.label_ope2.Size = new System.Drawing.Size(13, 13);
            this.label_ope2.TabIndex = 12;
            this.label_ope2.Text = "=";
            this.label_ope2.Visible = false;
            // 
            // label_ope3
            // 
            this.label_ope3.AutoSize = true;
            this.label_ope3.Location = new System.Drawing.Point(192, 214);
            this.label_ope3.Name = "label_ope3";
            this.label_ope3.Size = new System.Drawing.Size(13, 13);
            this.label_ope3.TabIndex = 15;
            this.label_ope3.Text = "=";
            this.label_ope3.Visible = false;
            // 
            // label_Rep3
            // 
            this.label_Rep3.AutoSize = true;
            this.label_Rep3.Location = new System.Drawing.Point(87, 214);
            this.label_Rep3.Name = "label_Rep3";
            this.label_Rep3.Size = new System.Drawing.Size(35, 13);
            this.label_Rep3.TabIndex = 14;
            this.label_Rep3.Text = "label4";
            this.label_Rep3.Visible = false;
            // 
            // textBox_Rep3
            // 
            this.textBox_Rep3.Location = new System.Drawing.Point(211, 211);
            this.textBox_Rep3.Name = "textBox_Rep3";
            this.textBox_Rep3.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rep3.TabIndex = 13;
            this.textBox_Rep3.Visible = false;
            this.textBox_Rep3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_ope1
            // 
            this.label_ope1.AutoSize = true;
            this.label_ope1.Location = new System.Drawing.Point(192, 162);
            this.label_ope1.Name = "label_ope1";
            this.label_ope1.Size = new System.Drawing.Size(13, 13);
            this.label_ope1.TabIndex = 18;
            this.label_ope1.Text = "=";
            this.label_ope1.Visible = false;
            // 
            // label_Rep1
            // 
            this.label_Rep1.AutoSize = true;
            this.label_Rep1.Location = new System.Drawing.Point(87, 162);
            this.label_Rep1.Name = "label_Rep1";
            this.label_Rep1.Size = new System.Drawing.Size(35, 13);
            this.label_Rep1.TabIndex = 17;
            this.label_Rep1.Text = "label6";
            this.label_Rep1.Visible = false;
            // 
            // textBox_Rep1
            // 
            this.textBox_Rep1.Location = new System.Drawing.Point(211, 159);
            this.textBox_Rep1.Name = "textBox_Rep1";
            this.textBox_Rep1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rep1.TabIndex = 16;
            this.textBox_Rep1.Visible = false;
            this.textBox_Rep1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form_Perception_et_memoire_associative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 300);
            this.Controls.Add(this.label_ope1);
            this.Controls.Add(this.label_Rep1);
            this.Controls.Add(this.textBox_Rep1);
            this.Controls.Add(this.label_ope3);
            this.Controls.Add(this.label_Rep3);
            this.Controls.Add(this.textBox_Rep3);
            this.Controls.Add(this.label_ope2);
            this.Controls.Add(this.label_Rep2);
            this.Controls.Add(this.textBox_Rep2);
            this.Controls.Add(this.textBox_Instruction);
            this.Controls.Add(this.buttonCommencer);
            this.Name = "Form_Perception_et_memoire_associative";
            this.Text = "Form_Perception_et_memoire_associative";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Instruction;
        private System.Windows.Forms.Button buttonCommencer;
        private System.Windows.Forms.TextBox textBox_Rep2;
        private System.Windows.Forms.Label label_Rep2;
        private System.Windows.Forms.Label label_ope2;
        private System.Windows.Forms.Label label_ope3;
        private System.Windows.Forms.Label label_Rep3;
        private System.Windows.Forms.TextBox textBox_Rep3;
        private System.Windows.Forms.Label label_ope1;
        private System.Windows.Forms.Label label_Rep1;
        private System.Windows.Forms.TextBox textBox_Rep1;
    }
}