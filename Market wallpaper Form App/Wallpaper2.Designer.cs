
namespace Market_wallpaper_Form_App
{
    partial class Wallpaper2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallpaper2));
            this.panelTop = new System.Windows.Forms.Panel();
            this.GitHub = new System.Windows.Forms.Button();
            this.buttBack = new System.Windows.Forms.Button();
            this.buttMinimize = new System.Windows.Forms.Button();
            this.buttMaximize = new System.Windows.Forms.Button();
            this.buttClose = new System.Windows.Forms.Button();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.labelFPrix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelReleased = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelCateg = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTargeter1 = new System.Windows.Forms.Label();
            this.labelTargeter4 = new System.Windows.Forms.Label();
            this.labelTargeter3 = new System.Windows.Forms.Label();
            this.labelTargeter2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxWall = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panelTop.Controls.Add(this.GitHub);
            this.panelTop.Controls.Add(this.buttBack);
            this.panelTop.Controls.Add(this.buttMinimize);
            this.panelTop.Controls.Add(this.buttMaximize);
            this.panelTop.Controls.Add(this.buttClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 28);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // GitHub
            // 
            this.GitHub.FlatAppearance.BorderSize = 0;
            this.GitHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.GitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.GitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHub.ForeColor = System.Drawing.Color.White;
            this.GitHub.Image = global::Market_wallpaper_Form_App.Properties.Resources.github_32_whitepx;
            this.GitHub.Location = new System.Drawing.Point(42, 0);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(36, 28);
            this.GitHub.TabIndex = 11;
            this.toolTip1.SetToolTip(this.GitHub, "Click to Open GitHub Profile");
            this.GitHub.UseVisualStyleBackColor = true;
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // buttBack
            // 
            this.buttBack.FlatAppearance.BorderSize = 0;
            this.buttBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttBack.ForeColor = System.Drawing.Color.White;
            this.buttBack.Image = global::Market_wallpaper_Form_App.Properties.Resources.left_16px;
            this.buttBack.Location = new System.Drawing.Point(0, 0);
            this.buttBack.Name = "buttBack";
            this.buttBack.Size = new System.Drawing.Size(36, 28);
            this.buttBack.TabIndex = 10;
            this.buttBack.UseVisualStyleBackColor = true;
            this.buttBack.Click += new System.EventHandler(this.buttBack_Click);
            // 
            // buttMinimize
            // 
            this.buttMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttMinimize.FlatAppearance.BorderSize = 0;
            this.buttMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttMinimize.ForeColor = System.Drawing.Color.White;
            this.buttMinimize.Image = global::Market_wallpaper_Form_App.Properties.Resources.minimize_window_32px;
            this.buttMinimize.Location = new System.Drawing.Point(1197, 0);
            this.buttMinimize.Name = "buttMinimize";
            this.buttMinimize.Size = new System.Drawing.Size(36, 28);
            this.buttMinimize.TabIndex = 2;
            this.buttMinimize.UseVisualStyleBackColor = true;
            this.buttMinimize.Click += new System.EventHandler(this.buttMinimize_Click);
            // 
            // buttMaximize
            // 
            this.buttMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttMaximize.FlatAppearance.BorderSize = 0;
            this.buttMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttMaximize.ForeColor = System.Drawing.Color.White;
            this.buttMaximize.Image = global::Market_wallpaper_Form_App.Properties.Resources.maximize_button_32px;
            this.buttMaximize.Location = new System.Drawing.Point(1232, 0);
            this.buttMaximize.Name = "buttMaximize";
            this.buttMaximize.Size = new System.Drawing.Size(36, 28);
            this.buttMaximize.TabIndex = 1;
            this.buttMaximize.UseVisualStyleBackColor = true;
            this.buttMaximize.Click += new System.EventHandler(this.buttMaximize_Click);
            // 
            // buttClose
            // 
            this.buttClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttClose.FlatAppearance.BorderSize = 0;
            this.buttClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClose.ForeColor = System.Drawing.Color.White;
            this.buttClose.Location = new System.Drawing.Point(1265, 0);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(36, 28);
            this.buttClose.TabIndex = 0;
            this.buttClose.Text = "X";
            this.buttClose.UseVisualStyleBackColor = true;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.panelButtom.Controls.Add(this.labelFPrix);
            this.panelButtom.Controls.Add(this.label1);
            this.panelButtom.Controls.Add(this.labelReleased);
            this.panelButtom.Controls.Add(this.labelC);
            this.panelButtom.Controls.Add(this.labelR);
            this.panelButtom.Controls.Add(this.labelPrix);
            this.panelButtom.Controls.Add(this.labelCateg);
            this.panelButtom.Controls.Add(this.labelName);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(0, 662);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(1300, 153);
            this.panelButtom.TabIndex = 4;
            // 
            // labelFPrix
            // 
            this.labelFPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFPrix.AutoSize = true;
            this.labelFPrix.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFPrix.ForeColor = System.Drawing.Color.Silver;
            this.labelFPrix.Location = new System.Drawing.Point(1117, 106);
            this.labelFPrix.Name = "labelFPrix";
            this.labelFPrix.Size = new System.Drawing.Size(103, 38);
            this.labelFPrix.TabIndex = 8;
            this.labelFPrix.Text = "Prix_$";
            this.labelFPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // labelReleased
            // 
            this.labelReleased.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReleased.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleased.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelReleased.Location = new System.Drawing.Point(121, 85);
            this.labelReleased.Name = "labelReleased";
            this.labelReleased.Size = new System.Drawing.Size(943, 24);
            this.labelReleased.TabIndex = 5;
            this.labelReleased.Text = "Game_Releasaed";
            // 
            // labelC
            // 
            this.labelC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.Color.White;
            this.labelC.Location = new System.Drawing.Point(12, 122);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(113, 22);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "Categorie: ";
            // 
            // labelR
            // 
            this.labelR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.ForeColor = System.Drawing.Color.White;
            this.labelR.Location = new System.Drawing.Point(12, 85);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(104, 22);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "Released: ";
            // 
            // labelPrix
            // 
            this.labelPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.ForeColor = System.Drawing.Color.White;
            this.labelPrix.Location = new System.Drawing.Point(1070, 13);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(202, 78);
            this.labelPrix.TabIndex = 2;
            this.labelPrix.Text = "Prix_$";
            this.labelPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCateg
            // 
            this.labelCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCateg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCateg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelCateg.Location = new System.Drawing.Point(121, 122);
            this.labelCateg.Name = "labelCateg";
            this.labelCateg.Size = new System.Drawing.Size(943, 24);
            this.labelCateg.TabIndex = 1;
            this.labelCateg.Text = "Game_Categorie";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(22, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(231, 39);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Game_Name";
            // 
            // labelTargeter1
            // 
            this.labelTargeter1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTargeter1.BackColor = System.Drawing.Color.AliceBlue;
            this.labelTargeter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTargeter1.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargeter1.Location = new System.Drawing.Point(601, 638);
            this.labelTargeter1.Name = "labelTargeter1";
            this.labelTargeter1.Size = new System.Drawing.Size(21, 21);
            this.labelTargeter1.TabIndex = 6;
            this.labelTargeter1.Click += new System.EventHandler(this.labelTargeter1_Click);
            // 
            // labelTargeter4
            // 
            this.labelTargeter4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTargeter4.BackColor = System.Drawing.Color.AliceBlue;
            this.labelTargeter4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTargeter4.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargeter4.Location = new System.Drawing.Point(682, 638);
            this.labelTargeter4.Name = "labelTargeter4";
            this.labelTargeter4.Size = new System.Drawing.Size(21, 21);
            this.labelTargeter4.TabIndex = 7;
            this.labelTargeter4.Click += new System.EventHandler(this.labelTargeter4_Click);
            // 
            // labelTargeter3
            // 
            this.labelTargeter3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTargeter3.BackColor = System.Drawing.Color.AliceBlue;
            this.labelTargeter3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTargeter3.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargeter3.Location = new System.Drawing.Point(655, 638);
            this.labelTargeter3.Name = "labelTargeter3";
            this.labelTargeter3.Size = new System.Drawing.Size(21, 21);
            this.labelTargeter3.TabIndex = 8;
            this.labelTargeter3.Click += new System.EventHandler(this.labelTargeter3_Click);
            // 
            // labelTargeter2
            // 
            this.labelTargeter2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTargeter2.BackColor = System.Drawing.Color.AliceBlue;
            this.labelTargeter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTargeter2.Font = new System.Drawing.Font("Microsoft JhengHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTargeter2.Location = new System.Drawing.Point(628, 638);
            this.labelTargeter2.Name = "labelTargeter2";
            this.labelTargeter2.Size = new System.Drawing.Size(21, 21);
            this.labelTargeter2.TabIndex = 9;
            this.labelTargeter2.Click += new System.EventHandler(this.labelTargeter2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "Open Link";
            // 
            // pictureBoxWall
            // 
            this.pictureBoxWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWall.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxWall.Name = "pictureBoxWall";
            this.pictureBoxWall.Size = new System.Drawing.Size(1300, 634);
            this.pictureBoxWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWall.TabIndex = 5;
            this.pictureBoxWall.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxWall, "Double Click to open the link");
            this.pictureBoxWall.Click += new System.EventHandler(this.pictureBoxWall_Click);
            this.pictureBoxWall.DoubleClick += new System.EventHandler(this.pictureBoxWall_DoubleClick);
            this.pictureBoxWall.MouseHover += new System.EventHandler(this.pictureBoxWall_MouseHover);
            // 
            // Wallpaper2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 815);
            this.Controls.Add(this.labelTargeter2);
            this.Controls.Add(this.labelTargeter3);
            this.Controls.Add(this.labelTargeter4);
            this.Controls.Add(this.labelTargeter1);
            this.Controls.Add(this.pictureBoxWall);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wallpaper2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper2";
            this.Load += new System.EventHandler(this.Wallpaper2_Load);
            this.panelTop.ResumeLayout(false);
            this.panelButtom.ResumeLayout(false);
            this.panelButtom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttMinimize;
        private System.Windows.Forms.Button buttMaximize;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelReleased;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelCateg;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxWall;
        private System.Windows.Forms.Label labelTargeter1;
        private System.Windows.Forms.Label labelTargeter4;
        private System.Windows.Forms.Label labelTargeter3;
        private System.Windows.Forms.Label labelTargeter2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttBack;
        private System.Windows.Forms.Label labelFPrix;
        private System.Windows.Forms.Button GitHub;
    }
}