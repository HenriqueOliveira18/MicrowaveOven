using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    [StateDescription(StateDescriptionType.Summary, "In this state the door is closed.")]
    [StateDescription(StateDescriptionType.Enter, "All pending events are cleared.")]

    [EventDescription(MicroEvent.DoorOpen, "", MicroTransition.DoorIsOpen)]
    [EventDescription(MicroEvent.ButtonPressed, "", MicroTransition.StartCooking)]

    class DoorClosed : State
    {
        IMicrowaveOven oven;

        public DoorClosed(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);

            RemovePendingEventsOfType(MicroEvent.ButtonPressed);
            RemovePendingEventsOfType(MicroEvent.DoorClosed);
            RemovePendingEventsOfType(MicroEvent.DoorOpen);
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(MicroEvent.DoorOpen))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.DoorIsOpen);
            }
            else if (stateEngineEvent.Type.Equals(MicroEvent.ButtonPressed))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.StartCooking);
            }
        }
    }
}
