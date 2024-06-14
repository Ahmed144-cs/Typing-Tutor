namespace TypingTutor
{
    partial class FormTypingTutor
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
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panelReset = new System.Windows.Forms.Panel();
            this.LabComma = new System.Windows.Forms.Label();
            this.LabDot = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelMaxTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.InvalidKey = new System.Windows.Forms.Label();
            this.Spacebar = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.Label();
            this.LabelShift = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.Label();
            this.J = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Label();
            this.O = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.difficultyLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSentenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentenceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelReset.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Location = new System.Drawing.Point(51, 196);
            this.textBoxWrite.Multiline = true;
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.ReadOnly = true;
            this.textBoxWrite.Size = new System.Drawing.Size(834, 70);
            this.textBoxWrite.TabIndex = 1;
            this.textBoxWrite.Click += new System.EventHandler(this.textBoxWrite_Click);
            this.textBoxWrite.TextChanged += new System.EventHandler(this.textBoxWrite_TextChanged);
            this.textBoxWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWrite_KeyDown);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(965, 40);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(295, 445);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // panelReset
            // 
            this.panelReset.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelReset.Controls.Add(this.LabComma);
            this.panelReset.Controls.Add(this.LabDot);
            this.panelReset.Controls.Add(this.buttonReset);
            this.panelReset.Controls.Add(this.labelMaxTime);
            this.panelReset.Controls.Add(this.label1);
            this.panelReset.Controls.Add(this.textBoxShow);
            this.panelReset.Controls.Add(this.InvalidKey);
            this.panelReset.Controls.Add(this.Spacebar);
            this.panelReset.Controls.Add(this.M);
            this.panelReset.Controls.Add(this.N);
            this.panelReset.Controls.Add(this.B);
            this.panelReset.Controls.Add(this.V);
            this.panelReset.Controls.Add(this.C);
            this.panelReset.Controls.Add(this.X);
            this.panelReset.Controls.Add(this.Z);
            this.panelReset.Controls.Add(this.LabelShift);
            this.panelReset.Controls.Add(this.L);
            this.panelReset.Controls.Add(this.K);
            this.panelReset.Controls.Add(this.J);
            this.panelReset.Controls.Add(this.H);
            this.panelReset.Controls.Add(this.G);
            this.panelReset.Controls.Add(this.F);
            this.panelReset.Controls.Add(this.D);
            this.panelReset.Controls.Add(this.S);
            this.panelReset.Controls.Add(this.A);
            this.panelReset.Controls.Add(this.P);
            this.panelReset.Controls.Add(this.O);
            this.panelReset.Controls.Add(this.I);
            this.panelReset.Controls.Add(this.U);
            this.panelReset.Controls.Add(this.Y);
            this.panelReset.Controls.Add(this.T);
            this.panelReset.Controls.Add(this.R);
            this.panelReset.Controls.Add(this.E);
            this.panelReset.Controls.Add(this.W);
            this.panelReset.Controls.Add(this.Q);
            this.panelReset.Controls.Add(this.buttonStart);
            this.panelReset.Controls.Add(this.textBoxWrite);
            this.panelReset.Controls.Add(this.textBoxResult);
            this.panelReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReset.Location = new System.Drawing.Point(22, 39);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(1278, 593);
            this.panelReset.TabIndex = 2;
            this.panelReset.TabStop = true;
            this.panelReset.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReset_Paint);
            // 
            // LabComma
            // 
            this.LabComma.AutoSize = true;
            this.LabComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabComma.Location = new System.Drawing.Point(769, 422);
            this.LabComma.Name = "LabComma";
            this.LabComma.Size = new System.Drawing.Size(23, 36);
            this.LabComma.TabIndex = 41;
            this.LabComma.Tag = ",";
            this.LabComma.Text = ",";
            // 
            // LabDot
            // 
            this.LabDot.AutoSize = true;
            this.LabDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDot.Location = new System.Drawing.Point(856, 422);
            this.LabDot.Name = "LabDot";
            this.LabDot.Size = new System.Drawing.Size(23, 36);
            this.LabDot.TabIndex = 40;
            this.LabDot.Tag = ".";
            this.LabDot.Text = ".";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.SeaShell;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(1130, 519);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 51);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelMaxTime
            // 
            this.labelMaxTime.AutoSize = true;
            this.labelMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTime.Location = new System.Drawing.Point(459, 35);
            this.labelMaxTime.Name = "labelMaxTime";
            this.labelMaxTime.Size = new System.Drawing.Size(71, 38);
            this.labelMaxTime.TabIndex = 37;
            this.labelMaxTime.Text = ": 40";
            this.labelMaxTime.Click += new System.EventHandler(this.labelMaxTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(51, 111);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.ReadOnly = true;
            this.textBoxShow.Size = new System.Drawing.Size(834, 70);
            this.textBoxShow.TabIndex = 34;
            this.textBoxShow.TabStop = false;
            this.textBoxShow.TextChanged += new System.EventHandler(this.textBoxShow_TextChanged);
            // 
            // InvalidKey
            // 
            this.InvalidKey.AutoSize = true;
            this.InvalidKey.Location = new System.Drawing.Point(756, 498);
            this.InvalidKey.Name = "InvalidKey";
            this.InvalidKey.Size = new System.Drawing.Size(129, 29);
            this.InvalidKey.TabIndex = 33;
            this.InvalidKey.Tag = "Spacebar";
            this.InvalidKey.Text = "Invalid Key";
            this.InvalidKey.Click += new System.EventHandler(this.InvalidKey_Click);
            // 
            // Spacebar
            // 
            this.Spacebar.AutoSize = true;
            this.Spacebar.Location = new System.Drawing.Point(439, 498);
            this.Spacebar.Name = "Spacebar";
            this.Spacebar.Size = new System.Drawing.Size(82, 29);
            this.Spacebar.TabIndex = 32;
            this.Spacebar.Tag = "Space";
            this.Spacebar.Text = "Space";
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(672, 429);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(33, 29);
            this.M.TabIndex = 30;
            this.M.Tag = "M";
            this.M.Text = "M";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(577, 429);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(31, 29);
            this.N.TabIndex = 29;
            this.N.Tag = "N";
            this.N.Text = "N";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(484, 429);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(29, 29);
            this.B.TabIndex = 28;
            this.B.Tag = "B";
            this.B.Text = "B";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(392, 429);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(28, 29);
            this.V.TabIndex = 27;
            this.V.Tag = "V";
            this.V.Text = "V";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(298, 429);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(30, 29);
            this.C.TabIndex = 26;
            this.C.Tag = "C";
            this.C.Text = "C";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(204, 429);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(30, 29);
            this.X.TabIndex = 25;
            this.X.Tag = "X";
            this.X.Text = "X";
            // 
            // Z
            // 
            this.Z.AutoSize = true;
            this.Z.Location = new System.Drawing.Point(113, 428);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(27, 29);
            this.Z.TabIndex = 24;
            this.Z.Tag = "Z";
            this.Z.Text = "Z";
            // 
            // LabelShift
            // 
            this.LabelShift.AutoSize = true;
            this.LabelShift.Location = new System.Drawing.Point(18, 428);
            this.LabelShift.Name = "LabelShift";
            this.LabelShift.Size = new System.Drawing.Size(60, 29);
            this.LabelShift.TabIndex = 23;
            this.LabelShift.Tag = "Shift";
            this.LabelShift.Text = "Shift";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(819, 369);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(26, 29);
            this.L.TabIndex = 22;
            this.L.Tag = "L";
            this.L.Text = "L";
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Location = new System.Drawing.Point(725, 369);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(29, 29);
            this.K.TabIndex = 21;
            this.K.Tag = "K";
            this.K.Text = "K";
            // 
            // J
            // 
            this.J.AutoSize = true;
            this.J.Location = new System.Drawing.Point(635, 369);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(25, 29);
            this.J.TabIndex = 20;
            this.J.Tag = "J";
            this.J.Text = "J";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(540, 369);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(30, 29);
            this.H.TabIndex = 19;
            this.H.Tag = "H";
            this.H.Text = "H";
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(444, 369);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(31, 29);
            this.G.TabIndex = 18;
            this.G.Tag = "G";
            this.G.Text = "G";
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(351, 369);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(28, 29);
            this.F.TabIndex = 17;
            this.F.Tag = "F";
            this.F.Text = "F";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(256, 369);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(30, 29);
            this.D.TabIndex = 16;
            this.D.Tag = "D";
            this.D.Text = "D";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(162, 369);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(29, 29);
            this.S.TabIndex = 15;
            this.S.Tag = "S";
            this.S.Text = "S";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(69, 369);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(28, 29);
            this.A.TabIndex = 14;
            this.A.Tag = "A";
            this.A.Text = "A";
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(851, 314);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(29, 29);
            this.P.TabIndex = 13;
            this.P.Tag = "P";
            this.P.Text = "P";
            // 
            // O
            // 
            this.O.AutoSize = true;
            this.O.Location = new System.Drawing.Point(759, 314);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(32, 29);
            this.O.TabIndex = 12;
            this.O.Tag = "O";
            this.O.Text = "O";
            // 
            // I
            // 
            this.I.AutoSize = true;
            this.I.Location = new System.Drawing.Point(680, 314);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(19, 29);
            this.I.TabIndex = 11;
            this.I.Tag = "I";
            this.I.Text = "I";
            // 
            // U
            // 
            this.U.AutoSize = true;
            this.U.Location = new System.Drawing.Point(590, 314);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(30, 29);
            this.U.TabIndex = 10;
            this.U.Tag = "U";
            this.U.Text = "U";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(501, 314);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(29, 29);
            this.Y.TabIndex = 9;
            this.Y.Tag = "Y";
            this.Y.Text = "Y";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Location = new System.Drawing.Point(412, 314);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(29, 29);
            this.T.TabIndex = 8;
            this.T.Tag = "T";
            this.T.Text = "T";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(322, 314);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(30, 29);
            this.R.TabIndex = 7;
            this.R.Tag = "R";
            this.R.Text = "R";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(233, 314);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(29, 29);
            this.E.TabIndex = 6;
            this.E.Tag = "E";
            this.E.Text = "E";
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(138, 314);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(35, 29);
            this.W.TabIndex = 5;
            this.W.Tag = "W";
            this.W.Text = "W";
            // 
            // Q
            // 
            this.Q.AutoSize = true;
            this.Q.Location = new System.Drawing.Point(46, 314);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(32, 29);
            this.Q.TabIndex = 4;
            this.Q.Tag = "Q";
            this.Q.Text = "Q";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.SeaShell;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(965, 519);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(130, 51);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyLevelToolStripMenuItem,
            this.sentenceToolStripMenuItem,
            this.quatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // difficultyLevelToolStripMenuItem
            // 
            this.difficultyLevelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevelToolStripMenuItem.Name = "difficultyLevelToolStripMenuItem";
            this.difficultyLevelToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.difficultyLevelToolStripMenuItem.Text = "Difficulty Level";
            this.difficultyLevelToolStripMenuItem.Click += new System.EventHandler(this.difficultyLevelToolStripMenuItem_Click);
            // 
            // sentenceToolStripMenuItem
            // 
            this.sentenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSentenceToolStripMenuItem,
            this.sentenceManagementToolStripMenuItem});
            this.sentenceToolStripMenuItem.Name = "sentenceToolStripMenuItem";
            this.sentenceToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.sentenceToolStripMenuItem.Text = "Sentence";
            // 
            // addSentenceToolStripMenuItem
            // 
            this.addSentenceToolStripMenuItem.Name = "addSentenceToolStripMenuItem";
            this.addSentenceToolStripMenuItem.Size = new System.Drawing.Size(298, 32);
            this.addSentenceToolStripMenuItem.Text = "Add Sentence";
            this.addSentenceToolStripMenuItem.Click += new System.EventHandler(this.addSentenceToolStripMenuItem_Click);
            // 
            // sentenceManagementToolStripMenuItem
            // 
            this.sentenceManagementToolStripMenuItem.Name = "sentenceManagementToolStripMenuItem";
            this.sentenceManagementToolStripMenuItem.Size = new System.Drawing.Size(298, 32);
            this.sentenceManagementToolStripMenuItem.Text = "Sentence Management";
            this.sentenceManagementToolStripMenuItem.Click += new System.EventHandler(this.sentenceManagementToolStripMenuItem_Click);
            // 
            // quatToolStripMenuItem
            // 
            this.quatToolStripMenuItem.Name = "quatToolStripMenuItem";
            this.quatToolStripMenuItem.Size = new System.Drawing.Size(73, 32);
            this.quatToolStripMenuItem.Text = "Close";
            this.quatToolStripMenuItem.Click += new System.EventHandler(this.quatToolStripMenuItem_Click);
            // 
            // FormTypingTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1312, 650);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormTypingTutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Tutor";
            this.Load += new System.EventHandler(this.FormTypingTutor_Load);
            this.panelReset.ResumeLayout(false);
            this.panelReset.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Label Q;
        private System.Windows.Forms.Label LabelShift;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.Label J;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label O;
        private System.Windows.Forms.Label I;
        private System.Windows.Forms.Label U;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label Spacebar;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Z;
        private System.Windows.Forms.Label InvalidKey;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Label labelMaxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label LabDot;
        private System.Windows.Forms.Label LabComma;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem difficultyLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSentenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentenceManagementToolStripMenuItem;
    }
}

