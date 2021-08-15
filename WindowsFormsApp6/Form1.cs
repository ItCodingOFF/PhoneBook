using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		static DataSet ds;
		protected static DataSet Pb
		{
			get
			{
				if (ds == null)
					ds = new DataSet();
				return ds;
				
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			string filename = string.Format("{0}//data.dat", Application.StartupPath);
			//if (File.Exists(filename))
			//Pb.DataSetName.read

			

		}

		private void btnNew_Click(object sender, EventArgs e)
		{

		}

		private void bntEdit_Click(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnCansel_Click(object sender, EventArgs e)
		{

		}
	}
}
