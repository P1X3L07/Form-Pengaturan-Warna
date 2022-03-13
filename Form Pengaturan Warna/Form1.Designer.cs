
namespace Form_Pengaturan_Warna
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
            this.TxtBoxInput = new System.Windows.Forms.TextBox();
            this.LblInputData = new System.Windows.Forms.Label();
            this.BtnProses = new System.Windows.Forms.Button();
            this.LblEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxInput
            // 
            this.TxtBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxInput.Location = new System.Drawing.Point(64, 87);
            this.TxtBoxInput.Name = "TxtBoxInput";
            this.TxtBoxInput.Size = new System.Drawing.Size(255, 35);
            this.TxtBoxInput.TabIndex = 0;
            this.TxtBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblInputData
            // 
            this.LblInputData.AutoSize = true;
            this.LblInputData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInputData.Location = new System.Drawing.Point(59, 55);
            this.LblInputData.Name = "LblInputData";
            this.LblInputData.Size = new System.Drawing.Size(132, 29);
            this.LblInputData.TabIndex = 1;
            this.LblInputData.Text = "Input Data: ";
            this.LblInputData.Click += new System.EventHandler(this.LblInputData_Click);
            // 
            // BtnProses
            // 
            this.BtnProses.Location = new System.Drawing.Point(64, 148);
            this.BtnProses.Name = "BtnProses";
            this.BtnProses.Size = new System.Drawing.Size(87, 33);
            this.BtnProses.TabIndex = 2;
            this.BtnProses.Text = "Proses";
            this.BtnProses.UseVisualStyleBackColor = true;
            this.BtnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // LblEmpty
            // 
            this.LblEmpty.AutoSize = true;
            this.LblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpty.Location = new System.Drawing.Point(59, 210);
            this.LblEmpty.Name = "LblEmpty";
            this.LblEmpty.Size = new System.Drawing.Size(111, 29);
            this.LblEmpty.TabIndex = 3;
            this.LblEmpty.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 344);
            this.Controls.Add(this.LblEmpty);
            this.Controls.Add(this.BtnProses);
            this.Controls.Add(this.LblInputData);
            this.Controls.Add(this.TxtBoxInput);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxInput;
        private System.Windows.Forms.Label LblInputData;
        private System.Windows.Forms.Button BtnProses;
        private System.Windows.Forms.Label LblEmpty;
    }
}

