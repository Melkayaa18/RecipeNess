using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RecipeNess.Components
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(Panel))]
    public class RoundedPanel : Panel
    {
        private int cornerRadius = 20;
        private Color borderColor = Color.Transparent;
        private float borderWidth = 1f;

        [DefaultValue(20)]
        [Description("Радиус скругления углов")]
        [Category("Внешний вид")]
        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                if (cornerRadius != value)
                {
                    cornerRadius = value;
                    UpdateRegion();
                    Invalidate();
                }
            }
        }

        [DefaultValue(typeof(Color), "Transparent")]
        [Description("Цвет границы")]
        [Category("Внешний вид")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                if (borderColor != value)
                {
                    borderColor = value;
                    Invalidate();
                }
            }
        }

        [DefaultValue(1f)]
        [Description("Толщина границы")]
        [Category("Внешний вид")]
        public float BorderWidth
        {
            get => borderWidth;
            set
            {
                if (borderWidth != value)
                {
                    borderWidth = value;
                    Invalidate();
                }
            }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            BackColor = Color.White;
            Resize += (s, e) => UpdateRegion();
        }

        private void UpdateRegion()
        {
            using (var path = GetRoundedRectanglePath(ClientRectangle, cornerRadius))
            {
                Region = new Region(path);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Отключаем стандартную отрисовку фона
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = GetRoundedRectanglePath(ClientRectangle, cornerRadius))
            {
                // Заливка цветом BackColor
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Рисуем границу, если она не прозрачная
                if (borderColor != Color.Transparent && borderWidth > 0)
                {
                    using (var pen = new Pen(borderColor, borderWidth))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
            base.OnPaint(e); // Отрисовка дочерних элементов
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int r = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2);
            if (r <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90);
            path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90);
            path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}