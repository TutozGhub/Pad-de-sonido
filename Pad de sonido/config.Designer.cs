namespace Pad_de_sonido
{
    partial class config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(config));
            this.btnAudacityConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAudacityConfig
            // 
            this.btnAudacityConfig.Location = new System.Drawing.Point(12, 12);
            this.btnAudacityConfig.Name = "btnAudacityConfig";
            this.btnAudacityConfig.Size = new System.Drawing.Size(101, 34);
            this.btnAudacityConfig.TabIndex = 0;
            this.btnAudacityConfig.Text = "Ruta Audacity";
            this.btnAudacityConfig.UseVisualStyleBackColor = true;
            this.btnAudacityConfig.Click += new System.EventHandler(this.btnAudacityConfig_Click);
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 227);
            this.Controls.Add(this.btnAudacityConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "config";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAudacityConfig;
    }
}