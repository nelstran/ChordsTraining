namespace ChordsTraining
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chordLabel = new System.Windows.Forms.Label();
            this.revealButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.keysPanel = new System.Windows.Forms.Panel();
            this.quizButton = new System.Windows.Forms.Button();
            this.GButton = new System.Windows.Forms.Button();
            this.GSharpButton = new System.Windows.Forms.Button();
            this.FSharpButton = new System.Windows.Forms.Button();
            this.Dbutton = new System.Windows.Forms.Button();
            this.CSharpButton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.ESharpButton = new System.Windows.Forms.Button();
            this.FButton = new System.Windows.Forms.Button();
            this.DSharpButton = new System.Windows.Forms.Button();
            this.Bbutton = new System.Windows.Forms.Button();
            this.ASharpButton = new System.Windows.Forms.Button();
            this.Abutton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.majButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.augButton = new System.Windows.Forms.Button();
            this.dimButton = new System.Windows.Forms.Button();
            this.sevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.keysPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(952, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // chordLabel
            // 
            this.chordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chordLabel.Location = new System.Drawing.Point(296, 10);
            this.chordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.chordLabel.Name = "chordLabel";
            this.chordLabel.Size = new System.Drawing.Size(406, 77);
            this.chordLabel.TabIndex = 1;
            this.chordLabel.Text = "label1";
            this.chordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // revealButton
            // 
            this.revealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revealButton.Location = new System.Drawing.Point(244, 467);
            this.revealButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.revealButton.Name = "revealButton";
            this.revealButton.Size = new System.Drawing.Size(250, 77);
            this.revealButton.TabIndex = 2;
            this.revealButton.Text = "Reveal";
            this.revealButton.UseVisualStyleBackColor = true;
            this.revealButton.UseWaitCursor = true;
            this.revealButton.Click += new System.EventHandler(this.revealButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(504, 467);
            this.nextButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(250, 77);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // keysPanel
            // 
            this.keysPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.keysPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keysPanel.Controls.Add(this.quizButton);
            this.keysPanel.Controls.Add(this.GButton);
            this.keysPanel.Controls.Add(this.GSharpButton);
            this.keysPanel.Controls.Add(this.FSharpButton);
            this.keysPanel.Controls.Add(this.Dbutton);
            this.keysPanel.Controls.Add(this.CSharpButton);
            this.keysPanel.Controls.Add(this.Cbutton);
            this.keysPanel.Controls.Add(this.ESharpButton);
            this.keysPanel.Controls.Add(this.FButton);
            this.keysPanel.Controls.Add(this.DSharpButton);
            this.keysPanel.Controls.Add(this.Bbutton);
            this.keysPanel.Controls.Add(this.ASharpButton);
            this.keysPanel.Controls.Add(this.Abutton);
            this.keysPanel.Controls.Add(this.backButton);
            this.keysPanel.Location = new System.Drawing.Point(0, 0);
            this.keysPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keysPanel.Name = "keysPanel";
            this.keysPanel.Size = new System.Drawing.Size(454, 560);
            this.keysPanel.TabIndex = 4;
            // 
            // quizButton
            // 
            this.quizButton.BackColor = System.Drawing.Color.Transparent;
            this.quizButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.quizButton.FlatAppearance.BorderSize = 0;
            this.quizButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quizButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizButton.Location = new System.Drawing.Point(-2, 460);
            this.quizButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(456, 83);
            this.quizButton.TabIndex = 25;
            this.quizButton.Text = "Quiz yourself!";
            this.quizButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.quizButton.UseVisualStyleBackColor = false;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // GButton
            // 
            this.GButton.BackColor = System.Drawing.Color.Transparent;
            this.GButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GButton.FlatAppearance.BorderSize = 0;
            this.GButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GButton.Location = new System.Drawing.Point(174, 363);
            this.GButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(94, 83);
            this.GButton.TabIndex = 24;
            this.GButton.Text = "G";
            this.GButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GButton.UseVisualStyleBackColor = false;
            this.GButton.Click += new System.EventHandler(this.GButton_Click);
            // 
            // GSharpButton
            // 
            this.GSharpButton.BackColor = System.Drawing.Color.Transparent;
            this.GSharpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GSharpButton.FlatAppearance.BorderSize = 0;
            this.GSharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GSharpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GSharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GSharpButton.Location = new System.Drawing.Point(288, 365);
            this.GSharpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GSharpButton.Name = "GSharpButton";
            this.GSharpButton.Size = new System.Drawing.Size(140, 83);
            this.GSharpButton.TabIndex = 23;
            this.GSharpButton.Text = "G#";
            this.GSharpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GSharpButton.UseVisualStyleBackColor = false;
            this.GSharpButton.Click += new System.EventHandler(this.GSharpButton_Click);
            // 
            // FSharpButton
            // 
            this.FSharpButton.BackColor = System.Drawing.Color.Transparent;
            this.FSharpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.FSharpButton.FlatAppearance.BorderSize = 0;
            this.FSharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FSharpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FSharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSharpButton.Location = new System.Drawing.Point(22, 365);
            this.FSharpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FSharpButton.Name = "FSharpButton";
            this.FSharpButton.Size = new System.Drawing.Size(138, 83);
            this.FSharpButton.TabIndex = 22;
            this.FSharpButton.Text = "F#";
            this.FSharpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FSharpButton.UseVisualStyleBackColor = false;
            this.FSharpButton.Click += new System.EventHandler(this.FSharpButton_Click);
            // 
            // Dbutton
            // 
            this.Dbutton.BackColor = System.Drawing.Color.Transparent;
            this.Dbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dbutton.FlatAppearance.BorderSize = 0;
            this.Dbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Dbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Dbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbutton.Location = new System.Drawing.Point(334, 187);
            this.Dbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Dbutton.Name = "Dbutton";
            this.Dbutton.Size = new System.Drawing.Size(94, 83);
            this.Dbutton.TabIndex = 21;
            this.Dbutton.Text = "D";
            this.Dbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Dbutton.UseVisualStyleBackColor = false;
            this.Dbutton.Click += new System.EventHandler(this.Dbutton_Click);
            // 
            // CSharpButton
            // 
            this.CSharpButton.BackColor = System.Drawing.Color.Transparent;
            this.CSharpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CSharpButton.FlatAppearance.BorderSize = 0;
            this.CSharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CSharpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CSharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSharpButton.Location = new System.Drawing.Point(150, 187);
            this.CSharpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CSharpButton.Name = "CSharpButton";
            this.CSharpButton.Size = new System.Drawing.Size(142, 83);
            this.CSharpButton.TabIndex = 20;
            this.CSharpButton.Text = "C#";
            this.CSharpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CSharpButton.UseVisualStyleBackColor = false;
            this.CSharpButton.Click += new System.EventHandler(this.CSharpButton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.BackColor = System.Drawing.Color.Transparent;
            this.Cbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbutton.FlatAppearance.BorderSize = 0;
            this.Cbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbutton.Location = new System.Drawing.Point(22, 187);
            this.Cbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(94, 83);
            this.Cbutton.TabIndex = 19;
            this.Cbutton.Text = "C";
            this.Cbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cbutton.UseVisualStyleBackColor = false;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // ESharpButton
            // 
            this.ESharpButton.BackColor = System.Drawing.Color.Transparent;
            this.ESharpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ESharpButton.FlatAppearance.BorderSize = 0;
            this.ESharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ESharpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ESharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESharpButton.Location = new System.Drawing.Point(174, 269);
            this.ESharpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ESharpButton.Name = "ESharpButton";
            this.ESharpButton.Size = new System.Drawing.Size(94, 83);
            this.ESharpButton.TabIndex = 18;
            this.ESharpButton.Text = "E";
            this.ESharpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ESharpButton.UseVisualStyleBackColor = false;
            this.ESharpButton.Click += new System.EventHandler(this.ESharpButton_Click);
            // 
            // FButton
            // 
            this.FButton.BackColor = System.Drawing.Color.Transparent;
            this.FButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.FButton.FlatAppearance.BorderSize = 0;
            this.FButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FButton.Location = new System.Drawing.Point(332, 271);
            this.FButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(96, 83);
            this.FButton.TabIndex = 17;
            this.FButton.Text = "F";
            this.FButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FButton.UseVisualStyleBackColor = false;
            this.FButton.Click += new System.EventHandler(this.FButton_Click);
            // 
            // DSharpButton
            // 
            this.DSharpButton.BackColor = System.Drawing.Color.Transparent;
            this.DSharpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DSharpButton.FlatAppearance.BorderSize = 0;
            this.DSharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DSharpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DSharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSharpButton.Location = new System.Drawing.Point(22, 271);
            this.DSharpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DSharpButton.Name = "DSharpButton";
            this.DSharpButton.Size = new System.Drawing.Size(138, 83);
            this.DSharpButton.TabIndex = 16;
            this.DSharpButton.Text = "D#";
            this.DSharpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DSharpButton.UseVisualStyleBackColor = false;
            this.DSharpButton.Click += new System.EventHandler(this.DSharpButton_Click);
            // 
            // Bbutton
            // 
            this.Bbutton.BackColor = System.Drawing.Color.Transparent;
            this.Bbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bbutton.FlatAppearance.BorderSize = 0;
            this.Bbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbutton.Location = new System.Drawing.Point(334, 92);
            this.Bbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.Size = new System.Drawing.Size(94, 83);
            this.Bbutton.TabIndex = 9;
            this.Bbutton.Text = "B";
            this.Bbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bbutton.UseVisualStyleBackColor = false;
            this.Bbutton.Click += new System.EventHandler(this.Bbutton_Click);
            // 
            // ASharpButton
            // 
            this.ASharpButton.BackColor = System.Drawing.Color.Transparent;
            this.ASharpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ASharpButton.FlatAppearance.BorderSize = 0;
            this.ASharpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ASharpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ASharpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ASharpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASharpButton.Location = new System.Drawing.Point(150, 92);
            this.ASharpButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ASharpButton.Name = "ASharpButton";
            this.ASharpButton.Size = new System.Drawing.Size(142, 83);
            this.ASharpButton.TabIndex = 8;
            this.ASharpButton.Text = "A#";
            this.ASharpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ASharpButton.UseVisualStyleBackColor = false;
            this.ASharpButton.Click += new System.EventHandler(this.ASharpButton_Click);
            // 
            // Abutton
            // 
            this.Abutton.BackColor = System.Drawing.Color.Transparent;
            this.Abutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Abutton.FlatAppearance.BorderSize = 0;
            this.Abutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Abutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Abutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abutton.Location = new System.Drawing.Point(22, 92);
            this.Abutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Abutton.Name = "Abutton";
            this.Abutton.Size = new System.Drawing.Size(94, 83);
            this.Abutton.TabIndex = 7;
            this.Abutton.Text = "A";
            this.Abutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Abutton.UseVisualStyleBackColor = false;
            this.Abutton.Click += new System.EventHandler(this.Abutton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(6, -8);
            this.backButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 83);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "←";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(0, 0);
            this.menuButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(94, 75);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "≡";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 5;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // majButton
            // 
            this.majButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majButton.Location = new System.Drawing.Point(30, 463);
            this.majButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.majButton.Name = "majButton";
            this.majButton.Size = new System.Drawing.Size(162, 77);
            this.majButton.TabIndex = 6;
            this.majButton.Text = "Reveal";
            this.majButton.Visible = false;
            this.majButton.Click += new System.EventHandler(this.majButton_Click);
            // 
            // minButton
            // 
            this.minButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.Location = new System.Drawing.Point(224, 463);
            this.minButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(162, 77);
            this.minButton.TabIndex = 7;
            this.minButton.Text = "Reveal";
            this.minButton.Visible = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // augButton
            // 
            this.augButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.augButton.Location = new System.Drawing.Point(612, 463);
            this.augButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.augButton.Name = "augButton";
            this.augButton.Size = new System.Drawing.Size(162, 77);
            this.augButton.TabIndex = 8;
            this.augButton.Text = "Reveal";
            this.augButton.Visible = false;
            this.augButton.Click += new System.EventHandler(this.augButton_Click);
            // 
            // dimButton
            // 
            this.dimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimButton.Location = new System.Drawing.Point(806, 463);
            this.dimButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dimButton.Name = "dimButton";
            this.dimButton.Size = new System.Drawing.Size(162, 77);
            this.dimButton.TabIndex = 9;
            this.dimButton.Text = "Reveal";
            this.dimButton.Visible = false;
            this.dimButton.Click += new System.EventHandler(this.dimButton_Click);
            // 
            // sevButton
            // 
            this.sevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevButton.Location = new System.Drawing.Point(418, 463);
            this.sevButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sevButton.Name = "sevButton";
            this.sevButton.Size = new System.Drawing.Size(162, 77);
            this.sevButton.TabIndex = 10;
            this.sevButton.Text = "Reveal";
            this.sevButton.Visible = false;
            this.sevButton.Click += new System.EventHandler(this.sevButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 560);
            this.Controls.Add(this.keysPanel);
            this.Controls.Add(this.sevButton);
            this.Controls.Add(this.dimButton);
            this.Controls.Add(this.augButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.majButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.revealButton);
            this.Controls.Add(this.chordLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Chords";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.keysPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label chordLabel;
        private System.Windows.Forms.Button revealButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel keysPanel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button Abutton;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.Button GSharpButton;
        private System.Windows.Forms.Button FSharpButton;
        private System.Windows.Forms.Button Dbutton;
        private System.Windows.Forms.Button CSharpButton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button ESharpButton;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.Button DSharpButton;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Button ASharpButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button majButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button augButton;
        private System.Windows.Forms.Button dimButton;
        private System.Windows.Forms.Button sevButton;
    }
}

