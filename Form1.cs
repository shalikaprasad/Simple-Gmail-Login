using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail_Log
{
    public partial class Form1 : Form
    {
        public bool n = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void gmail_web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
                try
                {
                    HtmlDocument doc = gmail_web.Document;
                    HtmlElement email = doc.GetElementById("identifierId");
                    HtmlElement next = doc.GetElementById("identifierNext");
                    email.SetAttribute("value", "shalikamanchanayaka38@gmail.com");
                    next.InvokeMember("click");
                }
                catch
                {
                    
                }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
