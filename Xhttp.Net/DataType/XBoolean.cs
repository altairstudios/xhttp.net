using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create a boolean argument for an XSchema action.
	/// </summary>
	public class XBoolean : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XBoolean"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		public XBoolean(string name) : this(name, false) {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XBoolean"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		/// <param name='value'>
		/// The argument value.
		/// </param>
		public XBoolean(string name, bool value) : base(name, value, Types.BOOLEAN) {		
		}
		#endregion
	}
}