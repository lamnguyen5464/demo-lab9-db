
namespace TestApp
{
    partial class CountryItem
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
            this.panelCountry = new System.Windows.Forms.Panel();
            this.buttonCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCountry
            // 
            this.panelCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.panelCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCountry.Location = new System.Drawing.Point(0, 50);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(199, 62);
            this.panelCountry.TabIndex = 3;
            // 
            // buttonCountry
            // 
            this.buttonCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCountry.FlatAppearance.BorderSize = 0;
            this.buttonCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCountry.Location = new System.Drawing.Point(0, 0);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(199, 50);
            this.buttonCountry.TabIndex = 2;
            this.buttonCountry.Text = "Việt Nam";
            this.buttonCountry.UseVisualStyleBackColor = true;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // CountryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panelCountry);
            this.Controls.Add(this.buttonCountry);
            this.Name = "CountryItem";
            this.Size = new System.Drawing.Size(199, 147);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCountry;
        private System.Windows.Forms.Button buttonCountry;
    }
}
