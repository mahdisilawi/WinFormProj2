namespace Music_Player
{
    partial class musicPlayerApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicPlayerApp));
            this.lbl_topPanelLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.listBox_songList = new System.Windows.Forms.ListBox();
            this.btn_selectMusic = new System.Windows.Forms.Button();
            this.lbl_developerName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.wmp_playSong = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_playSong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_topPanelLogo
            // 
            this.lbl_topPanelLogo.AutoSize = true;
            this.lbl_topPanelLogo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_topPanelLogo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_topPanelLogo.Location = new System.Drawing.Point(472, 3);
            this.lbl_topPanelLogo.Name = "lbl_topPanelLogo";
            this.lbl_topPanelLogo.Size = new System.Drawing.Size(155, 18);
            this.lbl_topPanelLogo.TabIndex = 0;
            this.lbl_topPanelLogo.Text = "پخش کننده موسیقی";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.lbl_topPanelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 27);
            this.panel1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(24, 23);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // listBox_songList
            // 
            this.listBox_songList.AllowDrop = true;
            this.listBox_songList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox_songList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_songList.FormattingEnabled = true;
            this.listBox_songList.ItemHeight = 16;
            this.listBox_songList.Location = new System.Drawing.Point(479, 30);
            this.listBox_songList.Name = "listBox_songList";
            this.listBox_songList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_songList.Size = new System.Drawing.Size(151, 356);
            this.listBox_songList.TabIndex = 2;
            this.listBox_songList.SelectedIndexChanged += new System.EventHandler(this.listBox_songList_SelectedIndexChanged);
            // 
            // btn_selectMusic
            // 
            this.btn_selectMusic.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_selectMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectMusic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_selectMusic.Location = new System.Drawing.Point(336, 349);
            this.btn_selectMusic.Name = "btn_selectMusic";
            this.btn_selectMusic.Size = new System.Drawing.Size(137, 37);
            this.btn_selectMusic.TabIndex = 4;
            this.btn_selectMusic.Text = "انتخاب موسیقی";
            this.btn_selectMusic.UseVisualStyleBackColor = false;
            this.btn_selectMusic.Click += new System.EventHandler(this.btn_selectMusic_Click);
            // 
            // lbl_developerName
            // 
            this.lbl_developerName.AutoSize = true;
            this.lbl_developerName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_developerName.Location = new System.Drawing.Point(39, 374);
            this.lbl_developerName.Name = "lbl_developerName";
            this.lbl_developerName.Size = new System.Drawing.Size(24, 13);
            this.lbl_developerName.TabIndex = 5;
            this.lbl_developerName.Text = "M.s";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 360);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // wmp_playSong
            // 
            this.wmp_playSong.Enabled = true;
            this.wmp_playSong.Location = new System.Drawing.Point(6, 30);
            this.wmp_playSong.Name = "wmp_playSong";
            this.wmp_playSong.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_playSong.OcxState")));
            this.wmp_playSong.Size = new System.Drawing.Size(467, 313);
            this.wmp_playSong.TabIndex = 3;
            // 
            // musicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(630, 391);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_developerName);
            this.Controls.Add(this.btn_selectMusic);
            this.Controls.Add(this.wmp_playSong);
            this.Controls.Add(this.listBox_songList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musicPlayerApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_playSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_topPanelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.ListBox listBox_songList;
        private AxWMPLib.AxWindowsMediaPlayer wmp_playSong;
        private System.Windows.Forms.Button btn_selectMusic;
        private System.Windows.Forms.Label lbl_developerName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

