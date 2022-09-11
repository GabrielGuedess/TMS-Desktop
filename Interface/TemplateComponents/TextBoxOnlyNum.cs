﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.TemplateComponents
{
    public class TextBoxOnlyNum : TextBox
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            BackColor = Color.FromArgb(15, 15, 19);
            ForeColor = Color.White;
            BorderStyle = BorderStyle.None;
            Margin = new Padding(10, 6, 10, 5);
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Font = new Font(new FontFamily("Segoe UI"), 12, FontStyle.Regular);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;

            else
                e.Handled = true;
        }
    }
}
