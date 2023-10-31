//using System;
//using System.Collections.Generic;
//using System.Text;
//using Wayne.Lib.StateEngine;

//namespace MicrowaveOven2.States
//{
//    class __Cooking :State
//    {
//           IMicrowaveOven oven;

//        public __Cooking(IMicrowaveOven oven)
//        {
//            this.oven = oven;
//        }

//        protected override void Enter(StateEntry stateEntry)
//        {
//            base.Enter(stateEntry);
//            oven.TurnOnLight();
//            oven.TurnOnHeater();
//        }


//        protected override void HandleEvent(StateEngineEvent stateEngineEvent, ref Transition transition)
//        {
//            base.HandleEvent(stateEngineEvent, ref transition);

//            if (stateEngineEvent.Type.Equals(MicroEvent.ButtonPressed))
//            {
//                stateEngineEvent.Handled = true;
//                transition = new Transition(this, MicroTransition.StopCooking);
//            }
//            else if (stateEngineEvent.Type.Equals(MicroEvent.DoorOpen))
//            {
//                stateEngineEvent.Handled = true;
//                transition = new Transition(this, MicroTransition.DoorIsOpen);
//            }
//        }

//        protected override void Exit()
//        {
//            base.Exit();
//            oven.TurnOffLight();
//            oven.TurnOffHeater();
//        }
//    }
//}
