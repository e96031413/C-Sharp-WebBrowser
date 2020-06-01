namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.previous_page = new System.Windows.Forms.Button();
            this.next_page = new System.Windows.Forms.Button();
            this.refersh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(33, 63);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1875, 1050);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com.tw", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(978, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(270, 21);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(712, 22);
            this.search_bar.TabIndex = 2;
            this.search_bar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // previous_page
            // 
            this.previous_page.Location = new System.Drawing.Point(33, 21);
            this.previous_page.Name = "previous_page";
            this.previous_page.Size = new System.Drawing.Size(59, 23);
            this.previous_page.TabIndex = 3;
            this.previous_page.Text = "上一頁";
            this.previous_page.UseVisualStyleBackColor = true;
            this.previous_page.Click += new System.EventHandler(this.button2_Click);
            // 
            // next_page
            // 
            this.next_page.Location = new System.Drawing.Point(180, 20);
            this.next_page.Name = "next_page";
            this.next_page.Size = new System.Drawing.Size(75, 23);
            this.next_page.TabIndex = 4;
            this.next_page.Text = "下一頁";
            this.next_page.UseVisualStyleBackColor = true;
            this.next_page.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // refersh_btn
            // 
            this.refersh_btn.Location = new System.Drawing.Point(99, 21);
            this.refersh_btn.Name = "refersh_btn";
            this.refersh_btn.Size = new System.Drawing.Size(75, 23);
            this.refersh_btn.TabIndex = 5;
            this.refersh_btn.Text = "重新整理";
            this.refersh_btn.UseVisualStyleBackColor = true;
            this.refersh_btn.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.refersh_btn);
            this.Controls.Add(this.next_page);
            this.Controls.Add(this.previous_page);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Button previous_page;
        private System.Windows.Forms.Button next_page;
        private System.Windows.Forms.Button refersh_btn;
    }
}

