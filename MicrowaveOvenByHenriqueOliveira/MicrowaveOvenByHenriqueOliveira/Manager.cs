using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Analyzer;
using Wayne.Lib.StateEngine.Visualizer;
using Wayne.MicrowaveOven.States;

namespace Wayne.MicrowaveOven
{
    public partial class Manager : Form
    {
        #region Fields

        private readonly StateMachine stateMachine;
        private readonly IMicrowaveOven microwaveOven;
        private StateMachineVisualizer stateMachineVisualizer;

        #endregion

        #region Construtor

        public Manager()
        {
            InitializeComponent();

            // Create the mock-up microwave oven
            MainForm mockup = new MainForm();
            mockup.Show();

            microwaveOven = mockup;
            microwaveOven.OnButtonPressed += microwaveOven_OnButtonPressed;
            microwaveOven.OnDoorClosed += microwaveOven_OnDoorClosed;
            microwaveOven.OnDoorOpen += microwaveOven_OnDoorOpen;

            // Create State Machine object
            stateMachine = StateMachine.Create("Microwave oven", StateMachineType.Synchronous, null, null);

            //Equip it with a State Factory
            stateMachine.AddStateFactory(new MicroStateFactory(microwaveOven));

            // Configure the State Machine
            Configuration.Config(stateMachine.StateTransitionLookup);
        }

        #endregion

        #region MicrowaveOven Event Handlers

        private void microwaveOven_OnDoorOpen(object sender, EventArgs e)
        {
            stateMachine.IncomingEvent(new StateEngineEvent(MicroEvent.DoorOpen));
        }

        private void microwaveOven_OnDoorClosed(object sender, EventArgs e)
        {
            stateMachine.IncomingEvent(new StateEngineEvent(MicroEvent.DoorClosed));
        }

        private void microwaveOven_OnButtonPressed(object sender, EventArgs e)
        {
            stateMachine.IncomingEvent(new StateEngineEvent(MicroEvent.ButtonPressed));
        }

        #endregion

        #region Form Event Handlers


        // Start the Statemachine.
        private void bStart_Click(object sender, EventArgs e)
        {
            stateMachine.Start();

            // Create the StateMachineVisualizer aid if not already created (must be created after the statemachine has started).
            if (stateMachineVisualizer == null)
                stateMachineVisualizer = new StateMachineVisualizer(stateMachine); // Please notice that this class is disposed in the form's Dispose-method!

            // Analyze the statemachine.
            GenerateDocumentationXmlOptions generateDocumentationXmlOptions = new GenerateDocumentationXmlOptions();
            generateDocumentationXmlOptions.IncludeIssues = true;
            generateDocumentationXmlOptions.ImagePath = @"C:\Temp\"; // Where to store images
            generateDocumentationXmlOptions.ImageAnalyzer = stateMachineVisualizer;
            generateDocumentationXmlOptions.ImageScale = 1.0f / stateMachineVisualizer.AppearanceManager.PrinterScaling;

            AnalyzedStateMachine analyzedStateMachine = new AnalyzedStateMachine(stateMachine);
            analyzedStateMachine.AbbreviatorDictionary.Add("Wayne.MicrowaveOven.States.MicroTransition", "MicroTransition");
            analyzedStateMachine.AbbreviatorDictionary.Add("Wayne.MicrowaveOven.States.MicroEvent", "MicroEvent");
            analyzedStateMachine.GenerateDocumentationXml(@"C:\Temp\MicrowaveOvenAnalyze.xml", generateDocumentationXmlOptions);

            // Start the visualizer.
            stateMachineVisualizer.Show();
        }

        #endregion

    }
}
