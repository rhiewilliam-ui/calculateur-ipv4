using SAE_réseaux;
using System.Drawing;
using System.Windows.Forms;

namespace SAE_réseaux
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Déclarations ─────────────────────────────────────────────
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlScroll = new System.Windows.Forms.Panel();

            // Bloc IP
            this.pnlIP = new RoundedPanel();
            this.lblIPTitle = new System.Windows.Forms.Label();
            this.lblOct1 = new System.Windows.Forms.Label();
            this.txtBoxOct1 = new RoundedTextBox();
            this.lblBin1 = new System.Windows.Forms.Label();
            this.txtBoxBinOct1 = new RoundedTextBox();
            this.lblOct2 = new System.Windows.Forms.Label();
            this.txtBoxOct2 = new RoundedTextBox();
            this.txtBoxBinOct2 = new RoundedTextBox();
            this.lblOct3 = new System.Windows.Forms.Label();
            this.txtBoxOct3 = new RoundedTextBox();
            this.txtBoxBinOct3 = new RoundedTextBox();
            this.lblOct4 = new System.Windows.Forms.Label();
            this.txtBoxOct4 = new RoundedTextBox();
            this.txtBoxBinOct4 = new RoundedTextBox();

            // Bloc Masque
            this.pnlMasque = new RoundedPanel();
            this.lblMasqueTitle = new System.Windows.Forms.Label();
            this.lblCIDR = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtBoxCIDR = new RoundedTextBox();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.txtBoxMasOct1 = new RoundedTextBox();
            this.txtBoxMasOct2 = new RoundedTextBox();
            this.txtBoxMasOct3 = new RoundedTextBox();
            this.txtBoxMasOct4 = new RoundedTextBox();

            // Bouton
            this.btnValider = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            // Bloc Résultats
            this.pnlResultats = new RoundedPanel();
            this.lblResultatsTitle = new System.Windows.Forms.Label();
            this.lblReseau = new System.Windows.Forms.Label();
            this.TxtBox_Reseau = new RoundedTextBox();
            this.lblPremIP = new System.Windows.Forms.Label();
            this.TxtBox_PremIP = new RoundedTextBox();
            this.lblDernIP = new System.Windows.Forms.Label();
            this.TxtBox_DernIP = new RoundedTextBox();
            this.lblBroadcast = new System.Windows.Forms.Label();
            this.TxtBox_Broadcast = new RoundedTextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.pnlClasseA = new RoundedPanel();
            this.lblClasseA = new System.Windows.Forms.Label();
            this.pnlClasseB = new RoundedPanel();
            this.lblClasseB = new System.Windows.Forms.Label();
            this.pnlClasseC = new RoundedPanel();
            this.lblClasseC = new System.Windows.Forms.Label();
            this.pnlClasseD = new RoundedPanel();
            this.lblClasseD = new System.Windows.Forms.Label();
            this.TxtNbIPs = new System.Windows.Forms.Label();
            this.TxtNbMachines = new System.Windows.Forms.Label();
            this.circleIPs = new CirclePanel();
            this.circleMachines = new CirclePanel();

            this.SuspendLayout();

            // ─────────────────────────────────────────────
            // 🎨 STYLE PASTEL GLOBAL
            // ─────────────────────────────────────────────

            // Fond général
            this.BackColor = Color.FromArgb(247, 247, 247);

            // ─────────────────────────────────────────────
            // 🎨 Bloc IP
            // ─────────────────────────────────────────────
            this.pnlIP.BackColor = Color.FromArgb(232, 241, 255);
            this.lblIPTitle.ForeColor = Color.Black;

            this.txtBoxOct1.BackColor = ColorTranslator.FromHtml("#E8F1FF");
            this.txtBoxOct2.BackColor = ColorTranslator.FromHtml("#E8F1FF");
            this.txtBoxOct3.BackColor = ColorTranslator.FromHtml("#E8F1FF");
            this.txtBoxOct4.BackColor = ColorTranslator.FromHtml("#E8F1FF");

            this.txtBoxBinOct1.BackColor = ColorTranslator.FromHtml("#E8F1FF");
            this.txtBoxBinOct2.BackColor = ColorTranslator.FromHtml("#E8F1FF");
            this.txtBoxBinOct3.BackColor = ColorTranslator.FromHtml("#E8F1FF");
            this.txtBoxBinOct4.BackColor = ColorTranslator.FromHtml("#E8F1FF");

            // ─────────────────────────────────────────────
            // 🎨 Bloc Masque
            // ─────────────────────────────────────────────
            this.pnlMasque.BackColor = ColorTranslator.FromHtml("#E6F8E7");
            this.lblMasqueTitle.ForeColor = Color.Black;

            this.txtBoxCIDR.BackColor = ColorTranslator.FromHtml("#E6F8E7");
            this.txtBoxMasOct1.BackColor = ColorTranslator.FromHtml("#E6F8E7");
            this.txtBoxMasOct2.BackColor = ColorTranslator.FromHtml("#E6F8E7");
            this.txtBoxMasOct3.BackColor = ColorTranslator.FromHtml("#E6F8E7");
            this.txtBoxMasOct4.BackColor = ColorTranslator.FromHtml("#E6F8E7");

            // ─────────────────────────────────────────────
            // 🎨 Bouton Valider
            // ─────────────────────────────────────────────
            this.btnValider.BackColor = ColorTranslator.FromHtml("#CFE2FF");
            this.btnValider.FlatStyle = FlatStyle.Flat;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#BBD4FF");

            // ─────────────────────────────────────────────
            // 🎨 Bloc Résultats
            // ─────────────────────────────────────────────
            this.pnlResultats.BackColor = ColorTranslator.FromHtml("#FFF8D9");
            this.lblResultatsTitle.ForeColor = Color.Black;

            this.TxtBox_Reseau.BackColor = Color.White;
            this.TxtBox_PremIP.BackColor = Color.White;
            this.TxtBox_DernIP.BackColor = Color.White;
            this.TxtBox_Broadcast.BackColor = Color.White;

            // ─────────────────────────────────────────────
            // 🎨 Classes A/B/C/D pastel
            // ─────────────────────────────────────────────
            this.pnlClasseA.BackColor = Color.White;
            this.pnlClasseB.BackColor = Color.White;
            this.pnlClasseC.BackColor = Color.White;
            this.pnlClasseD.BackColor = Color.White;

            this.lblClasseA.ForeColor = Color.Black;
            this.lblClasseB.ForeColor = Color.Black;
            this.lblClasseC.ForeColor = Color.Black;
            this.lblClasseD.ForeColor = Color.Black;

            // ─────────────────────────────────────────────
            // 🎨 Cercles IPs / Machines
            // ─────────────────────────────────────────────
            this.circleIPs.BackColor = ColorTranslator.FromHtml("#CFF9D9");
            this.circleMachines.BackColor = ColorTranslator.FromHtml("#CFF9D9");

            // ════════════════════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════════════════════
            this.Text = "Calculateur masque réseau";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MinimumSize = new System.Drawing.Size(940, 650);

            // ════════════════════════════════════════════════════════════
            // BARRE DE TITRE
            // ════════════════════════════════════════════════════════════
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(229, 229, 229);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Height = 28;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarreTitre_MouseDown);

            this.lblTitle.Text = "Calculateur masque réseau";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            // Boutons (avec tes symboles)
            ConfigTitleBtn(this.btnMinimize, "–", 0);
            ConfigTitleBtn(this.btnMaximize, "□", 25);
            ConfigTitleBtn(this.btnClose, "✕", 50);

            // Actions
            this.btnMinimize.Click += (s, ev) => this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.btnMaximize.Click += (s, ev) => this.WindowState =
                (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
                ? System.Windows.Forms.FormWindowState.Normal
                : System.Windows.Forms.FormWindowState.Maximized;
            this.btnClose.Click += (s, ev) => this.Close();

            // Effets hover
            this.btnMinimize.MouseEnter += (s, e) => this.btnMinimize.BackColor = Color.FromArgb(230, 230, 230);
            this.btnMinimize.MouseLeave += (s, e) => this.btnMinimize.BackColor = Color.Transparent;

            this.btnMaximize.MouseEnter += (s, e) => this.btnMaximize.BackColor = Color.FromArgb(230, 230, 230);
            this.btnMaximize.MouseLeave += (s, e) => this.btnMaximize.BackColor = Color.Transparent;

            this.btnClose.MouseEnter += (s, e) => {
                this.btnClose.BackColor = Color.FromArgb(232, 17, 35);
                this.btnClose.ForeColor = Color.White;
            };
            this.btnClose.MouseLeave += (s, e) => {
                this.btnClose.BackColor = Color.Transparent;
                this.btnClose.ForeColor = Color.Black;
            };

            // Ajout dans la barre
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnClose);




            // ════════════════════════════════════════════════════════════
            // PANEL SCROLLABLE
            // ════════════════════════════════════════════════════════════
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Padding = new System.Windows.Forms.Padding(0);

            // ════════════════════════════════════════════════════════════
            // BLOC ADRESSE IP
            // ════════════════════════════════════════════════════════════
            this.pnlIP.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.pnlIP.BorderRadius = 10;
            this.pnlIP.Location = new System.Drawing.Point(20, 15);
            this.pnlIP.Size = new System.Drawing.Size(880, 120);
            this.pnlIP.Anchor = AnchorLeft;

            int[] xCols = { 20, 235, 450, 665 };
            int boxW = 190;
            var decLabels = new[] { lblOct1, lblOct2, lblOct3, lblOct4 };
            var decBoxes = new[] { txtBoxOct1, txtBoxOct2, txtBoxOct3, txtBoxOct4 };
            var binBoxes = new[] { txtBoxBinOct1, txtBoxBinOct2, txtBoxBinOct3, txtBoxBinOct4 };
            string[] octNames = { "Octet 1", "Octet 2", "Octet 3", "Octet 4" };

            for (int i = 0; i < 4; i++)
            {
                // Label octet
                decLabels[i].Text = octNames[i];
                decLabels[i].Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
                decLabels[i].AutoSize = true;
                decLabels[i].Location = new System.Drawing.Point(xCols[i], 18);
                this.pnlIP.Controls.Add(decLabels[i]);

                // TextBox décimal
                decBoxes[i].Location = new System.Drawing.Point(xCols[i], 36);
                decBoxes[i].Size = new System.Drawing.Size(boxW, 26);
                decBoxes[i].MaxLength = 3;
                decBoxes[i].Font = new System.Drawing.Font("Segoe UI", 9f);
                decBoxes[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                decBoxes[i].KeyPress += OnlyNumbers_KeyPress;
                this.pnlIP.Controls.Add(decBoxes[i]);

                // TextBox binaire
                binBoxes[i].Location = new System.Drawing.Point(xCols[i], 82);
                binBoxes[i].Size = new System.Drawing.Size(boxW, 26);
                binBoxes[i].MaxLength = 8;
                binBoxes[i].Font = new System.Drawing.Font("Segoe UI", 9f);
                binBoxes[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                binBoxes[i].KeyPress += Only01_KeyPress;
                this.pnlIP.Controls.Add(binBoxes[i]);
            }

            // Label "Binaire" (sous Octet 1)
            this.lblBin1.Text = "Binaire";
            this.lblBin1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblBin1.AutoSize = true;
            this.lblBin1.Location = new System.Drawing.Point(xCols[0], 65);
            this.pnlIP.Controls.Add(this.lblBin1);

            // ════════════════════════════════════════════════════════════
            // BLOC MASQUE RÉSEAU
            // ════════════════════════════════════════════════════════════
            this.pnlMasque.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.pnlMasque.BorderRadius = 10;
            this.pnlMasque.Location = new System.Drawing.Point(20, 172);
            this.pnlMasque.Size = new System.Drawing.Size(880, 72);
            this.pnlMasque.Anchor = AnchorLeft;

            // ── CIDR : boîte "/" + champ fusionnés ──────────────────────
            // On crée un panel qui simule un champ unique avec "/" à gauche
            var pnlCIDR = new RoundedPanel();
            pnlCIDR.BackColor = System.Drawing.Color.White;
            pnlCIDR.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            pnlCIDR.BorderRadius = 6;
            pnlCIDR.Size = new System.Drawing.Size(80, 28);
            pnlCIDR.Location = new System.Drawing.Point(18, 30);

            // Label "/" à l'intérieur du panel fusionné
            var lblSlashInner = new System.Windows.Forms.Label();
            lblSlashInner.Text = "/";
            lblSlashInner.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            lblSlashInner.AutoSize = false;
            lblSlashInner.Size = new System.Drawing.Size(20, 24);
            lblSlashInner.Location = new System.Drawing.Point(4, 2);
            lblSlashInner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblSlashInner.BackColor = System.Drawing.Color.White;
            pnlCIDR.Controls.Add(lblSlashInner);

            // TextBox CIDR sans bordure visible (la bordure est celle du panel)
            var innerCIDR = new System.Windows.Forms.TextBox();
            innerCIDR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            innerCIDR.Location = new System.Drawing.Point(24, 5);
            innerCIDR.Size = new System.Drawing.Size(48, 18);
            innerCIDR.MaxLength = 2;
            innerCIDR.Font = new System.Drawing.Font("Segoe UI", 9f);
            innerCIDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            innerCIDR.BackColor = System.Drawing.Color.White;
            innerCIDR.KeyPress += OnlyNumbers_KeyPress;
            pnlCIDR.Controls.Add(innerCIDR);

            // Relier les events de txtBoxCIDR (RoundedTextBox) vers innerCIDR
            // On remplace l'usage de txtBoxCIDR par innerCIDR via un pont
            innerCIDR.TextChanged += (s, ev) =>
            {
                txtBoxCIDR.Text = innerCIDR.Text;
                TxtBoxCIDR_TextChanged(s, ev);
                // Sync retour si la valeur a été modifiée par la validation
                if (innerCIDR.Text != txtBoxCIDR.Text)
                    innerCIDR.Text = txtBoxCIDR.Text;
            };
            txtBoxCIDR.TextChanged += (s, ev) =>
            {
                if (innerCIDR.Text != txtBoxCIDR.Text)
                    innerCIDR.Text = txtBoxCIDR.Text;
            };

            this.pnlMasque.Controls.Add(pnlCIDR);

            // Label "CIDR" au-dessus de la boîte fusionnée
            this.lblCIDR.Text = "CIDR";
            this.lblCIDR.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblCIDR.AutoSize = true;
            this.lblCIDR.Location = new System.Drawing.Point(18, 10);
            this.pnlMasque.Controls.Add(this.lblCIDR);

            // On garde lblSlash et txtBoxCIDR déclarés mais invisibles
            // (ils servent de pont de données)
            this.lblSlash.Visible = false;
            this.txtBoxCIDR.Visible = false;
            this.txtBoxCIDR.Location = new System.Drawing.Point(-200, -200);
            this.pnlMasque.Controls.Add(this.lblSlash);
            this.pnlMasque.Controls.Add(this.txtBoxCIDR);

            this.lblOR.Text = "OR";
            this.lblOR.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(112, 28);
            this.pnlMasque.Controls.Add(this.lblOR);

            this.lblStandard.Text = "Standard ( 4 octets )";
            this.lblStandard.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(175, 10);
            this.pnlMasque.Controls.Add(this.lblStandard);

            // 4 textboxes masque : répartition uniforme avec marge à droite
            // Panel width = 880, zone utilisable après "OR" = de x=175 à x=858 (marge 22px)
            // 4 boîtes × 158px + 3 espaces × 5px = 632 + 15 = 647 → fits
            var masBoxes = new[] { txtBoxMasOct1, txtBoxMasOct2, txtBoxMasOct3, txtBoxMasOct4 };
            int masStartX = 175;
            int masBoxW = 158;
            int masGap = 8;
            for (int i = 0; i < 4; i++)
            {
                masBoxes[i].Location = new System.Drawing.Point(masStartX + i * (masBoxW + masGap), 30);
                masBoxes[i].Size = new System.Drawing.Size(masBoxW, 26);
                masBoxes[i].MaxLength = 3;
                masBoxes[i].Font = new System.Drawing.Font("Segoe UI", 9f);
                masBoxes[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                masBoxes[i].KeyPress += OnlyNumbers_KeyPress;
                this.pnlMasque.Controls.Add(masBoxes[i]);
            }

            // ════════════════════════════════════════════════════════════
            // BOUTON VALIDER
            // ════════════════════════════════════════════════════════════
            this.btnValider.Text = "Valider";
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.btnValider.Location = new System.Drawing.Point(20, 258);
            this.btnValider.Size = new System.Drawing.Size(880, 40);
            this.btnValider.Anchor = AnchorLeft;
            this.btnValider.BackColor = System.Drawing.Color.White;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnValider.FlatAppearance.BorderSize = 2;
            this.btnValider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(229, 229, 229);
            this.btnValider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Click += new System.EventHandler(this.Btn_Valider_Click);

            // ════════════════════════════════════════════════════════════
            // BOUTON RESET
            // ════════════════════════════════════════════════════════════
            this.btnReset.Text = "Réinitialiser";
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.btnReset.Location = new System.Drawing.Point(20, 304);
            this.btnReset.Size = new System.Drawing.Size(880, 32);
            this.btnReset.Anchor = AnchorLeft;
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 80, 80);
            this.btnReset.FlatAppearance.BorderSize = 1;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Click += new System.EventHandler(this.Btn_Reset_Click);


            // Coins arrondis sur le bouton via Region
            this.btnValider.Paint += (s, ev) =>
            {
                var btn = (System.Windows.Forms.Button)s;
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                int r2 = 10;
                gp.AddArc(0, 0, r2 * 2, r2 * 2, 180, 90);
                gp.AddArc(btn.Width - r2 * 2, 0, r2 * 2, r2 * 2, 270, 90);
                gp.AddArc(btn.Width - r2 * 2, btn.Height - r2 * 2, r2 * 2, r2 * 2, 0, 90);
                gp.AddArc(0, btn.Height - r2 * 2, r2 * 2, r2 * 2, 90, 90);
                gp.CloseFigure();
                btn.Region = new System.Drawing.Region(gp);
            };

            // ════════════════════════════════════════════════════════════
            // BLOC RÉSULTATS
            // ════════════════════════════════════════════════════════════
            this.pnlResultats.BorderColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.pnlResultats.BorderRadius = 10;
            this.pnlResultats.Location = new System.Drawing.Point(20, 352);
            this.pnlResultats.Size = new System.Drawing.Size(880, 320);
            this.pnlResultats.Anchor = AnchorLeft;
            this.pnlResultats.Paint += PnlResultats_Paint;


            // @ Réseau
            this.lblReseau.Text = "@ Réseau";
            this.lblReseau.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblReseau.AutoSize = true;
            this.lblReseau.Location = new System.Drawing.Point(20, 28);
            this.pnlResultats.Controls.Add(this.lblReseau);

            SetResultBox(this.TxtBox_Reseau, 220, 26, 210, 28);
            this.pnlResultats.Controls.Add(this.TxtBox_Reseau);

            // Première IP
            this.lblPremIP.Text = "Première IP";
            this.lblPremIP.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblPremIP.AutoSize = true;
            this.lblPremIP.Location = new System.Drawing.Point(85, 90);
            this.pnlResultats.Controls.Add(this.lblPremIP);

            SetResultBox(this.TxtBox_PremIP, 220, 88, 210, 24);
            this.pnlResultats.Controls.Add(this.TxtBox_PremIP);

            // Points de suspension
            for (int i = 0; i < 3; i++)
            {
                var dot = new System.Windows.Forms.Label();
                dot.Text = "•";
                dot.Font = new System.Drawing.Font("Segoe UI", 9f);
                dot.AutoSize = true;
                dot.Location = new System.Drawing.Point(148, 118 + i * 14);
                this.pnlResultats.Controls.Add(dot);
            }

            // Dernière IP
            this.lblDernIP.Text = "Dernière IP";
            this.lblDernIP.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblDernIP.AutoSize = true;
            this.lblDernIP.Location = new System.Drawing.Point(85, 158);
            this.pnlResultats.Controls.Add(this.lblDernIP);

            SetResultBox(this.TxtBox_DernIP, 220, 156, 210, 24);
            this.pnlResultats.Controls.Add(this.TxtBox_DernIP);

            // @ Broadcast
            this.lblBroadcast.Text = "@ Broadcast";
            this.lblBroadcast.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblBroadcast.AutoSize = true;
            this.lblBroadcast.Location = new System.Drawing.Point(20, 210);
            this.pnlResultats.Controls.Add(this.lblBroadcast);

            SetResultBox(this.TxtBox_Broadcast, 220, 208, 210, 28);
            this.pnlResultats.Controls.Add(this.TxtBox_Broadcast);

            // ── Classes A/B/C/D empilées colorées ───────────────────────
            this.lblClasse.Text = "Classe";
            this.lblClasse.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(500, 15);
            this.pnlResultats.Controls.Add(this.lblClasse);

            // Couleurs de base (état non-sélectionné) : tons pastel chauds
            // A=saumon clair, B=pêche, C=crème, D=blanc → comme l'image de référence
            System.Drawing.Color[] classeBaseColors = {
                Color.White,
                Color.White,
                Color.White,
                Color.White,
            };


            var classePanels = new[] { pnlClasseA, pnlClasseB, pnlClasseC, pnlClasseD };
            var classeLabels = new[] { lblClasseA, lblClasseB, lblClasseC, lblClasseD };
            string[] classeNoms = { "A", "B", "C", "D" };

            // Géométrie : 4 boîtes de 100×60px jointives, contour commun arrondi
            // On dessine un contour externe arrondi uniquement pour A (top) et D (bottom)
            // mais tous ont une bordure noire pleine de 2px pour rester visibles.
            int cX = 490, cY = 42, cW = 108, cH = 58;

            for (int i = 0; i < 4; i++)
            {
                // Boîtes A / B / C / D collées avec bordure 2px
                classePanels[i].BackColor = classeBaseColors[i];
                classePanels[i].BorderColor = Color.Black;
                classePanels[i].BorderRadius = 0; // PAS D'ARRONDI

                classePanels[i].Size = new Size(cW, cH);

                // Positionnement collé (fusion bordures)
                // Chaque panel descend de cH mais remonte de 2px * i
                classePanels[i].Location = new Point(cX, cY + i * cH - (i * 2));

                // Label
                classeLabels[i].Text = classeNoms[i];
                classeLabels[i].Font = new Font("Segoe UI", 18f, FontStyle.Bold);
                classeLabels[i].AutoSize = false;
                classeLabels[i].Size = new Size(cW, cH);
                classeLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                classeLabels[i].BackColor = Color.Transparent;

                classePanels[i].Controls.Add(classeLabels[i]);
                this.pnlResultats.Controls.Add(classePanels[i]);


            }

            // ── Cercles IPs / Machines ────────────────────────────────────
            this.circleIPs.Size = new System.Drawing.Size(120, 120);
            this.circleIPs.Location = new System.Drawing.Point(640, 20);
            this.circleIPs.BackColor = System.Drawing.Color.Transparent;

            this.circleMachines.Size = new System.Drawing.Size(120, 120);
            this.circleMachines.Location = new System.Drawing.Point(640, 175);
            this.circleMachines.BackColor = System.Drawing.Color.Transparent;

            // Label nb IPs
            this.TxtNbIPs.Text = "—";
            this.TxtNbIPs.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.TxtNbIPs.ForeColor = Color.FromArgb(30, 30, 30);
            this.TxtNbIPs.AutoSize = false;
            this.TxtNbIPs.Size = new System.Drawing.Size(120, 30);
            this.TxtNbIPs.Location = new System.Drawing.Point(0, 35);
            this.TxtNbIPs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.circleIPs.Controls.Add(this.TxtNbIPs);

            var lblIPsUnit = new System.Windows.Forms.Label();
            lblIPsUnit.Text = "IPs";
            lblIPsUnit.ForeColor = System.Drawing.Color.White;
            lblIPsUnit.Font = new System.Drawing.Font("Segoe UI", 8f);
            lblIPsUnit.AutoSize = false;
            lblIPsUnit.Size = new System.Drawing.Size(120, 18);
            lblIPsUnit.Location = new System.Drawing.Point(0, 65);
            lblIPsUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.circleIPs.Controls.Add(lblIPsUnit);

            // Label nb Machines
            this.TxtNbMachines.Text = "—";
            this.TxtNbMachines.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.TxtNbMachines.ForeColor = Color.FromArgb(30, 30, 30);
            this.TxtNbMachines.AutoSize = false;
            this.TxtNbMachines.Size = new System.Drawing.Size(120, 30);
            this.TxtNbMachines.Location = new System.Drawing.Point(0, 35);
            this.TxtNbMachines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.circleMachines.Controls.Add(this.TxtNbMachines);

            var lblMachUnit = new System.Windows.Forms.Label();
            lblMachUnit.Text = "Machines";
            lblMachUnit.ForeColor = System.Drawing.Color.White;
            lblMachUnit.Font = new System.Drawing.Font("Segoe UI", 8f);
            lblMachUnit.AutoSize = false;
            lblMachUnit.Size = new System.Drawing.Size(120, 18);
            lblMachUnit.Location = new System.Drawing.Point(0, 65);
            lblMachUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.circleMachines.Controls.Add(lblMachUnit);

            this.pnlResultats.Controls.Add(this.circleIPs);
            this.pnlResultats.Controls.Add(this.circleMachines);

            // ════════════════════════════════════════════════════════════
            // LABELS "FLOTTANTS" — titres sur les bordures des blocs
            //
            // Principe : on les ajoute dans pnlScroll APRÈS les panels,
            // et on les positionne exactement à cheval sur la bordure haut.
            // Fond blanc + padding pour "gommer" la bordure derrière le texte.
            // ════════════════════════════════════════════════════════════

            // Titre "Adresse IP"
            this.lblIPTitle.Text = "  Adresse IP  ";
            this.lblIPTitle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblIPTitle.BackColor = System.Drawing.Color.White;
            this.lblIPTitle.AutoSize = true;
            // Y = top du panel − demi-hauteur du label → chevauchement exact
            // On place en dur ; la valeur finale est ajustée après ResumeLayout
            this.lblIPTitle.Location = new System.Drawing.Point(35, 20);

            // Titre "Masque Réseau"
            this.lblMasqueTitle.Text = "  Masque Réseau  ";
            this.lblMasqueTitle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblMasqueTitle.BackColor = System.Drawing.Color.White;
            this.lblMasqueTitle.AutoSize = true;
            this.lblMasqueTitle.Location = new System.Drawing.Point(35, 162);

            // Titre "Résultats"
            this.lblResultatsTitle.Text = "  Résultats  ";
            this.lblResultatsTitle.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.lblResultatsTitle.BackColor = System.Drawing.Color.White;
            this.lblResultatsTitle.AutoSize = true;
            this.lblResultatsTitle.Location = new System.Drawing.Point(35, 342);

            // ════════════════════════════════════════════════════════════
            // ASSEMBLAGE dans pnlScroll
            // Ordre impératif : panels d'abord, puis labels flottants
            // (WinForms Z-order = ordre d'ajout inversé, ou BringToFront)
            // ════════════════════════════════════════════════════════════
            this.pnlScroll.Controls.Add(this.pnlResultats);
            this.pnlScroll.Controls.Add(this.btnValider);
            this.pnlScroll.Controls.Add(this.btnReset);
            this.pnlScroll.Controls.Add(this.pnlMasque);
            this.pnlScroll.Controls.Add(this.pnlIP);

            // Labels flottants ajoutés en dernier → Z-order le plus haut
            this.pnlScroll.Controls.Add(this.lblResultatsTitle);
            this.pnlScroll.Controls.Add(this.lblMasqueTitle);
            this.pnlScroll.Controls.Add(this.lblIPTitle);

            // S'assurer qu'ils sont vraiment au premier plan
            this.lblIPTitle.BringToFront();
            this.lblMasqueTitle.BringToFront();
            this.lblResultatsTitle.BringToFront();

            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.pnlTitleBar);

            // ── Auto-focus entre champs ──────────────────────────────────
            txtBoxOct1.TextChanged += (s, ev) => { if (txtBoxOct1.Text.Length == 3) txtBoxOct2.Controls[0].Focus(); };
            txtBoxOct2.TextChanged += (s, ev) => { if (txtBoxOct2.Text.Length == 3) txtBoxOct3.Controls[0].Focus(); };
            txtBoxOct3.TextChanged += (s, ev) => { if (txtBoxOct3.Text.Length == 3) txtBoxOct4.Controls[0].Focus(); };
            txtBoxBinOct1.TextChanged += (s, ev) => { if (txtBoxBinOct1.Text.Length == 8) txtBoxBinOct2.Controls[0].Focus(); };
            txtBoxBinOct2.TextChanged += (s, ev) => { if (txtBoxBinOct2.Text.Length == 8) txtBoxBinOct3.Controls[0].Focus(); };
            txtBoxBinOct3.TextChanged += (s, ev) => { if (txtBoxBinOct3.Text.Length == 8) txtBoxBinOct4.Controls[0].Focus(); };
            txtBoxMasOct1.TextChanged += (s, ev) => { if (txtBoxMasOct1.Text.Length == 3) txtBoxMasOct2.Controls[0].Focus(); };
            txtBoxMasOct2.TextChanged += (s, ev) => { if (txtBoxMasOct2.Text.Length == 3) txtBoxMasOct3.Controls[0].Focus(); };
            txtBoxMasOct3.TextChanged += (s, ev) => { if (txtBoxMasOct3.Text.Length == 3) txtBoxMasOct4.Controls[0].Focus(); };

            this.ResumeLayout(false);

            // Ajustement des labels flottants via Load pour garantir que
            // le layout est complet (panels ont leur taille définitive)
            this.Load += (s, ev) =>
            {
                AdjustFloatingLabel(this.lblIPTitle, this.pnlIP);
                AdjustFloatingLabel(this.lblMasqueTitle, this.pnlMasque);
                AdjustFloatingLabel(this.lblResultatsTitle, this.pnlResultats);
                this.lblIPTitle.BringToFront();
                this.lblMasqueTitle.BringToFront();
                this.lblResultatsTitle.BringToFront();
            };
        }

        /// <summary>
        /// Replace le label flottant exactement à cheval sur la bordure supérieure du panel.
        /// </summary>
        private void AdjustFloatingLabel(System.Windows.Forms.Label lbl, System.Windows.Forms.Control panel)
        {
            int labelH = lbl.PreferredHeight;
            lbl.Location = new System.Drawing.Point(
                panel.Left + 15,
                panel.Top - labelH / 2);
        }

        // ── Ligne pointillée verticale dans le bloc Résultats ───────────
        private void PnlResultats_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(80, 80, 80), 2))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(pen, 75, 55, 75, 240);
                e.Graphics.DrawLine(pen, 75, 100, 220, 100);
                e.Graphics.DrawLine(pen, 75, 168, 220, 168);
            }
        }

        // ── Helpers ─────────────────────────────────────────────────────
        private static readonly System.Windows.Forms.AnchorStyles AnchorLeft =
            System.Windows.Forms.AnchorStyles.Top |
            System.Windows.Forms.AnchorStyles.Left;

        private void ConfigTitleBtn(Button btn, string text, int offsetX)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Black;
            btn.Size = new Size(45, 28);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Cursor = Cursors.Hand;

            // Le bouton se colle automatiquement à droite
            btn.Dock = DockStyle.Right;
        }




        private void SetResultBox(RoundedTextBox tb, int x, int y, int w, int h)
        {
            tb.Location = new System.Drawing.Point(x, y);
            tb.Size = new System.Drawing.Size(w, h);
            tb.ReadOnly = true;
            tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            tb.Font = new System.Drawing.Font("Segoe UI", 10f);
        }

        // ── Champs membres ───────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMinimize, btnMaximize, btnClose;
        private System.Windows.Forms.Panel pnlScroll;

        private RoundedPanel pnlIP;
        private System.Windows.Forms.Label lblIPTitle;
        private System.Windows.Forms.Label lblOct1, lblOct2, lblOct3, lblOct4, lblBin1;
        private RoundedTextBox txtBoxOct1, txtBoxOct2, txtBoxOct3, txtBoxOct4;
        private RoundedTextBox txtBoxBinOct1, txtBoxBinOct2, txtBoxBinOct3, txtBoxBinOct4;

        private RoundedPanel pnlMasque;
        private System.Windows.Forms.Label lblMasqueTitle, lblCIDR, lblSlash, lblOR, lblStandard;
        private RoundedTextBox txtBoxCIDR;
        private RoundedTextBox txtBoxMasOct1, txtBoxMasOct2, txtBoxMasOct3, txtBoxMasOct4;

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnReset;

        private RoundedPanel pnlResultats;
        private System.Windows.Forms.Label lblResultatsTitle;
        private System.Windows.Forms.Label lblReseau, lblPremIP, lblDernIP, lblBroadcast;
        private RoundedTextBox TxtBox_Reseau, TxtBox_PremIP, TxtBox_DernIP, TxtBox_Broadcast;
        private System.Windows.Forms.Label lblClasse;
        private RoundedPanel pnlClasseA, pnlClasseB, pnlClasseC, pnlClasseD;
        private System.Windows.Forms.Label lblClasseA, lblClasseB, lblClasseC, lblClasseD;
        private System.Windows.Forms.Label TxtNbIPs, TxtNbMachines;
        private CirclePanel circleIPs, circleMachines;

        #endregion
    }
}
