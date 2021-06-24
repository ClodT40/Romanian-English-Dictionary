
namespace PROIECT_PAW
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.cuvCautat = new System.Windows.Forms.TextBox();
            this.TBtraducere = new System.Windows.Forms.TextBox();
            this.TBexplicatii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EtoR = new System.Windows.Forms.RadioButton();
            this.RtoE = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.button1.Location = new System.Drawing.Point(222, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuvCautat
            // 
            this.cuvCautat.Location = new System.Drawing.Point(111, 66);
            this.cuvCautat.Name = "cuvCautat";
            this.cuvCautat.Size = new System.Drawing.Size(144, 24);
            this.cuvCautat.TabIndex = 1;
            // 
            // TBtraducere
            // 
            this.TBtraducere.Location = new System.Drawing.Point(181, 103);
            this.TBtraducere.Name = "TBtraducere";
            this.TBtraducere.Size = new System.Drawing.Size(144, 24);
            this.TBtraducere.TabIndex = 2;
            // 
            // TBexplicatii
            // 
            this.TBexplicatii.Location = new System.Drawing.Point(150, 133);
            this.TBexplicatii.Multiline = true;
            this.TBexplicatii.Name = "TBexplicatii";
            this.TBexplicatii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBexplicatii.Size = new System.Drawing.Size(403, 150);
            this.TBexplicatii.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cuvant cautat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modificare cuvant tradus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modificare explicatie:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.EtoR);
            this.groupBox1.Controls.Add(this.RtoE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBexplicatii);
            this.groupBox1.Controls.Add(this.TBtraducere);
            this.groupBox1.Controls.Add(this.cuvCautat);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 289);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificare cuvant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Selectati limba pentru care doriti sa modificati cuvantul:";
            // 
            // EtoR
            // 
            this.EtoR.AutoSize = true;
            this.EtoR.Location = new System.Drawing.Point(370, 60);
            this.EtoR.Name = "EtoR";
            this.EtoR.Size = new System.Drawing.Size(138, 23);
            this.EtoR.TabIndex = 8;
            this.EtoR.TabStop = true;
            this.EtoR.Text = "Engleza->Romana";
            this.EtoR.UseVisualStyleBackColor = true;
            // 
            // RtoE
            // 
            this.RtoE.AutoSize = true;
            this.RtoE.Location = new System.Drawing.Point(370, 31);
            this.RtoE.Name = "RtoE";
            this.RtoE.Size = new System.Drawing.Size(138, 23);
            this.RtoE.TabIndex = 7;
            this.RtoE.TabStop = true;
            this.RtoE.Text = "Romana->Engleza";
            this.RtoE.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(557, -8);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 51);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificare";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cuvCautat;
        private System.Windows.Forms.TextBox TBtraducere;
        private System.Windows.Forms.TextBox TBexplicatii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton EtoR;
        private System.Windows.Forms.RadioButton RtoE;
        private System.Windows.Forms.Button button2;
    }
}