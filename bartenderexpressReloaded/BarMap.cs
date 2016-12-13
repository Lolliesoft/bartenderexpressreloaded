using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bartenderexpressReloaded
{
    public partial class BarMap : Form
    {
        public BarMap()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int BrowserVer, RegVal;

            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            Key.Close();

            string bars = "bars in my area";
            string city = txtCity.Text;
            string state = txtState.Text;
            
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                //if(street != string.Empty)
                {
                    queryaddress.Append(bars + "," + "+");

                }

                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }

                if (state != string.Empty)
                {
                    queryaddress.Append(state + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "error");
            }
        }
    }
   
}
