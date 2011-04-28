/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 30/03/2008
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace envRoom
{
	partial class Option
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTimeInterval = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPtime = new System.Windows.Forms.TextBox();
			this.txtPdiff = new System.Windows.Forms.TextBox();
			this.txtHdiff = new System.Windows.Forms.TextBox();
			this.txtTdiff = new System.Windows.Forms.TextBox();
			this.checkBoxActiveAlerts = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(112, 252);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(51, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// btnApply
			// 
			this.btnApply.Location = new System.Drawing.Point(169, 252);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(50, 23);
			this.btnApply.TabIndex = 11;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.BtnApplyClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Record Interval [min]";
			// 
			// txtTimeInterval
			// 
			this.txtTimeInterval.Location = new System.Drawing.Point(143, 30);
			this.txtTimeInterval.Name = "txtTimeInterval";
			this.txtTimeInterval.Size = new System.Drawing.Size(48, 20);
			this.txtTimeInterval.TabIndex = 1;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(67, 252);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(39, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Temperatur differential [oC]";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Humidity differential [%]";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPhone);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtPtime);
			this.groupBox1.Controls.Add(this.txtPdiff);
			this.groupBox1.Controls.Add(this.txtHdiff);
			this.groupBox1.Controls.Add(this.txtTdiff);
			this.groupBox1.Controls.Add(this.checkBoxActiveAlerts);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(17, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 190);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Alerts";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(64, 154);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(130, 20);
			this.txtPhone.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(64, 128);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(130, 20);
			this.txtEmail.TabIndex = 7;
			// 
			// txtPtime
			// 
			this.txtPtime.Location = new System.Drawing.Point(146, 80);
			this.txtPtime.Name = "txtPtime";
			this.txtPtime.Size = new System.Drawing.Size(48, 20);
			this.txtPtime.TabIndex = 5;
			// 
			// txtPdiff
			// 
			this.txtPdiff.Location = new System.Drawing.Point(146, 57);
			this.txtPdiff.Name = "txtPdiff";
			this.txtPdiff.Size = new System.Drawing.Size(48, 20);
			this.txtPdiff.TabIndex = 4;
			// 
			// txtHdiff
			// 
			this.txtHdiff.Location = new System.Drawing.Point(146, 34);
			this.txtHdiff.Name = "txtHdiff";
			this.txtHdiff.Size = new System.Drawing.Size(48, 20);
			this.txtHdiff.TabIndex = 3;
			// 
			// txtTdiff
			// 
			this.txtTdiff.Location = new System.Drawing.Point(146, 11);
			this.txtTdiff.Name = "txtTdiff";
			this.txtTdiff.Size = new System.Drawing.Size(48, 20);
			this.txtTdiff.TabIndex = 2;
			// 
			// checkBoxActiveAlerts
			// 
			this.checkBoxActiveAlerts.Location = new System.Drawing.Point(6, 98);
			this.checkBoxActiveAlerts.Name = "checkBoxActiveAlerts";
			this.checkBoxActiveAlerts.Size = new System.Drawing.Size(104, 24);
			this.checkBoxActiveAlerts.TabIndex = 6;
			this.checkBoxActiveAlerts.Text = "Active";
			this.checkBoxActiveAlerts.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 154);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Phone";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Email";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Pressure differential";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(134, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Pressure Time delay [min]";
			// 
			// Option
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(231, 281);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtTimeInterval);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox1);
			this.Name = "Option";
			this.Text = "Option";
			this.Load += new System.EventHandler(this.OptionLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPtime;
		private System.Windows.Forms.TextBox txtPdiff;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBoxActiveAlerts;
		private System.Windows.Forms.TextBox txtTdiff;
		private System.Windows.Forms.TextBox txtHdiff;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTimeInterval;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.Button btnCancel;
	}
}
