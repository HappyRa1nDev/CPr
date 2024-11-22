using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompLab3
{

    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        public int R, G, B;

        private void changePanelColor()
        {
            if (!(rBox.notation == gBox.notation && gBox.notation == bBox.notation))
                return;

            R = 0; G = 0; B = 0;
            Color color;

            if (decBtn.Checked && rBox.notation == ColorBoxNew.Notation.DEC)
            {
                R = Int32.Parse(rBox.Text);
                G = Int32.Parse(gBox.Text);
                B = Int32.Parse(bBox.Text);
            }

            if (hexBtn.Checked && rBox.notation == ColorBoxNew.Notation.HEX)
            {
                R = Convert.ToInt32("0x" + rBox.Text, 16);
                G = Convert.ToInt32("0x" + gBox.Text, 16);
                B = Convert.ToInt32("0x" + bBox.Text, 16);
            }

            color = Color.FromArgb(R, G, B);

            ColorPanel.BackColor = color;

        }

        private void rBox_TextChanged(object sender, EventArgs e)
        {
            if (rBox.Text != "")
                changePanelColor();
        }

        private void gBox_TextChanged(object sender, EventArgs e)
        {
            if (gBox.Text != "")
                changePanelColor();
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {
            if (bBox.Text != "")
                changePanelColor();
        }

        private void decBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBox.notation != ColorBoxNew.Notation.DEC)
            {
                rBox.notation = ColorBoxNew.Notation.DEC;
                rBox.Text = int.Parse(rBox.Text, System.Globalization.NumberStyles.HexNumber).ToString();

                gBox.notation = ColorBoxNew.Notation.DEC;
                gBox.Text = int.Parse(gBox.Text, System.Globalization.NumberStyles.HexNumber).ToString();

                bBox.notation = ColorBoxNew.Notation.DEC;
                bBox.Text = int.Parse(bBox.Text, System.Globalization.NumberStyles.HexNumber).ToString();
            }
        }

        private void hexBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rBox.notation != ColorBoxNew.Notation.HEX)
            {
                rBox.notation = ColorBoxNew.Notation.HEX;
                rBox.Text = Int32.Parse(rBox.Text).ToString("X");

                gBox.notation = ColorBoxNew.Notation.HEX;
                gBox.Text = Int32.Parse(gBox.Text).ToString("X");

                bBox.notation = ColorBoxNew.Notation.HEX;
                bBox.Text = Int32.Parse(bBox.Text).ToString("X");
            }
        }
    }
}
