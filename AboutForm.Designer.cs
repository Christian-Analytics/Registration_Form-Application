namespace Castillo_4
{
    partial class AboutForm
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
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Button();
            this.aboutFilmPictureBox = new System.Windows.Forms.PictureBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aboutFilmPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(338, 111);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 36);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.toolTip1.SetToolTip(this.closeButton, "Returns to the Registration Form.");
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // aboutFilmPictureBox
            // 
            this.aboutFilmPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.aboutFilmPictureBox.Image = global::Castillo_4.Properties.Resources.about_film_picture;
            this.aboutFilmPictureBox.Location = new System.Drawing.Point(12, 12);
            this.aboutFilmPictureBox.Name = "aboutFilmPictureBox";
            this.aboutFilmPictureBox.Size = new System.Drawing.Size(207, 119);
            this.aboutFilmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutFilmPictureBox.TabIndex = 1;
            this.aboutFilmPictureBox.TabStop = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copyrightLabel.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(225, 12);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(375, 92);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright© 2023 by Christian Castillo";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 155);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.aboutFilmPictureBox);
            this.Controls.Add(this.closeButton);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.aboutFilmPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox aboutFilmPictureBox;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}