using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace bBear_v2
{
    internal class RoundPanel : Panel
    {
        // คุณสมบัติสำหรับการกำหนดรัศมีของขอบโค้ง
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // ตั้งค่าการทำ AntiAliasing เพื่อให้ขอบโค้งเรียบ
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // สร้างกราฟิกพาธเพื่อวาดรูปทรงโค้ง
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, CornerRadius, CornerRadius), 180, 90);
            path.AddArc(new Rectangle(this.Width - CornerRadius, 0, CornerRadius, CornerRadius), -90, 90);
            path.AddArc(new Rectangle(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - CornerRadius, CornerRadius, CornerRadius), 90, 90);



            path.CloseAllFigures();

            // วาดพื้นหลังของ Panel
            e.Graphics.FillPath(new SolidBrush(this.BackColor), path);

            // วาดขอบของ Panel
            e.Graphics.DrawPath(new Pen(Color.Black, 1), path);
        }
    }
}
