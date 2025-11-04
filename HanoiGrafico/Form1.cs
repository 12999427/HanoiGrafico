namespace HanoiGrafico
{
    public partial class Form1 : Form
    {
        const int AltezzaDisco = 28;
        int AnimIndex;
        System.Windows.Forms.Timer animTimer;
        List<(char Da, char A)> passaggi;
        List<Panel> dischi;
        int NUMDISCHI;

        public Form1()
        {
            InitializeComponent();

            using (AskIndex ask = new AskIndex())
            {
                if (ask.ShowDialog() == DialogResult.OK)
                {
                    NUMDISCHI = ask.num;
                }
                else
                {
                    NUMDISCHI = 10;
                }
            }

            dischi = CreaDischi(NUMDISCHI);
            pnl_Canvas.Controls.AddRange(dischi.ToArray());

            foreach (var disco in dischi)
                disco.BringToFront();

            passaggi = new();
            int numMinimoPassaggi = RisolutoreHanoi.Hanoi(NUMDISCHI, 'A', 'C', 'B', passaggi);

            //MessageBox.Show($"{numMinimoPassaggi} - {passaggi.Count}");

            animTimer = new System.Windows.Forms.Timer();
            animTimer.Interval = 1300;
            animTimer.Tick += OnTimedEvent;
            animTimer.Enabled = true;

            AnimIndex = 0;
        }

        private void OnTimedEvent(object? sender, EventArgs e)
        {
            if (AnimIndex >= passaggi.Count)
            {
                animTimer.Stop();
                MessageBox.Show("Fatto");
                return;
            }

            var passaggio = passaggi[AnimIndex++];

            lbl_Step.Text = AnimIndex.ToString();

            int torreDa = passaggio.Da - 'A';
            int torreA = passaggio.A - 'A';

            Panel? discoDaMuovere = null;
            int maxY = -1;

            foreach (var panel in dischi)
            {
                if (panel.Tag is (int torre, int altezza) && torre == torreDa)
                {
                    if (altezza > maxY)
                    {
                        maxY = altezza;
                        discoDaMuovere = panel;
                    }
                }
            }

            int altezzaDestinazione = -1;

            foreach (var panel in dischi)
            {
                if (panel.Tag is (int torre, int altezza) && torre == torreA)
                {
                    if (altezza > altezzaDestinazione)
                        altezzaDestinazione = altezza;
                }
            }

            int nuovaAltezza = altezzaDestinazione + 1;
            
            // Aggiorna disco
            discoDaMuovere.Tag = (torreA, nuovaAltezza);
            discoDaMuovere.Location = GetLocation(torreA, nuovaAltezza, discoDaMuovere.Width);
            discoDaMuovere.BringToFront();
        }

        private Point GetLocation(int torre, int livello, int width)
        {
            Point baseLocation;
            switch (torre)
            {
                case 0: baseLocation = pnl_Torre1.Location; break;
                case 1: baseLocation = pnl_Torre2.Location; break;
                case 2: baseLocation = pnl_Torre3.Location; break;
                default: throw new ArgumentException();
            }

            baseLocation.X += pnl_Torre1.Width / 2;
            baseLocation.Y += pnl_Torre1.Height;

            return new Point(baseLocation.X - width / 2, baseLocation.Y - (livello + 1) * AltezzaDisco);
        }

        private List<Panel> CreaDischi(int n)
        {
            if (n < 1)
                throw new ArgumentException();

            Random random = new(Environment.TickCount);
            List<Panel> panels = new();

            for (int i = 0; i < n; i++)
            {
                int w = 50 + (n - i - 1) * 27; // disco più grande in basso
                panels.Add(new Panel
                {
                    Width = w,
                    Height = AltezzaDisco,
                    BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                });

                int torre = 0;
                int livello = i;
                panels[^1].Location = GetLocation(torre, livello, w);
                panels[^1].Tag = (torre, livello);
                panels[^1].BringToFront();
            }

            return panels;
        }
    }
}
