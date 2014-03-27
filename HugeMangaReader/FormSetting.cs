using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HugeMangaReader
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            txtUrl.Text = Program.url;
            txtPath.Text = Program.savepath;
            numVol.Value = Program.vol;
            numPage.Value = Program.ipage;

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            //Program.url = txtUrl.Text;
            //Program.savepath = txtPath.Text;
            Program.vol = Convert.ToInt32(numVol.Value);
            Program.ipage = Convert.ToInt32(numPage.Value);
            Close();
        }
    }
}
