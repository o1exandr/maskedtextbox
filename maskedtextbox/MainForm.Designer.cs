namespace maskedtextbox
{
    partial class MainForm
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
            this.lbMask = new System.Windows.Forms.Label();
            this.msMask = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbMask
            // 
            this.lbMask.AutoSize = true;
            this.lbMask.Location = new System.Drawing.Point(12, 18);
            this.lbMask.Name = "lbMask";
            this.lbMask.Size = new System.Drawing.Size(103, 13);
            this.lbMask.TabIndex = 0;
            this.lbMask.Text = "Enter phone number";
            // 
            // msMask
            // 
            this.msMask.BeepOnError = true;
            this.msMask.Location = new System.Drawing.Point(132, 15);
            this.msMask.Mask = "(999) 000-0000";
            this.msMask.Name = "msMask";
            this.msMask.Size = new System.Drawing.Size(93, 20);
            this.msMask.TabIndex = 1;
            this.msMask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msMask_MaskInputRejected);
            this.msMask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msMask_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 53);
            this.Controls.Add(this.msMask);
            this.Controls.Add(this.lbMask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMask;
        private System.Windows.Forms.MaskedTextBox msMask;
    }
}

