namespace AuthorizationForm
{
    partial class Captcha
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
            this.CaptchaBox = new System.Windows.Forms.TextBox();
            this.CheckIn = new System.Windows.Forms.Button();
            this.ShowNext = new System.Windows.Forms.Button();
            this.CaptchaPicture = new System.Windows.Forms.PictureBox();
            this.CaptchaLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchaBox
            // 
            this.CaptchaBox.Location = new System.Drawing.Point(203, 175);
            this.CaptchaBox.Multiline = true;
            this.CaptchaBox.Name = "CaptchaBox";
            this.CaptchaBox.Size = new System.Drawing.Size(160, 23);
            this.CaptchaBox.TabIndex = 0;
            // 
            // CheckIn
            // 
            this.CheckIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckIn.Location = new System.Drawing.Point(21, 204);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(40, 35);
            this.CheckIn.TabIndex = 1;
            this.CheckIn.Text = "OK";
            this.CheckIn.UseVisualStyleBackColor = true;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // ShowNext
            // 
            this.ShowNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowNext.Location = new System.Drawing.Point(67, 204);
            this.ShowNext.Name = "ShowNext";
            this.ShowNext.Size = new System.Drawing.Size(90, 35);
            this.ShowNext.TabIndex = 2;
            this.ShowNext.Text = "Обновить";
            this.ShowNext.UseVisualStyleBackColor = true;
            this.ShowNext.Click += new System.EventHandler(this.ShowNext_Click);
            // 
            // CaptchaPicture
            // 
            this.CaptchaPicture.BackColor = System.Drawing.Color.Transparent;
            this.CaptchaPicture.Location = new System.Drawing.Point(21, 12);
            this.CaptchaPicture.Name = "CaptchaPicture";
            this.CaptchaPicture.Size = new System.Drawing.Size(342, 146);
            this.CaptchaPicture.TabIndex = 4;
            this.CaptchaPicture.TabStop = false;
            // 
            // CaptchaLabel
            // 
            this.CaptchaLabel.BackColor = System.Drawing.Color.Transparent;
            this.CaptchaLabel.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CaptchaLabel.ForeColor = System.Drawing.Color.Transparent;
            this.CaptchaLabel.Location = new System.Drawing.Point(88, 46);
            this.CaptchaLabel.Name = "CaptchaLabel";
            this.CaptchaLabel.Size = new System.Drawing.Size(152, 66);
            this.CaptchaLabel.TabIndex = 5;
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Close.Location = new System.Drawing.Point(288, 204);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 35);
            this.Close.TabIndex = 6;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.Location = new System.Drawing.Point(21, 175);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(184, 20);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Введите цифры с экрана ";
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CaptchaLabel);
            this.Controls.Add(this.CaptchaPicture);
            this.Controls.Add(this.ShowNext);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.CaptchaBox);
            this.Name = "Captcha";
            this.Text = "CAPTCHA";
            this.Load += new System.EventHandler(this.Captcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CaptchaBox;
        private System.Windows.Forms.Button CheckIn;
        private System.Windows.Forms.Button ShowNext;
        private System.Windows.Forms.PictureBox CaptchaPicture;
        private System.Windows.Forms.Label CaptchaLabel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label ValueLabel;
    }
}