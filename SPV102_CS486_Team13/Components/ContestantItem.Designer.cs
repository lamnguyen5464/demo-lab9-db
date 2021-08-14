
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonUni = new System.Windows.Forms.Button();
            this.buttonBD = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.panelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.buttonInfo);
            this.panelLayout.Controls.Add(this.buttonUni);
            this.panelLayout.Controls.Add(this.buttonBD);
            this.panelLayout.Controls.Add(this.buttonName);
            this.panelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayout.Location = new System.Drawing.Point(0, 0);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(1000, 58);
            this.panelLayout.TabIndex = 0;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInfo.Location = new System.Drawing.Point(757, 0);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(243, 58);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Moreinfo";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonUni
            // 
            this.buttonUni.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUni.Location = new System.Drawing.Point(483, 0);
            this.buttonUni.Name = "buttonUni";
            this.buttonUni.Size = new System.Drawing.Size(274, 58);
            this.buttonUni.TabIndex = 2;
            this.buttonUni.Text = "Uni";
            this.buttonUni.UseVisualStyleBackColor = true;
            // 
            // buttonBD
            // 
            this.buttonBD.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBD.Location = new System.Drawing.Point(325, 0);
            this.buttonBD.Name = "buttonBD";
            this.buttonBD.Size = new System.Drawing.Size(158, 58);
            this.buttonBD.TabIndex = 1;
            this.buttonBD.Text = "BD";
            this.buttonBD.UseVisualStyleBackColor = true;
            // 
            // buttonName
            // 
            this.buttonName.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonName.Location = new System.Drawing.Point(0, 0);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(325, 58);
            this.buttonName.TabIndex = 0;
            this.buttonName.Text = "Name";
            this.buttonName.UseVisualStyleBackColor = true;
            // 
            // ContestantItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLayout);
            this.Name = "ContestantItem";
            this.Size = new System.Drawing.Size(1000, 58);
            this.panelLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonUni;
        private System.Windows.Forms.Button buttonBD;
        private System.Windows.Forms.Button buttonName;
    }
}
