using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create a floating point argument for an XSchema action.
	/// </summary>
	public class XDouble : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XDouble"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		public XDouble(string name) : this(name, 0) {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XDouble"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		/// <param name='value'>
		/// The argument value.
		/// </param>
		public XDouble(string name, double value) : base(name, value, Types.DOUBLE) {		
		}
		#endregion
	}
}