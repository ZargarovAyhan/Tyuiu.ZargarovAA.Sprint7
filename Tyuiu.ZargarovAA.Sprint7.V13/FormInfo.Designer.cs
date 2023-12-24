
namespace Tyuiu.ZargarovAA.Sprint7.V13
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.textBoxBDInfo_ZAA = new System.Windows.Forms.TextBox();
            this.buttonOKInfo_ZAA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonInfo = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBDInfo_ZAA
            // 
            this.textBoxBDInfo_ZAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.textBoxBDInfo_ZAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBDInfo_ZAA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBDInfo_ZAA.Location = new System.Drawing.Point(12, 58);
            this.textBoxBDInfo_ZAA.Multiline = true;
            this.textBoxBDInfo_ZAA.Name = "textBoxBDInfo_ZAA";
            this.textBoxBDInfo_ZAA.ReadOnly = true;
            this.textBoxBDInfo_ZAA.Size = new System.Drawing.Size(893, 371);
            this.textBoxBDInfo_ZAA.TabIndex = 0;
            this.textBoxBDInfo_ZAA.Text = resources.GetString("textBoxBDInfo_ZAA.Text");
            this.textBoxBDInfo_ZAA.TextChanged += new System.EventHandler(this.textBoxBDInfo_ZAA_TextChanged);
            // 
            // buttonOKInfo_ZAA
            // 
            this.buttonOKInfo_ZAA.Location = new System.Drawing.Point(809, 425);
            this.buttonOKInfo_ZAA.Name = "buttonOKInfo_ZAA";
            this.buttonOKInfo_ZAA.Size = new System.Drawing.Size(96, 31);
            this.buttonOKInfo_ZAA.TabIndex = 2;
            this.buttonOKInfo_ZAA.Text = "OK";
            this.buttonOKInfo_ZAA.UseVisualStyleBackColor = true;
            this.buttonOKInfo_ZAA.Click += new System.EventHandler(this.buttonOKInfo_ZAA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.iconButtonInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 52);
            this.panel1.TabIndex = 3;
            // 
            // iconButtonInfo
            // 
            this.iconButtonInfo.BackgroundImage = global::Tyuiu.ZargarovAA.Sprint7.V13.Properties.Resources.closefi1;
            this.iconButtonInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonInfo.IconColor = System.Drawing.Color.Black;
            this.iconButtonInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfo.Location = new System.Drawing.Point(882, 12);
            this.iconButtonInfo.Name = "iconButtonInfo";
            this.iconButtonInfo.Size = new System.Drawing.Size(23, 24);
            this.iconButtonInfo.TabIndex = 0;
            this.iconButtonInfo.Text = "\r\n";
            this.iconButtonInfo.UseVisualStyleBackColor = true;
            this.iconButtonInfo.Click += new System.EventHandler(this.iconButtonInfo_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(122)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(932, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOKInfo_ZAA);
            this.Controls.Add(this.textBoxBDInfo_ZAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBDInfo_ZAA;
        private System.Windows.Forms.Button buttonOKInfo_ZAA;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonInfo;
    }
}