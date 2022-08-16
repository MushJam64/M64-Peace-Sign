using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibV64Core;

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
            Core.SetHandState(Types.HandState.FISTS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Core.SetHandState(Types.HandState.OPEN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Core.SetHandState(Types.HandState.RIGHT_OPEN);
        }
        
        private void Button4_Click(object sender, EventArgs e)
        {
            Core.SetHandState(Types.HandState.PEACE);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Core.SetHandState(Types.HandState.WITH_CAP);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Core.SetHandState(Types.HandState.WITH_WING_CAP);
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
            Core.SetEyeState(Types.EyeState.BLINKING);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Core.SetEyeState(Types.EyeState.OPEN);
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
            Core.SetEyeState(Types.EyeState.DEAD);
        }
    }
}