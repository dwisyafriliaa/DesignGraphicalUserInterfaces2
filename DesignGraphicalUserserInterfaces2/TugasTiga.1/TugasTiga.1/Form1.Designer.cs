
namespace TugasTiga._1
{
    partial class frmTugas
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
            this.lblNIM = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnKosong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNIM
            // 
            this.lblNIM.AutoSize = true;
            this.lblNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIM.Location = new System.Drawing.Point(24, 41);
            this.lblNIM.Name = "lblNIM";
            this.lblNIM.Size = new System.Drawing.Size(122, 15);
            this.lblNIM.TabIndex = 0;
            this.lblNIM.Text = "NIM       :  20.11.3665";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(24, 77);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(143, 15);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama   :  DWI SYAFRILIA";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelas.Location = new System.Drawing.Point(24, 115);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(103, 15);
            this.lblKelas.TabIndex = 0;
            this.lblKelas.Text = "Kelas    :  20 IF 06";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(83, 189);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(84, 23);
            this.btnTampil.TabIndex = 1;
            this.btnTampil.Text = "Tampilkan";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnKosong
            // 
            this.btnKosong.Location = new System.Drawing.Point(175, 189);
            this.btnKosong.Name = "btnKosong";
            this.btnKosong.Size = new System.Drawing.Size(84, 23);
            this.btnKosong.TabIndex = 2;
            this.btnKosong.Text = "Kosongkan";
            this.btnKosong.UseVisualStyleBackColor = true;
            this.btnKosong.Click += new System.EventHandler(this.btnKosong_Click);
            // 
            // frmTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 254);
            this.Controls.Add(this.btnKosong);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNIM);
            this.Name = "frmTugas";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIM;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnKosong;
    }
}

