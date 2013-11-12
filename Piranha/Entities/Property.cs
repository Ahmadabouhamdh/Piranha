﻿using System;

namespace Piranha.Entities
{
	/// <summary>
	/// The property entity
	/// </summary>
	[Serializable]
	public class Property : StandardEntity<Property>
	{
		#region Properties
		/// <summary>
		/// Gets/sets whether this property instance is a draft or not.
		/// </summary>
		internal bool IsDraft { get ; set ; }

		/// <summary>
		/// Gets/sets the id of the parent this property is attached to.
		/// </summary>
		public Guid ParentId { get ; set ; }

		/// <summary>
		/// Gets/sets the property name.
		/// </summary>
		public string Name { get ; set ; }

		/// <summary>
		/// Gets/sets the property value.
		/// </summary>
		public string Value { get ; set ; }
		#endregion
	}
}
