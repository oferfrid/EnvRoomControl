/*
 * Created by SharpDevelop.
 * User: oferfrid
 * Date: 02/04/2008
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace EnvRoomControler
{
	/// <summary>
	/// Description of ControllerEntry.
	/// </summary>
	public struct ControllerEntry : IEquatable<ControllerEntry>

	{
		public int ID;
		public string Name;
		public string LongName;
		public bool ReadOnly;
		public double   EntryValue ;
		
		public ControllerEntry(int _ID,string _Name, string _LongName,bool _ReadOnly)
		{
			ID=_ID;
			Name=_Name;
			LongName = _LongName;
			ReadOnly=_ReadOnly;
			EntryValue = double.NaN  ;
		}
		
		
		public ControllerEntry(ControllerEntry ce,double _EntryValue)
		{
			ID=ce.ID;
			Name=ce.Name;
			LongName = ce.LongName;
			ReadOnly=ce.ReadOnly;
			EntryValue = _EntryValue  ;
		}
		
		public ControllerEntry(string _EntryName,double _EntryValue)
		{
			ID= -1;
			Name=_EntryName;
			LongName = string.Empty ;
			ReadOnly= false;
			EntryValue = _EntryValue  ;
		}

		#region Equals and GetHashCode implementation
		// The code in this region is useful if you want to use this structure in collections.
		// If you don't need it, you can just remove the region and the ": IEquatable<ControllerEntry>" declaration.
		
		public override bool Equals(object obj)
		{
			if (obj is ControllerEntry)
				return Equals((ControllerEntry)obj); // use Equals method below
			else
				return false;
		}
		
		public bool Equals(ControllerEntry other)
		{
			// add comparisions for all members here
			return (this.ID == other.ID) & (this.Name == other.Name) &
				(this.LongName == other.LongName) & (this.ReadOnly == other.ReadOnly);
		}
		
		public override int GetHashCode()
		{
			// combine the hash codes of all members here (e.g. with XOR operator ^)
			return ID.GetHashCode()^ Name.GetHashCode()^ LongName.GetHashCode()^ReadOnly.GetHashCode();
			
		}
		
		public static bool operator ==(ControllerEntry lhs, ControllerEntry rhs)
		{
			return lhs.Equals(rhs);
		}
		
		public static bool operator !=(ControllerEntry lhs, ControllerEntry rhs)
		{
			return !(lhs.Equals(rhs)); // use operator == and negate result
		}
		#endregion
	}
}
