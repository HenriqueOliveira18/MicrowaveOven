using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    static class Configuration
    {
        public static void Config(StateTransitionLookup sl)
        {
            sl.AddTransition<Init, DoorOpen>(MicroTransition.DoorIsOpen);
            sl.AddTransition<Init, DoorClosed>(MicroTransition.DoorIsClosed);

            sl.AddTransition<DoorOpen,DoorClosed>(MicroTransition.DoorIsClosed);

            sl.AddTransition<DoorClosed, DoorOpen>(MicroTransition.DoorIsOpen);
            sl.AddTransition<DoorClosed, Cooking.Composite>(MicroTransition.StartCooking, HistoryType.Shallow);

            sl.AddTransition<Cooking.Composite, DoorOpen>(MicroTransition.DoorIsOpen);
            sl.AddTransition<Cooking.Composite, DoorClosed>(MicroTransition.StopCooking);
        }
    }
}
