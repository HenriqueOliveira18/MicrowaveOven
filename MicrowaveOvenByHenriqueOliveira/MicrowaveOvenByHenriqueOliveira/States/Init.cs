using System;
using System.Collections.Generic;
using System.Text;
using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    class Init : InitialState
    {
        #region Fields
        IMicrowaveOven oven;
        #endregion

        #region Properties
        public Init(IMicrowaveOven oven)
        {
            this.oven = oven;
        }
        #endregion

        protected override Transition CreatePseudoStateTransition(StateEntry stateEntry)
        {
            if (oven.DoorIsOpen)
                return new Transition(this, MicroTransition.DoorIsOpen);
            else
                return new Transition(this, MicroTransition.DoorIsClosed);
        }

    }
}
