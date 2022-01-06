namespace Cbus.Gladsheimr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.accErrorCodeControl1 = new Cbus.Gladsheimr.AccErrorCodeControl();
            this.csFlagsControl1 = new Cbus.Gladsheimr.CSFlagsControl();
            this.dccErrorCodeControl1 = new Cbus.Gladsheimr.DccErrorCodeControl();
            this.engineStateControl1 = new Cbus.Gladsheimr.EngineStateControl();
            this.functionRangeControl1 = new Cbus.Gladsheimr.FunctionRangeControl();
            this.monthControl1 = new Cbus.Gladsheimr.MonthControl();
            this.nodeFlagsControl1 = new Cbus.Gladsheimr.NodeFlagsControl();
            this.serviceModeControl1 = new Cbus.Gladsheimr.ServiceModeControl();
            this.SessionFlagsControl = new Cbus.Gladsheimr.SessionFlagsControl();
            this.sessionStatusControl1 = new Cbus.Gladsheimr.SessionStatusControl();
            this.speedModeControl1 = new Cbus.Gladsheimr.SpeedModeControl();
            this.weekdayControl1 = new Cbus.Gladsheimr.WeekdayControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //
            // accErrorCodeControl1
            //
            this.accErrorCodeControl1.Location = new System.Drawing.Point(30, 30);
            this.accErrorCodeControl1.Name = "accErrorCodeControl1";
            this.accErrorCodeControl1.Size= new System.Drawing.Size(100, 23);
            this.accErrorCodeControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accErrorCodeControl1);
            //this.Controls.Add(this.csFlagsControl1);
            //this.Controls.Add(this.dccErrorCodeControl1);
            //this.Controls.Add(this.engineStateControl1);
            //this.Controls.Add(this.functionRangeControl1);
            //this.Controls.Add(this.monthControl1);
            //this.Controls.Add(this.nodeFlagsControl1);
            //this.Controls.Add(this.serviceModeControl1);
            //this.Controls.Add(this.SessionFlagsControl);
            //this.Controls.Add(this.sessionStatusControl1);
            //this.Controls.Add(this.speedModeControl1);
            //this.Controls.Add(this.weekdayControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Cbus.Gladsheimr.AccErrorCodeControl accErrorCodeControl1;
        private Cbus.Gladsheimr.CSFlagsControl csFlagsControl1;
        private Cbus.Gladsheimr.DccErrorCodeControl dccErrorCodeControl1;
        private Cbus.Gladsheimr.EngineStateControl engineStateControl1;
        private Cbus.Gladsheimr.FunctionRangeControl functionRangeControl1;
        private Cbus.Gladsheimr.MonthControl monthControl1;
        private Cbus.Gladsheimr.NodeFlagsControl nodeFlagsControl1;
        private Cbus.Gladsheimr.ServiceModeControl serviceModeControl1;
        private Cbus.Gladsheimr.SessionFlagsControl SessionFlagsControl;
        private Cbus.Gladsheimr.SessionStatusControl sessionStatusControl1;
        private Cbus.Gladsheimr.SpeedModeControl speedModeControl1;
        private Cbus.Gladsheimr.WeekdayControl weekdayControl1;
        private System.Windows.Forms.Button button1;
    }
}
