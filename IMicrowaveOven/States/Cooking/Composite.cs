using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States.Cooking
{
    [StateDescription(StateDescriptionType.Summary, "This is the cooking composite state.")]
    [StateDescription(StateDescriptionType.Enter, "The light is turned on.")]
    [StateDescription(StateDescriptionType.Exit, "The light is turned off.")]

    [EventDescription(MicroEvent.ButtonPressed, "", MicroTransition.StopCooking)]
    [EventDescription(MicroEvent.DoorOpen, "", MicroTransition.DoorIsOpen)]

    class Composite : CompositeState
    {
        IMicrowaveOven oven;

        public Composite(IMicrowaveOven oven)
        {
            this.oven = oven;
            StateMachine.AddStateFactory(new MicroStateFactory(oven));
            Configuration.Config(StateMachine.StateTransitionLookup);
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
            oven.TurnOnLight();
        }

        public override void UnhandledEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.UnhandledEvent(stateEngineEvent, ref transition);

            if (stateEngineEvent.Type.Equals(MicroEvent.ButtonPressed))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.StopCooking);
            }
            else if (stateEngineEvent.Type.Equals(MicroEvent.DoorOpen))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.DoorIsOpen);
            }
        }

        protected override void Exit()
        {
            base.Exit();
            oven.TurnOffLight();
        }
    }
}
