namespace PingMonitor
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.currentPingLabel = new System.Windows.Forms.Label();
            this.currentPing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greenLight = new System.Windows.Forms.Label();
            this.orangeLight = new System.Windows.Forms.Label();
            this.redLight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentPingLabel
            // 
            resources.ApplyResources(this.currentPingLabel, "currentPingLabel");
            this.currentPingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentPingLabel.Name = "currentPingLabel";
            this.currentPingLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentPing
            // 
            resources.ApplyResources(this.currentPing, "currentPing");
            this.currentPing.Name = "currentPing";
            this.currentPing.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // greenLight
            // 
            resources.ApplyResources(this.greenLight, "greenLight");
            this.greenLight.Name = "greenLight";
            // 
            // orangeLight
            // 
            resources.ApplyResources(this.orangeLight, "orangeLight");
            this.orangeLight.Name = "orangeLight";
            // 
            // redLight
            // 
            resources.ApplyResources(this.redLight, "redLight");
            this.redLight.Name = "redLight";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Test
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redLight);
            this.Controls.Add(this.orangeLight);
            this.Controls.Add(this.greenLight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPing);
            this.Controls.Add(this.currentPingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentPingLabel;
        private System.Windows.Forms.Label currentPing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label greenLight;
        private System.Windows.Forms.Label orangeLight;
        private System.Windows.Forms.Label redLight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

