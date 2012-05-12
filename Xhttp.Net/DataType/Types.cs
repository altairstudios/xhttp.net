using System;


namespace AltairStudios.Xhttp.DataType {
	/// <summary>
	/// DataType Types.
	/// </summary>
	public enum Types {
		/// <summary>
		/// Constant NULL.
		/// </summary>
		NULL = 0,
		/// <summary>
		/// Constant BOOLEAN.
		/// </summary>
		BOOLEAN = 1,
		/// <summary>
		/// Constant INTEGER.
		/// </summary>
		INTEGER = 2,
		/// <summary>
		/// Constant DOUBLE.
		/// </summary>
		DOUBLE = 3,
		/// <summary>
		/// Constant STRING.
		/// </summary>
		STRING = 4,
		/// <summary>
		/// Constant ARRAY.
		/// </summary>
		ARRAY = 5,
		/// <summary>
		/// Constant STRUCT.
		/// </summary>
		STRUCT = 6,
		/// <summary>
		/// Constant LAMBDA.
		/// </summary>
		LAMBDA = 7,
		/// <summary>
		/// Constant BASE64.
		/// </summary>
		BASE64 = 8,
		/// <summary>
		/// Constant DATETIME.
		/// ISO 8601 format
		/// </summary>
		DATETIME = 9
	}
}