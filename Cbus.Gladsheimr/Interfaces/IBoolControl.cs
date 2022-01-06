namespace Cbus.Gladsheimr.Interfaces
{
    public partial interface IBoolControl :
		IParameterControl<bool>
	{
		/// <summary>
		/// Gets and sets the text to accompany the radio buttons.
		/// </summary>
		string LabelText { get; set; }

		string RadioButtonOnText { get; set; }
		string RadioButtonOffText { get; set; }

		/// <summary>
		/// True to use a checkbox rather than radio buttons.
		/// </summary>
		bool UseCheckboxStyle { get; set; }
	}
}
