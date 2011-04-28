/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 23/03/2008
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections ;
using System.Collections.Generic;
using System.Data ;
using System.IO ;
using System.Configuration ;
using System.Net;
using System.Net.Mail ;
using EnvRoomControler;

namespace envRoom
{
	/// <summary>
	/// Description of ShowValues.
	/// </summary>
	public partial class ShowValues : Form
	{
		EnvRoomControler.EnvControlerIO ECIO;
		bool IsRocording = false;
		DataTable RoomDataTable;
		DataTable RoomLastDataTable;
		string SaveRecordingFile = string.Empty ;
		
		public bool AlertsActive = false;
		public double AlertsTdiff;
		public double AlertsHdiff;
		public double AlertsPdiff;
		public double AlertsPtime;
		public string AlertsPhone = string.Empty;
		public string AlertsEmail = string.Empty;
		public DateTime LastAlertsPdiff  = DateTime.MaxValue;
		
		
		public ShowValues()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			ECIO = new EnvControlerIO();
			
			RoomDataTable = BuldDataTable(@"ControlerData");
			RoomLastDataTable = BuldDataTable(@"ControlerLastData");
			
			UpdateDefaults();
			
		}
		
		
		#region Handel UI actions
		
		void BtnGetValuesClick(object sender, EventArgs e)
		{
			UpdateAllValues();
		}
		
		void TxtTDoubleClick(object sender, EventArgs e)
		{
			((System.Windows.Forms.TextBox) sender).ReadOnly  = false;
		}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			if (txtTSP.ReadOnly == false)
			{
				ECIO.SetValue(new ControllerEntry("TemperatureSP",Convert.ToDouble( txtTSP.Text)));
				txtTSP.ReadOnly = true;
			}
			if (txtPSP.ReadOnly == false)
			{
				ECIO.SetValue(new ControllerEntry("PressureSP",Convert.ToDouble(txtPSP.Text)));
				txtPSP.ReadOnly = true;
			}
			if (txtHSP.ReadOnly == false)
			{
				ECIO.SetValue(new ControllerEntry("HumiditySP",Convert.ToDouble(txtHSP.Text)));
				txtHSP.ReadOnly = true;
			}
			
			UpdateAllValues();
		}
		void ShowValuesLoad(object sender, EventArgs e)
		{
			//EmailSMSSender.Sender.SendEmail("oferfrid@gmail.com","Differential Allert","dsf");
			UpdateAllValues();
			EventLoger.Source = "envRoom";
			EventLoger.Log = "Application";
			//SendEmail("test01234","tttt");
			
		}
		
		void ShowValuesResize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
				Hide();

		}
		
		void EnvRoomnotifyIconDoubleClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;

		}
		
		void GetValuesToolStripMenuItemClick(object sender, EventArgs e)
		{
			UpdateAllValues();
		}
		
		void CbRecordCheckStateChanged(object sender, EventArgs e)
		{
			if(((System.Windows.Forms.CheckBox)sender).Checked )
			{
				StartRecording();
			}
			else
			{
				StoptRecording();
			}
			
		}
		void StartRecordingToolStripMenuItemClick(object sender, EventArgs e)
		{
			ReplaseRecordValue();
		}
		
		void RecordtimerTick(object sender, EventArgs e)
		{
			List<ControllerEntry> ControlerData =  UpdateAllValues();
			RecordData(ControlerData);
			ChackAlerst(ControlerData);
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (saveDataFileDialog.ShowDialog() == DialogResult.OK)
			{
				SaveDataTableToCsvFile(saveDataFileDialog.FileName,RoomDataTable);
			}
		}
		
		void OptionsToolStripMenuItemClick(object sender, EventArgs e)
		{
			// Create a new form to represent the child form.
			Option childOption = new Option();
			// Display the child form
			childOption.MainForm = this;
			childOption.Show();
		}
		
		void RecordSaveStripMenuItemClick(object sender, EventArgs e)
		{
			if (saveDataFileDialog.ShowDialog() == DialogResult.OK)
			{
				SaveRecordingFile = saveDataFileDialog.FileName;
			}
			else
			{
				SaveRecordingFile = string.Empty ;
			}
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			About childAbout = new About();
			childAbout.Show();
		}
		
		
		void StartStopRecordingMenuStripClick(object sender, EventArgs e)
		{
			ReplaseRecordValue();
		}
		
		void RestoreStripMenuItemClick(object sender, EventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ShowValuesFormClosing(object sender, FormClosingEventArgs e)
		{
			if(e.CloseReason != CloseReason.WindowsShutDown)
			{
				DialogResult result = MessageBox.Show( @"Are you sure you'd like to Exit?",
				                                      @"Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning  );
				if ( result == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
			
		}
		
		
		
		#endregion
		
		#region private members
		
		private DataTable  BuldDataTable(string TableName)
		{
			List<ControllerEntry> myControllerEntrys = ECIO.GetDictionaryList();
			RoomData.Tables.Add(TableName);
			DataTable _DataTable = RoomData.Tables[TableName];
			_DataTable.Columns.Add(@"DateTime",System.Type.GetType("System.DateTime"));
			for(int i = 0 ;i < myControllerEntrys.Count;i++)
			{
				_DataTable.Columns.Add(myControllerEntrys[i].Name,System.Type.GetType("System.Decimal"));
			}
			
			return _DataTable;
		}
		
		
		private List<EnvRoomControler.ControllerEntry> UpdateAllValues()
		{
			
			List<ControllerEntry>  ControlerData = null ;
			try
			{
				ControlerData=  ECIO.GetCurentValues();
				
				
				foreach (ControllerEntry ce in ControlerData)
				{
					switch (ce.Name)
					{
						case "Temperature":
							txtT.Text =ce.EntryValue.ToString();
							break;
						case "Pressure":
							txtP.Text =ce.EntryValue.ToString();
							break;
						case "Humidity":
							txtH.Text =ce.EntryValue.ToString();
							break;
						case "TemperatureSP":
							txtTSP.Text =ce.EntryValue.ToString();
							break;
						case "PressureSP":
							txtPSP.Text = ce.EntryValue.ToString();
							break;
						case "HumiditySP":
							txtHSP.Text = ce.EntryValue.ToString();
							break;
						case "Steam":
							txtS.Text = ce.EntryValue.ToString();
							break;
					}
				}
			}
			catch(System.Net.WebException e)
			{
				ErrorMessage("Nework Error","Unable to onnect controler \n (ip: " +  ConfigurationManager.AppSettings["ControllerIP"] + ")",e);
			}
			
			return ControlerData;

		}
		
		private void ErrorMessage(string Caption, string Message ,Exception  e)
		{
			EnvRoomnotifyIcon.ShowBalloonTip(3000,Caption,Message,ToolTipIcon.Error);
			EventLoger.WriteEntry(Message + "\n" + e.ToString() ,System.Diagnostics.EventLogEntryType.Error);
		}
		
		private void StartRecording()
		{
			Recordtimer.Start();
			cbRecord.Checked = true;
			FormStripStatusLabel.Text = @"Data is recorded!";
			StartStopRecordingToolStripMenuItem.Text = @"Stop recording";
			StartStopRecordingMenuStrip.Text = @"Stop recording";
			IsRocording = true;
		}
		private void StoptRecording()
		{
			Recordtimer.Stop();
			cbRecord.Checked = false;
			FormStripStatusLabel.Text = @"Not recording data!";
			StartStopRecordingToolStripMenuItem.Text = @"Start recording";
			StartStopRecordingMenuStrip.Text = @"Start recording";
			IsRocording = false;
		}
		
		
		
		private void ReplaseRecordValue()
		{
			if(!IsRocording)
			{
				StartRecording();
			}
			else
			{
				StoptRecording();
			}
		}
		
		
		private void RecordData(List<EnvRoomControler.ControllerEntry> ControlerData)
		{
			if (ControlerData!=null)
			{
				object[] Values = new object[ControlerData.Count + 1];
				Values[0]=DateTime.Now ;
				for(int i=1 ; i<ControlerData.Count + 1;i++)
				{
					Values[i]=ControlerData[i-1].EntryValue;
				}
				RoomDataTable.Rows.Add(Values);
				if (SaveRecordingFile!=string.Empty)
				{
					RoomLastDataTable.Rows.Clear();
					RoomLastDataTable.Rows.Add(Values);
					AppendDataTableToCsvFile(SaveRecordingFile,RoomLastDataTable);
				}
			}
		}
		
		private void ChackAlerst(List<EnvRoomControler.ControllerEntry> ControlerData)
		{
			if (AlertsActive)
			{
				double Temperature=0;
				double TemperatureSP=0;
				double Humidity=0;
				double HumiditySP=0;
				double Pressure=0;
				double PressureSP=0;
				
				string Error = string.Empty;
				
				foreach (ControllerEntry ce in ControlerData)
				{
					switch (ce.Name)
					{
						case "Temperature":
							Temperature =ce.EntryValue;
							break;
						case "Pressure":
							Pressure =ce.EntryValue;
							break;
						case "Humidity":
							Humidity =ce.EntryValue;
							break;
						case "TemperatureSP":
							TemperatureSP =ce.EntryValue;
							break;
						case "PressureSP":
							PressureSP = ce.EntryValue;
							break;
						case "HumiditySP":
							HumiditySP = ce.EntryValue;
							break;
					}
				}
				
				if(Math.Abs(TemperatureSP-Temperature)>this.AlertsTdiff)
				{
					Error += "Temperature Diff Allert T=" + Temperature + "(SP=" + TemperatureSP + ")\n";
				}
				
				if(Math.Abs(HumiditySP-Humidity)>this.AlertsHdiff)
				{
					
					Error += "Humidity Diff Allert H=" + Humidity + "(SP=" + HumiditySP + ")\n";
				}
				
				if(Math.Abs(PressureSP-Pressure)>this.AlertsPdiff)
				{
					if (LastAlertsPdiff == DateTime.MaxValue)
					{
						LastAlertsPdiff = DateTime.Now ;
					}
					else
					{
						if (LastAlertsPdiff.AddMinutes(AlertsPtime) < DateTime.Now)
						{
							Error += "Pressure Diff Allert P=" + Pressure + "(SP=" + PressureSP + ")\n";
						}
					}
					
				}
				else
				{
					LastAlertsPdiff=DateTime.MaxValue;
				}
				
				if (Error !=String.Empty)
				{
					ErrorMessage("Differential Allert",Error,new Exception("Differential Allert" + Error));
					if (this.AlertsEmail != string.Empty)
					{
						EmailSMSSender.Sender.SendEmail(AlertsEmail,"Differential Allert",Error);
					}
					if (this.AlertsPhone != string.Empty)
					{
						try
						{
							EmailSMSSender.Sender.SendSMS(AlertsPhone,Error);
						}
						catch(Exception e)
						{
							ErrorMessage("Email Failier","Error Sending Email (" +e.Message + ")" ,e);
						}
						
					}
					AlertsActive = false;
				}
			}
		}
		
		
		private void UpdateDefaults()
		{
			Recordtimer.Interval =  Convert.ToInt32((Convert.ToDecimal(ConfigurationManager.AppSettings["DefaultRecordingInterval"])*60000));
			this.AlertsHdiff =  Convert.ToDouble(ConfigurationManager.AppSettings["DefaultHumidityDifferential"]);
			this.AlertsPdiff =  Convert.ToDouble(ConfigurationManager.AppSettings["DefaultPressureDifferential"]);
			this.AlertsPtime =  Convert.ToDouble(ConfigurationManager.AppSettings["DefaultPressureTime"]);
			this.AlertsTdiff =  Convert.ToDouble(ConfigurationManager.AppSettings["DefaultTemperatureDifferential"]);
		}
		
		
		#endregion
		
		#region Creates a CSV file
		/// <summary>
		/// Creates a CSV file
		/// </summary>
		/// <param name="AbsolutePathAndFileName"></param>
		/// <param name="TheDataTable"></param>
		/// <param name="Options">[0] = separator, e.g. ";" (default = ",")</param>
		public static void SaveDataTableToCsvFile(string AbsolutePathAndFileName, DataTable TheDataTable,params string[] Options)
		{
			//variables
			string separator;
			if (Options.Length > 0)
			{
				separator = Options[0];
			}
			else
			{
				separator = ","; //default
			}
			string quote =string.Empty ; //"\"";

			//create CSV file
			StreamWriter sw = new StreamWriter(AbsolutePathAndFileName);

			//write header line
			int iColCount = TheDataTable.Columns.Count;
			for (int i = 0; i < iColCount; i++)
			{
				sw.Write(TheDataTable.Columns[i]);
				if (i < iColCount - 1)
				{
					sw.Write(separator);
				}
			}
			sw.Write(sw.NewLine);

			//write rows
			foreach (DataRow dr in TheDataTable.Rows)
			{
				for (int i = 0; i < iColCount; i++)
				{
					if (!Convert.IsDBNull(dr[i]))
					{
						string data = dr[i].ToString();
						data = data.Replace("\"", "\\\"");
						sw.Write(quote + data + quote);
					}
					if (i < iColCount - 1)
					{
						sw.Write(separator);
					}
				}
				sw.Write(sw.NewLine);
			}
			sw.Close();
		}

		
		
		public void AppendDataTableToCsvFile(string AbsolutePathAndFileName, DataTable TheDataTable,params string[] Options)
		{
			//variables
			string separator;
			bool NewFile = true;
			if (Options.Length > 0)
			{
				separator = Options[0];
			}
			else
			{
				separator = ","; //default
			}
			string quote =string.Empty ; //"\"";
			
			//create CSV file

			if(File.Exists(AbsolutePathAndFileName))
			{
				NewFile = false;
			}
			
			
			
			try
			{
				StreamWriter sw = new StreamWriter(AbsolutePathAndFileName,true);
				int iColCount = TheDataTable.Columns.Count;
				
				if (NewFile)
				{
					//write header line
					
					for (int i = 0; i < iColCount; i++)
					{
						sw.Write(TheDataTable.Columns[i]);
						if (i < iColCount - 1)
						{
							sw.Write(separator);
						}
					}
					sw.Write(sw.NewLine);
				}
				
				//write rows
				foreach (DataRow dr in TheDataTable.Rows)
				{
					for (int i = 0; i < iColCount; i++)
					{
						if (!Convert.IsDBNull(dr[i]))
						{
							string data = dr[i].ToString();
							data = data.Replace("\"", "\\\"");
							sw.Write(quote + data + quote);
						}
						if (i < iColCount - 1)
						{
							sw.Write(separator);
						}
					}
					sw.Write(sw.NewLine);
				}
				sw.Close();
			}
			catch(IOException e)
			{
				ErrorMessage("IO Error","Unable to write file \n" +  AbsolutePathAndFileName , e);
			}
			
		}
		
		#endregion
		
	}
}
