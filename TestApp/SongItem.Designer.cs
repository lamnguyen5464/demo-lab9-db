
namespace TestApp
{
    partial class SongItem
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
            this.panelName = new System.Windows.Forms.Panel();
            this.singer = new System.Windows.Forms.Label();
            this.composerName = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.view = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sq = new System.Windows.Forms.Button();
            this.offical = new System.Windows.Forms.Button();
            this.panelName.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.singer);
            this.panelName.Controls.Add(this.composerName);
            this.panelName.Controls.Add(this.songName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(339, 85);
            this.panelName.TabIndex = 0;
            // 
            // singer
            // 
            this.singer.AutoSize = true;
            this.singer.Location = new System.Drawing.Point(108, 45);
            this.singer.Name = "singer";
            this.singer.Size = new System.Drawing.Size(97, 20);
            this.singer.TabIndex = 2;
            this.singer.Text = "SingerName";
            // 
            // composerName
            // 
            this.composerName.AutoSize = true;
            this.composerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.composerName.Location = new System.Drawing.Point(0, 45);
            this.composerName.Name = "composerName";
            this.composerName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.composerName.Size = new System.Drawing.Size(102, 20);
            this.composerName.TabIndex = 1;
            this.composerName.Text = "Composer";
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Dock = System.Windows.Forms.DockStyle.Top;
            this.songName.Location = new System.Drawing.Point(0, 0);
            this.songName.Name = "songName";
            this.songName.Padding = new System.Windows.Forms.Padding(20, 25, 0, 0);
            this.songName.Size = new System.Drawing.Size(113, 45);
            this.songName.TabIndex = 0;
            this.songName.Text = "Song Name";
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.view);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelView.Location = new System.Drawing.Point(590, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(272, 85);
            this.panelView.TabIndex = 1;
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.Location = new System.Drawing.Point(42, 32);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(43, 20);
            this.view.TabIndex = 0;
            this.view.Text = "View";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sq);
            this.panel1.Controls.Add(this.offical);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(339, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 85);
            this.panel1.TabIndex = 2;
            // 
            // sq
            // 
            this.sq.Location = new System.Drawing.Point(173, 29);
            this.sq.Name = "sq";
            this.sq.Size = new System.Drawing.Size(42, 36);
            this.sq.TabIndex = 1;
            this.sq.Text = "SQ";
            this.sq.UseVisualStyleBackColor = true;
            // 
            // offical
            // 
            this.offical.Location = new System.Drawing.Point(30, 29);
            this.offical.Name = "offical";
            this.offical.Size = new System.Drawing.Size(109, 36);
            this.offical.TabIndex = 0;
            this.offical.Text = "OFFICIAL";
            this.offical.UseVisualStyleBackColor = true;
            // 
            // SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelName);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(862, 85);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label composerName;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Label view;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label singer;
        private System.Windows.Forms.Button sq;
        private System.Windows.Forms.Button offical;
    }
}
