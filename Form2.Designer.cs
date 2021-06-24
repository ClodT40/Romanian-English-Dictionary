
namespace PROIECT_PAW
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EtoR = new System.Windows.Forms.RadioButton();
            this.RtoE = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cuvCautat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBtraducere = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TBexplicatii = new System.Windows.Forms.TextBox();
            this.LB_Explicatii = new System.Windows.Forms.Label();
            this.LB_cuvEng = new System.Windows.Forms.Label();
            this.Lb_cuvRom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.EtoR);
            this.groupBox2.Controls.Add(this.RtoE);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.cuvCautat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TBtraducere);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TBexplicatii);
            this.groupBox2.Controls.Add(this.LB_Explicatii);
            this.groupBox2.Controls.Add(this.LB_cuvEng);
            this.groupBox2.Controls.Add(this.Lb_cuvRom);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 368);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traducere cuvant:";
            // 
            // EtoR
            // 
            this.EtoR.AutoSize = true;
            this.EtoR.Location = new System.Drawing.Point(319, 31);
            this.EtoR.Name = "EtoR";
            this.EtoR.Size = new System.Drawing.Size(138, 23);
            this.EtoR.TabIndex = 20;
            this.EtoR.TabStop = true;
            this.EtoR.Text = "Engleza->Romana";
            this.EtoR.UseVisualStyleBackColor = true;
            // 
            // RtoE
            // 
            this.RtoE.AutoSize = true;
            this.RtoE.Location = new System.Drawing.Point(175, 31);
            this.RtoE.Name = "RtoE";
            this.RtoE.Size = new System.Drawing.Size(138, 23);
            this.RtoE.TabIndex = 19;
            this.RtoE.TabStop = true;
            this.RtoE.Text = "Romana->Engleza";
            this.RtoE.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bifati tipul de traducere:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(277, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 70);
            this.button3.TabIndex = 22;
            this.button3.Text = "Curata casete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cuvCautat
            // 
            this.cuvCautat.Location = new System.Drawing.Point(104, 91);
            this.cuvCautat.Name = "cuvCautat";
            this.cuvCautat.Size = new System.Drawing.Size(129, 24);
            this.cuvCautat.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Traducere:";
            // 
            // TBtraducere
            // 
            this.TBtraducere.Enabled = false;
            this.TBtraducere.Location = new System.Drawing.Point(104, 160);
            this.TBtraducere.Name = "TBtraducere";
            this.TBtraducere.Size = new System.Drawing.Size(128, 24);
            this.TBtraducere.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(160)))), ((int)(((byte)(233)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(277, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 66);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cauta cuvant";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBexplicatii
            // 
            this.TBexplicatii.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBexplicatii.Enabled = false;
            this.TBexplicatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBexplicatii.Location = new System.Drawing.Point(95, 225);
            this.TBexplicatii.Multiline = true;
            this.TBexplicatii.Name = "TBexplicatii";
            this.TBexplicatii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBexplicatii.Size = new System.Drawing.Size(398, 129);
            this.TBexplicatii.TabIndex = 5;
            // 
            // LB_Explicatii
            // 
            this.LB_Explicatii.AutoSize = true;
            this.LB_Explicatii.Location = new System.Drawing.Point(25, 228);
            this.LB_Explicatii.Name = "LB_Explicatii";
            this.LB_Explicatii.Size = new System.Drawing.Size(71, 19);
            this.LB_Explicatii.TabIndex = 4;
            this.LB_Explicatii.Text = "Explicatii:";
            // 
            // LB_cuvEng
            // 
            this.LB_cuvEng.AutoSize = true;
            this.LB_cuvEng.Location = new System.Drawing.Point(254, 89);
            this.LB_cuvEng.Name = "LB_cuvEng";
            this.LB_cuvEng.Size = new System.Drawing.Size(0, 19);
            this.LB_cuvEng.TabIndex = 1;
            // 
            // Lb_cuvRom
            // 
            this.Lb_cuvRom.AutoSize = true;
            this.Lb_cuvRom.Location = new System.Drawing.Point(6, 91);
            this.Lb_cuvRom.Name = "Lb_cuvRom";
            this.Lb_cuvRom.Size = new System.Drawing.Size(99, 19);
            this.Lb_cuvRom.TabIndex = 0;
            this.Lb_cuvRom.Text = "Cuvant cautat:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(530, -5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 51);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(622, 392);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traducere";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBtraducere;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBexplicatii;
        private System.Windows.Forms.Label LB_Explicatii;
        private System.Windows.Forms.Label LB_cuvEng;
        private System.Windows.Forms.Label Lb_cuvRom;
        private System.Windows.Forms.TextBox cuvCautat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton EtoR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RtoE;
        private System.Windows.Forms.Button button1;
    }
}