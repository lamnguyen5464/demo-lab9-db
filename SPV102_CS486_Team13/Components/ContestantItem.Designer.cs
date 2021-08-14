
namespace SPV102_CS486_Team13.Components
{
    partial class ContestantItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonName = new System.Windows.Forms.Button();
            this.buttonBirthday = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBirthday);
            this.panel1.Controls.Add(this.buttonName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 79);
            this.panel1.TabIndex = 0;
            // 
            // buttonName
            // 
            this.buttonName.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonName.Location = new System.Drawing.Point(0, 0);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(386, 38);
            this.buttonName.TabIndex = 0;
            this.buttonName.Text = "button1";
            this.buttonName.UseVisualStyleBackColor = true;
            // 
            // buttonBirthday
            // 
            this.buttonBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBirthday.Location = new System.Drawing.Point(0, 38);
            this.buttonBirthday.Name = "buttonBirthday";
            this.buttonBirthday.Size = new System.Drawing.Size(386, 41);
            this.buttonBirthday.TabIndex = 1;
            this.buttonBirthday.Text = "button2";
            this.buttonBirthday.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(386, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 79;
            this.iconPictureBox1.Location = new System.Drawing.Point(819, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(82, 79);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // ContestantItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "ContestantItem";
            this.Size = new System.Drawing.Size(901, 79);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBirthday;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
