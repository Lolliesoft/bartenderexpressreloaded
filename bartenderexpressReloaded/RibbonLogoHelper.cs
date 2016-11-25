using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace DevExpress.XtraBars.Ribbon
{
    [DesignerCategory("")]
    [Designer("")]
    public class RibbonLogoHelper : Component
    {
        private Image _Image;
        private RibbonControl _RibbonControl;


        public RibbonControl RibbonControl
        {
            get { return _RibbonControl; }
            set
            {
                if (value == _RibbonControl)
                    return;
                RibbonControl prevValue = _RibbonControl;
                _RibbonControl = value;
                OnRibbonChanged(prevValue, _RibbonControl);
            }
        }

        private void OnRibbonChanged(RibbonControl prevValue, RibbonControl ribbonControl)
        {
            if (prevValue != null)
                prevValue.Paint -= ribbonControl_Paint;
            if (ribbonControl != null)
            {
                ribbonControl.Paint += ribbonControl_Paint;
                ribbonControl.Invalidate();
            }

        }

        void ribbonControl_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            DrawRibbonLogo(e.Graphics);
        }


        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == _Image)
                    return;
                _Image = value;
                OnImageChanged();
            }
        }



        private void OnImageChanged()
        {
            if (RibbonControl != null)
                RibbonControl.Invalidate();
        }

        private void DrawRibbonLogo(Graphics graphics)
        {
            if (Image == null)
                return;
            RibbonViewInfo ribbonViewInfo = RibbonControl.ViewInfo;
            if (ribbonViewInfo == null)
                return;
            RibbonPanelViewInfo panelViewInfo = ribbonViewInfo.Panel;
            if (panelViewInfo == null)
                return;
            Rectangle bounds = panelViewInfo.Bounds;
            int minX = bounds.X;
            RibbonPageGroupViewInfoCollection groups = panelViewInfo.Groups;
            if (groups == null)
                return;
            if (groups.Count > 0)
                minX = groups[groups.Count - 1].Bounds.Right;
            if (bounds.Height < Image.Height)
                return;
            int offset = (bounds.Height - Image.Height) / 2;
            int width = Image.Width + 15;
            bounds.X = bounds.Width - width;
            if (bounds.X < minX)
                return;
            bounds.Width = width;
            bounds.Y += offset;
            bounds.Height = Image.Height;
            graphics.DrawImage(Image, new Rectangle(bounds.Location, Image.Size), new Rectangle(Point.Empty, Image.Size), GraphicsUnit.Pixel);
        }

    }
}