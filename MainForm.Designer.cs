namespace Camurphy.SerialToKeyboard
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cboSerialPort = new System.Windows.Forms.ComboBox();
			this.lblSerialPort = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cboSerialPort
			// 
			this.cboSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSerialPort.FormattingEnabled = true;
			this.cboSerialPort.Location = new System.Drawing.Point(72, 12);
			this.cboSerialPort.Name = "cboSerialPort";
			this.cboSerialPort.Size = new System.Drawing.Size(83, 21);
			this.cboSerialPort.TabIndex = 0;
			// 
			// lblSerialPort
			// 
			this.lblSerialPort.AutoSize = true;
			this.lblSerialPort.Location = new System.Drawing.Point(12, 16);
			this.lblSerialPort.Name = "lblSerialPort";
			this.lblSerialPort.Size = new System.Drawing.Size(54, 13);
			this.lblSerialPort.TabIndex = 1;
			this.lblSerialPort.Text = "Serial port";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(167, 10);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 24);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(246, 10);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 24);
			this.btnStop.TabIndex = 3;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 45);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblSerialPort);
			this.Controls.Add(this.cboSerialPort);
			this.Name = "MainForm";
			this.Text = "Serial To Keyboard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboSerialPort;
		private System.Windows.Forms.Label lblSerialPort;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
	}
}

