using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create a null argument for an XSchema action
	/// </summary>
	public class XNull : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XNull"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		public XNull(string name) : base(name, null, Types.NULL) {
		}
		#endregion
	}
}