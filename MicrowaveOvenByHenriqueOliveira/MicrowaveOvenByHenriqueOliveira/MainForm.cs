using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wayne.MicrowaveOven
{
    public partial class MainForm : Form, IMicrowaveOven
    {

        #region Fields

        private bool doorIsOpen;

        #endregion

        #region Events

        public event EventHandler OnDoorOpen;
        public event EventHandler OnDoorClosed;
        public event EventHandler OnButtonPressed;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void bDoor_Click(object sender, EventArgs e)
        {
            doorIsOpen = !doorIsOpen;
            if (doorIsOpen)
            {

            }
            else
            {
                lDoor.Text = "Closed";
                if (OnDoorClosed != null)
                    OnDoorClosed(this, EventArgs.Empty);
            }
        }

        #endregion

        #region IMicrowaveOven Members

        public bool DoorIsOpen
        {
            get { return doorIsOpen; }
        }

        private delegate void EmptyMethod();

        public void TurnOnLight()
        {
            lLight.BeginInvoke(new EmptyMethod(delegate ()
            {
                lLight.Text = "ON";
            }));
        }

        public void TurnOffLight()
        {
            lLight.BeginInvoke(new EmptyMethod(delegate ()
            {
                lLight.Text = "OFF";
            }));
        }
        public void TurnOnHeater()
        {
            lHeater.BeginInvoke(new EmptyMethod(delegate ()
            {
                lHeater.Text = "ON";
            }));
        }
        public void TurnOffHeater()
        {
            lHeater.BeginInvoke(new EmptyMethod(delegate ()
            {
                lHeater.Text = "OFF";
            }));
        }

        #endregion

        #region Form Event Handlers

        private void bOpenDoor_Click(object sender, EventArgs e)
        {
            doorIsOpen = true;
            lDoor.Text = "Open";

            if (OnDoorOpen != null)
                OnDoorOpen(this, EventArgs.Empty);
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            if (OnButtonPressed != null)
                OnButtonPressed(this, EventArgs.Empty);
        }

        private void bCloseDoor_Click(object sender, EventArgs e)
        {
            doorIsOpen = false;
            lDoor.Text = "Closed";

            if (OnDoorClosed != null)
                OnDoorClosed(this, EventArgs.Empty);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
