using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace bartenderexpressReloaded
{
      /// <summary>
    /// Provides textual cues to a text box.
    /// </summary>
    /// <summary>
    
    public static class CueProvider
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage
          (IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        /// <summary>
        /// Sets a text box's cue text.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <param name="cue">The cue text.</param>
        public static void SetCue (TextBox textBox, string cue)
        {
            textBox.Font = new System.Drawing.Font();

            //TextBox.DefaultFont.Italic = true;
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, cue);

        }

        /// <summary>
        /// Clears a text box's cue text.
        /// </summary>
        /// <param name="textBox">The text box</param>
        public static void ClearCue
          (TextBox textBox)
        {
            SendMessage (textBox.Handle, EM_SETCUEBANNER, 0, string.Empty);
        }
    }
}

