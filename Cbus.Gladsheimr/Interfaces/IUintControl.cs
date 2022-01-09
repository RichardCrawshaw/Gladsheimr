﻿namespace Cbus.Gladsheimr.Interfaces
{
    public partial interface IUintControl :
		IParameterControl<uint>
	{
		/// <summary>
		/// Gets and sets the text to accompany the value.
		/// </summary>
		string LabelText { get; set; }

		/// <summary>
		/// Gets and sets whether hex is used for the value.
		/// </summary>
		bool UseHex { get; set; }
	}
}
