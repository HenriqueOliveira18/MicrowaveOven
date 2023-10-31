using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    [StateDescription(StateDescriptionType.Summary, "In this state the door is open.")]
    [StateDescription(StateDescriptionType.Enter, "The light is turned on.")]
    [StateDescription(StateDescriptionType.Exit, "The light is turned off.")]

    [EventDescription(MicroEvent.DoorClosed, "", MicroTransition.DoorIsClosed)]

    class DoorOpen : State
    {
        IMicrowaveOven oven;

        public DoorOpen(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);

            oven.TurnOnLight();
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(MicroEvent.DoorClosed))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.DoorIsClosed);
            }
            else if (stateEngineEvent.Type.Equals(MicroEvent.ButtonPressed))
            {
                stateEngineEvent.Handled = true;
            }
        }

        protected override void Exit()
        {
            base.Exit();

            oven.TurnOffLight();
        }
    }
}
