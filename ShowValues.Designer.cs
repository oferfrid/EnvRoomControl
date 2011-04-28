/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 23/03/2008
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace envRoom
{
	partial class ShowValues
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowValues));
			this.btnGetValues = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtT = new System.Windows.Forms.TextBox();
			this.txtH = new System.Windows.Forms.TextBox();
			this.txtP = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTSP = new System.Windows.Forms.TextBox();
			this.txtHSP = new System.Windows.Forms.TextBox();
			this.txtPSP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.EnvRoomnotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.IconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.RestoreStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartStopRecordingMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FormMenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.getValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StartStopRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RecordSaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FormStatusStrip = new System.Windows.Forms.StatusStrip();
			this.FormStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.cbRecord = new System.Windows.Forms.CheckBox();
			this.RoomData = new System.Data.DataSet();
			this.Recordtimer = new System.Windows.Forms.Timer(this.components);
			this.saveDataFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.label6 = new System.Windows.Forms.Label();
			this.txtS = new System.Windows.Forms.TextBox();
			this.EventLoger = new System.Diagnostics.EventLog();
			this.IconMenuStrip.SuspendLayout();
			this.FormMenuStrip.SuspendLayout();
			this.FormStatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EventLoger)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetValues
			// 
			this.btnGetValues.Image = ((System.Drawing.Image)(resources.GetObject("btnGetValues.Image")));
			this.btnGetValues.Location = new System.Drawing.Point(25, 35);
			this.btnGetValues.Name = "btnGetValues";
			this.btnGetValues.Size = new System.Drawing.Size(34, 27);
			this.btnGetValues.TabIndex = 0;
			this.btnGetValues.UseVisualStyleBackColor = true;
			this.btnGetValues.Click += new System.EventHandler(this.BtnGetValuesClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Temperature";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Humidity";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Pressure";
			// 
			// txtT
			// 
			this.txtT.Location = new System.Drawing.Point(93, 64);
			this.txtT.Name = "txtT";
			this.txtT.ReadOnly = true;
			this.txtT.Size = new System.Drawing.Size(47, 20);
			this.txtT.TabIndex = 2;
			// 
			// txtH
			// 
			this.txtH.Location = new System.Drawing.Point(93, 87);
			this.txtH.Name = "txtH";
			this.txtH.ReadOnly = true;
			this.txtH.Size = new System.Drawing.Size(47, 20);
			this.txtH.TabIndex = 3;
			// 
			// txtP
			// 
			this.txtP.Location = new System.Drawing.Point(93, 110);
			this.txtP.Name = "txtP";
			this.txtP.ReadOnly = true;
			this.txtP.Size = new System.Drawing.Size(47, 20);
			this.txtP.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(93, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 19);
			this.label4.TabIndex = 5;
			this.label4.Text = "Value";
			// 
			// txtTSP
			// 
			this.txtTSP.Location = new System.Drawing.Point(146, 64);
			this.txtTSP.Name = "txtTSP";
			this.txtTSP.ReadOnly = true;
			this.txtTSP.Size = new System.Drawing.Size(47, 20);
			this.txtTSP.TabIndex = 2;
			this.txtTSP.DoubleClick += new System.EventHandler(this.TxtTDoubleClick);
			// 
			// txtHSP
			// 
			this.txtHSP.Location = new System.Drawing.Point(146, 87);
			this.txtHSP.Name = "txtHSP";
			this.txtHSP.ReadOnly = true;
			this.txtHSP.Size = new System.Drawing.Size(47, 20);
			this.txtHSP.TabIndex = 3;
			this.txtHSP.DoubleClick += new System.EventHandler(this.TxtTDoubleClick);
			// 
			// txtPSP
			// 
			this.txtPSP.Location = new System.Drawing.Point(146, 110);
			this.txtPSP.Name = "txtPSP";
			this.txtPSP.ReadOnly = true;
			this.txtPSP.Size = new System.Drawing.Size(47, 20);
			this.txtPSP.TabIndex = 4;
			this.txtPSP.DoubleClick += new System.EventHandler(this.TxtTDoubleClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(146, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "SP";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(93, 161);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 20);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// EnvRoomnotifyIcon
			// 
			this.EnvRoomnotifyIcon.BalloonTipText = "Env Room Controler";
			this.EnvRoomnotifyIcon.BalloonTipTitle = "Env Room Controler";
			this.EnvRoomnotifyIcon.ContextMenuStrip = this.IconMenuStrip;
			this.EnvRoomnotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("EnvRoomnotifyIcon.Icon")));
			this.EnvRoomnotifyIcon.Text = "Env Room Controler";
			this.EnvRoomnotifyIcon.Visible = true;
			this.EnvRoomnotifyIcon.DoubleClick += new System.EventHandler(this.EnvRoomnotifyIconDoubleClick);
			// 
			// IconMenuStrip
			// 
			this.IconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.RestoreStripMenuItem,
									this.StartStopRecordingMenuStrip,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.IconMenuStrip.Name = "IconMenuStrip";
			this.IconMenuStrip.Size = new System.Drawing.Size(150, 76);
			// 
			// RestoreStripMenuItem
			// 
			this.RestoreStripMenuItem.Name = "RestoreStripMenuItem";
			this.RestoreStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.RestoreStripMenuItem.Text = "Restore";
			this.RestoreStripMenuItem.Click += new System.EventHandler(this.RestoreStripMenuItemClick);
			// 
			// StartStopRecordingMenuStrip
			// 
			this.StartStopRecordingMenuStrip.Name = "StartStopRecordingMenuStrip";
			this.StartStopRecordingMenuStrip.Size = new System.Drawing.Size(149, 22);
			this.StartStopRecordingMenuStrip.Text = "Start Recording";
			this.StartStopRecordingMenuStrip.Click += new System.EventHandler(this.StartStopRecordingMenuStripClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// FormMenuStrip
			// 
			this.FormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.FileMenu,
									this.toolsStripMenuItem,
									this.helpToolStripMenuItem});
			this.FormMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.FormMenuStrip.Name = "FormMenuStrip";
			this.FormMenuStrip.Size = new System.Drawing.Size(199, 24);
			this.FormMenuStrip.TabIndex = 8;
			this.FormMenuStrip.Text = "FormMenuStrip";
			// 
			// FileMenu
			// 
			this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.getValuesToolStripMenuItem,
									this.StartStopRecordingToolStripMenuItem,
									this.toolStripSeparator3,
									this.saveToolStripMenuItem,
									this.RecordSaveStripMenuItem});
			this.FileMenu.Name = "FileMenu";
			this.FileMenu.Size = new System.Drawing.Size(35, 20);
			this.FileMenu.Text = "File";
			// 
			// getValuesToolStripMenuItem
			// 
			this.getValuesToolStripMenuItem.Name = "getValuesToolStripMenuItem";
			this.getValuesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.getValuesToolStripMenuItem.Text = "Get Values";
			this.getValuesToolStripMenuItem.Click += new System.EventHandler(this.GetValuesToolStripMenuItemClick);
			// 
			// StartStopRecordingToolStripMenuItem
			// 
			this.StartStopRecordingToolStripMenuItem.Name = "StartStopRecordingToolStripMenuItem";
			this.StartStopRecordingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.StartStopRecordingToolStripMenuItem.Text = "Start recording";
			this.StartStopRecordingToolStripMenuItem.Click += new System.EventHandler(this.StartRecordingToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// RecordSaveStripMenuItem
			// 
			this.RecordSaveStripMenuItem.Name = "RecordSaveStripMenuItem";
			this.RecordSaveStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.RecordSaveStripMenuItem.Text = "Save Recording";
			this.RecordSaveStripMenuItem.Click += new System.EventHandler(this.RecordSaveStripMenuItemClick);
			// 
			// toolsStripMenuItem
			// 
			this.toolsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.optionsToolStripMenuItem});
			this.toolsStripMenuItem.Name = "toolsStripMenuItem";
			this.toolsStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsStripMenuItem.Text = "Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.optionsToolStripMenuItem.Text = "Options...";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// FormStatusStrip
			// 
			this.FormStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.FormStripStatusLabel});
			this.FormStatusStrip.Location = new System.Drawing.Point(0, 193);
			this.FormStatusStrip.Name = "FormStatusStrip";
			this.FormStatusStrip.Size = new System.Drawing.Size(199, 22);
			this.FormStatusStrip.TabIndex = 9;
			this.FormStatusStrip.Text = "statusStrip1";
			// 
			// FormStripStatusLabel
			// 
			this.FormStripStatusLabel.Name = "FormStripStatusLabel";
			this.FormStripStatusLabel.Size = new System.Drawing.Size(97, 17);
			this.FormStripStatusLabel.Text = "Not recording data";
			// 
			// cbRecord
			// 
			this.cbRecord.Location = new System.Drawing.Point(12, 160);
			this.cbRecord.Name = "cbRecord";
			this.cbRecord.Size = new System.Drawing.Size(75, 24);
			this.cbRecord.TabIndex = 10;
			this.cbRecord.Text = "Record";
			this.cbRecord.UseVisualStyleBackColor = true;
			this.cbRecord.CheckStateChanged += new System.EventHandler(this.CbRecordCheckStateChanged);
			// 
			// RoomData
			// 
			this.RoomData.DataSetName = "RoomData";
			// 
			// Recordtimer
			// 
			this.Recordtimer.Interval = 60000;
			this.Recordtimer.Tick += new System.EventHandler(this.RecordtimerTick);
			// 
			// saveDataFileDialog
			// 
			this.saveDataFileDialog.Filter = "Text File|*.csv";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Steam";
			// 
			// txtS
			// 
			this.txtS.Location = new System.Drawing.Point(93, 135);
			this.txtS.Name = "txtS";
			this.txtS.ReadOnly = true;
			this.txtS.Size = new System.Drawing.Size(47, 20);
			this.txtS.TabIndex = 4;
			// 
			// EventLoger
			// 
			this.EventLoger.SynchronizingObject = this;
			// 
			// ShowValues
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 215);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbRecord);
			this.Controls.Add(this.FormStatusStrip);
			this.Controls.Add(this.FormMenuStrip);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPSP);
			this.Controls.Add(this.txtHSP);
			this.Controls.Add(this.txtS);
			this.Controls.Add(this.txtP);
			this.Controls.Add(this.txtTSP);
			this.Controls.Add(this.txtH);
			this.Controls.Add(this.txtT);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGetValues);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.FormMenuStrip;
			this.Name = "ShowValues";
			this.Text = "Env Room Control";
			this.Load += new System.EventHandler(this.ShowValuesLoad);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowValuesFormClosing);
			this.Resize += new System.EventHandler(this.ShowValuesResize);
			this.IconMenuStrip.ResumeLayout(false);
			this.FormMenuStrip.ResumeLayout(false);
			this.FormMenuStrip.PerformLayout();
			this.FormStatusStrip.ResumeLayout(false);
			this.FormStatusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RoomData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EventLoger)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Diagnostics.EventLog EventLoger;
		private System.Windows.Forms.TextBox txtS;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripMenuItem RecordSaveStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolsStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveDataFileDialog;
		public System.Windows.Forms.Timer Recordtimer;
		private System.Data.DataSet RoomData;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem StartStopRecordingMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem RestoreStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem StartStopRecordingToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip IconMenuStrip;
		private System.Windows.Forms.CheckBox cbRecord;
		private System.Windows.Forms.ToolStripStatusLabel FormStripStatusLabel;
		private System.Windows.Forms.StatusStrip FormStatusStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getValuesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.MenuStrip FormMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileMenu;
		private System.Windows.Forms.NotifyIcon EnvRoomnotifyIcon;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPSP;
		private System.Windows.Forms.TextBox txtHSP;
		private System.Windows.Forms.TextBox txtTSP;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtP;
		private System.Windows.Forms.TextBox txtH;
		private System.Windows.Forms.TextBox txtT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGetValues;
	}
}
