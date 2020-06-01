using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();//清空comboBox1內元素
            comboBox1.Items.Add("GitHub");
            comboBox1.Items.Add("Medium部落格");
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 把目前的網址顯示在網址輸入框中
            search_bar.Text = webBrowser1.Url.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // webBrowser1.Navigate("https://www.nknu.edu.tw");
            webBrowser1.Navigate(search_bar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tw");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();//程式關閉
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "GitHub":
                    webBrowser1.Navigate("https://github.com/e96031413");
                    break;
                case "Medium部落格":
                    webBrowser1.Navigate("https://medium.com/@yanweiliu");
                    break;
                default:
                    webBrowser1.Navigate("https://www.google.com.tw");
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
