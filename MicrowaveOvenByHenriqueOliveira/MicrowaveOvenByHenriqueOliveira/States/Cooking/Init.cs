using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States.Cooking
{
    class Init : InitialState
    {
        IMicrowaveOven oven;

        public Init(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        protected override Transition CreatePseudoStateTransition(StateEntry stateEntry)
        {
            return new Transition(this, MicroTransition.Init);
        }
    }
}
