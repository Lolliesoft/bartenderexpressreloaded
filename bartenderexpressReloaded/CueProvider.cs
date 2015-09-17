using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace bartenderexpressReloaded
{
      /// <summary>
    /// Provides textual cues to a text box.
    /// </summary>
    /// <summary>
    
    public class CueProvider
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
        public void SetCue (TextBox textBox, string cue)
        {
            textBox.Font = new Font("Default", 8, FontStyle.Italic);  
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, cue);

        }

        /// <summary>
        /// Clears a text box's cue text.
        /// </summary>
        /// <param name="textBox">The text box</param>
        public void ClearCue
          (TextBox textBox)
        {
            textBox.Font = new Font("Default", 8, FontStyle.Regular);
            SendMessage (textBox.Handle, EM_SETCUEBANNER, 0, string.Empty);
        }
    }
}

