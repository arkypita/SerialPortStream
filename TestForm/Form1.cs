using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RJCP.IO.Ports;

namespace TestForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SerialPortStream sps;

		private void BtnOpen_Click(object sender, EventArgs e)
		{
			if (sps == null)
			{
				sps = new SerialPortStream(TxtCom.Text);
				sps.BaudRate = 115200;
				sps.Open();
			}
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			if (sps != null)
			{
				sps.Close();
				sps = null;
			}
		}

		private void BtnTX_Click(object sender, EventArgs e)
		{
			if (sps != null && sps.IsOpen)
				sps.Write(TxtTX.Text);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (sps != null && sps.IsOpen)
			{
				string newtext = sps.ReadExisting();
				if (!string.IsNullOrEmpty(newtext))
					TxtRX.Text = TxtRX.Text + newtext;
			}
		}
	}
}
