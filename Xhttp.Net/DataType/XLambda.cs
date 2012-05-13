using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create a lambda argument for an XSchema action.
	/// </summary>
	public class XLambda : XArgument {
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XLambda"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		public XLambda(string name) : this(name, null) {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XLambda"/> class.
		/// </summary>
		/// <param name='name'>
		/// The argument name.
		/// </param>
		/// <param name='value'>
		/// The argument value.
		/// </param>
		public XLambda(string name, object value) : base(name, value, Types.LAMBDA) {
		}
		#endregion
	}
}