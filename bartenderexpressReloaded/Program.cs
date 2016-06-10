using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SecureApp;

namespace bartenderexpressReloaded
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");          
            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = false;
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            //secureApp
            String abc = @"Software\LollieSoft\Bartender Express";
            string[,] passwordSt = new string[,] // 5X10
            {
                {"ASDZ","QWEY","MKOX","EDFW","CVBV","DRFU","HNKT","GHES","RERR","SWVQ"},
                {"ASDP","HJUO","VGTN","VFDM","PCFL","GEIJ","CWTK","GETI","ETDH","EFQG"},
                {"HGFE","POLF","DFRC","NBGD","JYUC","GECB","DFWA","GQAN","VRYP","CAEV"},
                {"GFHM", "OPHL","GHSF","JNYU","CFFJ","VS5R","CD3F","C67E","F34Z","F8J6"},
                {"DRFX", "HNKI","GHEL","RERC","SWVK","E4N9","2C8Y","3F5M","3CFS","F5UQ"}
            };
            Secure sec = new Secure();

            bool logic = sec.Algorithm(passwordSt, abc);
            if (logic == true)

                Application.Run(new Form1());
        }
    }


    public class WizardPages : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
    
}
