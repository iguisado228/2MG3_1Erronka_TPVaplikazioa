    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace TeknoBideTPV.UI.Styles
    {
        public static class TPVEstiloaFinkoa
        {
            private class KontrolInfo
            {
                public Rectangle Bounds;
                public float FontSize;
            }

            private static readonly Dictionary<Form, Dictionary<Control, KontrolInfo>> originalak = new();

            public static void Prestatu(Form form)
            {
                if (originalak.ContainsKey(form))
                    return;

                var dic = new Dictionary<Control, KontrolInfo>();
                Gorde(form.Controls, dic);
                originalak[form] = dic;
            }

            private static void Gorde(Control.ControlCollection controls, Dictionary<Control, KontrolInfo> dic)
            {
                foreach (Control c in controls)
                {
                    dic[c] = new KontrolInfo
                    {
                        Bounds = c.Bounds,
                        FontSize = c.Font.Size
                    };

                    if (c.HasChildren)
                        Gorde(c.Controls, dic);
                }
            }

        public static void Aplikatu(Form form)
        {
            if (!originalak.TryGetValue(form, out var dic))
                return;

            float baseW = 1920f;
            float baseH = 1080f;

            float scaleX = Screen.PrimaryScreen.Bounds.Width / baseW;
            float scaleY = Screen.PrimaryScreen.Bounds.Height / baseH;
            float scale = Math.Min(scaleX, scaleY);

            foreach (var kvp in dic)
            {
                var c = kvp.Key;
                var info = kvp.Value;

                if (c.Dock != DockStyle.None)
                    continue;

                c.SetBounds(
                    (int)(info.Bounds.X * scale),
                    (int)(info.Bounds.Y * scale),
                    (int)(info.Bounds.Width * scale),
                    (int)(info.Bounds.Height * scale)
                );

                c.Font = new Font(
                    c.Font.FontFamily,
                    info.FontSize * scale,
                    c.Font.Style
                );
            }
        }

    }

}
