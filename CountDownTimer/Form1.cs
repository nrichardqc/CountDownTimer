using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CountDownTimer
{
    public partial class frmPrincipal : Form
    {
        private Timer   m_Timer;
        private int     m_Remainging = 0;

        private const String PAUSE  = "Pause";
        private const String RESUME = "Resume";


        public frmPrincipal()
        {
            InitializeComponent();

            btnPause.Text = PAUSE;

            m_Timer = new Timer();
            m_Timer.Tick += new EventHandler(TimerEventProcessor);
            m_Timer.Interval = 1000;
        }

        private void TimerEventProcessor(Object myObject,
                                        EventArgs myEventArgs)
        {
            m_Remainging -=  m_Timer.Interval;
            RefreshUI();

            if (m_Remainging == 0)
            {
                using (Stream bellSound = Properties.Resources.bell)
                {
                    new SoundPlayer(bellSound).Play();
                }
            }
        }

        private void RefreshUI()
        {
            int absRemaining = Math.Abs(m_Remainging);
            lblRemaining.Text = String.Format("{0}:{1:D2}", absRemaining / 60000, (absRemaining % 60000) / 1000);

            if (m_Remainging > 0)
            {
                lblRemaining.ForeColor = Color.Black;
            }
            else
            {
                lblRemaining.ForeColor = Color.Red;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPause.Text = PAUSE;
            m_Remainging = Convert.ToInt32(spnMinutes.Value) * 60 * 1000;
            RefreshUI();
            m_Timer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text.Equals(PAUSE))
            {
                m_Timer.Stop();
                btnPause.Text = RESUME;
            }
            else
            {
                m_Timer.Start();
                btnPause.Text = PAUSE;
            }
        }
    }
}
