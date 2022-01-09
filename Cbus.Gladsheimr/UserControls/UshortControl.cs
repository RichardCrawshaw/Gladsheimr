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
    public partial class UshortControl : UserControl,
        IUshortControl
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
                Update();
            }
        }

        public ushort Value
        {
            get => Get();
            set => Set(value);
        }

        #endregion

        #region Constructors

        public UshortControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public ushort Get() => (ushort)this.numericUpDown.Value;

        public void Set(ushort value) => this.numericUpDown.Value = value;

        #endregion

        #region Support routines

        private void Update()
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
