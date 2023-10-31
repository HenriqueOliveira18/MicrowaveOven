using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States.Cooking
{
    [StateDescription(StateDescriptionType.Summary, "In this state the microwave oven is running but the heater is off.")]

    [EventDescription(MicroEvent.Timer, "", MicroTransition.ToggleHeater)]

    class Off : State
    {
        IMicrowaveOven oven;

        public Off(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);

            Timer t = new Timer(this, MicroEvent.Timer, 5000, null);

            ActivateTimer(t);
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(MicroEvent.Timer))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.ToggleHeater);
            }
        }

    }
}
