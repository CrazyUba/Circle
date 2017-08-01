using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15UITask
{
    public partial class Form1 : Form
    {
        Task t;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.DoWork();

            t = new Task(DoWork);
            t.Start();
            
        }

        void DoWork()
        {
            for (int i = 0; i < 1000; i++)
            {
                this.label1.Text = i.ToString();
                Thread.Sleep(500);
            }
        }
    }
}
