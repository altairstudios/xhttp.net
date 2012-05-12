using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// Class to create an argument for an XSchema action
	/// </summary>
	public class XArgument {
		#region Attributes
		/// <summary>
		/// The argument name.
		/// </summary>
		protected string name;
		
		
		
		/// <summary>
		/// The argument value.
		/// </summary>
		protected object value;
		
		
		
		/// <summary>
		/// The argument type.
		/// </summary>
		protected Types type;
		#endregion
		
		
		
		
		
		#region Properties
		/// <summary>
		/// Gets the argument name.
		/// </summary>
		/// <value>
		/// The argument name.
		/// </value>
		public string Name {
			get {
				return this.name;
			}
		}
		
		
		
		/// <summary>
		/// Gets the argument value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public object Value {
			get {
				return this.value;
			}
		}
		
		
		
		/// <summary>
		/// Gets the argument type.
		/// </summary>
		/// <value>
		/// The argument type.
		/// </value>
		public Types Type {
			get {
				return this.type;
			}
		}
		#endregion
	
		
		
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XArgument"/> class.
		/// </summary>
		/// <param name='name'>
		/// Argument Name.
		/// </param>
		public XArgument(string name) : this(name, null, Types.NULL) {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XArgument"/> class.
		/// </summary>
		/// <param name='name'>
		/// Argument Name.
		/// </param>
		/// <param name='value'>
		/// Argument Value.
		/// </param>
		public XArgument(string name, object value) : this(name, valuem, Types.NULL) {
		}
		
		
		
		/// <summary>
		/// Initializes a new instance of the <see cref="AltairStudios.Xhttp.DataType.XArgument"/> class.
		/// </summary>
		/// <param name='name'>
		/// Argument Name.
		/// </param>
		/// <param name='value'>
		/// Argument Value.
		/// </param>
		/// <param name='type'>
		/// Argument Type.
		/// </param>
		public XArgument(string name, object value, Types type) {
			this.name = name;
			this.value = value;
			this.type = type;
		}
		#endregion
	}
}