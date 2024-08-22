using Microsoft.Web.WebView2.Core;

namespace WebViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://airmanxtw.github.io/StustTraining/webview.html");
            webView21.WebMessageReceived += (object? sender, CoreWebView2WebMessageReceivedEventArgs e) =>
            {
                //MessageBox.Show(e.TryGetWebMessageAsString());
                browserTime.Text= e.TryGetWebMessageAsString();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (webView21.CoreWebView2 != null)
            {

                webView21.CoreWebView2.PostWebMessageAsString(textBox1.Text);

            }
        }
    }
}
