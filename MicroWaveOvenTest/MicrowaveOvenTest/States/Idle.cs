using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    class IdleState : State
    {
        #region Fields
        IMicrowaveOven oven;
        #endregion

        public IdleState(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);
            RemovePendingEventsOfType(MicroEvent.ButtonPressed);
            if(oven.DoorIsOpen)
            {
                transition = new Transition(this, MicroTransition.DoorIsOpen);
            }
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            if (stateEngineEvent.Type is MicroEvent)
            {
                switch((MicroEvent)stateEngineEvent.Type)
                {
                    case MicroEvent.DoorOpen:
                        stateEngineEvent.Handled = true;
                        transition = new Transition(this, MicroTransition.DoorIsOpen);
                        break;
                    case MicroEvent.ButtonPressed:
                        stateEngineEvent.Handled = true;
                        transition = new Transition(this, MicroTransition.StartCooking);
                        break;
                }
            }
        }
    }
}
