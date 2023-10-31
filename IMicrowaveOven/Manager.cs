using System;
using System.Windows.Forms;
using Wayne.Lib.StateEngine;
using Wayne.Lib.StateEngine.Visualizer;
using Wayne.Lib.StateEngine.Analyzer;
using Wayne.Lib;
using Wayne.Lib.Log;
using System.IO;
using System.Reflection;

namespace Wayne.MicrowaveOven
{
    public partial class Manager : Form, IIdentifiableEntity
    {
        #region Fields

        private readonly StateMachine stateMachine;
        private readonly IMicrowaveOven microwaveOven;
        private StateMachineVisualizer stateMachineVisualizer;
        private DebugLogger logger;

        #endregion

        #region Construction

        /// <summary>
        /// Construction
        /// </summary>
        public Manager()
        {
            InitializeComponent();

            //Create the mock-up microwave oven.
            MainForm mockup = new MainForm();
            mockup.Show();

            Uri fileUri = new Uri(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase), "LogConfig.xml"));
            Logger.SetConfigFile(fileUri.LocalPath);

            logger = new DebugLogger(this, true);

            microwaveOven = mockup;
            microwaveOven.OnButtonPressed += microwaveOven_OnButtonPressed;
            microwaveOven.OnDoorClosed += microwaveOven_OnDoorClosed;
            microwaveOven.OnDoorOpen += microwaveOven_OnDoorOpen;

            //Create statemachine object
            stateMachine = StateMachine.Create("Microwave oven", StateMachineType.Synchronous, logger, "StateMachine");

            //Equip it with a state factory.
            stateMachine.AddStateFactory(new States.MicroStateFactory(microwaveOven));

            //Configure the state machine.
            States.Configuration.Config(stateMachine.StateTransitionLookup);
        }

        #endregion

        #region IIdentifiableEntity Members

        public int Id { get { return IdentifiableEntity.NoId; } }

        public string EntityType { get { return "MicrowaveOven"; } }

        public string EntitySubType { get { return String.Empty; } }

        public IIdentifiableEntity ParentEntity { get { return null; } }

        #endregion

        #region MicrowaveOven Event Handlers

        private void microwaveOven_OnDoorOpen(object sender, EventArgs e)
        {
            logger.Add("Test log microwaveOven_OnDoorOpen");
            stateMachine.IncomingEvent(new StateEngineEvent(States.MicroEvent.DoorOpen));
        }

        private void microwaveOven_OnDoorClosed(object sender, EventArgs e)
        {
            logger.Add("Test log microwaveOven_OnDoorClosed");
            stateMachine.IncomingEvent(new StateEngineEvent(States.MicroEvent.DoorClosed));
        }

        private void microwaveOven_OnButtonPressed(object sender, EventArgs e)
        {
            logger.Add("Test log microwaveOven_OnButtonPressed");
            stateMachine.IncomingEvent(new StateEngineEvent(States.MicroEvent.ButtonPressed));
        }

        #endregion

        #region Form Event Handlers

        /// <summary>
        /// Start the Statemachine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.Dispose();
        }
    }
}