
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
            this.buttonCountry = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelCountry
            // 
            this.panelCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(170)))));
            this.panelCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCountry.Location = new System.Drawing.Point(0, 50);
            this.panelCountry.Margin = new System.Windows.Forms.Padding(4);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(265, 206);
            this.panelCountry.TabIndex = 3;
            // 
            // buttonCountry
            // 
            this.buttonCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(122)))));
            this.buttonCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCountry.FlatAppearance.BorderSize = 0;
            this.buttonCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCountry.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.buttonCountry.IconColor = System.Drawing.Color.Crimson;
            this.buttonCountry.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCountry.Location = new System.Drawing.Point(0, 0);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Size = new System.Drawing.Size(265, 50);
            this.buttonCountry.TabIndex = 4;
            this.buttonCountry.Text = "iconButton1";
            this.buttonCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCountry.UseVisualStyleBackColor = false;
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click_1);
            // 
            // CountryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(11)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.panelCountry);
            this.Controls.Add(this.buttonCountry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CountryItem";
            this.Size = new System.Drawing.Size(265, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCountry;
        private FontAwesome.Sharp.IconButton buttonCountry;
    }
}
