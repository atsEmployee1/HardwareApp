namespace HardwareApp
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
            this.txtJobPreview = new System.Windows.Forms.TextBox();
            this.btnRunJob = new System.Windows.Forms.Button();
            this.lblJobStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtJobPreview
            // 
            this.txtJobPreview.Location = new System.Drawing.Point(235, 139);
            this.txtJobPreview.Multiline = true;
            this.txtJobPreview.Name = "txtJobPreview";
            this.txtJobPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJobPreview.Size = new System.Drawing.Size(365, 69);
            this.txtJobPreview.TabIndex = 0;
            // 
            // btnRunJob
            // 
            this.btnRunJob.Location = new System.Drawing.Point(441, 94);
            this.btnRunJob.Name = "btnRunJob";
            this.btnRunJob.Size = new System.Drawing.Size(75, 23);
            this.btnRunJob.TabIndex = 1;
            this.btnRunJob.Text = "button1";
            this.btnRunJob.UseVisualStyleBackColor = true;
            this.btnRunJob.Click += new System.EventHandler(this.btnRunJob_Click);
            // 
            // lblJobStatus
            // 
            this.lblJobStatus.AutoSize = true;
            this.lblJobStatus.Location = new System.Drawing.Point(232, 233);
            this.lblJobStatus.Name = "lblJobStatus";
            this.lblJobStatus.Size = new System.Drawing.Size(51, 20);
            this.lblJobStatus.TabIndex = 2;
            this.lblJobStatus.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblJobStatus);
            this.Controls.Add(this.btnRunJob);
            this.Controls.Add(this.txtJobPreview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJobPreview;
        private System.Windows.Forms.Button btnRunJob;
        private System.Windows.Forms.Label lblJobStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

