using System;
using System.Collections.Generic;
using System.Text;

namespace Wayne.MicrowaveOven
{
    public interface IMicrowaveOven
    {
        event EventHandler OnDoorOpen;
        event EventHandler OnDoorClosed;
        event EventHandler OnButtonPressed;

        bool DoorIsOpen { get; }
        void TurnOnLight();
        void TurnOffLight();
        void TurnOnHeater();
        void TurnOffHeater();
    }
}
