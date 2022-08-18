using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibV64Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Peacesign__alpha_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Process[] emulatorProcesses = Memory.GetEmulatorProcesses("Project64");
            Memory.HookEmulatorProcess(emulatorProcesses[0]);
            Memory.FindBaseAddress();

            if (Core.CameraFrozen)
                Debug.WriteLine("Camera was already frozen!");

            Core.FixCameraZoomOut();
            Core.FixResetBodyState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            Core.SetHandState(Types.HandState.PEACE);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.HALF);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.CLOSED);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.UP);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.DOWN);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.LEFT);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.RIGHT);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Process[] emulatorProcesses = Memory.GetEmulatorProcesses("Project64");
            Memory.HookEmulatorProcess(emulatorProcesses[0]);
            Memory.FindBaseAddress();

            if (Core.CameraFrozen)
                Debug.WriteLine("Camera was already frozen!");

            Core.FixCameraZoomOut();
            Core.FixResetBodyState();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboboxHands.Text)
            {
                case "Fists":
                    // fist
                    Core.SetHandState(Types.HandState.FISTS);
                    break;
                case "Open":
                    // open
                    Core.SetHandState(Types.HandState.OPEN);
                    break;
                case "Right Open":
                    // Right hand open only
                    Core.SetHandState(Types.HandState.RIGHT_OPEN);
                    break;
                case "Peace Sign":
                    // Peace Sign
                    Core.SetHandState(Types.HandState.PEACE);
                    break;
                case "Cap In Hand":
                    // Cap in hand
                    Core.SetHandState(Types.HandState.WITH_CAP);
                    break;
                case "Wingcap In Hand":
                    // Wingcap in hand
                    Core.SetHandState(Types.HandState.WITH_WING_CAP);
                    break;
            }
        }
        
        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboboxEye_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboboxEye.Text)
            {
                case "Blinking":
                    // Blinking
                    Core.SetEyeState(Types.EyeState.BLINKING);
                    break;
                case "Open":
                    // open
                    Core.SetEyeState(Types.EyeState.OPEN);
                    break;
                case "Half":
                    // half
                    Core.SetEyeState(Types.EyeState.HALF);
                    break;
                case "Closed":
                    // closed
                    Core.SetEyeState(Types.EyeState.CLOSED);
                    break;
                case "Up":
                    // unused up
                    Core.SetEyeState(Types.EyeState.UP);
                    break;
                case "Down":
                    // unused down
                    Core.SetEyeState(Types.EyeState.DOWN);
                    break;
                case "Right":
                    // unused right
                    Core.SetEyeState(Types.EyeState.RIGHT);
                    break;
                case "Left":
                    // unused left
                    Core.SetEyeState(Types.EyeState.LEFT);
                    break;
                case "Dead":
                    // dead eyes
                    Core.SetEyeState(Types.EyeState.DEAD);
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboboxX3.Text)
            {
                case "Default":
                    // Default
                    Core.SetPowerUpState(Types.PowerUpState.DEFAULT);
                    break;
                case "Expression 1":
                    // Expression 1
                    Core.SetPowerUpState(Types.PowerUpState.VANISH);
                    break;
                case "Expression 2":
                    // Expression 2
                    Core.SetPowerUpState(Types.PowerUpState.METAL);
                    break;
                case "Expression 3":
                    // Expression 3
                    Core.SetPowerUpState(Types.PowerUpState.METAL_VANISH);
                    break;
            }
        }
    }
}

