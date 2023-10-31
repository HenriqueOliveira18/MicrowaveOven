using Wayne.Lib.StateEngine;
using Wayne.MicrowaveOven;
using Wayne.MicrowaveOven.States;

namespace Wayne.MicrowaveOven.States
{
    class DoorClosed : State
    {
        #region Fields

        IMicrowaveOven oven;

        #endregion

        #region Constructor

        public DoorClosed(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        #endregion

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
