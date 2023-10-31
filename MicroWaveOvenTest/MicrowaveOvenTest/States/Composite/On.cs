using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States.Composite
{
    #region Description
    [StateDescription(StateDescriptionType.Summary, "In this state the microwave oven is running and the heater is on.")]
    [StateDescription(StateDescriptionType.Enter, "The heater is turned on.")]
    [StateDescription(StateDescriptionType.Exit, "The heater is turned off.")]

    [EventDescription(MicroEvent.Timer, "", MicroTransition.ToggleHeater)]
    #endregion

    class On : State
    {
        #region Fields

        IMicrowaveOven oven;

        #endregion

        #region Properties

        public On(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        #endregion

        protected override void Enter(StateEntry stateEntry, ref Transition transition)
        {
            base.Enter(stateEntry, ref transition);

            oven.TurnOnHeater();

            Lib.StateEngine.Timer t = new Lib.StateEngine.Timer(this, MicroEvent.Timer, 5000, null);

            ActivateTimer(t);
        }

        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
        {
            base.HandleEvent(stateEngineEvent, ref transition);

            if(stateEngineEvent.Type.Equals(MicroEvent.Timer))
            {
                stateEngineEvent.Handled = true;
                transition = new Transition(this, MicroTransition.ToggleHeater);
            }
        }

        protected override void Exit()
        {
            base.Exit();
            oven.TurnOffHeater();
        }
    }
}
