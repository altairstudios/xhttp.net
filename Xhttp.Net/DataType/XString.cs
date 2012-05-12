using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create a string argument for an XSchema action
	/// </summary>
	public class XString : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XString"/> class.
		/// Constructor for the XString class
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		public XString(string name) : this(name, "") {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XString"/> class.
		/// Constructor for the XString class
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		/// <param name='value'>
		/// The argument value.
		/// </param>
		public XString(string name, string value) : base(name, value, Types.STRING) {
		}
		#endregion
	}
}