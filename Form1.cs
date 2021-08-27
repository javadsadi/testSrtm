using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRTM;
using SRTM.Sources.USGS;

namespace testSrtm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var srtmData = new SRTMData(@"srtm-cache", new USGSSource());

            int? elevation = srtmData.GetElevation(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            textBox3.Text = Convert.ToString(elevation);
        }
    }
}
