namespace Cbus.Gladsheimr.Interfaces
{
    public interface IParameterControl
    {
    }

    public interface IParameterControl<T> : IParameterControl
    {
        T Value { get; set; }
    }
}
