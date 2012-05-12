using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create an integer argument for an XSchema action.
	/// </summary>
	public class XInteger : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XInteger"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		public XInteger(string name) : base(name, 0, Types.INTEGER) {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XInteger"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		/// <param name='value'>
		/// The argument value.
		/// </param>
		public XInteger(string name, int value) : base(name, value, Types.INTEGER) {
		}
		#endregion
	}
}