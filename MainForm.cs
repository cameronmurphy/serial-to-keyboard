using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace Camurphy.SerialToKeyboard
{
	public partial class MainForm : Form
	{
		private ISynchronizeInvoke m_Sync;
		private SerialPort m_SerialPort;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			cboSerialPort.Items.AddRange(SerialPort.GetPortNames());
			m_Sync = this;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (cboSerialPort.SelectedItem == null)
			{
				MessageBox.Show("Please select a serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				StartListening(cboSerialPort.SelectedItem.ToString());
			}
		}

		private void StartListening(string portName)
		{
			btnStart.Enabled = false;
			btnStop.Enabled = true;

			m_SerialPort = new SerialPort(portName);
			m_SerialPort.DataReceived += (sender, args) =>
			{
				string text = m_SerialPort.ReadExisting();

				if (text != null)
				{
					text = Regex.Replace(text, @"[^\d\r\n]", string.Empty);

					m_Sync.Invoke(new Action<string>((data) =>
					{
						SendKeys.Send(data);
					}), new object[] { text });
				}
			};
			m_SerialPort.Open();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (m_SerialPort != null && m_SerialPort.IsOpen)
			{
				m_SerialPort.Close();
			}
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			btnStart.Enabled = true;
			btnStop.Enabled = false;

			if (m_SerialPort != null && m_SerialPort.IsOpen)
			{
				m_SerialPort.Close();
			}
		}
	}
}
