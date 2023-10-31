using Wayne.Lib.StateEngine;

namespace Wayne.MicrowaveOven.States.Cooking
{
    static class Configuration
    {
        public static void Config(StateTransitionLookup sl)
        {
            sl.AddTransition<Init, On>(MicroTransition.Init);
            sl.AddTransition<On, Off>(MicroTransition.ToggleHeater);
            sl.AddTransition<Off, On>(MicroTransition.ToggleHeater);
        }
    }
}
