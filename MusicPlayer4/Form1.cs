using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer4
{
    public partial class Form1 : Form
    {
        private List<string> musicList = new List<string>();
        private List<string> mpList= new List<string>();
        private List<double> ircList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            musicPlayer.URL = musicList[listBox1.SelectedIndex];
            musicPlayer.Ctlcontrols.play();
        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.autoStart = false;
            //musicPlayer.URL = @"C:\CloudMusic\简弘亦 - 魔鬼中的天使.mp3";
            if (listBox1.Items.Count == 0)
            {
                StartOrPausebutton.Enabled = false;
            }
        }

        private void StartOrPausebutton_Click(object sender, EventArgs e)
        {


            // StartOrPausebutton.Enabled = true;
            if (StartOrPausebutton.Text == "播放")
            {

                if (listBox1.SelectedItems.Count > 0)
                {
                    musicPlayer.Ctlcontrols.play();
                    StartOrPausebutton.Text = "暂停";
                    WriteIrc(musicPlayer.URL);
                }
            }
            else
            {

                musicPlayer.Ctlcontrols.pause();
                StartOrPausebutton.Text = "播放";
            }
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\CloudMusic";
            ofd.Title = "请选择你想要播放的歌曲";
            ofd.Filter = "MP3文件|*.mp3|音乐文件|*.wav|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            string[] path1 = ofd.FileNames;//获取全路径
            for (int i = 0; i < path1.Length; i++)
            {
                musicList.Add(path1[i]);
                listBox1.Items.Add(Path.GetFileName(path1[i]));//用Path获取文件名
            }
            if (listBox1.Items.Count > 0)
            {
                StartOrPausebutton.Enabled = true;
            }
        }
        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)//里面的内容的双击事件
        {
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("请先选择音乐文件！");
                }
                musicPlayer.URL = musicList[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                StartOrPausebutton.Text = "暂停";
                WriteIrc(musicPlayer.URL);
            }
            catch
            {
            }
        }
        private void WriteIrc(string filePath) {
            mpList.Clear();
            ircList.Clear();
            filePath += ".lrc";
            if (File.Exists(filePath))
            {
                string[] strContext = File.ReadAllLines(filePath);
                //获取里面的时间和内容 [00:29.33]十里寒塘
                for (int i=0;i<strContext.Length;i++) {
                    string[] strConTimer = strContext[i].Split(new char[] { '[',']'});
                    FormatIrc(strConTimer[1]);
                    mpList.Add(strConTimer[2]);
                }
            }
            else {
                ircLabel.Text = "歌词未找到。。。";
            }
        }
        private void FormatIrc(string ircTime) {
            string[] strTime = ircTime.Split(new char[] { ':'});
            double time = Double.Parse(strTime[0]) * 60 + Double.Parse(strTime[1]);
            ircList.Add(time);
        }
        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            if (index == 0)
            {
                index = listBox1.Items.Count;
            }
            index--;
            listBox1.SelectedIndex = index;
            musicPlayer.URL = musicList[index];
            musicPlayer.Ctlcontrols.play();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            NextMusic();
        }
        private void NextMusic() {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            if (index == listBox1.Items.Count - 1)
            {
                index = -1;
            }
            index++;
            listBox1.SelectedIndex = index;
            musicPlayer.URL = musicList[index];
            musicPlayer.Ctlcontrols.play();
            WriteIrc(musicPlayer.URL);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count - 1; i++)
            {
                //先删集合
                musicList.RemoveAt(listBox1.SelectedIndex);
                //再删列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void MusicLabel_Click(object sender, EventArgs e)
        {
            if (MusicLabel.Tag.ToString() == "1")
            {
                musicPlayer.settings.mute = true;
                MusicLabel.Tag = "2";
                MusicLabel.Image = Image.FromFile(@"D:\我的文档\Visual Studio 2015\Projects\MusicPlayer4\MusicPlayer4\Image\放音.png");
            }
            else
            {
                musicPlayer.settings.mute = false;
                MusicLabel.Tag = "1";
                MusicLabel.Image = Image.FromFile(@"D:\我的文档\Visual Studio 2015\Projects\MusicPlayer4\MusicPlayer4\Image\静音.png");
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            musicPlayer.URL = musicList[listBox1.SelectedIndex];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                disTimeLabel.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;
                if (Double.Parse(musicPlayer.currentMedia.duration.ToString()) < Double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) + 1)
                {
                    NextMusic();
                }
                for (int i = 0; i < ircList.Count - 1; i++)
                {
                    if (Double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) < ircList[0])
                    {
                        ircLabel.Text = "歌词显示";
                    }
                    else if (Double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) > ircList[i] && Double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) < ircList[i + 1])
                    {
                        ircLabel.Text = mpList[i];
                    }
                }
            }
        }
    }
}
