namespace SSHMusicPlayer
{
    partial class Setup
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userInputPort = new System.Windows.Forms.TextBox();
            this.userInputIP = new System.Windows.Forms.TextBox();
            this.userInputPassword = new System.Windows.Forms.TextBox();
            this.userInputUsername = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.muteSong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.wishSong = new System.Windows.Forms.Button();
            this.hateSong = new System.Windows.Forms.Button();
            this.likeSong = new System.Windows.Forms.Button();
            this.shuffleSong = new System.Windows.Forms.Button();
            this.repeatSong = new System.Windows.Forms.Button();
            this.prevSong = new System.Windows.Forms.Button();
            this.nextSong = new System.Windows.Forms.Button();
            this.stopMusic = new System.Windows.Forms.Button();
            this.volumeControl = new System.Windows.Forms.NumericUpDown();
            this.playPauseSong = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ConsoleWindow = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.syncPhoneData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(216, 110);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(257, 80);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect to device";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 309);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.userInputPort);
            this.tabPage1.Controls.Add(this.userInputIP);
            this.tabPage1.Controls.Add(this.userInputPassword);
            this.tabPage1.Controls.Add(this.userInputUsername);
            this.tabPage1.Controls.Add(this.buttonConnect);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(263, 214);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(102, 17);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Not Connected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // userInputPort
            // 
            this.userInputPort.Location = new System.Drawing.Point(373, 34);
            this.userInputPort.Name = "userInputPort";
            this.userInputPort.Size = new System.Drawing.Size(100, 22);
            this.userInputPort.TabIndex = 4;
            this.userInputPort.Text = "22";
            // 
            // userInputIP
            // 
            this.userInputIP.Location = new System.Drawing.Point(373, 6);
            this.userInputIP.Name = "userInputIP";
            this.userInputIP.Size = new System.Drawing.Size(100, 22);
            this.userInputIP.TabIndex = 3;
            this.userInputIP.Text = "192.168.1.115";
            // 
            // userInputPassword
            // 
            this.userInputPassword.Location = new System.Drawing.Point(216, 33);
            this.userInputPassword.Name = "userInputPassword";
            this.userInputPassword.PasswordChar = '●';
            this.userInputPassword.Size = new System.Drawing.Size(100, 22);
            this.userInputPassword.TabIndex = 2;
            this.userInputPassword.Text = "alpine";
            // 
            // userInputUsername
            // 
            this.userInputUsername.Location = new System.Drawing.Point(216, 6);
            this.userInputUsername.Name = "userInputUsername";
            this.userInputUsername.Size = new System.Drawing.Size(100, 22);
            this.userInputUsername.TabIndex = 1;
            this.userInputUsername.Text = "root";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.muteSong);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.wishSong);
            this.tabPage2.Controls.Add(this.hateSong);
            this.tabPage2.Controls.Add(this.likeSong);
            this.tabPage2.Controls.Add(this.shuffleSong);
            this.tabPage2.Controls.Add(this.repeatSong);
            this.tabPage2.Controls.Add(this.prevSong);
            this.tabPage2.Controls.Add(this.nextSong);
            this.tabPage2.Controls.Add(this.stopMusic);
            this.tabPage2.Controls.Add(this.volumeControl);
            this.tabPage2.Controls.Add(this.playPauseSong);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Music Controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // muteSong
            // 
            this.muteSong.Location = new System.Drawing.Point(405, 6);
            this.muteSong.Name = "muteSong";
            this.muteSong.Size = new System.Drawing.Size(127, 70);
            this.muteSong.TabIndex = 11;
            this.muteSong.Text = "Mute: Off";
            this.muteSong.UseVisualStyleBackColor = true;
            this.muteSong.Click += new System.EventHandler(this.muteSong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Volume:";
            // 
            // wishSong
            // 
            this.wishSong.Location = new System.Drawing.Point(272, 158);
            this.wishSong.Name = "wishSong";
            this.wishSong.Size = new System.Drawing.Size(127, 70);
            this.wishSong.TabIndex = 9;
            this.wishSong.Text = "Wishlist (Radio)";
            this.wishSong.UseVisualStyleBackColor = true;
            this.wishSong.Click += new System.EventHandler(this.wishSong_Click);
            // 
            // hateSong
            // 
            this.hateSong.Location = new System.Drawing.Point(272, 82);
            this.hateSong.Name = "hateSong";
            this.hateSong.Size = new System.Drawing.Size(127, 70);
            this.hateSong.TabIndex = 8;
            this.hateSong.Text = "Hate (Radio)";
            this.hateSong.UseVisualStyleBackColor = true;
            this.hateSong.Click += new System.EventHandler(this.hateSong_Click);
            // 
            // likeSong
            // 
            this.likeSong.Location = new System.Drawing.Point(272, 6);
            this.likeSong.Name = "likeSong";
            this.likeSong.Size = new System.Drawing.Size(127, 70);
            this.likeSong.TabIndex = 7;
            this.likeSong.Text = "Like (Radio)";
            this.likeSong.UseVisualStyleBackColor = true;
            this.likeSong.Click += new System.EventHandler(this.likeSong_Click);
            // 
            // shuffleSong
            // 
            this.shuffleSong.Location = new System.Drawing.Point(139, 158);
            this.shuffleSong.Name = "shuffleSong";
            this.shuffleSong.Size = new System.Drawing.Size(127, 70);
            this.shuffleSong.TabIndex = 6;
            this.shuffleSong.Text = "Shuffle: Off";
            this.shuffleSong.UseVisualStyleBackColor = true;
            this.shuffleSong.Click += new System.EventHandler(this.shuffleSong_Click);
            // 
            // repeatSong
            // 
            this.repeatSong.Location = new System.Drawing.Point(6, 158);
            this.repeatSong.Name = "repeatSong";
            this.repeatSong.Size = new System.Drawing.Size(127, 70);
            this.repeatSong.TabIndex = 5;
            this.repeatSong.Text = "Repeat: Off";
            this.repeatSong.UseVisualStyleBackColor = true;
            this.repeatSong.Click += new System.EventHandler(this.repeatMusic_Click);
            // 
            // prevSong
            // 
            this.prevSong.Location = new System.Drawing.Point(139, 82);
            this.prevSong.Name = "prevSong";
            this.prevSong.Size = new System.Drawing.Size(127, 70);
            this.prevSong.TabIndex = 4;
            this.prevSong.Text = "Prev";
            this.prevSong.UseVisualStyleBackColor = true;
            this.prevSong.Click += new System.EventHandler(this.prevSong_Click);
            // 
            // nextSong
            // 
            this.nextSong.Location = new System.Drawing.Point(139, 6);
            this.nextSong.Name = "nextSong";
            this.nextSong.Size = new System.Drawing.Size(127, 70);
            this.nextSong.TabIndex = 3;
            this.nextSong.Text = "Next";
            this.nextSong.UseVisualStyleBackColor = true;
            this.nextSong.Click += new System.EventHandler(this.nextSong_Click);
            // 
            // stopMusic
            // 
            this.stopMusic.Location = new System.Drawing.Point(6, 82);
            this.stopMusic.Name = "stopMusic";
            this.stopMusic.Size = new System.Drawing.Size(127, 70);
            this.stopMusic.TabIndex = 2;
            this.stopMusic.Text = "Stop (Kill song)";
            this.stopMusic.UseVisualStyleBackColor = true;
            this.stopMusic.Click += new System.EventHandler(this.stopMusic_Click);
            // 
            // volumeControl
            // 
            this.volumeControl.Location = new System.Drawing.Point(539, 206);
            this.volumeControl.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(120, 22);
            this.volumeControl.TabIndex = 1;
            this.volumeControl.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // playPauseSong
            // 
            this.playPauseSong.Location = new System.Drawing.Point(6, 6);
            this.playPauseSong.Name = "playPauseSong";
            this.playPauseSong.Size = new System.Drawing.Size(127, 70);
            this.playPauseSong.TabIndex = 0;
            this.playPauseSong.Text = "Play / Pause";
            this.playPauseSong.UseVisualStyleBackColor = true;
            this.playPauseSong.Click += new System.EventHandler(this.playPause_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ConsoleWindow);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(700, 280);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Console";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ConsoleWindow
            // 
            this.ConsoleWindow.Location = new System.Drawing.Point(4, 7);
            this.ConsoleWindow.Multiline = true;
            this.ConsoleWindow.Name = "ConsoleWindow";
            this.ConsoleWindow.ReadOnly = true;
            this.ConsoleWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleWindow.Size = new System.Drawing.Size(693, 267);
            this.ConsoleWindow.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.syncPhoneData);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(700, 280);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Phone Status Testing";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // syncPhoneData
            // 
            this.syncPhoneData.Location = new System.Drawing.Point(338, 46);
            this.syncPhoneData.Name = "syncPhoneData";
            this.syncPhoneData.Size = new System.Drawing.Size(307, 206);
            this.syncPhoneData.TabIndex = 0;
            this.syncPhoneData.Text = "Sync";
            this.syncPhoneData.UseVisualStyleBackColor = true;
            this.syncPhoneData.Click += new System.EventHandler(this.syncPhoneData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(582, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "This is testing out Syncing Data from the phone to this client. You can just igno" +
    "re this page.";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 333);
            this.Controls.Add(this.tabControl1);
            this.Name = "Setup";
            this.Text = "Music SSH";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox userInputPort;
        private System.Windows.Forms.TextBox userInputIP;
        private System.Windows.Forms.TextBox userInputPassword;
        private System.Windows.Forms.TextBox userInputUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox ConsoleWindow;
        private System.Windows.Forms.Button playPauseSong;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown volumeControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button wishSong;
        private System.Windows.Forms.Button hateSong;
        private System.Windows.Forms.Button likeSong;
        private System.Windows.Forms.Button shuffleSong;
        private System.Windows.Forms.Button repeatSong;
        private System.Windows.Forms.Button prevSong;
        private System.Windows.Forms.Button nextSong;
        private System.Windows.Forms.Button stopMusic;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button syncPhoneData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button muteSong;
        private System.Windows.Forms.Label label8;
    }
}

