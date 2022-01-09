namespace Cbus.Gladsheimr.Interfaces
{
    public partial interface IStringControl :
        IParameterControl<string>
    {
        /// <summary>
        /// Gets and sets the text to accompany the value.
        /// </summary>
        string LabelText { get; set; }
    }
}
