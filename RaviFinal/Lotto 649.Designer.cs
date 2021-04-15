namespace Ravi
{
    partial class Lotto_649
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.frm_Lotto649_lblName = new System.Windows.Forms.Button();
            this.frm_Lotto649 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lable_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "ReadFile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_Lotto649_lblName
            // 
            this.frm_Lotto649_lblName.Location = new System.Drawing.Point(118, 324);
            this.frm_Lotto649_lblName.Name = "frm_Lotto649_lblName";
            this.frm_Lotto649_lblName.Size = new System.Drawing.Size(75, 23);
            this.frm_Lotto649_lblName.TabIndex = 7;
            this.frm_Lotto649_lblName.Text = "Generate";
            this.frm_Lotto649_lblName.UseVisualStyleBackColor = true;
            this.frm_Lotto649_lblName.Click += new System.EventHandler(this.frm_Lotto649_lblName_Click);
            // 
            // frm_Lotto649
            // 
            this.frm_Lotto649.Location = new System.Drawing.Point(322, 77);
            this.frm_Lotto649.Multiline = true;
            this.frm_Lotto649.Name = "frm_Lotto649";
            this.frm_Lotto649.Size = new System.Drawing.Size(79, 210);
            this.frm_Lotto649.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "The winning numbers are :";
            // 
            // lable_welcome
            // 
            this.lable_welcome.AutoSize = true;
            this.lable_welcome.Location = new System.Drawing.Point(80, 22);
            this.lable_welcome.Name = "lable_welcome";
            this.lable_welcome.Size = new System.Drawing.Size(0, 17);
            this.lable_welcome.TabIndex = 10;
            // 
            // Lotto_649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.lable_welcome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.frm_Lotto649_lblName);
            this.Controls.Add(this.frm_Lotto649);
            this.Controls.Add(this.label1);
            this.Name = "Lotto_649";
            this.Text = "Lotto_649-Ravi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button frm_Lotto649_lblName;
        private System.Windows.Forms.TextBox frm_Lotto649;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_welcome;
    }
}