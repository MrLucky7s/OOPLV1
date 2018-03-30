namespace Crtanje
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
            this.grBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnPol = new System.Windows.Forms.RadioButton();
            this.rdBtnEll = new System.Windows.Forms.RadioButton();
            this.rdBtnCir = new System.Windows.Forms.RadioButton();
            this.rdBtnRec = new System.Windows.Forms.RadioButton();
            this.rdBtnLn = new System.Windows.Forms.RadioButton();
            this.grBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnRed = new System.Windows.Forms.RadioButton();
            this.rdBtnBlue = new System.Windows.Forms.RadioButton();
            this.rdBtnBlack = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grBox1.SuspendLayout();
            this.grBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBox1
            // 
            this.grBox1.Controls.Add(this.rdBtnPol);
            this.grBox1.Controls.Add(this.rdBtnEll);
            this.grBox1.Controls.Add(this.rdBtnCir);
            this.grBox1.Controls.Add(this.rdBtnRec);
            this.grBox1.Controls.Add(this.rdBtnLn);
            this.grBox1.Location = new System.Drawing.Point(536, 23);
            this.grBox1.Name = "grBox1";
            this.grBox1.Size = new System.Drawing.Size(126, 200);
            this.grBox1.TabIndex = 0;
            this.grBox1.TabStop = false;
            this.grBox1.Text = "Oblici";
            // 
            // rdBtnPol
            // 
            this.rdBtnPol.AutoSize = true;
            this.rdBtnPol.Location = new System.Drawing.Point(6, 161);
            this.rdBtnPol.Name = "rdBtnPol";
            this.rdBtnPol.Size = new System.Drawing.Size(60, 17);
            this.rdBtnPol.TabIndex = 4;
            this.rdBtnPol.TabStop = true;
            this.rdBtnPol.Text = "Poligon";
            this.rdBtnPol.UseVisualStyleBackColor = true;
            this.rdBtnPol.CheckedChanged += new System.EventHandler(this.rdBtnPol_CheckedChanged);
            // 
            // rdBtnEll
            // 
            this.rdBtnEll.AutoSize = true;
            this.rdBtnEll.Location = new System.Drawing.Point(6, 124);
            this.rdBtnEll.Name = "rdBtnEll";
            this.rdBtnEll.Size = new System.Drawing.Size(53, 17);
            this.rdBtnEll.TabIndex = 3;
            this.rdBtnEll.TabStop = true;
            this.rdBtnEll.Text = "Elipsa";
            this.rdBtnEll.UseVisualStyleBackColor = true;
            this.rdBtnEll.CheckedChanged += new System.EventHandler(this.rdBtnEll_CheckedChanged);
            // 
            // rdBtnCir
            // 
            this.rdBtnCir.AutoSize = true;
            this.rdBtnCir.Location = new System.Drawing.Point(6, 91);
            this.rdBtnCir.Name = "rdBtnCir";
            this.rdBtnCir.Size = new System.Drawing.Size(47, 17);
            this.rdBtnCir.TabIndex = 2;
            this.rdBtnCir.TabStop = true;
            this.rdBtnCir.Text = "Krug";
            this.rdBtnCir.UseVisualStyleBackColor = true;
            this.rdBtnCir.CheckedChanged += new System.EventHandler(this.rdBtnCir_ChekedChanged);
            // 
            // rdBtnRec
            // 
            this.rdBtnRec.AutoSize = true;
            this.rdBtnRec.Location = new System.Drawing.Point(6, 54);
            this.rdBtnRec.Name = "rdBtnRec";
            this.rdBtnRec.Size = new System.Drawing.Size(82, 17);
            this.rdBtnRec.TabIndex = 1;
            this.rdBtnRec.TabStop = true;
            this.rdBtnRec.Text = "Pravokutnik";
            this.rdBtnRec.UseVisualStyleBackColor = true;
            this.rdBtnRec.CheckedChanged += new System.EventHandler(this.rdBtnRec_CheckedChanged);
            // 
            // rdBtnLn
            // 
            this.rdBtnLn.AutoSize = true;
            this.rdBtnLn.Location = new System.Drawing.Point(7, 20);
            this.rdBtnLn.Name = "rdBtnLn";
            this.rdBtnLn.Size = new System.Drawing.Size(49, 17);
            this.rdBtnLn.TabIndex = 0;
            this.rdBtnLn.TabStop = true;
            this.rdBtnLn.Text = "Linija";
            this.rdBtnLn.UseVisualStyleBackColor = true;
            this.rdBtnLn.CheckedChanged += new System.EventHandler(this.rdBtnLn_CheckedChange);
            // 
            // grBox2
            // 
            this.grBox2.Controls.Add(this.rdBtnRed);
            this.grBox2.Controls.Add(this.rdBtnBlue);
            this.grBox2.Controls.Add(this.rdBtnBlack);
            this.grBox2.Location = new System.Drawing.Point(536, 302);
            this.grBox2.Name = "grBox2";
            this.grBox2.Size = new System.Drawing.Size(126, 91);
            this.grBox2.TabIndex = 1;
            this.grBox2.TabStop = false;
            this.grBox2.Text = "Boje";
            // 
            // rdBtnRed
            // 
            this.rdBtnRed.AutoSize = true;
            this.rdBtnRed.Location = new System.Drawing.Point(6, 65);
            this.rdBtnRed.Name = "rdBtnRed";
            this.rdBtnRed.Size = new System.Drawing.Size(59, 17);
            this.rdBtnRed.TabIndex = 3;
            this.rdBtnRed.TabStop = true;
            this.rdBtnRed.Text = "Crvena";
            this.rdBtnRed.UseVisualStyleBackColor = true;
            // 
            // rdBtnBlue
            // 
            this.rdBtnBlue.AutoSize = true;
            this.rdBtnBlue.Location = new System.Drawing.Point(6, 42);
            this.rdBtnBlue.Name = "rdBtnBlue";
            this.rdBtnBlue.Size = new System.Drawing.Size(52, 17);
            this.rdBtnBlue.TabIndex = 2;
            this.rdBtnBlue.TabStop = true;
            this.rdBtnBlue.Text = "Plava";
            this.rdBtnBlue.UseVisualStyleBackColor = true;
            // 
            // rdBtnBlack
            // 
            this.rdBtnBlack.AutoSize = true;
            this.rdBtnBlack.Location = new System.Drawing.Point(7, 19);
            this.rdBtnBlack.Name = "rdBtnBlack";
            this.rdBtnBlack.Size = new System.Drawing.Size(47, 17);
            this.rdBtnBlack.TabIndex = 1;
            this.rdBtnBlack.TabStop = true;
            this.rdBtnBlack.Text = "Crna";
            this.rdBtnBlack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 531);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grBox2);
            this.Controls.Add(this.grBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.grBox1.ResumeLayout(false);
            this.grBox1.PerformLayout();
            this.grBox2.ResumeLayout(false);
            this.grBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBox1;
        private System.Windows.Forms.RadioButton rdBtnPol;
        private System.Windows.Forms.RadioButton rdBtnEll;
        private System.Windows.Forms.RadioButton rdBtnCir;
        private System.Windows.Forms.RadioButton rdBtnRec;
        private System.Windows.Forms.RadioButton rdBtnLn;
        private System.Windows.Forms.GroupBox grBox2;
        private System.Windows.Forms.RadioButton rdBtnRed;
        private System.Windows.Forms.RadioButton rdBtnBlue;
        private System.Windows.Forms.RadioButton rdBtnBlack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

