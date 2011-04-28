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
using System.Text.RegularExpressions;


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
			this.btnCancel.CausesValidation = false;
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
		
		void TxtEmailValidated(object sender, EventArgs e)
		{
			if (this.txtEmail.Text!=string.Empty )
			{
				if (!isEmail(this.txtEmail.Text))
				{
					this.OptionErrorProvider.SetError(this.txtEmail,"Email invalid");
				}
				else
				{
					OptionErrorProvider.Clear();

				}
			}
			else
			{
				OptionErrorProvider.Clear();
			}
			
		}
		
		private  bool isEmail(string inputEmail)
		{
			string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
				@"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
				@".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
			Regex re = new Regex(strRegex);
			if (re.IsMatch(inputEmail))
				return (true);
			else
				return (false);
		}
		
		
		void TxtPhoneMaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			if (txtPhone.MaskFull)
			{
				//toolTip1.ToolTipTitle = "Input Rejected - Too Much Data";
				//toolTip1.Show("You cannot enter any more data into the date field. Delete some characters in order to insert more data.", maskedTextBox1, 0, -20, 5000);
				this.OptionErrorProvider.SetError(this.txtPhone,"Phone to long use +(972)XX-XXXXXXX");
			}
			else if (e.Position == txtPhone.Mask.Length)
			{
				//toolTip1.ToolTipTitle = "Input Rejected - End of Field";
				//toolTip1.Show("You cannot add extra characters to the end of this date field.", maskedTextBox1, 0, -20, 5000);
				this.OptionErrorProvider.SetError(this.txtPhone,"Phone to long You cannot add extra characters \nuse +(972)XX-XXXXXXX");
			}
			else
			{
				//toolTip1.ToolTipTitle = "Input Rejected";
				//toolTip1.Show("You can only add numeric characters (0-9) into this date field.", maskedTextBox1, 0, -20, 5000);
				this.OptionErrorProvider.SetError(this.txtPhone,"Phone can includ numbers only us +(972)XX-XXXXXXX format");
			}
		}
		
		void TxtPhoneValidated(object sender, EventArgs e)
		{
			if( !txtPhone.MaskCompleted  && txtPhone.Text.Length !=0)
			{
				this.OptionErrorProvider.SetError(this.txtPhone,"Phone not valid \nuse +(972)XX-XXXXXXX format");
			}
			else
			{
				this.OptionErrorProvider.Clear();
			}
		}
		
		void TxtPhoneKeyDown(object sender, KeyEventArgs e)
		{
			this.OptionErrorProvider.Clear();
		}
	}
}




//***************
