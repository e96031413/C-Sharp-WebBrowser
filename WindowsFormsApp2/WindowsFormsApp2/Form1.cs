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
    }
}
