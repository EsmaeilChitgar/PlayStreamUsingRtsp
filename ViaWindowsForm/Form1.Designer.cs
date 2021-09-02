namespace ViaWindowsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.btnPlayRtsp = new System.Windows.Forms.Button();
            this.btnPlayLocalFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(800, 450);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // btnPlayRtsp
            // 
            this.btnPlayRtsp.Location = new System.Drawing.Point(12, 87);
            this.btnPlayRtsp.Name = "btnPlayRtsp";
            this.btnPlayRtsp.Size = new System.Drawing.Size(107, 43);
            this.btnPlayRtsp.TabIndex = 4;
            this.btnPlayRtsp.Text = "Play RTSP";
            this.btnPlayRtsp.UseVisualStyleBackColor = true;
            this.btnPlayRtsp.Click += new System.EventHandler(this.btnPlayRtsp_Click);
            // 
            // btnPlayLocalFile
            // 
            this.btnPlayLocalFile.Location = new System.Drawing.Point(12, 12);
            this.btnPlayLocalFile.Name = "btnPlayLocalFile";
            this.btnPlayLocalFile.Size = new System.Drawing.Size(107, 43);
            this.btnPlayLocalFile.TabIndex = 3;
            this.btnPlayLocalFile.Text = "Play Local File";
            this.btnPlayLocalFile.UseVisualStyleBackColor = true;
            this.btnPlayLocalFile.Click += new System.EventHandler(this.btnPlayLocalFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayRtsp);
            this.Controls.Add(this.btnPlayLocalFile);
            this.Controls.Add(this.axVLCPlugin21);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Button btnPlayRtsp;
        private System.Windows.Forms.Button btnPlayLocalFile;
    }
}

