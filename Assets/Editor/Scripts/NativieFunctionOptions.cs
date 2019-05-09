﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mochineko.ReorderableList
{
	/// <summary>
	/// Holds options which judge to use native functions.
	/// </summary>
	public struct NativeFunctionOptions
	{
		public bool Draggable { get; private set; }
		public bool DisplayHeader { get; private set; }
		public bool DisplayAddButton { get; private set; }
		public bool DisplayRemoveButton { get; private set; }

		public NativeFunctionOptions(
			bool draggable,
			bool displayHeader,
			bool displayAddButton,
			bool displayRemoveButton)
		{
			Draggable = draggable;
			DisplayHeader = displayHeader;
			DisplayAddButton = displayAddButton;
			DisplayRemoveButton = displayRemoveButton;
		}

		/// <summary>
		/// Supplies defalut options.
		/// </summary>
		public static NativeFunctionOptions Default
			=> new NativeFunctionOptions
			{
				Draggable = true,
				DisplayHeader = true,
				DisplayAddButton = true,
				DisplayRemoveButton = true
			};
	}
}

