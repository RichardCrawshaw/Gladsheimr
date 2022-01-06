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
    public partial class BoolControl : UserControl,
        IBoolControl
    {
        #region Fields

        private bool useCheckboxStyle;

        #endregion

        #region Properties

        public string LabelText 
        {
            get => this.label.Text;
            set => this.label.Text = value;
        }

        public string RadioButtonOnText
        {
            get => this.radioButtonOn.Text;
            set => this.radioButtonOn.Text = value;
        }

        public string RadioButtonOffText
        {
            get => this.radioButtonOff.Text;
            set => this.radioButtonOff.Text = value;
        }

        public bool UseCheckboxStyle
        {
            get => this.useCheckboxStyle;
            set
            {
                this.useCheckboxStyle = value;
                this.checkBox.Visible = this.useCheckboxStyle;
                this.label.Visible = !this.useCheckboxStyle;
                this.radioButtonOff.Visible = !this.useCheckboxStyle;
                this.radioButtonOn.Visible = !this.useCheckboxStyle;
            }
        }

        public bool Value
        {
            get => this.UseCheckboxStyle ? this.checkBox.Checked : this.radioButtonOn.Checked;
            set
            {
                if (this.UseCheckboxStyle)
                    this.checkBox.Checked = value;
                else
                {
                    this.radioButtonOn.Checked = value;
                    this.radioButtonOff.Checked = !value;
                }
            }
        }

        #endregion

        #region Constructors

        public BoolControl()
        {
            InitializeComponent();
        }

        #endregion
    }
}
