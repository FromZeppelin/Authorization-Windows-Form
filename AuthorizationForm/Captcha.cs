using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationForm
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
        }
        private void Captcha_Load(object sender, EventArgs e)
        {
            Random randomize = new Random();
            int pics = randomize.Next(1, 5);
            int nums = randomize.Next(0, 100000);
            CaptchaLabel.Text = nums.ToString();
            CaptchaLabel.BackColor = Color.Transparent;
            CaptchaLabel.Parent = CaptchaPicture;
            switch (pics)
            {
                case 1:
                    CaptchaPicture.Image = Image.FromFile("CaptchaPictures/1.jpg");
                    CaptchaLabel.ForeColor = Color.Silver;
                    break;
                case 2:
                    CaptchaPicture.Image = Image.FromFile("CaptchaPictures/2.jpg");
                    CaptchaLabel.ForeColor = Color.SteelBlue;
                    break;
                case 3:
                    CaptchaPicture.Image = Image.FromFile("CaptchaPictures/3.jpg");
                    CaptchaLabel.ForeColor = Color.Red;
                    break;
                case 4:
                    CaptchaPicture.Image = Image.FromFile("CaptchaPictures/4.jpg");
                    CaptchaLabel.ForeColor = Color.Gold;
                    break;
                case 5:
                    CaptchaPicture.Image = Image.FromFile("CaptchaPictures/1.jpg");
                    CaptchaLabel.ForeColor = Color.GreenYellow;
                    break;
            }
        }
        private void CheckIn_Click(object sender, EventArgs e)
        {
            if (CaptchaBox.Text == CaptchaLabel.Text)
            {
                Form Authorization = new Authorization();
                Authorization.Show();
                this.Close();
            }
            else
            {
                Captcha_Load(sender, e);
            }
        }
        private void ShowNext_Click(object sender, EventArgs e)
        {
            Captcha_Load(sender, e);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
