using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cbus.Gladsheimr.Interfaces;

namespace Cbus.Gladsheimr.UserControls
{
    public partial class UintControl : UserControl,
        IUintControl
    {
        #region Fields

        private bool useHex;

        #endregion

        #region Properties

        public string LabelText
        {
            get => this.label.Text;
            set => this.label.Text = value;
        }

        public bool UseHex
        {
            get => this.useHex;
            set
            {
                this.useHex = value;
                this.labelBase.Text = this.useHex
                    ? "0x"
                    : "dec";
            }
        }

        public uint Value
        {
            get => Get();
            set => Set(Value);
        }

        #endregion

        #region Constructors

        public UintControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public uint Get()
        {
            var text =
                this.textBox.Text
                    .Trim()
                    .Replace(" ", "")
                    .Replace(",", "")
                    .Replace("-", "");
            if (this.UseHex)
            {
                if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                    text = text[2..];
                if (uint.TryParse(text, NumberStyles.HexNumber, null, out var value))
                    return value;
            }
            else if (uint.TryParse(text, out var value))
                return value;
            return 0;
        }

        public void Set(uint value)
        {
            if (this.UseHex)
                this.textBox.Text = value.ToString("X");
            else
                this.textBox.Text = value.ToString();
        }

        #endregion

        #region Event handler routines

        private void LabelBase_DoubleClick(object sender, EventArgs e)
        {
            var value = Get();
            this.UseHex = !this.UseHex;
            Set(value);
        }
        #endregion
    }
}
