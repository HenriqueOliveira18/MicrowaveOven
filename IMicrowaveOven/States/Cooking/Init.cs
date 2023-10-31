using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States.Cooking
{
    [StateDescription(StateDescriptionType.Summary, "The cooking init state")]

    [EnterDescription("", MicroTransition.Init)]

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
