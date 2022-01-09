namespace Cbus.Gladsheimr.UserControls
{
    partial class UintControl
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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 6);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 20);
            this.label.TabIndex = 0;
            this.label.Text = "label";
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(96, 3);
            this.textBox.MaxLength = 16;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(135, 27);
            this.textBox.TabIndex = 1;
            // 
            // labelBase
            // 
            this.labelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(57, 6);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(33, 20);
            this.labelBase.TabIndex = 3;
            this.labelBase.Text = "dec";
            this.labelBase.DoubleClick += new System.EventHandler(this.LabelBase_DoubleClick);
            // 
            // UintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Name = "UintControl";
            this.Size = new System.Drawing.Size(234, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelBase;
    }
}
