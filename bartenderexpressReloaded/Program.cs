using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.TouchSkins.Register();

            DevExpress.LookAndFeel.UserLookAndFeel.Default.UseWindowsXPTheme = false;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013";

            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkins();
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
