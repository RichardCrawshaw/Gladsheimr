namespace Cbus.Gladsheimr.UserControls
{
    partial class BoolControl
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(3, 5);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(95, 24);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "CheckBox";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(131, 3);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(49, 24);
            this.radioButtonF.TabIndex = 1;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "On";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(182, 3);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(51, 24);
            this.radioButtonR.TabIndex = 2;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "Off";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 20);
            this.label.TabIndex = 3;
            this.label.Text = "label";
            // 
            // BoolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonR);
            this.Name = "BoolControl";
            this.Size = new System.Drawing.Size(441, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.RadioButton radioButtonOff;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.Label label;
    }
}
