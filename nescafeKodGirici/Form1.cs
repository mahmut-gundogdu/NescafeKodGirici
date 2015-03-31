using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nescafeKodGirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.nescafe.com.mx/lottery_tr_tr.axcms?secured=1");
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
           
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnKodGir_Click(object sender, EventArgs e)
        {
            try
            {
                  var txtAd = webBrowser1.Document.GetElementById("txtFirstname");
            var txtSoyad = webBrowser1.Document.GetElementById("txtLastname");
            var txtAdres = webBrowser1.Document.GetElementById("txtAddress");
            var txttel = webBrowser1.Document.GetElementById("txtPhone");
            var txtKampanyaKodu = webBrowser1.Document.GetElementById("txtEANCode");


            txtAd.InnerText = "Mahmut";
            txtSoyad.InnerText = "Gündoğdu";
            txtAdres.InnerText = "Seyit Gazi Mah. Sami Akbulut cad. Mavi Kule apt altı. Ef bilişim Kayseri";
            txttel.InnerText = "05058552387";
            txtKampanyaKodu.InnerText = txtGirilenKampanyakodu.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
