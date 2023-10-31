using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    [StateDescription(StateDescriptionType.Summary, "The main init state")]

    [EnterDescription("If the door is open", MicroTransition.DoorIsOpen)]
    [EnterDescription("If the door is closed", MicroTransition.DoorIsClosed)]

    class Init : InitialState
    {
        IMicrowaveOven oven;

        public Init(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        protected override Transition CreatePseudoStateTransition(StateEntry stateEntry)
        {
            if (oven.DoorIsOpen)
                return new Transition(this, MicroTransition.DoorIsOpen);
            else
                return new Transition(this, MicroTransition.DoorIsClosed);
        }
    }
}
