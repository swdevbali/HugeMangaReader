using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace HugeMangaReader
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Program.isTwoDigit = false;
            Program.vol = 29;
            Program.ipage = 55;
            generatePath(Program.vol, Program.ipage);
            loadPage(Program.ipage, true);            
        }

        private void generatePath(int vol, int ipage)
        {

            //Program.url = @"http://hugemanga.com/mangas/Kariage Kun/vol " + vol + @"/";
            //Program.savepath = @"C:\Users\Eko Wibowo\Books\Komik\Kariage Kun\Vol " + vol.ToString("00") + @"\";

            //Program.url = @"http://hugemanga.com/mangas/New Kungfu Boy/Vol " + vol.ToString("00") + @"/";            
            //Program.savepath = @"C:\Users\Eko Wibowo\Books\Komik\New Kungfu Boy\Vol " + vol.ToString("00") + @"\";
            
            //Program.url = @"http://hugemanga.com/mangas/Tekken Chinmi Gaiden/" + vol.ToString("00") + @"/";
            //Program.savepath = @"C:\Users\Eko Wibowo\Books\Komik\Tekken Chinmi Gaiden\Vol " + vol.ToString("00") + @"\";

            Program.url = @"http://hugemanga.com/mangas/Kungfu Boy/Kungfu Boy Volume " + vol.ToString("00")+ "/";//
            Program.savepath = @"C:\Users\Eko Wibowo\Books\Komik\Kungfu Boy\Vol " + vol.ToString("00") + @"\";

            if (!File.Exists(Program.savepath))
            {
                Directory.CreateDirectory(Program.savepath);
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Space)
            {
                Program.ipage++;
                if (!loadPage(Program.ipage, true))
                {
                    changeExtension();
                    loadPage(Program.ipage, true);
                }
                timerPrefetch.Interval = 500;
                timerPrefetch.Enabled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                Program.ipage--;
                loadPage(Program.ipage, true);

            }
            else if (e.KeyCode == Keys.Up)
            {
                Program.vol++;
                Program.ipage = 1;
                Program.isTwoDigit = true;
                generatePath(Program.vol, Program.ipage);

                if (!loadPage(Program.ipage, true))
                {
                    changeExtension();
                    loadPage(Program.ipage, true);
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                Program.vol--;
                Program.ipage = 1;
                Program.isTwoDigit = true;
                generatePath(Program.vol, Program.ipage);
                if (!loadPage(Program.ipage, true))
                {
                    changeExtension();
                    loadPage(Program.ipage, true);
                }

            }
            else if (e.KeyCode == Keys.F12)
            {
                FormSetting settings = new FormSetting();
                settings.ShowDialog();
                generatePath(Program.vol, Program.ipage);
                if (!loadPage(Program.ipage, true))
                {
                    changeExtension();
                    loadPage(Program.ipage, true);
                }
                
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            
        }
        string extension = ".jpg";
        private void changeExtension()
        {
            if (extension.Equals(".jpg"))
            {
                extension = ".JPG";
            }
            else
            {
                extension = ".jpg";
            }
        }

        
        private bool loadPage(int ipage, bool show)
        {
            string filename = "";
            bool isnewfile = false;
            string filepart = "";            
            try
            {
                if (Program.isTwoDigit)
                {
                    filepart = "001 " + "(" + ipage.ToString("00") + ")" + extension;
                    //filepart = "Chinmi-gaiden-" + ipage.ToString("00") + "" + extension;
                    //filepart = ipage.ToString("00") + "" + extension;
                    //filepart = "Kariage-kun-vol" + Program.vol + "-indo-" + Program.ipage.ToString("00") + "" + extension;                    

                    filename = Program.savepath + filepart;
                    if (File.Exists(filename))
                    {
                        if(show) pictureBox1.Load(filename);
                    }else{
                        isnewfile = true;
                        if (show)
                        {
                            pictureBox1.Load(Program.url + filepart);
                        }
                        else
                        {
                            byte[] data;
                            using (WebClient client = new WebClient())
                            {
                                data = client.DownloadData(Program.url + filepart);
                            }
                            File.WriteAllBytes(filename, data);
                        }
                    }
                    
                }
                else
                {
                    filepart = "001 " + "(" + ipage.ToString("00") + ")" + extension;
                    //filepart = ipage.ToString("000") + "" + extension;
                    //filepart = "Kariage-kun-vol" + Program.vol + "-indo-" + Program.ipage.ToString("000") + "" + extension;
                    filename = Program.savepath + filepart;
                    if (File.Exists(filename))
                    {
                        if (show) pictureBox1.Load(filename);
                    }
                    else
                    {
                        isnewfile = true;
                        if (show)
                        {
                            pictureBox1.Load(Program.url + filepart);
                        }
                        else
                        {
                            byte[] data;
                            using (WebClient client = new WebClient())
                            {
                                data = client.DownloadData(Program.url + filepart);
                            }
                            File.WriteAllBytes(filename, data);
                        }
                    }                    
                }
            }
            catch (Exception e)
            {
                Program.isTwoDigit = false;
                filename = Program.savepath + filepart;
                if (File.Exists(filename))
                {
                    if (show) pictureBox1.Load(filename);
                }
                else
                {
                    isnewfile = true;
                    //filepart = "Kariage-kun-vol" + Program.vol + "-indo-" + Program.ipage.ToString("000") + "" + extension;
                    //filepart = ipage.ToString("000") + "" + extension;
                    //filepart = "Chinmi-gaiden-" + ipage.ToString("000") + "" + extension;
                    filepart = "001 " + "(" + ipage.ToString("00") + ")" + extension;
                    if (show)
                    {
                        try
                        {
                            pictureBox1.Load(Program.url + filepart);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Dhehell?? Loading URL");
                            return false;
                        }
                    }
                }
                
            }
            if (isnewfile && show)
            {
                try
                {
                    pictureBox1.Image.Save(filename);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Dhehell?? Saving file");
                    return false;
                }

            }

            return true;
        }

        private void timerPrefetch_Tick(object sender, EventArgs e)
        {
            timerPrefetch.Enabled = false;
            loadPage(Program.ipage + 1, false);
            loadPage(Program.ipage + 2, false);
            loadPage(Program.ipage + 3, false);
            
        }
    }
}
