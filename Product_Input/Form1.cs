using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 銷售列表
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			var productName = textBox1.Text;
			var quantitiy = (int)numericUpDown1.Value;

			string[] rowA = { productName, quantitiy.ToString() };

			int listIndex = Find(productName);

			if (listIndex != -1)
			{
				var existQuant = Convert.ToInt32(listView1.Items[listIndex].SubItems[1].Text);

				int existQuantAdd = existQuant + quantitiy;
				listView1.Items[listIndex].SubItems[1].Text = existQuantAdd.ToString();
			}
			else
			{
				listView1.Items.Add(new ListViewItem(rowA));
			}

		}

		private int Find(string productName)
		{
			
			foreach (ListViewItem item in listView1.Items)
			{
				if (item.SubItems[0].Text == productName)
				{
					return item.Index;
				}
			}
			return -1;
		}
	}
}
