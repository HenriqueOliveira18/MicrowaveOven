using System;
using System.Collections.Generic;
using System.Text;

namespace Wayne.MicrowaveOven.States
{
    public enum MicroTransition
    {
        Init,
        DoorIsOpen,
        DoorIsClosed,
        StartCooking,
        StopCooking,
        ToggleHeater
    }
}
