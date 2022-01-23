using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cbus.Gladsheimr.Interfaces;

namespace Cbus.Gladsheimr.UserControls
{
    public partial class ByteControl : UserControl,
        IByteControl
    {
        #region Properties

        public string LabelText
        {
            get => this.label.Text;
            set => this.label.Text = value;
        }

        public bool UseHex
        {
            get => this.numericUpDown.Hexadecimal;
            set
            {
                this.numericUpDown.Hexadecimal = value;
                UpdateControl();
            }
        }

        public byte Value 
        {
            get => (byte)this.numericUpDown.Value;
            set => this.numericUpDown.Value= value;
        }

        #endregion

        #region Constructors

        public ByteControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public byte Get() => (byte)this.numericUpDown.Value;

        #endregion

        #region Support routines

        private void UpdateControl()
        {
            this.labelBase.Text = this.UseHex ? "0x" : "dec";
        }

        #endregion

        #region Event handler routines

        private void LabelBase_DoubleClick(object sender, EventArgs e)
        {
            this.UseHex = !this.UseHex;
        }

        #endregion
    }
}
