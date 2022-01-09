namespace Cbus.Gladsheimr.Interfaces
{
    public partial interface IEnumControl :
		IParameterControl<string>
	{
		/// <summary>
		/// Gets and sets the text to accompany the value.
		/// </summary>
		string LabelText { get; set; }

		/// <summary>
		/// Gets the name of the item selected from the list.
		/// </summary>
		string? SelectedName { get; }

		/// <summary>
		/// Gets the text of the item selected from the list.
		/// </summary>
		string? SelectedText { get; }

		/// <summary>
		/// Gets the value of the item selected from the list.
		/// </summary>
		byte? SelectedValue { get; }
	}
}
