using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.TemplateComponents
{
    public class EmpDateTimer : DateTimePicker
    {
        protected override void InitLayout()
        {
            Margin = new Padding(10, 6, 10, 5);
            base.InitLayout();
            CustomFormat = " ";
            Format = DateTimePickerFormat.Custom;
            Anchor = AnchorStyles.Left | AnchorStyles.Right;
        }
        protected override void OnValueChanged(EventArgs eventargs)
        {
            base.OnValueChanged(eventargs);
            Format = DateTimePickerFormat.Short;
        }
    }
}
