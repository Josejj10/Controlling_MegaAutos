namespace LP2MegaAutos
{
    partial class frmLoading
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
            this.panel_logo_empresa = new System.Windows.Forms.Panel();
            this.panelContainerLogin = new System.Windows.Forms.Panel();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panelContainerLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_logo_empresa
            // 
            this.panel_logo_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel_logo_empresa.BackgroundImage = global::LP2MegaAutos.Properties.Resources.logo_megaautos;
            this.panel_logo_empresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_logo_empresa.Location = new System.Drawing.Point(379, 12);
            this.panel_logo_empresa.Name = "panel_logo_empresa";
            this.panel_logo_empresa.Size = new System.Drawing.Size(48, 40);
            this.panel_logo_empresa.TabIndex = 17;
            this.panel_logo_empresa.Tag = "logo";
            // 
            // panelContainerLogin
            // 
            this.panelContainerLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panelContainerLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerLogin.Controls.Add(this.panelLoading);
            this.panelContainerLogin.Location = new System.Drawing.Point(155, 70);
            this.panelContainerLogin.Name = "panelContainerLogin";
            this.panelContainerLogin.Size = new System.Drawing.Size(490, 14);
            this.panelContainerLogin.TabIndex = 18;
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(45)))));
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(70, 14);
            this.panelLoading.TabIndex = 19;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Interval = 10;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 105);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainerLogin);
            this.Controls.Add(this.panel_logo_empresa);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.panelContainerLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_logo_empresa;
        private System.Windows.Forms.Panel panelContainerLogin;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Timer timerLoading;
    }
}