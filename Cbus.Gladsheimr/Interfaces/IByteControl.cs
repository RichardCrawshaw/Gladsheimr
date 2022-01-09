namespace Cbus.Gladsheimr.Interfaces
{
    public partial interface IByteControl :
		IParameterControl<byte>
	{
		/// <summary>
		/// Gets and sets the text to accompany the value.
		/// </summary>
		string LabelText { get; set; }
	}
}
