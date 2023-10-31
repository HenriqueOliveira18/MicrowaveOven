using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States
{
    public class MicroStateFactory : IStateFactory
    {
        #region Fields

        IMicrowaveOven oven;

        #endregion

        #region Constructor

        public MicroStateFactory(IMicrowaveOven oven)
        {
            this.oven = oven;
        }

        #endregion

        public State CreateState(string stateName)
        {
            // Root States

            if (stateName == typeof(Init).FullName)
                return new Init(oven);
            else if (stateName == typeof(DoorOpen).FullName)
                return new DoorOpen(oven);
            else if (stateName == typeof(DoorClosed).FullName)
                return new DoorClosed(oven);

            // Cooking Composite
            else if (stateName == typeof(Cooking.Composite).FullName)
                return new Cooking.Composite(oven);
            else if (stateName == typeof(Cooking.Init).FullName)
                return new Cooking.Init(oven);
            else if (stateName == typeof(Cooking.On).FullName)
                return new Cooking.On(oven);
            else if (stateName == typeof(Cooking.Off).FullName)
                return new Cooking.Off(oven);

            return null;

        }

        public string Name
        {
            get { return "MicroStateFactory"; }
        }


    }
}
