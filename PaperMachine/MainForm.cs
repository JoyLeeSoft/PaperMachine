using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PaperMachine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        struct PaperingData
        {
            public string str;
            public int num;
            public int time;
        }

        private bool m_IsThrdRunning;

        private void Papering(object p)
        {
            PaperingData pd = (PaperingData)p;

            for (int i = 0; i < pd.num && m_IsThrdRunning == true; i++)
            {
                foreach (var ch in pd.str)
                    SendKeys.SendWait(ch.ToString());

                SendKeys.SendWait("{ENTER}");

                Invoke((MethodInvoker)delegate()
                {
                    label_Info.Text = string.Format("Papering... {0}", i);
                });
                Thread.Sleep(pd.time);
            }

            Invoke((MethodInvoker)delegate()
            {
                label_Info.Text = "Done!";
                button_Start.Enabled = true;
                button_Stop.Enabled = false;
            });

            m_IsThrdRunning = false;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Enabled = false;

            PaperingData p = new PaperingData();
            p.str = textBox_Input.Text;

            try
            {
                p.num = Convert.ToInt32(textBox_InputNum.Text);
                p.time = Convert.ToInt32(textBox_InputTime.Text);

                if (p.time == 0)
                {
                    MessageBox.Show("Sleep time cannot to be 0");
                    button_Start.Enabled = true;
                    return;
                }

                MessageBox.Show("After 3 seconds machine will papering.\nPlease set focus your target window.");
                Thread.Sleep(3000);

                Thread thrd = new Thread(new ParameterizedThreadStart(Papering));
                m_IsThrdRunning = true;
                thrd.Start((object)p);

                button_Stop.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to papering text.\n" + ex.Message, "PaperMachine", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button_Start.Enabled = true;
                return;
            }
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            m_IsThrdRunning = false;
        }
    }
}
