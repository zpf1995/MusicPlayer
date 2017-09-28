namespace MusicPlayer4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.StartButton = new System.Windows.Forms.Button();
            this.RefuseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartOrPausebutton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deleteContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.MusicLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disTimeLabel = new System.Windows.Forms.Label();
            this.ircLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.deleteContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(42, 12);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(459, 209);
            this.musicPlayer.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(15, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(78, 31);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "播放";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RefuseButton
            // 
            this.RefuseButton.Location = new System.Drawing.Point(15, 56);
            this.RefuseButton.Name = "RefuseButton";
            this.RefuseButton.Size = new System.Drawing.Size(78, 31);
            this.RefuseButton.TabIndex = 2;
            this.RefuseButton.Text = "暂停";
            this.RefuseButton.UseVisualStyleBackColor = true;
            this.RefuseButton.Click += new System.EventHandler(this.RefuseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(176, 264);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(78, 31);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "结束";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RefuseButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Location = new System.Drawing.Point(710, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "播放器老版本";
            // 
            // StartOrPausebutton
            // 
            this.StartOrPausebutton.Location = new System.Drawing.Point(51, 264);
            this.StartOrPausebutton.Name = "StartOrPausebutton";
            this.StartOrPausebutton.Size = new System.Drawing.Size(78, 31);
            this.StartOrPausebutton.TabIndex = 5;
            this.StartOrPausebutton.Text = "播放";
            this.StartOrPausebutton.UseVisualStyleBackColor = true;
            this.StartOrPausebutton.Click += new System.EventHandler(this.StartOrPausebutton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(725, 143);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(78, 31);
            this.openButton.TabIndex = 6;
            this.openButton.Text = "打开";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.deleteContextMenuStrip;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(710, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 148);
            this.listBox1.TabIndex = 7;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // deleteContextMenuStrip
            // 
            this.deleteContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.deleteContextMenuStrip.Name = "deleteContextMenuStrip";
            this.deleteContextMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DeleteToolStripMenuItem.Text = "删除";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(570, 180);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(78, 31);
            this.UpButton.TabIndex = 8;
            this.UpButton.Text = "上一曲";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(570, 227);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(78, 31);
            this.DownButton.TabIndex = 9;
            this.DownButton.Text = "下一曲";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // MusicLabel
            // 
            this.MusicLabel.Image = ((System.Drawing.Image)(resources.GetObject("MusicLabel.Image")));
            this.MusicLabel.Location = new System.Drawing.Point(424, 248);
            this.MusicLabel.Name = "MusicLabel";
            this.MusicLabel.Size = new System.Drawing.Size(72, 47);
            this.MusicLabel.TabIndex = 10;
            this.MusicLabel.Tag = "1";
            this.MusicLabel.Click += new System.EventHandler(this.MusicLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disTimeLabel
            // 
            this.disTimeLabel.Location = new System.Drawing.Point(312, 248);
            this.disTimeLabel.Name = "disTimeLabel";
            this.disTimeLabel.Size = new System.Drawing.Size(80, 59);
            this.disTimeLabel.TabIndex = 11;
            // 
            // ircLabel
            // 
            this.ircLabel.Location = new System.Drawing.Point(566, 79);
            this.ircLabel.Name = "ircLabel";
            this.ircLabel.Size = new System.Drawing.Size(138, 68);
            this.ircLabel.TabIndex = 12;
            this.ircLabel.Text = "歌词显示";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 347);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ircLabel);
            this.Controls.Add(this.disTimeLabel);
            this.Controls.Add(this.MusicLabel);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.StartOrPausebutton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.musicPlayer);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.deleteContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RefuseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartOrPausebutton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.ContextMenuStrip deleteContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Label MusicLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label disTimeLabel;
        private System.Windows.Forms.Label ircLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

