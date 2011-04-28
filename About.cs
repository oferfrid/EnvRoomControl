/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 31/03/2008
 * Time: 17:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace envRoom
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AboutLoad(object sender, EventArgs e)
		{
			ltxtVersion.Text =   System.Reflection.Assembly.GetExecutingAssembly().GetName(false).Version.ToString();
		}
	}
}
