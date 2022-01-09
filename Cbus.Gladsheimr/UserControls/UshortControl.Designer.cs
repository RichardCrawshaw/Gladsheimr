namespace Cbus.Gladsheimr.UserControls
{
    partial class UshortControl
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
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelBase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 20);
            this.label.TabIndex = 0;
            this.label.Text = "label";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(127, 3);
            this.numericUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(104, 27);
            this.numericUpDown.TabIndex = 1;
            // 
            // labelBase
            // 
            this.labelBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(88, 5);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(33, 20);
            this.labelBase.TabIndex = 2;
            this.labelBase.Text = "dec";
            this.labelBase.DoubleClick += new System.EventHandler(this.LabelBase_DoubleClick);
            // 
            // UshortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label);
            this.Name = "UshortControl";
            this.Size = new System.Drawing.Size(234, 34);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label labelBase;
    }
}
