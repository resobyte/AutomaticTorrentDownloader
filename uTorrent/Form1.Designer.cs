namespace uTorrent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelect_File = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btnSelect_File
            // 
            this.btnSelect_File.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelect_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelect_File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect_File.BorderRadius = 0;
            this.btnSelect_File.ButtonText = "Dosya Seç";
            this.btnSelect_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect_File.DisabledColor = System.Drawing.Color.Gray;
            this.btnSelect_File.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSelect_File.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSelect_File.Iconimage")));
            this.btnSelect_File.Iconimage_right = null;
            this.btnSelect_File.Iconimage_right_Selected = null;
            this.btnSelect_File.Iconimage_Selected = null;
            this.btnSelect_File.IconMarginLeft = 0;
            this.btnSelect_File.IconMarginRight = 0;
            this.btnSelect_File.IconRightVisible = true;
            this.btnSelect_File.IconRightZoom = 0D;
            this.btnSelect_File.IconVisible = true;
            this.btnSelect_File.IconZoom = 90D;
            this.btnSelect_File.IsTab = false;
            this.btnSelect_File.Location = new System.Drawing.Point(16, 16);
            this.btnSelect_File.Name = "btnSelect_File";
            this.btnSelect_File.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSelect_File.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSelect_File.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSelect_File.selected = false;
            this.btnSelect_File.Size = new System.Drawing.Size(136, 32);
            this.btnSelect_File.TabIndex = 0;
            this.btnSelect_File.Text = "Dosya Seç";
            this.btnSelect_File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect_File.Textcolor = System.Drawing.Color.White;
            this.btnSelect_File.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect_File.Click += new System.EventHandler(this.btnSelect_File_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.btnSelect_File);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSelect_File;
    }
}

