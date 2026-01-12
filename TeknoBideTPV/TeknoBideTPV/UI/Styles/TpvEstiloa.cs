using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public static class TPVEstiloa
{
    private class KontrolenInformazioa
    {
        public Rectangle Bounds;
        public float FontSize;
    }

    
    private static readonly Dictionary<Form, Dictionary<Control, KontrolenInformazioa>> _originales
        = new();

    public static void PantailarenEskalatuaHasi(Form form)
    {
        if (_originales.ContainsKey(form))
            return;

        var dic = new Dictionary<Control, KontrolenInformazioa>();
        HasierakoPosizioakGorde(form.Controls, dic);
        _originales[form] = dic;
    }

    private static void HasierakoPosizioakGorde(Control.ControlCollection controls,
                                          Dictionary<Control, KontrolenInformazioa> dic)
    {
        foreach (Control c in controls)
        {
            dic[c] = new KontrolenInformazioa
            {
                Bounds = c.Bounds,
                FontSize = c.Font.Size
            };

            if (c.HasChildren)
                HasierakoPosizioakGorde(c.Controls, dic);
        }
    }

    public static void EskalatuaAplikatu(Form form)
    {
        if (!_originales.TryGetValue(form, out var dic))
            return;

        float hasieraZabalera = 1920;
        float hasieraAltuera = 1080;

        float Xeskala = form.ClientSize.Width / hasieraZabalera;
        float Yeskala = form.ClientSize.Height / hasieraAltuera;
        float eskala = Math.Min(Xeskala, Yeskala);

        if (eskala < 0.7f) eskala = 0.7f;

        foreach (var kvp in dic)
        {
            var c = kvp.Key;
            var info = kvp.Value;

            c.SetBounds(
                x: (int)(info.Bounds.X * eskala),
                y: (int)(info.Bounds.Y * eskala),
                width: (int)(info.Bounds.Width * eskala),
                height: (int)(info.Bounds.Height * eskala)
            );

            c.Font = new Font(
                c.Font.FontFamily,
                info.FontSize * eskala,
                c.Font.Style
            );
        }
    }
}
