using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.ComponentModel;

namespace RecipeNess.controls
{
    public class RoundedButton : Button
    {
        private int cornerRadius = 10;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                UpdateRegion(); 
            }
        }

        public RoundedButton()
        {
  
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UpdateRegion();
        }


        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }

        private void UpdateRegion()
        {
            if (ClientRectangle.Width > 0 && ClientRectangle.Height > 0)
            {
                using (var path = GetRoundedRectangle(ClientRectangle, cornerRadius))
                {
                    Region = new Region(path);
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);                
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);   
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); 
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);  
            path.CloseFigure();
            return path;
        }
    }
}
