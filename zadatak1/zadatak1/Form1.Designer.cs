namespace zadatak1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPopisKnjiga = new System.Windows.Forms.ListBox();
            this.lbIznajmljene = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis knjiga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznajmljene";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iznajmi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPopisKnjiga
            // 
            this.lbPopisKnjiga.FormattingEnabled = true;
            this.lbPopisKnjiga.Location = new System.Drawing.Point(117, 164);
            this.lbPopisKnjiga.Name = "lbPopisKnjiga";
            this.lbPopisKnjiga.Size = new System.Drawing.Size(120, 43);
            this.lbPopisKnjiga.TabIndex = 5;
            // 
            // lbIznajmljene
            // 
            this.lbIznajmljene.FormattingEnabled = true;
            this.lbIznajmljene.Location = new System.Drawing.Point(541, 151);
            this.lbIznajmljene.Name = "lbIznajmljene";
            this.lbIznajmljene.Size = new System.Drawing.Size(118, 56);
            this.lbIznajmljene.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Vrati";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbIznajmljene);
            this.Controls.Add(this.lbPopisKnjiga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbPopisKnjiga;
        private System.Windows.Forms.ListBox lbIznajmljene;
        private System.Windows.Forms.Button button2;
    }
}

