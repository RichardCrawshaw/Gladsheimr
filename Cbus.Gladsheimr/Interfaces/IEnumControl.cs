﻿namespace Cbus.Gladsheimr.Interfaces
{
    public partial interface IEnumControl :
		IParameterControl<string>
	{
		string? SelectedName { get; }
		string? SelectedText { get; }
		byte? SelectedValue { get; }
	}
}
