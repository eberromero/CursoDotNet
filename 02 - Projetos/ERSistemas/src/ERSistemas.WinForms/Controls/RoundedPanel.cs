using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace ERSistemas.WinForms.Controls;

public class RoundedPanel : Panel
{
    private int _borderRadius = 10;
    private Color _borderColor = Color.LightGray;
    private int _borderThickness = 1;

    [Category("Appearance")]
    [DefaultValue(10)]
    public int BorderRadius
    {
        get => _borderRadius;
        set
        {
            _borderRadius = Math.Max(1, value);
            Invalidate();
        }
    }

    [Category("Appearance")]
    [DefaultValue(typeof(Color), "LightGray")]
    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    [DefaultValue(1)]
    public int BorderThickness
    {
        get => _borderThickness;
        set
        {
            _borderThickness = Math.Max(1, value);
            Invalidate();
        }
    }

    public RoundedPanel()
    {
        DoubleBuffered = true;
        BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

        using GraphicsPath path = CriarCaminhoArredondado(rect, BorderRadius);

        using Pen pen = new Pen(BorderColor, BorderThickness);

        e.Graphics.DrawPath(pen, path);
    }

    private GraphicsPath CriarCaminhoArredondado(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();

        int diameter = radius * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);

        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);

        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

        path.CloseFigure();

        return path;
    }
}