/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 23/03/2008
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Web;
using System.Net;
using System.Text;
using System.Configuration;
using System.Collections ;
using System.Collections.Generic;

namespace EnvRoomControler
{
	/// <summary>
	/// Description of EnvControlerIO.
	/// </summary>
	public class EnvControlerIO
	{
		const int NumberOfValues = 6;
		WebClient WC;
		List<ControllerEntry> ControllerDictionaryList;
		
		string ControlerDataTag = "ofer";
		public EnvControlerIO()
		{
			WC = new WebClient();

			ControllerDictionaryList = new List<ControllerEntry>();
			
			
			try
			{
				string[] ParamsID = ConfigurationManager.AppSettings["ParamsID"].Split(',');
				string[] ParamsName = ConfigurationManager.AppSettings["ParamsName"].Split(',');
				string[] ParamsLongName = ConfigurationManager.AppSettings["ParamsLongName"].Split(',');
				string[] ParamsReadOnly = ConfigurationManager.AppSettings["ParamsReadOnly"].Split(',');
				
				for(int i=0; i<ParamsID.Length;i++)
				{
					ControllerDictionaryList.Add(new ControllerEntry(Convert.ToInt32(ParamsID[i])
					                                                 ,ParamsName[i]
					                                                 ,ParamsLongName[i]
					                                                 ,Convert.ToBoolean(Convert.ToByte(ParamsReadOnly[i]))));
				}
				
			}
			catch(Exception e)
			{
				throw new Exception(@"Error Parsing Configuration Parameters",e);
			}
			
		}
		
		public List<ControllerEntry>  GetDictionaryList()
		{
			return ControllerDictionaryList;
		}
		
		public List<ControllerEntry>  GetCurentValues()
		{
			ReadValuseFromControler();
			return ControllerDictionaryList;
		}
		
		public void SetValue(ControllerEntry ce)
		{
			if (Convert.ToBoolean(ConfigurationManager.AppSettings["ControlerIsReadonly"]))
			{
				throw new Exception(@"Controler is read only (Chack configureaion)");	
			}
			else
			{
			int intValue =  Convert.ToInt32(ce.EntryValue  *10);
			foreach (ControllerEntry maince in ControllerDictionaryList)
			{
				if(ce.Name == maince.Name)
				{
					ce = new ControllerEntry(maince,ce.EntryValue);
				}
			}
			
			string url = @"http://" + ConfigurationManager.AppSettings["ControllerIP"] + ConfigurationManager.AppSettings["SetValuesURI"] +"R"+ ce.ID.ToString("000") + @"%2CD+" + intValue.ToString("000");
			byte[] myDataBuffer = WC.DownloadData(url);
			
			}
		}



		private void ReadValuseFromControler()
		{
			byte[] myDataBuffer = WC.DownloadData( BuildControlerRequest() );
			string url = @"http://" + ConfigurationManager.AppSettings["ControllerIP"] + ConfigurationManager.AppSettings["ReadValuesURI"] + ControlerDataTag;
			myDataBuffer = WC.DownloadData(url);
			string ControlerResponseString = Encoding.ASCII.GetString(myDataBuffer);
			ParseControlerResponse(ControlerResponseString);
		}

		private void ParseControlerResponse(string ControlerResponse)
		{
			string [] splitControlerResponse  = ControlerResponse.Split(new Char[] {} );
			for (int j = 0 ; j<ControllerDictionaryList.Count ; j++)
			{
				
				for (int i = 0; i<ControllerDictionaryList.Count; i++ )
				{
					string ID =  splitControlerResponse[i].Substring(6,4);
					if (ID == ControllerDictionaryList[j].ID.ToString("0000"))
					{
						string Value =  splitControlerResponse[i].Substring(13);
						double   DecimalValue =  Convert.ToDouble(Value)/10;
						ControllerDictionaryList[j]   = new ControllerEntry(ControllerDictionaryList[j] ,DecimalValue);
					}
				}
				
			}
		}

		private string BuildControlerRequest()
		{
			
			string ControlerRequesString =  @"http://" + ConfigurationManager.AppSettings["ControllerIP"] +  ConfigurationManager.AppSettings["OrderValuesURI"] + ControlerDataTag + @"+dummy+60000" ;
			foreach (ControllerEntry ce in ControllerDictionaryList)
			{
				//HttpUtility.UrlEncode(",")
				ControlerRequesString += @"+PDP%2C%2CR" + ce.ID.ToString("0000") + @"%2CD";
			}
			return ControlerRequesString;
			
		}
	}
}

