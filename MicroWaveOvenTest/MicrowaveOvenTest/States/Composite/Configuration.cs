using Wayne.Lib.StateEngine;
using Wayne.MicrowaveOven.States.Cooking;

namespace Wayne.MicrowaveOven.States.Composite
{
    static class Configuration
    {
        public static void config(StateTransitionLookup sl)
        {
            sl.AddTransition<Init, On>(MicroTransition.Init);
            sl.AddTransition<On, Off>(MicroTransition.ToggleHeater);
            sl.AddTransition<Off, On>(MicroTransition.ToggleHeater);
        }
    }
}
