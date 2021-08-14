
namespace SPV102_CS486_Team13.Screen
{
    partial class MainScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonAbout = new FontAwesome.Sharp.IconButton();
            this.panelRound = new System.Windows.Forms.Panel();
            this.buttonRounds = new FontAwesome.Sharp.IconButton();
            this.buttonExaminers = new FontAwesome.Sharp.IconButton();
            this.buttonContestant = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonAbout);
            this.panelLeft.Controls.Add(this.panelRound);
            this.panelLeft.Controls.Add(this.buttonRounds);
            this.panelLeft.Controls.Add(this.buttonExaminers);
            this.panelLeft.Controls.Add(this.buttonContestant);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(179, 502);
            this.panelLeft.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.IconChar = FontAwesome.Sharp.IconChar.React;
            this.buttonAbout.IconColor = System.Drawing.Color.Black;
            this.buttonAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAbout.IconSize = 20;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(0, 228);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(179, 40);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelRound
            // 
            this.panelRound.BackColor = System.Drawing.SystemColors.Control;
            this.panelRound.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRound.Location = new System.Drawing.Point(0, 120);
            this.panelRound.Name = "panelRound";
            this.panelRound.Size = new System.Drawing.Size(179, 108);
            this.panelRound.TabIndex = 3;
            // 
            // buttonRounds
            // 
            this.buttonRounds.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRounds.FlatAppearance.BorderSize = 0;
            this.buttonRounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRounds.IconChar = FontAwesome.Sharp.IconChar.React;
            this.buttonRounds.IconColor = System.Drawing.Color.Black;
            this.buttonRounds.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRounds.IconSize = 20;
            this.buttonRounds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRounds.Location = new System.Drawing.Point(0, 80);
            this.buttonRounds.Name = "buttonRounds";
            this.buttonRounds.Size = new System.Drawing.Size(179, 40);
            this.buttonRounds.TabIndex = 6;
            this.buttonRounds.Text = "Rounds";
            this.buttonRounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRounds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRounds.UseVisualStyleBackColor = true;
            this.buttonRounds.Click += new System.EventHandler(this.buttonRounds_Click_1);
            // 
            // buttonExaminers
            // 
            this.buttonExaminers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExaminers.FlatAppearance.BorderSize = 0;
            this.buttonExaminers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExaminers.IconChar = FontAwesome.Sharp.IconChar.React;
            this.buttonExaminers.IconColor = System.Drawing.Color.Black;
            this.buttonExaminers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonExaminers.IconSize = 20;
            this.buttonExaminers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExaminers.Location = new System.Drawing.Point(0, 40);
            this.buttonExaminers.Name = "buttonExaminers";
            this.buttonExaminers.Size = new System.Drawing.Size(179, 40);
            this.buttonExaminers.TabIndex = 5;
            this.buttonExaminers.Text = "Examiners";
            this.buttonExaminers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExaminers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExaminers.UseVisualStyleBackColor = true;
            // 
            // buttonContestant
            // 
            this.buttonContestant.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonContestant.FlatAppearance.BorderSize = 0;
            this.buttonContestant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContestant.IconChar = FontAwesome.Sharp.IconChar.React;
            this.buttonContestant.IconColor = System.Drawing.Color.Black;
            this.buttonContestant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonContestant.IconSize = 20;
            this.buttonContestant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContestant.Location = new System.Drawing.Point(0, 0);
            this.buttonContestant.Name = "buttonContestant";
            this.buttonContestant.Size = new System.Drawing.Size(179, 40);
            this.buttonContestant.TabIndex = 4;
            this.buttonContestant.Text = "Contestants";
            this.buttonContestant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContestant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonContestant.UseVisualStyleBackColor = true;
            this.buttonContestant.Click += new System.EventHandler(this.buttonContestant_Click);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(179, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(706, 40);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(179, 40);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(617, 462);
            this.panelMain.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(885, 502);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton buttonContestant;
        private System.Windows.Forms.Panel panelRound;
        private FontAwesome.Sharp.IconButton buttonRounds;
        private FontAwesome.Sharp.IconButton buttonExaminers;
        private FontAwesome.Sharp.IconButton buttonAbout;
    }
}
