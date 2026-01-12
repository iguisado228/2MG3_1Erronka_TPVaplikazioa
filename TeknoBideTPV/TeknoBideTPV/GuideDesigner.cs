using System.Drawing;
using System.Windows.Forms.Design;

public class GuideDesigner : ControlDesigner
{
    protected override void OnPaintAdornments(PaintEventArgs pe)
    {
        base.OnPaintAdornments(pe);

        var g = pe.Graphics;
        var rect = Control.ClientRectangle;

        int centerX = rect.Width / 2;
        int centerY = rect.Height / 2;

        using (var pen = new Pen(Color.Red, 1))
        {
            g.DrawLine(pen, centerX, 0, centerX, rect.Height);
            g.DrawLine(pen, 0, centerY, rect.Width, centerY);
        }
    }
}
