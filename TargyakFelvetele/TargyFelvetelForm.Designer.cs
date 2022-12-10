namespace TargyakFelvetele
{
    partial class TargyFelvetelForm
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
            this.lbFelvehetoTargyak = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFelvettTargyak = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFelvehetoTargyak
            // 
            this.lbFelvehetoTargyak.FormattingEnabled = true;
            this.lbFelvehetoTargyak.Location = new System.Drawing.Point(22, 51);
            this.lbFelvehetoTargyak.Name = "lbFelvehetoTargyak";
            this.lbFelvehetoTargyak.Size = new System.Drawing.Size(120, 199);
            this.lbFelvehetoTargyak.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felvehető tárgyak:";
            // 
            // lbFelvettTargyak
            // 
            this.lbFelvettTargyak.FormattingEnabled = true;
            this.lbFelvettTargyak.Location = new System.Drawing.Point(218, 51);
            this.lbFelvettTargyak.Name = "lbFelvettTargyak";
            this.lbFelvettTargyak.Size = new System.Drawing.Size(120, 199);
            this.lbFelvettTargyak.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Felvett tárgyak:";
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(22, 256);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(120, 23);
            this.btnFelvesz.TabIndex = 4;
            this.btnFelvesz.Text = ">>";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hallgató neve: aaa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Neptun kódja: AAA";
            // 
            // btnLead
            // 
            this.btnLead.Location = new System.Drawing.Point(218, 256);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(120, 23);
            this.btnLead.TabIndex = 7;
            this.btnLead.Text = "<<";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // TargyFelvetelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 276);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFelvettTargyak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFelvehetoTargyak);
            this.Name = "TargyFelvetelForm";
            this.Text = "Tárgyak felvétele";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TargyFelvetelForm_FormClosing);
            this.Load += new System.EventHandler(this.TargyFelvetelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFelvehetoTargyak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFelvettTargyak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLead;
    }
}

