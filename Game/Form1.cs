namespace Game
{
    public partial class Form1 : Form
    {
        Button[] kartlar = new Button[8];
        Color[] renkler = new Color[8];
        bool[] tapilib = new bool[8];
        Random rnd = new Random();

        int xal = 0;
        int birinci = -1;
        int ikinci = -1;
        bool gozle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kartlar[0] = kart1;
            kartlar[1] = kart2;
            kartlar[2] = kart3;
            kartlar[3] = kart4;
            kartlar[4] = kart5;
            kartlar[5] = kart6;
            kartlar[6] = kart7;
            kartlar[7] = kart8;

            yeniOyun();
        }

        private void yeniOyun()
        {
            timer1.Stop();
            xal = 0;
            birinci = -1;
            ikinci = -1;
            gozle = false;
            lblXal.Text = "Xal: 0";
            lblNetice.Text = "";

            Color[] secim = { Color.Red, Color.Red, Color.Blue, Color.Blue,
                              Color.Green, Color.Green, Color.Yellow, Color.Yellow };

            for (int i = secim.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Color temp = secim[i];
                secim[i] = secim[j];
                secim[j] = temp;
            }

            for (int i = 0; i < 8; i++)
            {
                renkler[i] = secim[i];
                tapilib[i] = false;
                kartlar[i].BackColor = Color.Gainsboro;
            }
        }

        private void kart_Click(object sender, EventArgs e)
        {
            if (gozle)
                return;

            Button b = (Button)sender;
            int index = Array.IndexOf(kartlar, b);

            if (tapilib[index] || index == birinci)
                return;

            b.BackColor = renkler[index];

            if (birinci == -1)
            {
                birinci = index;
                lblNetice.Text = "";
                return;
            }

            ikinci = index;

            if (renkler[birinci] == renkler[ikinci])
            {
                tapilib[birinci] = true;
                tapilib[ikinci] = true;
                xal++;
                lblXal.Text = "Xal: " + xal;
                lblNetice.Text = "✅";
                birinci = -1;
                ikinci = -1;

                bool hamisi = true;
                foreach (bool t in tapilib)
                {
                    if (!t)
                        hamisi = false;
                }

                if (hamisi)
                    MessageBox.Show("Oyun bitdi! Xal: " + xal);
            }
            else
            {
                lblNetice.Text = "❌";
                gozle = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            kartlar[birinci].BackColor = Color.Gainsboro;
            kartlar[ikinci].BackColor = Color.Gainsboro;
            birinci = -1;
            ikinci = -1;
            gozle = false;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            yeniOyun();
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}