namespace TargyakFelvetele
{
    partial class HallgatoFelvitelForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNeptun = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonFelvitel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(8, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxNeptun
            // 
            this.textBoxNeptun.Location = new System.Drawing.Point(8, 105);
            this.textBoxNeptun.Name = "textBoxNeptun";
            this.textBoxNeptun.Size = new System.Drawing.Size(100, 22);
            this.textBoxNeptun.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(8, 187);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // buttonFelvitel
            // 
            this.buttonFelvitel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonFelvitel.Location = new System.Drawing.Point(146, 94);
            this.buttonFelvitel.Name = "buttonFelvitel";
            this.buttonFelvitel.Size = new System.Drawing.Size(99, 45);
            this.buttonFelvitel.TabIndex = 3;
            this.buttonFelvitel.Text = "Felvitel";
            this.buttonFelvitel.UseVisualStyleBackColor = true;
            this.buttonFelvitel.Click += new System.EventHandler(this.buttonFelvitel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Neptun kód";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jelszó";
            // 
            // HallgatoFelvitelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 245);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFelvitel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNeptun);
            this.Controls.Add(this.textBoxName);
            this.Name = "HallgatoFelvitelForm";
            this.Text = "HallgatoFelvitelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNeptun;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonFelvitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}