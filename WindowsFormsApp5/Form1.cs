using System;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        public int h, m, s, ms;

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            saatLbl.Text = "00:00:00:00";
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                ms += 1;
                if(ms == 100)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                saatLbl.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));

            }));

        }
    }
}
