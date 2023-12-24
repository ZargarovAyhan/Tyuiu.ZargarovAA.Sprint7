
namespace Tyuiu.ZargarovAA.Sprint7.V13
{
    partial class FormAbout
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
            this.textBoxAbout_ZAA = new System.Windows.Forms.TextBox();
            this.buttonOkAbout_ZAA = new System.Windows.Forms.Button();
            this.pictureBoxMe_ZAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_ZAA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout_ZAA
            // 
            this.textBoxAbout_ZAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_ZAA.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAbout_ZAA.Location = new System.Drawing.Point(157, 12);
            this.textBoxAbout_ZAA.Multiline = true;
            this.textBoxAbout_ZAA.Name = "textBoxAbout_ZAA";
            this.textBoxAbout_ZAA.ReadOnly = true;
            this.textBoxAbout_ZAA.Size = new System.Drawing.Size(499, 221);
            this.textBoxAbout_ZAA.TabIndex = 1;
            this.textBoxAbout_ZAA.Text = "Выполнил проект: Заргаров Айхан Ахатович\r\nСтудент Института Тиу Вшцт - группа ИИП" +
    "Б-23-2.\r\n\r\nПроект 7 спринт, 13 вариант\r\n";
            this.textBoxAbout_ZAA.TextChanged += new System.EventHandler(this.textBoxAbout_ZAA_TextChanged);
            // 
            // buttonOkAbout_ZAA
            // 
            this.buttonOkAbout_ZAA.Location = new System.Drawing.Point(610, 202);
            this.buttonOkAbout_ZAA.Name = "buttonOkAbout_ZAA";
            this.buttonOkAbout_ZAA.Size = new System.Drawing.Size(96, 31);
            this.buttonOkAbout_ZAA.TabIndex = 2;
            this.buttonOkAbout_ZAA.Text = "OK";
            this.buttonOkAbout_ZAA.UseVisualStyleBackColor = true;
            this.buttonOkAbout_ZAA.Click += new System.EventHandler(this.buttonOkAbout_ZAA_Click);
            // 
            // pictureBoxMe_ZAA
            // 
            this.pictureBoxMe_ZAA.BackgroundImage = global::Tyuiu.ZargarovAA.Sprint7.V13.Properties.Resources._8cfa37f1_fc3e_4402_9600_52fee19cac8a;
            this.pictureBoxMe_ZAA.Image = global::Tyuiu.ZargarovAA.Sprint7.V13.Properties.Resources.nefoooooor;
            this.pictureBoxMe_ZAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMe_ZAA.Name = "pictureBoxMe_ZAA";
            this.pictureBoxMe_ZAA.Size = new System.Drawing.Size(120, 146);
            this.pictureBoxMe_ZAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMe_ZAA.TabIndex = 0;
            this.pictureBoxMe_ZAA.TabStop = false;
            this.pictureBoxMe_ZAA.Click += new System.EventHandler(this.pictureBoxMe_ZAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 258);
            this.Controls.Add(this.buttonOkAbout_ZAA);
            this.Controls.Add(this.textBoxAbout_ZAA);
            this.Controls.Add(this.pictureBoxMe_ZAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe_ZAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMe_ZAA;
        private System.Windows.Forms.TextBox textBoxAbout_ZAA;
        private System.Windows.Forms.Button buttonOkAbout_ZAA;
    }
}