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
    public partial class StringControl : UserControl,
        IStringControl
    {
        #region Properties

        public string LabelText
        {
            get => this.label.Text;
            set => this.label.Text = value;
        }

        public string Value
        {
            get => this.textBox.Text;
            set => this.textBox.Text = value;
        }

        #endregion

        #region Constructors

        public StringControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public string Get() => this.textBox.Text;

        #endregion
    }
}
