
namespace datachange
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Button();
            this.kB = new System.Windows.Forms.Button();
            this.MB = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.Button();
            this.choosemode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.Label();
            this.kb1 = new System.Windows.Forms.Label();
            this.mb1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了するEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切り替えToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データ容量変換器Ver12についてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(17, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 62);
            this.textBox1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(50, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(495, 64);
            this.title.TabIndex = 1;
            this.title.Text = "データ容量変換機";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(11, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "大きさを入力して、下のボタンを押してください";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ok.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Ok.Location = new System.Drawing.Point(17, 257);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(305, 64);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "決定";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(529, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "KB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(519, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 64);
            this.label3.TabIndex = 7;
            this.label3.Text = "MB";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.MenuText;
            this.clear.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(345, 257);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(290, 64);
            this.clear.TabIndex = 8;
            this.clear.Text = "消去";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(567, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 64);
            this.label5.TabIndex = 10;
            this.label5.Text = "B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(517, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 64);
            this.label7.TabIndex = 12;
            this.label7.Text = "ＧB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(529, 592);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 64);
            this.label9.TabIndex = 14;
            this.label9.Text = "TB";
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.B.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B.Location = new System.Drawing.Point(61, 212);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(121, 39);
            this.B.TabIndex = 16;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = false;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // kB
            // 
            this.kB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kB.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kB.Location = new System.Drawing.Point(201, 212);
            this.kB.Name = "kB";
            this.kB.Size = new System.Drawing.Size(121, 39);
            this.kB.TabIndex = 17;
            this.kB.Text = "KB";
            this.kB.UseVisualStyleBackColor = false;
            this.kB.Click += new System.EventHandler(this.kB_Click);
            // 
            // MB
            // 
            this.MB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MB.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MB.Location = new System.Drawing.Point(345, 212);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(121, 39);
            this.MB.TabIndex = 18;
            this.MB.Text = "MB";
            this.MB.UseVisualStyleBackColor = false;
            this.MB.Click += new System.EventHandler(this.MB_Click);
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GB.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB.Location = new System.Drawing.Point(488, 212);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(121, 39);
            this.GB.TabIndex = 19;
            this.GB.Text = "GB";
            this.GB.UseVisualStyleBackColor = false;
            this.GB.Click += new System.EventHandler(this.GB_Click);
            // 
            // choosemode
            // 
            this.choosemode.AutoSize = true;
            this.choosemode.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.choosemode.Location = new System.Drawing.Point(359, 144);
            this.choosemode.Name = "choosemode";
            this.choosemode.Size = new System.Drawing.Size(68, 64);
            this.choosemode.TabIndex = 21;
            this.choosemode.Text = "B";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(528, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 319);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // b1
            // 
            this.b1.AutoSize = true;
            this.b1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.b1.Location = new System.Drawing.Point(17, 336);
            this.b1.MaximumSize = new System.Drawing.Size(450, 0);
            this.b1.MinimumSize = new System.Drawing.Size(450, 0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(450, 64);
            this.b1.TabIndex = 23;
            this.b1.Text = "0";
            // 
            // kb1
            // 
            this.kb1.AutoSize = true;
            this.kb1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kb1.Location = new System.Drawing.Point(17, 400);
            this.kb1.MaximumSize = new System.Drawing.Size(450, 0);
            this.kb1.MinimumSize = new System.Drawing.Size(450, 0);
            this.kb1.Name = "kb1";
            this.kb1.Size = new System.Drawing.Size(450, 64);
            this.kb1.TabIndex = 24;
            this.kb1.Text = "0";
            // 
            // mb1
            // 
            this.mb1.AutoSize = true;
            this.mb1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mb1.Location = new System.Drawing.Point(17, 464);
            this.mb1.MaximumSize = new System.Drawing.Size(360, 0);
            this.mb1.MinimumSize = new System.Drawing.Size(450, 0);
            this.mb1.Name = "mb1";
            this.mb1.Size = new System.Drawing.Size(450, 64);
            this.mb1.TabIndex = 25;
            this.mb1.Text = "0";
            // 
            // gb1
            // 
            this.gb1.AutoSize = true;
            this.gb1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gb1.Location = new System.Drawing.Point(17, 528);
            this.gb1.MaximumSize = new System.Drawing.Size(450, 0);
            this.gb1.MinimumSize = new System.Drawing.Size(450, 0);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(450, 64);
            this.gb1.TabIndex = 26;
            this.gb1.Text = "0";
            // 
            // tb1
            // 
            this.tb1.AutoSize = true;
            this.tb1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb1.Location = new System.Drawing.Point(17, 591);
            this.tb1.MinimumSize = new System.Drawing.Size(450, 0);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(450, 64);
            this.tb1.TabIndex = 27;
            this.tb1.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.設定SToolStripMenuItem,
            this.ヘルプFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了するEToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 終了するEToolStripMenuItem
            // 
            this.終了するEToolStripMenuItem.Name = "終了するEToolStripMenuItem";
            this.終了するEToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.終了するEToolStripMenuItem.Text = "終了する(&E)";
            this.終了するEToolStripMenuItem.Click += new System.EventHandler(this.終了するEToolStripMenuItem_Click);
            // 
            // 設定SToolStripMenuItem
            // 
            this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切り替えToolStripMenuItem});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // 切り替えToolStripMenuItem
            // 
            this.切り替えToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.切り替えToolStripMenuItem.Name = "切り替えToolStripMenuItem";
            this.切り替えToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.切り替えToolStripMenuItem.Text = "1K切り替え";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem2.Text = "1K=1000";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem3.Text = "1K=1024";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ヘルプFToolStripMenuItem
            // 
            this.ヘルプFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データ容量変換器Ver12についてToolStripMenuItem});
            this.ヘルプFToolStripMenuItem.Name = "ヘルプFToolStripMenuItem";
            this.ヘルプFToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプFToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // データ容量変換器Ver12についてToolStripMenuItem
            // 
            this.データ容量変換器Ver12についてToolStripMenuItem.Name = "データ容量変換器Ver12についてToolStripMenuItem";
            this.データ容量変換器Ver12についてToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.データ容量変換器Ver12についてToolStripMenuItem.Text = "データ容量変換器 Ver1.2について(&A)";
            this.データ容量変換器Ver12についてToolStripMenuItem.Click += new System.EventHandler(this.データ容量変換器Ver12についてToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ba
            // 
            this.ba.AutoSize = true;
            this.ba.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ba.Location = new System.Drawing.Point(522, 169);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(122, 35);
            this.ba.TabIndex = 30;
            this.ba.Text = "1024倍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 671);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choosemode);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.MB);
            this.Controls.Add(this.kB);
            this.Controls.Add(this.B);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.mb1);
            this.Controls.Add(this.kb1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 710);
            this.MinimumSize = new System.Drawing.Size(670, 710);
            this.Name = "Form1";
            this.Text = "データ容量変換機 Ver1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button kB;
        private System.Windows.Forms.Button MB;
        private System.Windows.Forms.Button GB;
        private System.Windows.Forms.Label choosemode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label b1;
        private System.Windows.Forms.Label kb1;
        private System.Windows.Forms.Label mb1;
        private System.Windows.Forms.Label gb1;
        private System.Windows.Forms.Label tb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り替えToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ヘルプFToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 終了するEToolStripMenuItem;
        private System.Windows.Forms.Label ba;
        private System.Windows.Forms.ToolStripMenuItem データ容量変換器Ver12についてToolStripMenuItem;
    }
}

