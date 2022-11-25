using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.TemplateComponents
{
    public class TemplatePanel : Panel
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            Padding = new Padding(20, 20, 20, 10);
            Margin = new Padding(0, 0, 0, 0);
            BorderStyle = BorderStyle.None;
        }
    }
}
