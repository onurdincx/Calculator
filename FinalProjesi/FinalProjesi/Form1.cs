using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectTab("Register"); //baslangicta register tabtan basla
            helper_methods.runningWindow = this;
            Calculator.Enabled = false; //giris yapmadan hesap makinesine erisemezsin
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int one = rand.Next(0, 255);
            int two = rand.Next(0, 255);
            int three = rand.Next(0, 255);
            int four = rand.Next(0, 255);

            RegisterLabelRGB.ForeColor = Color.FromArgb(one, two, three, four);

        }

        private void Register_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password    ")
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        double sayi, sayi_v2, sonuc;

        //degisken:
        string islem;

        private void sayi1_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "1";
            }
            else
            {
                hesaplama.Text += "1";
            }
        }

        private void sayi2_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "2";
            }
            else
            {
                hesaplama.Text += "2";
            }
        }

        private void sayi3_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "3";
            }
            else
            {
                hesaplama.Text += "3";
            }
        }

        private void sayi4_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "4";
            }
            else
            {
                hesaplama.Text += "4";
            }
        }

        private void sayi5_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "5";
            }
            else
            {
                hesaplama.Text += "5";
            }
        }

        private void sayi6_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "6";
            }
            else
            {
                hesaplama.Text += "6";
            }
        }

        private void sayi7_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "7";
            }
            else
            {
                hesaplama.Text += "7";
            }
        }

        private void sayi8_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "8";
            }
            else
            {
                hesaplama.Text += "8";
            }
        }

        private void sayi9_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "9";
            }
            else
            {
                hesaplama.Text += "9";
            }
        }

        private void sayi0_Click(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                MessageBox.Show("The number cannot start with 0 (zero)");
            }
            else
            {
                hesaplama.Text += "0";
            }

        }
        //fonksiyon:
        void SayiYaz()
        {
            if (hesaplama.Text != "")//yani bos degilse (! degilse anlamina geliyor)
            {
                sayi = Convert.ToDouble(hesaplama.Text);
                analiz.Text = sayi.ToString() + islem.ToString();
                hesaplama.Text = "";
            }
            else analiz.Text = "Error! = Number cannot take a null value.";

        }

        void SayiYaz_v2() //islemlerde
        {
            analiz.Text = sayi.ToString() + islem.ToString() + sayi_v2.ToString() + "=" + sonuc.ToString();
            hesaplama.Text = "";
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            islem = "+";
            SayiYaz();

        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            islem = "-";
            SayiYaz();
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            islem = "x";
            SayiYaz();
        }

        private void ShowHistory_Click(object sender, EventArgs e)
        {
            if (ShowHistory.Text == "SHOW HISTORY")
            {
                groupBox1.Visible = true;
                ShowHistory.Text = "HIDE HISTORY";
            }
            else
            {
                groupBox1.Visible = false;
                ShowHistory.Text = "SHOW HISTORY";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            hesaplama.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Successful!");
        }

        private void SayiYaz_Click(object sender, EventArgs e)
        {

        }

        private void sayi1_Click_1(object sender, EventArgs e)
        {

            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "1";
            }
            else
            {
                hesaplama.Text += "1";
            }

        }

        private void sayi2_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "2";
            }
            else
            {
                hesaplama.Text += "2";
            }
        }

        private void sayi3_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "3";
            }
            else
            {
                hesaplama.Text += "3";
            }
        }

        private void sayi4_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "4";
            }
            else
            {
                hesaplama.Text += "4";
            }
        }

        private void sayi5_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "5";
            }
            else
            {
                hesaplama.Text += "5";
            }
        }

        private void sayi6_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "6";
            }
            else
            {
                hesaplama.Text += "6";
            }
        }

        private void sayi7_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "7";
            }
            else
            {
                hesaplama.Text += "7";
            }
        }

        private void sayi8_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "8";
            }
            else
            {
                hesaplama.Text += "8";
            }
        }

        private void sayi9_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                hesaplama.Text = "9";
            }
            else
            {
                hesaplama.Text += "9";
            }
        }

        private void sayi0_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text == "0")
            {
                MessageBox.Show("The number cannot start with 0 (zero)");
            }
            else
            {
                hesaplama.Text += "0";
            }
        }

        private void toplama_Click_1(object sender, EventArgs e)
        {

            islem = "+";
            SayiYaz();


        }

        private void cikarma_Click_1(object sender, EventArgs e)
        {
            islem = "-";
            SayiYaz();
        }

        private void carpma_Click_1(object sender, EventArgs e)
        {
            islem = "x";
            SayiYaz();
        }

        private void bolme_Click_1(object sender, EventArgs e)
        {
            islem = "÷";
            SayiYaz();
        }

        private void enter_Click_1(object sender, EventArgs e)
        {
            if (hesaplama.Text != "") sayi_v2 = Convert.ToDouble(hesaplama.Text);
            else analiz.Text = "You didn't enter number...";
            switch (islem)
            {
                case "+":
                    sonuc = sayi + sayi_v2;
                    SayiYaz_v2();
                    break;

                case "-":
                    sonuc = sayi - sayi_v2;
                    SayiYaz_v2();
                    break;

                case "x":
                    sonuc = sayi * sayi_v2;
                    SayiYaz_v2();
                    break;

                case "÷":
                    sonuc = sayi / sayi_v2;
                    SayiYaz_v2();
                    break;
            }
            listBox1.Items.Add(analiz.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesaplama.Clear();
            analiz.Text = "";
            MessageBox.Show("Everything is Cleared.");
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Username")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Username";
                textBox6.ForeColor = Color.Red;
            }
        }

        //password char kaldirmak:
        char? none = null; //soru isareti atmazsan null atayamazsin
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password    ";
                textBox1.ForeColor = Color.Red;
                textBox1.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password    ")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Username")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Username";
                textBox7.ForeColor = Color.Red;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password    ")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password    ";
                textBox2.ForeColor = Color.Red;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            progressBar1.Value = textBox1.TextLength;
            //uzunluk 12
            textBox1.MaxLength = 12;
            string yazi = textBox1.Text;
            yazi = yazi.Replace("ü", "u"); //yazi= yazi.Replace("eski değer","yeni değer") anlamına gelir.Yani yazi değişkenindeki eski değer ile yeni değiştirip tekrardan yazi değişkenime yeni değerimi atıyorum
            yazi = yazi.Replace("ı", "i");
            yazi = yazi.Replace("ö", "o");
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("ş", "s");
            yazi = yazi.Replace("ğ", "g");
            yazi = yazi.Replace("ç", "c");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("İ", "I");
            yazi = yazi.Replace("Ö", "O");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("Ş", "S");
            yazi = yazi.Replace("Ğ", "G");
            yazi = yazi.Replace("Ç", "C");

            textBox1.Text = yazi;

            //en basa atma sorunu:
            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //uzunluk 12
            textBox6.MaxLength = 12;
            string yazi = textBox6.Text;
            yazi = yazi.Replace("ü", "u"); //yazi= yazi.Replace("eski değer","yeni değer") anlamına gelir.Yani yazi değişkenindeki eski değer ile yeni değiştirip tekrardan yazi değişkenime yeni değerimi atıyorum
            yazi = yazi.Replace("ı", "i");
            yazi = yazi.Replace("ö", "o");
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("ş", "s");
            yazi = yazi.Replace("ğ", "g");
            yazi = yazi.Replace("ç", "c");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("İ", "I");
            yazi = yazi.Replace("Ö", "O");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("Ş", "S");
            yazi = yazi.Replace("Ğ", "G");
            yazi = yazi.Replace("Ç", "C");

            textBox6.Text = yazi;

            //en basa atma sorunu:
            textBox6.SelectionStart = textBox6.Text.Length;


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //IsLetterorDigit set allow only digit/number or letter
            //IsControl set allow control key backspace,delete,etc..
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //IsLetterorDigit set allow only digit/number or letter
                //IsControl set allow control key backspace,delete,etc..
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //uzunluk 12
            textBox7.MaxLength = 12;
            string yazi = textBox7.Text;
            yazi = yazi.Replace("ü", "u"); //yazi= yazi.Replace("eski değer","yeni değer") anlamına gelir.Yani yazi değişkenindeki eski değer ile yeni değiştirip tekrardan yazi değişkenime yeni değerimi atıyorum
            yazi = yazi.Replace("ı", "i");
            yazi = yazi.Replace("ö", "o");
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("ş", "s");
            yazi = yazi.Replace("ğ", "g");
            yazi = yazi.Replace("ç", "c");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("İ", "I");
            yazi = yazi.Replace("Ö", "O");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("Ş", "S");
            yazi = yazi.Replace("Ğ", "G");
            yazi = yazi.Replace("Ç", "C");

            textBox7.Text = yazi;

            //en basa atma sorunu:
            textBox7.SelectionStart = textBox7.Text.Length;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //uzunluk 12
            textBox2.MaxLength = 12;
            string yazi = textBox2.Text;
            yazi = yazi.Replace("ü", "u"); //yazi= yazi.Replace("eski değer","yeni değer") anlamına gelir.Yani yazi değişkenindeki eski değer ile yeni değiştirip tekrardan yazi değişkenime yeni değerimi atıyorum
            yazi = yazi.Replace("ı", "i");
            yazi = yazi.Replace("ö", "o");
            yazi = yazi.Replace("ü", "u");
            yazi = yazi.Replace("ş", "s");
            yazi = yazi.Replace("ğ", "g");
            yazi = yazi.Replace("ç", "c");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("İ", "I");
            yazi = yazi.Replace("Ö", "O");
            yazi = yazi.Replace("Ü", "U");
            yazi = yazi.Replace("Ş", "S");
            yazi = yazi.Replace("Ğ", "G");
            yazi = yazi.Replace("Ç", "C");

            textBox2.Text = yazi;

            //en basa atma sorunu:
            textBox2.SelectionStart = textBox2.Text.Length;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab("Login"); //yonlendirme
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Login"); //yonlendirme
        }


        //register kisim

       


        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> registerResult = MainFunctions.tryToRegister(this);

            if (registerResult.Item1 == false)
                MessageBox.Show(registerResult.Item2);

            if (registerResult.Item1)
                MessageBox.Show("You have successfully registered.");
        
    }

        public void displayMessage(string srMessage)
        {

            MessageBox.Show(srMessage);
        }


        private void button2_Click(object sender, EventArgs e) //login buton
        {
            MainFunctions.tryLogin(this);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            helper_methods.doLogout();
            analiz.Text = " ";
            listBox1.Items.Clear();
            groupBox1.Visible = false;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            ToolTip Info = new ToolTip();
            Info.ToolTipTitle = "Logout!";
            Info.ToolTipIcon = ToolTipIcon.Warning;
            Info.IsBalloon = true;

            Info.SetToolTip(pictureBox7, "Are you sure to log out?");
            
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip Info = new ToolTip();
            Info.ToolTipTitle = "Clear everything!";
            Info.ToolTipIcon = ToolTipIcon.Warning;
            Info.IsBalloon = true;

            Info.SetToolTip(button4, "Are you sure to clear everything?");

        }

        private void clear_MouseHover(object sender, EventArgs e)
        {
            ToolTip Info = new ToolTip();
            Info.ToolTipTitle = "Clear!";
            Info.ToolTipIcon = ToolTipIcon.Warning;
            Info.IsBalloon = true;

            Info.SetToolTip(clear, "Are you sure to clear process?");

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            ToolTip Info = new ToolTip();
            Info.ToolTipTitle = "Clear History!";
            Info.ToolTipIcon = ToolTipIcon.Warning;
            Info.IsBalloon = true;

            Info.SetToolTip(button3, "Are you sure to clear history?");

        }

        private void RegisterLabelRGB_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        void bolme_Click(object sender, EventArgs e)
            {
                islem = "÷";
                SayiYaz();
            }



            void enter_Click(object sender, EventArgs e)
            {
                //degisken:
                if (hesaplama.Text != "") sayi_v2 = Convert.ToDouble(hesaplama.Text);
                else analiz.Text = "You didn't enter number...";
                switch (islem)
                {
                    case "+":
                        sonuc = sayi + sayi_v2;
                        SayiYaz_v2();
                        break;

                    case "-":
                        sonuc = sayi - sayi_v2;
                        SayiYaz_v2();
                        break;

                    case "x":
                        sonuc = sayi * sayi_v2;
                        SayiYaz_v2();
                        break;

                    case "÷":
                        sonuc = sayi / sayi_v2;
                        SayiYaz_v2();
                        break;
                }
                listBox1.Items.Add(analiz.Text);
            }
        }
}
