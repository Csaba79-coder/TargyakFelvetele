namespace TargyakFelvetele
{
    partial class HallgatoTorleseForm
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
            this.buttonDeleteByNeptun = new System.Windows.Forms.Button();
            this.textBoxNeptun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListHallgatok = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteFromList = new System.Windows.Forms.Button();
            this.buttonKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeleteByNeptun
            // 
            this.buttonDeleteByNeptun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDeleteByNeptun.Location = new System.Drawing.Point(260, 36);
            this.buttonDeleteByNeptun.Name = "buttonDeleteByNeptun";
            this.buttonDeleteByNeptun.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteByNeptun.TabIndex = 0;
            this.buttonDeleteByNeptun.Text = "Törlés";
            this.buttonDeleteByNeptun.UseVisualStyleBackColor = true;
            this.buttonDeleteByNeptun.Click += new System.EventHandler(this.buttonDeleteByNeptun_Click);
            // 
            // textBoxNeptun
            // 
            this.textBoxNeptun.Location = new System.Drawing.Point(12, 37);
            this.textBoxNeptun.Name = "textBoxNeptun";
            this.textBoxNeptun.Size = new System.Drawing.Size(148, 22);
            this.textBoxNeptun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kérem adja meg a neptun kódot";
            // 
            // buttonListHallgatok
            // 
            this.buttonListHallgatok.Location = new System.Drawing.Point(260, 93);
            this.buttonListHallgatok.Name = "buttonListHallgatok";
            this.buttonListHallgatok.Size = new System.Drawing.Size(75, 23);
            this.buttonListHallgatok.TabIndex = 3;
            this.buttonListHallgatok.Text = "Hallgatók listája";
            this.buttonListHallgatok.UseVisualStyleBackColor = true;
            this.buttonListHallgatok.Click += new System.EventHandler(this.buttonListHallgatok_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 372);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hallgatók neve és neptun kódja";
            // 
            // buttonDeleteFromList
            // 
            this.buttonDeleteFromList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDeleteFromList.Location = new System.Drawing.Point(260, 148);
            this.buttonDeleteFromList.Name = "buttonDeleteFromList";
            this.buttonDeleteFromList.Size = new System.Drawing.Size(226, 23);
            this.buttonDeleteFromList.TabIndex = 6;
            this.buttonDeleteFromList.Text = "Kiválasztott elem törlése";
            this.buttonDeleteFromList.UseVisualStyleBackColor = true;
            this.buttonDeleteFromList.Click += new System.EventHandler(this.buttonDeleteFromList_Click);
            // 
            // buttonKilepes
            // 
            this.buttonKilepes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonKilepes.Location = new System.Drawing.Point(260, 442);
            this.buttonKilepes.Name = "buttonKilepes";
            this.buttonKilepes.Size = new System.Drawing.Size(75, 23);
            this.buttonKilepes.TabIndex = 7;
            this.buttonKilepes.Text = "Mégsem";
            this.buttonKilepes.UseVisualStyleBackColor = true;
            this.buttonKilepes.Click += new System.EventHandler(this.buttonKilepes_Click);
            // 
            // HallgatoTorleseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 515);
            this.Controls.Add(this.buttonKilepes);
            this.Controls.Add(this.buttonDeleteFromList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonListHallgatok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNeptun);
            this.Controls.Add(this.buttonDeleteByNeptun);
            this.Name = "HallgatoTorleseForm";
            this.Text = "HallgatoTorleseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteByNeptun;
        private System.Windows.Forms.TextBox textBoxNeptun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonListHallgatok;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteFromList;
        private System.Windows.Forms.Button buttonKilepes;
    }
}