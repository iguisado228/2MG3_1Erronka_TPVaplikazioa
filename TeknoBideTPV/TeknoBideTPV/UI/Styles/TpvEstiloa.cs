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

    private class FormInfo
    {
        public Size HasierakoTamaina;
        public Dictionary<Control, KontrolenInformazioa> Kontrolak;
    }

    private static readonly Dictionary<Form, FormInfo> hasierakoak = new();

    public static void PantailarenEskalatuaHasi(Form form)
    {
        if (hasierakoak.ContainsKey(form))
            return;

        var dic = new Dictionary<Control, KontrolenInformazioa>();
        HasierakoPosizioakGorde(form.Controls, dic);

        hasierakoak[form] = new FormInfo
        {
            HasierakoTamaina = form.ClientSize, 
            Kontrolak = dic
        };
    }

    private static void HasierakoPosizioakGorde(
        Control.ControlCollection controls,
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
        if (!hasierakoak.TryGetValue(form, out var info))
            return;

        var dic = info.Kontrolak;
        float hasieraZabalera = info.HasierakoTamaina.Width;
        float hasieraAltuera = info.HasierakoTamaina.Height;

        if (hasieraZabalera <= 0 || hasieraAltuera <= 0)
            return;

        float Xeskala = (float)form.ClientSize.Width / hasieraZabalera;
        float Yeskala = (float)form.ClientSize.Height / hasieraAltuera;
        float eskala = Math.Min(Xeskala, Yeskala);

        if (eskala < 0.7f) eskala = 0.7f;

        foreach (var kvp in dic)
        {
            var c = kvp.Key;
            var kInfo = kvp.Value;

            c.SetBounds(
                (int)(kInfo.Bounds.X * eskala),
                (int)(kInfo.Bounds.Y * eskala),
                (int)(kInfo.Bounds.Width * eskala),
                (int)(kInfo.Bounds.Height * eskala)
            );

            c.Font = new Font(
                c.Font.FontFamily,
                kInfo.FontSize * eskala,
                c.Font.Style
            );
        }
    }
}
