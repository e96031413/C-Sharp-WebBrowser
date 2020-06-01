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
            this.go_btn = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.previous_page_btn = new System.Windows.Forms.Button();
            this.next_page_btn = new System.Windows.Forms.Button();
            this.refersh_btn = new System.Windows.Forms.Button();
            this.main_page_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.favorite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(44, 79);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1308, 780);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com.tw", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // go_btn
            // 
            this.go_btn.Location = new System.Drawing.Point(1165, 25);
            this.go_btn.Margin = new System.Windows.Forms.Padding(4);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(100, 29);
            this.go_btn.TabIndex = 1;
            this.go_btn.Text = "Go";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(697, 26);
            this.search_bar.Margin = new System.Windows.Forms.Padding(4);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(460, 25);
            this.search_bar.TabIndex = 2;
            this.search_bar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // previous_page_btn
            // 
            this.previous_page_btn.Location = new System.Drawing.Point(44, 26);
            this.previous_page_btn.Margin = new System.Windows.Forms.Padding(4);
            this.previous_page_btn.Name = "previous_page_btn";
            this.previous_page_btn.Size = new System.Drawing.Size(79, 29);
            this.previous_page_btn.TabIndex = 3;
            this.previous_page_btn.Text = "上一頁";
            this.previous_page_btn.UseVisualStyleBackColor = true;
            this.previous_page_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // next_page_btn
            // 
            this.next_page_btn.Location = new System.Drawing.Point(240, 25);
            this.next_page_btn.Margin = new System.Windows.Forms.Padding(4);
            this.next_page_btn.Name = "next_page_btn";
            this.next_page_btn.Size = new System.Drawing.Size(100, 29);
            this.next_page_btn.TabIndex = 4;
            this.next_page_btn.Text = "下一頁";
            this.next_page_btn.UseVisualStyleBackColor = true;
            this.next_page_btn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // refersh_btn
            // 
            this.refersh_btn.Location = new System.Drawing.Point(132, 26);
            this.refersh_btn.Margin = new System.Windows.Forms.Padding(4);
            this.refersh_btn.Name = "refersh_btn";
            this.refersh_btn.Size = new System.Drawing.Size(100, 29);
            this.refersh_btn.TabIndex = 5;
            this.refersh_btn.Text = "重新整理";
            this.refersh_btn.UseVisualStyleBackColor = true;
            this.refersh_btn.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // main_page_btn
            // 
            this.main_page_btn.Location = new System.Drawing.Point(348, 25);
            this.main_page_btn.Name = "main_page_btn";
            this.main_page_btn.Size = new System.Drawing.Size(94, 30);
            this.main_page_btn.TabIndex = 6;
            this.main_page_btn.Text = "首頁";
            this.main_page_btn.UseVisualStyleBackColor = true;
            this.main_page_btn.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(449, 25);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(90, 29);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "離開";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(556, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "下拉選取網頁";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // favorite
            // 
            this.favorite.AutoSize = true;
            this.favorite.Location = new System.Drawing.Point(574, 8);
            this.favorite.Name = "favorite";
            this.favorite.Size = new System.Drawing.Size(67, 15);
            this.favorite.TabIndex = 9;
            this.favorite.Text = "常用連結";
            this.favorite.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 1024);
            this.Controls.Add(this.favorite);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.main_page_btn);
            this.Controls.Add(this.refersh_btn);
            this.Controls.Add(this.next_page_btn);
            this.Controls.Add(this.previous_page_btn);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "瀏覽器 by Yanwei Liu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Button previous_page_btn;
        private System.Windows.Forms.Button next_page_btn;
        private System.Windows.Forms.Button refersh_btn;
        private System.Windows.Forms.Button main_page_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label favorite;
    }
}

