using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create an array argument for an XSchema action.
	/// </summary>
	public class XArray : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XArray"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		/// <param name='value'>
		/// The argument value.
		/// </param>
		public XArray(string name, object[] value) : base(name, value, Types.ARRAY) {
		}
		#endregion
	}
}