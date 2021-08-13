
namespace TestApp
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
            this.panelCat = new System.Windows.Forms.Panel();
            this.mainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.NameCat = new System.Windows.Forms.Label();
            this.extendPanel = new System.Windows.Forms.Panel();
            this.panelCatExtend = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.mainLayout.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.extendPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCat
            // 
            this.panelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(122)))));
            this.panelCat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCat.Location = new System.Drawing.Point(0, 0);
            this.panelCat.Margin = new System.Windows.Forms.Padding(4);
            this.panelCat.Name = "panelCat";
            this.panelCat.Size = new System.Drawing.Size(222, 624);
            this.panelCat.TabIndex = 0;
            // 
            // mainLayout
            // 
            this.mainLayout.Controls.Add(this.panelTop);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(222, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(744, 624);
            this.mainLayout.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.NameCat);
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(741, 42);
            this.panelTop.TabIndex = 0;
            // 
            // NameCat
            // 
            this.NameCat.AutoSize = true;
            this.NameCat.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameCat.Location = new System.Drawing.Point(0, 0);
            this.NameCat.Name = "NameCat";
            this.NameCat.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.NameCat.Size = new System.Drawing.Size(74, 30);
            this.NameCat.TabIndex = 0;
            this.NameCat.Text = "label1";
            // 
            // extendPanel
            // 
            this.extendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(170)))));
            this.extendPanel.Controls.Add(this.panelCatExtend);
            this.extendPanel.Controls.Add(this.panel1);
            this.extendPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.extendPanel.Location = new System.Drawing.Point(222, 0);
            this.extendPanel.Name = "extendPanel";
            this.extendPanel.Size = new System.Drawing.Size(206, 624);
            this.extendPanel.TabIndex = 2;
            // 
            // panelCatExtend
            // 
            this.panelCatExtend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatExtend.Location = new System.Drawing.Point(0, 45);
            this.panelCatExtend.Name = "panelCatExtend";
            this.panelCatExtend.Size = new System.Drawing.Size(206, 579);
            this.panelCatExtend.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 45);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(122)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(161, 7);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 624);
            this.Controls.Add(this.extendPanel);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.panelCat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainLayout.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.extendPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCat;
        private System.Windows.Forms.FlowLayoutPanel mainLayout;
        private System.Windows.Forms.Panel extendPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCatExtend;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label NameCat;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

