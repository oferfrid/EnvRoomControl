/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 30/03/2008
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration ;

namespace envRoom
{
	/// <summary>
	/// Description of Option.
	/// </summary>
	public partial class Option : Form
	{
		public ShowValues MainForm;
		
		public Option()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void OptionLoad(object sender, EventArgs e)
		{
			txtTimeInterval.Text = (Convert.ToDecimal( this.MainForm.Recordtimer.Interval )/60000).ToString();
			txtHdiff.Text = this.MainForm.AlertsHdiff.ToString();
			txtPdiff.Text = this.MainForm.AlertsPdiff.ToString();
			txtPtime.Text = this.MainForm.AlertsPtime.ToString();
			txtTdiff.Text = this.MainForm.AlertsTdiff.ToString();
			checkBoxActiveAlerts.Checked = this.MainForm.AlertsActive;
			txtPhone.Text = this.MainForm.AlertsPhone;
			txtEmail.Text = this.MainForm.AlertsEmail;
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			UpdateInterval();
			UpdateAlerts();
			this.Close();
		}
		
		private void UpdateInterval()
		{
			this.MainForm.Recordtimer.Interval = Convert.ToInt32(Convert.ToDecimal(txtTimeInterval.Text) *60000);
		}
		
		private void UpdateAlerts()
		{
			this.MainForm.AlertsActive = this.checkBoxActiveAlerts.Checked ;
			
			this.MainForm.AlertsHdiff  = Convert.ToDouble(this.txtHdiff.Text);
			this.MainForm.AlertsPdiff  = Convert.ToDouble(this.txtPdiff.Text);
			this.MainForm.AlertsPtime  = Convert.ToDouble(this.txtPtime.Text);
			this.MainForm.AlertsTdiff  = Convert.ToDouble(this.txtTdiff.Text);
			this.MainForm.AlertsPhone  = this.txtPhone.Text;
			this.MainForm.AlertsEmail  = this.txtEmail.Text;
		}
		
		
		void BtnApplyClick(object sender, EventArgs e)
		{
			UpdateInterval();
			UpdateAlerts();
		}
		
		
		
		
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}


