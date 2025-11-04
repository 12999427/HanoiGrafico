namespace HanoiGrafico
{
    public partial class Form1 : Form
    {
        const int AltezzaDisco = 28;
        public Form1()
        {
            InitializeComponent();
            int NUMDISCHI = 5;
            pnl_Torre1.SendToBack();
            pnl_Torre2.SendToBack();
            pnl_Torre3.SendToBack();
            List<Panel> dischi = CreaDischi(NUMDISCHI);
            pnl_Canvas.Controls.AddRange(dischi.ToArray());

            List<(char Da, char A)> passaggi = new();
            int numMinimoPassaggi = RisolutoreHanoi.Hanoi(5, 'A', 'C', 'B', passaggi);

            System.Timers.Timer animTimer = new (2000);
            animTimer.Elapsed += OnTimedEvent;
            animTimer.Enabled = true;

        }

        public void OnTimedEvent (object sender, EventArgs ea)
        {
            MessageBox.Show("ciao");
        }

        public Point GetLocation(int x, int y, int width)
        {
            Point colLocation;
            switch (x)
            {
                case 0:
                    colLocation = pnl_Torre1.Location;
                    break;
                case 1:
                    colLocation = pnl_Torre2.Location;
                    break;
                case 2:
                    colLocation = pnl_Torre3.Location;
                    break;
                default:
                    throw new ArgumentException();
            }
            colLocation.X += pnl_Torre1.Width / 2;

            colLocation.Y += pnl_Torre1.Height / 2;

            return new Point(colLocation.X - width/2, colLocation.Y + y*AltezzaDisco);
        }

        public List<Panel> CreaDischi(int n)
        {
            Random random = new(Environment.TickCount);

            List<Panel> panels = new();
            for (int i = 0; i < n; i++)
            {
                int w = 50 + i * 27;
                panels.Add(new Panel
                {
                    Width = w,
                    BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)),
                    Height = AltezzaDisco,
                    Location = GetLocation(0, i, w),
                });
                panels[^1].BringToFront();
            }

            return panels;
        }
    }
}