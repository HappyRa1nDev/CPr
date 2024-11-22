using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CompLab3
{
	public partial class ColorBoxNew : TextBox
	{
		public ColorBoxNew()
		{
			InitializeComponent();
		}
		public enum Notation
		{
			DEC,
			HEX
		}

		public Notation notation;

		public ColorBoxNew(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
			this.TextAlign = HorizontalAlignment.Right;
			this.Text = "0";
			this.notation = Notation.DEC;
		}

		protected override void OnTextChanged(EventArgs e)
		{
			if (this.Text == "")
				return;
			int color = 0;

			if (this.notation == Notation.DEC)
			{
				if (Int32.TryParse(this.Text, out color))
					color = color > 255 ? 255 : color;
			}

			if (this.notation == Notation.HEX)
			{
				color = Convert.ToInt32("0x" + this.Text, 16);
				color = color > 0xFF ? 0xFF : color;
			}

			this.Text = this.notation == Notation.DEC ? color.ToString() : color.ToString("X");
			base.OnTextChanged(e);
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && this.notation == Notation.DEC)
			{
				e.Handled = true;
			}

			if (this.notation == Notation.HEX && e.KeyChar != 8 && !(Char.IsDigit(e.KeyChar) || Char.ToUpper(e.KeyChar) >= 'A' && Char.ToUpper(e.KeyChar) <= 'F'))
			{
				e.Handled = true;
			}
			base.OnKeyPress(e);
		}
	}
}
