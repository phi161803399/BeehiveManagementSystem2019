using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagementSystem
{
    public partial class Form1 : Form
    {
        Queen queen;
        Worker[] workers;
        public Form1()
        {
            InitializeComponent();
            cmbWorkerBeeJob.SelectedIndex = 0;
            CreateWorkerArray();
            queen = new Queen(workers);
        }

        private void CreateWorkerArray()
        {
            workers = new Worker[4]
            {
                new Worker(new string[] {"Nectar collector", "Honey manufacturing"}),
                new Worker(new string[] {"Egg care", "Baby bee tutoring"}),
                new Worker(new string[] {"Hive maintenance", "Sting patrol"}),
                new Worker(new string[] {"Nectar collector","Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol"})
            };
        }
    }
}
