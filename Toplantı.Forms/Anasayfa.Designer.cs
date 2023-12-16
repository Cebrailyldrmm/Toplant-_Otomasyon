namespace Toplantı.Forms
{
    partial class Anasayfa
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
            this.lblkullanici = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.btntoplantıs = new System.Windows.Forms.Button();
            this.btnkatil = new System.Windows.Forms.Button();
            this.btntoplantiolustur = new System.Windows.Forms.Button();
            this.texttoplantikod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.BackColor = System.Drawing.Color.Blue;
            this.lblkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.Location = new System.Drawing.Point(12, 31);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(100, 20);
            this.lblkullanici.TabIndex = 14;
            this.lblkullanici.Text = "KULLANICI:";
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(12, 221);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(269, 38);
            this.btngiris.TabIndex = 13;
            this.btngiris.Text = "GİRİŞ EKRANI";
            this.btngiris.UseVisualStyleBackColor = true;
            // 
            // btntoplantıs
            // 
            this.btntoplantıs.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoplantıs.Location = new System.Drawing.Point(16, 153);
            this.btntoplantıs.Name = "btntoplantıs";
            this.btntoplantıs.Size = new System.Drawing.Size(265, 34);
            this.btntoplantıs.TabIndex = 12;
            this.btntoplantıs.Text = "TOPLANTILARIM";
            this.btntoplantıs.UseVisualStyleBackColor = true;
            // 
            // btnkatil
            // 
            this.btnkatil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkatil.Location = new System.Drawing.Point(16, 325);
            this.btnkatil.Name = "btnkatil";
            this.btnkatil.Size = new System.Drawing.Size(271, 59);
            this.btnkatil.TabIndex = 10;
            this.btnkatil.Text = "TOPLANTIYA KATIL";
            this.btnkatil.UseVisualStyleBackColor = true;
            this.btnkatil.Click += new System.EventHandler(this.btnkatil_Click);
            // 
            // btntoplantiolustur
            // 
            this.btntoplantiolustur.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntoplantiolustur.Location = new System.Drawing.Point(12, 66);
            this.btntoplantiolustur.Name = "btntoplantiolustur";
            this.btntoplantiolustur.Size = new System.Drawing.Size(269, 38);
            this.btntoplantiolustur.TabIndex = 9;
            this.btntoplantiolustur.Text = "TOPLANTI OLUŞTUR";
            this.btntoplantiolustur.UseVisualStyleBackColor = true;
            this.btntoplantiolustur.Click += new System.EventHandler(this.btntoplantiolustur_Click);
            // 
            // texttoplantikod
            // 
            this.texttoplantikod.Location = new System.Drawing.Point(157, 284);
            this.texttoplantikod.Name = "texttoplantikod";
            this.texttoplantikod.Size = new System.Drawing.Size(124, 22);
            this.texttoplantikod.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "TOPLANTI KODU:";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(317, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texttoplantikod);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.btntoplantıs);
            this.Controls.Add(this.btnkatil);
            this.Controls.Add(this.btntoplantiolustur);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btntoplantıs;
        private System.Windows.Forms.Button btnkatil;
        private System.Windows.Forms.Button btntoplantiolustur;
        public System.Windows.Forms.TextBox texttoplantikod;
        private System.Windows.Forms.Label label4;
    }
}