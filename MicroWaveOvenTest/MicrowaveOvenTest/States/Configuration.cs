using System.Net;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    static class Configuration 
    {
        public static void Config(StateTransitionLookup sl)
        {
            // Init State Transitions
            sl.AddTransition<Init, DoorOpen>(MicroTransition.DoorIsOpen);
            sl.AddTransition<Init, DoorClosed>(MicroTransition.DoorIsClosed);

            // Door Open State Transitions
            sl.AddTransition<DoorOpen, DoorClosed>(MicroTransition.DoorIsClosed);

            // Door Closed State Transitions
            sl.AddTransition<DoorClosed, DoorOpen>(MicroTransition.DoorIsOpen);
            sl.AddTransition<DoorClosed, Cooking.Composite>(MicroTransition.StartCooking, HistoryType.Shallow);

            // Cooking Composite State Transitions
            sl.AddTransition<Cooking.Composite, DoorOpen>(MicroTransition.DoorIsOpen);
            sl.AddTransition<Cooking.Composite, DoorClosed>(MicroTransition.StopCooking);


        }
    }
}
