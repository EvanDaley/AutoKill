using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoKill
{
    public partial class AutoKillForm : Form
    {
        #region Setup

        private int frequency = 10;                 // The interval of peace between each round of "process murdering".
        private int currentValue = 0;               // The increment value. Once currentValue == frequency we kill tasks.
        private Timer myTimer;                      // The timer - creates an event every 1000 milleseconds (1 sec)
        private bool startSelected = true;          // Do we want each program to start as "checked'?
        private bool continueInBackground = false;  // Do we want the program to continue in bkg?

        // Initialize the form and create a timer
        public AutoKillForm()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Interval = 1000;
            myTimer.Tick += new  EventHandler(TimerEventProcessor);
            UpdateFrequency();
            myTimer.Enabled = true;

            L_TimeLeft.Text = frequency.ToString();

            // If 'started selected', give each process a check mark.
            if (startSelected) 
                SetAllChecked();
        }

        // Go through all processes and give each one a check-mark so it will be killed later
        private void SetAllChecked()
        {
            for(int i = 0; i < CLB_Tasks.Items.Count; i++)
            {
                CLB_Tasks.SetItemChecked(i,true);
            }
        }

        // Go through all processes and remove all check-marks
        private void SetAllUnChecked()
        {
            for (int i = 0; i < CLB_Tasks.Items.Count; i++)
            {
                CLB_Tasks.SetItemChecked(i, false);
            }
        }

        #endregion

        #region Control

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            currentValue++;
            
            L_TimeLeft.Text = (frequency - currentValue).ToString();

            if (currentValue >= frequency)
            {
                currentValue = 0;
                KillNow();
            }
        }

        private void UpdateFrequency()
        {
            try
            {
                int temp = 0;
                Int32.TryParse(TB_Frequency.Text, out temp);
                frequency = temp;
                currentValue = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Enter the number of seconds as an integer");
            }
        }

        private void AddItem()
        {
            MessageBox.Show("Feature not yet supported");
        }

        #endregion

        #region Process

        // It's time to muderize each process.
        private void KillNow()
        {
            if (CB_Ask.Checked)
                MessageBox.Show("Reducing System Load");

            // Go through  the whole list of checked items and kill each process
            for (int i = 0; i < CLB_Tasks.CheckedItems.Count; i++)
            {
                KillOne(CLB_Tasks.CheckedItems[i]);
            }
        }

        // Kill all processes with this specific name.
        private void KillOne(Object task)
        {
            System.Diagnostics.Process[] procs = null;

            try
            {
                // Get a list of processes running under the given name
                procs = Process.GetProcessesByName(task.ToString());

                if (procs.Length > 0)
                {
                    Process first = procs[0];

                    if (!first.HasExited)
                    {
                        first.Kill();
                    }
                }

                // Destroy them all
                if (procs != null)
                {
                    foreach (Process p in procs)
                    {
                        if (!p.HasExited)
                        {
                            p.Kill();
                        }
                    }
                }
            }
            finally
            {
                // If there are still processes left free them
                if(procs != null)
                {
                    foreach(Process p in procs)
                    {
                        p.Dispose();
                    }
                }
            }
        }
        #endregion

        #region Buttons

        // The user changed the frequency, update values
        private void TB_Frequency_TextChanged(object sender, EventArgs e)
        {
            UpdateFrequency();
        }

        // The button "kill now" was pressed. Kill now.
        private void B_Kill_Click(object sender, EventArgs e)
        {
            KillNow();
            currentValue = 0;
            L_TimeLeft.Text = frequency.ToString();
        }

        // The user wants to close the form. Should we let them?
        private void AutoKillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (continueInBackground)
            {
                // Cancel the quit operation
                e.Cancel = true;

                // Show a message
                MessageBox.Show("Will continue running in background. To view click on the AutoKill icon in the task tray");

                // Hide the form until further notice
                Form.ActiveForm.Hide();
            }
        }

        // If they click on the task tray icon re-enable the form.
        private void NI_AutoKill_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        // Quit the program
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // The user tried to add a process
        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        // The user tried to add a process
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        // About
        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Evan Daley. Kills selected tasks after a certain interval.");
        }

        // Check All
        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllChecked();
        }

        // Uncheck All
        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAllUnChecked();
        }

        // Help
         private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(" https://github.com/EvanDaley/AutoKill");
        }


        #endregion

    }
}
