namespace TugasTiga1
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
            this.labelNim = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelKelas = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNim
            // 
            this.labelNim.AutoSize = true;
            this.labelNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNim.Location = new System.Drawing.Point(63, 32);
            this.labelNim.Name = "labelNim";
            this.labelNim.Size = new System.Drawing.Size(102, 16);
            this.labelNim.TabIndex = 0;
            this.labelNim.Text = "NIM : 22.11.4849";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(63, 75);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(190, 16);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama : Linggar Elang Pratama";
            // 
            // labelKelas
            // 
            this.labelKelas.AutoSize = true;
            this.labelKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKelas.Location = new System.Drawing.Point(63, 114);
            this.labelKelas.Name = "labelKelas";
            this.labelKelas.Size = new System.Drawing.Size(125, 16);
            this.labelKelas.TabIndex = 2;
            this.labelKelas.Text = "Kelas : Informatika 5";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(80, 179);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(85, 25);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Tampilkan";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(185, 179);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(85, 25);
            this.hideButton.TabIndex = 4;
            this.hideButton.Text = "Kosongkan";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 242);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.labelKelas);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelNim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNim;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelKelas;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button hideButton;
    }
}

