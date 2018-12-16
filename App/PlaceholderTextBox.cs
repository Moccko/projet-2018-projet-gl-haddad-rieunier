using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class PlaceholderTextBox : TextBox
    {
        public string Placeholder { get; set; }

        protected override void InitLayout()
        {
            Text = Placeholder;
        }

        protected override void OnEnter(EventArgs e)
        {
            if (Text == Placeholder)
                Text = "";
        }

        protected override void OnLeave(EventArgs e)
        {
            if (Text == "")
                Text = Placeholder;
        }
    }
}
