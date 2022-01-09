using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cbus.Gladsheimr.UserControls;

namespace Cbus.Gladsheimr.Gui
{
    public partial class MainForm : Form
    {
        #region Consstructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Support routines

        private void DisplayOpCodeControl(ToolStripMenuItem? tsmi)
        {
            this.panelOpCodes.Controls.Clear();
            if (tsmi is null) return;

            var control = GetUserControl(tsmi.Name);
            if (control is null && !IsOpCodeWithNoData(tsmi.Name))
                return;
            var label = GetLabel(tsmi.Text);
            var button = GetButton();

            if (control is not null)
                control.Size = new Size(this.panelOpCodes.Width - 6, control.Height);

            button.Location =
                new Point(
                    this.panelOpCodes.Width - button.Width - 6,
                    control is not null
                        ? control.Location.Y + control.Height + 3
                        : label.Location.Y + label.Height + 3);

            this.panelOpCodes.Controls.Add(label);
            if (control is not null)
                this.panelOpCodes.Controls.Add(control);
            this.panelOpCodes.Controls.Add(button);
        }

        private static Button GetButton()
        {
            var location = new Point(20, 70);
            var tabIndex = 3;

            return new Button
            {
                Location = location,
                Name = "buttonSubmitOpCode",
                Size = new Size(94, 29),
                TabIndex = tabIndex,
                TabStop = true,
                Text = "Submit",
            };
        }

        private static Label GetLabel(string text)
        {
            var label = new Label
            {
                BackColor = Color.AliceBlue,
                Dock = DockStyle.Top,
                Location = new Point(3, 3),
                Name = "labelOpCodeName",
                TabIndex = 0,
                Text = text,
            };
            return label;
        }

        #endregion

        #region Event handler routines

        private void TsmiOpCodeMenu_Click(object sender, EventArgs e) => 
            DisplayOpCodeControl(sender as ToolStripMenuItem);

        #endregion
    }
}
