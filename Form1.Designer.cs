namespace WebViewDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            textBox1 = new TextBox();
            browserTime = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(42, 76);
            webView21.Name = "webView21";
            webView21.Size = new Size(691, 279);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.Location = new Point(647, 21);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 1;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(557, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "hello~";
            // 
            // browserTime
            // 
            browserTime.AutoSize = true;
            browserTime.Location = new Point(42, 374);
            browserTime.Name = "browserTime";
            browserTime.Size = new Size(35, 15);
            browserTime.TabIndex = 3;
            browserTime.Text = "Time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(browserTime);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private TextBox textBox1;
        private Label browserTime;
    }
}
