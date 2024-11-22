using PointLib;
using System;
using System.Windows.Forms;

namespace FormApp2
{
	public partial class PointForm : Form
	{
		private Point[] points = null;
		public PointForm()
		{
			InitializeComponent();
		}

		private void Create_Click(object sender, EventArgs e)
		{

		}

		private void Sort_Click(object sender, EventArgs e)
		{

		}

		private void Serialize_Click(object sender, EventArgs e)
		{

		}

		private void Deserialize_Click(object sender, EventArgs e)
		{
			var dlg = new OpenFileDialog();
			dlg.Filter = "SOAP|*.soap|XML|*.xml|JSON|*.json|Binary|*.bin";

			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			using (var fs =
				new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
			{
				switch (Path.GetExtension(dlg.FileName))
				{
					case ".bin":
						var bf = new BinaryFormatter();
						points = (Point[])bf.Deserialize(fs);
						break;
				}
			}

			listBox.DataSource = null;
			listBox.DataSource = points;
		}
	}
}
