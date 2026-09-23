using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAE_réseaux
{
   
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 12;
        public Color BorderColor { get; set; } = ColorTranslator.FromHtml("#787878");
        public int BorderSize { get; set; } = 3;

        public RoundedPanel()
        {
            this.Resize += (s, e) => this.Invalidate();
            this.SetStyle(ControlStyles.UserPaint
                          | ControlStyles.AllPaintingInWmPaint
                          | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int r = BorderRadius;
            if (r < 1) r = 1;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

            // Empêche les arcs négatifs 
            int maxRadius = Math.Min(rect.Width, rect.Height) / 2;
            if (r > maxRadius) r = maxRadius;

            using (GraphicsPath path = GetRoundedPath(rect, r))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                // Découpe réelle du panel
                this.Region = new Region(path);

                // Fond pastel arrondi
                e.Graphics.FillPath(brush, path);

                // Bordure
                if (BorderSize > 0)
                    e.Graphics.DrawPath(pen, path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
    }

    
    /// TextBox avec coins arrondis dessinés via un Panel englobant
    public class RoundedTextBox : Panel
    {
        private TextBox _inner;
        public int BorderRadius { get; set; } = 6;
        public Color BorderColor { get; set; } = Color.FromArgb(100, 100, 100);

        public int MaxLength
        {
            get => _inner.MaxLength;
            set => _inner.MaxLength = value;
        }

        public bool ReadOnly
        {
            get => _inner.ReadOnly;
            set
            {
                _inner.ReadOnly = value;
                _inner.BackColor = value ? Color.FromArgb(240, 240, 240) : Color.White;
                this.BackColor = _inner.BackColor;
            }
        }

        public override string Text
        {
            get => _inner.Text;
            set => _inner.Text = value;
        }

        public HorizontalAlignment TextAlign
        {
            get => _inner.TextAlign;
            set => _inner.TextAlign = value;
        }

        public new Font Font
        {
            get => _inner.Font;
            set
            {
                _inner.Font = value;
                UpdateInnerSize();
            }
        }

        public event EventHandler TextChanged
        {
            add => _inner.TextChanged += value;
            remove => _inner.TextChanged -= value;
        }

        public event KeyPressEventHandler KeyPress
        {
            add => _inner.KeyPress += value;
            remove => _inner.KeyPress -= value;
        }

        public RoundedTextBox()
        {
            this.DoubleBuffered = true;
            this.Padding = new Padding(3);
            this.BackColor = Color.White;

            _inner = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.White,
                TextAlign = HorizontalAlignment.Center,
                Font = new Font("Segoe UI", 9f),
            };

            this.Controls.Add(_inner);
            this.Resize += (s, e) => UpdateInnerSize();
            UpdateInnerSize();
        }

        private void UpdateInnerSize()
        {
            int pad = 5;
            int textHeight = _inner.PreferredHeight;
            int totalHeight = textHeight + pad * 2;
            this.Height = totalHeight;

            _inner.Location = new Point(pad, (this.Height - textHeight) / 2);
            _inner.Width = this.Width - pad * 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Width < 4 || this.Height < 4) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // Fond blanc direct  pas de g.Clear pour éviter les artefacts avec le parent
            g.Clear(Color.White);
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            int safeR = Math.Min(BorderRadius, Math.Min(rect.Width, rect.Height) / 2);
            if (safeR < 1) safeR = 1;
            using (GraphicsPath gp = RoundedRect(rect, safeR))
            {
                using (SolidBrush b = new SolidBrush(_inner.BackColor))
                    g.FillPath(b, gp);
                using (Pen p = new Pen(BorderColor, 1.5f))
                    g.DrawPath(p, gp);
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = Math.Max(2, Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height)));
            var gp = new GraphicsPath();
            gp.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            gp.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            gp.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            gp.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }
    }

    /// Panel circulaire vert avec arc bleu proportionnel
    public class CirclePanel : Panel
    {
        private double _ratio = 0.0;

        public double Ratio
        {
            get => _ratio;
            set { _ratio = Math.Max(0, Math.Min(1, value)); this.Invalidate(); }
        }

        public CirclePanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(2, 2, this.Width - 4, this.Height - 4);

            using (SolidBrush greenBrush = new SolidBrush(Color.FromArgb(207, 249, 217)))
                g.FillEllipse(greenBrush, bounds);

            if (_ratio > 0.001)
            {
                float sweepAngle = (float)(_ratio >= 1.0 ? 359.99 : _ratio * 360.0);
                using (SolidBrush blueBrush = new SolidBrush(Color.FromArgb(207, 226, 255)))
                    g.FillPie(blueBrush, bounds, -90, sweepAngle);
            }

            using (Pen pen = new Pen(Color.Black, 2))
                g.DrawEllipse(pen, bounds);
        }
    }


    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BarreTitre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
            }
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Only01_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == (char)Keys.Back);
        }

        private void TxtBoxCIDR_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCIDR.Text) &&
                int.TryParse(txtBoxCIDR.Text, out int valeur))
            {
                if (valeur > 32)
                {
                    MessageBox.Show("Le CIDR ne peut pas dépasser 32 !");
                    txtBoxCIDR.Text = "32";
                }
            }
        }

        public static byte[] CidrToMask(int cidr)
        {
            string bits = new string('1', cidr).PadRight(32, '0');
            return new byte[]
            {
                Convert.ToByte(bits.Substring(0,  8), 2),
                Convert.ToByte(bits.Substring(8,  8), 2),
                Convert.ToByte(bits.Substring(16, 8), 2),
                Convert.ToByte(bits.Substring(24, 8), 2)
            };
        }

        private int MasqueToCidr(int m1, int m2, int m3, int m4)
        {
            uint maskInt = ((uint)m1 << 24) | ((uint)m2 << 16) | ((uint)m3 << 8) | (uint)m4;
            int cidr = 0;
            for (int i = 31; i >= 0; i--)
                if ((maskInt & (1u << i)) != 0)
                    cidr++;
            return cidr;
        }

        private bool EstMasqueValide(int m1, int m2, int m3, int m4)
        {
            uint mask = ((uint)m1 << 24) | ((uint)m2 << 16) | ((uint)m3 << 8) | (uint)m4;
            uint inv = ~mask;
            return (inv & (inv + 1)) == 0;
        }
        private bool CidrCoherentAvecClasse(string classe, int cidr)
        {
            if (classe == "A") return cidr >= 8 && cidr <= 30;
            if (classe == "B") return cidr >= 16 && cidr <= 30;
            if (classe == "C") return cidr >= 24 && cidr <= 30;
            return true;
        }

        private void ConvertirOctetsEnBinaire()
        {
            txtBoxBinOct1.Text = Convert.ToString(int.Parse(txtBoxOct1.Text.Trim()), 2).PadLeft(8, '0');
            txtBoxBinOct2.Text = Convert.ToString(int.Parse(txtBoxOct2.Text.Trim()), 2).PadLeft(8, '0');
            txtBoxBinOct3.Text = Convert.ToString(int.Parse(txtBoxOct3.Text.Trim()), 2).PadLeft(8, '0');
            txtBoxBinOct4.Text = Convert.ToString(int.Parse(txtBoxOct4.Text.Trim()), 2).PadLeft(8, '0');
        }

        private void ConvertirBinaireEnOctets()
        {
            txtBoxOct1.Text = Convert.ToInt32(txtBoxBinOct1.Text.Trim(), 2).ToString();
            txtBoxOct2.Text = Convert.ToInt32(txtBoxBinOct2.Text.Trim(), 2).ToString();
            txtBoxOct3.Text = Convert.ToInt32(txtBoxBinOct3.Text.Trim(), 2).ToString();
            txtBoxOct4.Text = Convert.ToInt32(txtBoxBinOct4.Text.Trim(), 2).ToString();
        }

        private void AppliquerCidr()
        {
            int cidr = int.Parse(txtBoxCIDR.Text.Trim());
            byte[] masque = CidrToMask(cidr);
            txtBoxMasOct1.Text = masque[0].ToString();
            txtBoxMasOct2.Text = masque[1].ToString();
            txtBoxMasOct3.Text = masque[2].ToString();
            txtBoxMasOct4.Text = masque[3].ToString();
        }

        private void CalculerReseau()
        {
            int ip1 = int.Parse(txtBoxOct1.Text.Trim()), ip2 = int.Parse(txtBoxOct2.Text.Trim()),
                ip3 = int.Parse(txtBoxOct3.Text.Trim()), ip4 = int.Parse(txtBoxOct4.Text.Trim());

            int m1 = int.Parse(txtBoxMasOct1.Text.Trim()), m2 = int.Parse(txtBoxMasOct2.Text.Trim()),
                m3 = int.Parse(txtBoxMasOct3.Text.Trim()), m4 = int.Parse(txtBoxMasOct4.Text.Trim());

            int r1 = ip1 & m1, r2 = ip2 & m2, r3 = ip3 & m3, r4 = ip4 & m4;
            int b1 = r1 | (~m1 & 255), b2 = r2 | (~m2 & 255),
                b3 = r3 | (~m3 & 255), b4 = r4 | (~m4 & 255);

            TxtBox_Reseau.Text = $"{r1}.{r2}.{r3}.{r4}";
            TxtBox_Broadcast.Text = $"{b1}.{b2}.{b3}.{b4}";
            TxtBox_PremIP.Text = $"{r1}.{r2}.{r3}.{r4 + 1}";
            TxtBox_DernIP.Text = $"{b1}.{b2}.{b3}.{b4 - 1}";

            uint maskInt = ((uint)m1 << 24) | ((uint)m2 << 16) | ((uint)m3 << 8) | (uint)m4;
            int bitsHote = 0;
            for (int i = 0; i < 32; i++)
                if ((maskInt & (1u << i)) == 0) bitsHote++;

            long totalIPs = (long)Math.Pow(2, bitsHote);
            long utilisables = Math.Max(0, totalIPs - 2);

            TxtNbIPs.Text = FormatNombre(totalIPs);
            TxtNbMachines.Text = FormatNombre(utilisables);

            double ratio = bitsHote / 32.0;
            circleIPs.Ratio = ratio;
            circleMachines.Ratio = totalIPs > 0 ? (double)utilisables / totalIPs : 0;
        }

        
        /// Détermine la classe réseau à partir du 1er octet de l'IP.
        /// A: 1–126, B: 128–191, C: 192–223, D: 224–239, E: 240–255
        
        private string Classe(int octet1)
        {
            if (octet1 >= 1 && octet1 <= 126) return "A";
            else if (octet1 >= 128 && octet1 <= 191) return "B";
            else if (octet1 >= 192 && octet1 <= 223) return "C";
            else if (octet1 >= 224 && octet1 <= 239) return "D";
            else return "E";
        }

        private string FormatNombre(long n)
        {
            if (n >= 1_000_000) return $"{n / 1_000_000.0:0.#}M";
            if (n >= 1_000) return $"{n / 1_000.0:0.#}k";
            return n.ToString();
        }

        private void Btn_Valider_Click(object sender, EventArgs e)
        {
        
            bool OctetsRemplis = !string.IsNullOrWhiteSpace(txtBoxOct1.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxOct2.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxOct3.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxOct4.Text);

            bool BinaireRemplis = !string.IsNullOrWhiteSpace(txtBoxBinOct1.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxBinOct2.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxBinOct3.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxBinOct4.Text);

            bool MasqueRemplis = !string.IsNullOrWhiteSpace(txtBoxMasOct1.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxMasOct2.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxMasOct3.Text) &&
                                   !string.IsNullOrWhiteSpace(txtBoxMasOct4.Text);

            bool CidrRempli = !string.IsNullOrWhiteSpace(txtBoxCIDR.Text);


            if (!OctetsRemplis && !BinaireRemplis)
            {
                MessageBox.Show("L'un des champs de l'adresse IP n'est pas rempli :\n" +
                                "  - Soit l'un ou plusieurs champs Binaires.\n" +
                                "  - Soit l'un ou plusieurs champs Octets.");
                return;
            }

            if (!MasqueRemplis && !CidrRempli)
            {
                MessageBox.Show("L'un ou plusieurs champs du masque de sous-réseau ne sont pas remplis.");
                return;
            }

            if (OctetsRemplis)
            {
                int o1 = int.Parse(txtBoxOct1.Text.Trim());
                int o2 = int.Parse(txtBoxOct2.Text.Trim());
                int o3 = int.Parse(txtBoxOct3.Text.Trim());
                int o4 = int.Parse(txtBoxOct4.Text.Trim());

                if (o1 > 255 || o2 > 255 || o3 > 255 || o4 > 255)
                {
                    MessageBox.Show("Les octets de l'adresse IP ne peuvent pas dépasser 255 !");
                    return;
                }
            }

            if (MasqueRemplis)
            {
                int m1 = int.Parse(txtBoxMasOct1.Text.Trim());
                int m2 = int.Parse(txtBoxMasOct2.Text.Trim());
                int m3 = int.Parse(txtBoxMasOct3.Text.Trim());
                int m4 = int.Parse(txtBoxMasOct4.Text.Trim());

                if (m1 > 255 || m2 > 255 || m3 > 255 || m4 > 255)
                {
                    MessageBox.Show("Les octets du masque ne peuvent pas dépasser 255 !");
                    return;
                }

                if (!EstMasqueValide(m1, m2, m3, m4))
                {
                    MessageBox.Show("Masque invalide : les bits doivent se suivre.\n Ex : 255.255.128.0   /  255.254.255.0 ");
                    return;
                }
            }

            if (BinaireRemplis && !OctetsRemplis)
                ConvertirBinaireEnOctets();
            else if (OctetsRemplis && !BinaireRemplis)
                ConvertirOctetsEnBinaire();

            if (CidrRempli)
                AppliquerCidr();
            else if (MasqueRemplis)
            {
                int m1 = int.Parse(txtBoxMasOct1.Text.Trim());
                int m2 = int.Parse(txtBoxMasOct2.Text.Trim());
                int m3 = int.Parse(txtBoxMasOct3.Text.Trim());
                int m4 = int.Parse(txtBoxMasOct4.Text.Trim());
                txtBoxCIDR.Text = MasqueToCidr(m1, m2, m3, m4).ToString();
            }

            CalculerReseau();

            // ── Mise en couleur de la classe ────────────────────────────
            Color saumon = Color.FromArgb(255, 200, 180);

            pnlClasseA.BackColor = Color.White;
            pnlClasseB.BackColor = Color.White;
            pnlClasseC.BackColor = Color.White;
            pnlClasseD.BackColor = Color.White;

            string classe = Classe(int.Parse(txtBoxOct1.Text.Trim())); // ← une seule fois
            switch (classe)
            {
                case "A": pnlClasseA.BackColor = saumon; break;
                case "B": pnlClasseB.BackColor = saumon; break;
                case "C": pnlClasseC.BackColor = saumon; break;
                case "D": pnlClasseD.BackColor = saumon; break;
            }

            pnlClasseA.Invalidate(); pnlClasseB.Invalidate();
            pnlClasseC.Invalidate(); pnlClasseD.Invalidate();

            int cidr = int.Parse(txtBoxCIDR.Text.Trim());
            if (!CidrCoherentAvecClasse(classe, cidr))
                MessageBox.Show($"CIDR /{cidr} inhabituel pour une adresse de classe {classe}.");

        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            RoundedTextBox[] tousLesChamps = {
            txtBoxOct1, txtBoxOct2, txtBoxOct3, txtBoxOct4,
            txtBoxBinOct1, txtBoxBinOct2, txtBoxBinOct3, txtBoxBinOct4,
            txtBoxCIDR, txtBoxMasOct1, txtBoxMasOct2, txtBoxMasOct3, txtBoxMasOct4,
            TxtBox_Reseau, TxtBox_Broadcast, TxtBox_PremIP, TxtBox_DernIP
            };
            foreach (var tb in tousLesChamps) tb.Text = "";
            TxtNbIPs.Text = "—";
            TxtNbMachines.Text = "—";
            circleIPs.Ratio = 0;
            circleMachines.Ratio = 0;
            pnlClasseA.BackColor = Color.White;
            pnlClasseB.BackColor = Color.White;
            pnlClasseC.BackColor = Color.White;
            pnlClasseD.BackColor = Color.White;
        }
    }
}