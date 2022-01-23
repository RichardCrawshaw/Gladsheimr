using System;

namespace Cbus.Gladsheimr.Interfaces
{
    public interface IOpCodeControl
    {
        string OpCodeCode { get; }

        event EventHandler? Actioned;
    }
}
