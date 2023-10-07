using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp122
{
    class FButton : System.Windows.Forms.Button
    {

        public FButton() : base()
        {
            base.Text = "ثبت";
            base.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);

        }

        public override string Text
        {
            get { return base.Text; }
            set
            {

                base.Text = "ثبت";
            }
        }
        public new string Name
        {
            get => base.Name;
            set => base.Name = value;
        }
    }
}
