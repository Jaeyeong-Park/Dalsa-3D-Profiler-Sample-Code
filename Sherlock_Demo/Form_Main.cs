using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ipeenginectrlLib;
using ipedisplayctrlLib;
namespace Sherlock_Demo
{
    
    public partial class Form_Main : Form
    {
        AxIpeEngine Engine;
        string filePath = "";
        string workSpaceToDisplay3Dcloud = "";
        string workSpaceToDisplayMono16 = "";
        string workSpaceToDisplayMono8 = "";


        public Form_Main()
        {
            InitializeComponent();

            
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            btn_Initialize.Enabled = false;
            btn_Run.Enabled = false;
            btn_Halt.Enabled = false;
            btn_Terminate.Enabled = false;
            label_Status.Text = "No File";

            
            
        }

        private void btn_FileLoad_Click(object sender, EventArgs e)
        {
            filePath = System.IO.Path.GetFullPath(@"..\..\sh8\test_16m.sh8");
            workSpaceToDisplay3Dcloud = "workspace_3dcloudA";
            workSpaceToDisplayMono16 = "workspace_mono16A";
            workSpaceToDisplayMono8 = "workspace_mono8A";
            btn_Initialize.Enabled = true;
            label_Status.Text = "File Name : test_16m.sh8";
        }

        private void btn_Initialize_Click(object sender, EventArgs e)
        {
            label_Status.Text = "Initialzing Engine...";
            btn_Initialize.Enabled = false;
            btn_FileLoad.Enabled = false;

            Engine = new AxIpeEngine();
            Result ret = Engine.initialize("default");

            if(ret != Result.Ok)
            {
                MessageBox.Show("Could not initialize engine object.", "FATAL ERROR", MessageBoxButtons.OK);
                Close();
            }

            Engine.programStarted +=
                new ipeenginectrlLib.IAxIpeEngineEvents_programStartedEventHandler(onProgramStart);
            Engine.programStopped +=
                new ipeenginectrlLib.IAxIpeEngineEvents_programStoppedEventHandler(onProgramStop);
            Engine.programLoopCompleted +=
                new ipeenginectrlLib.IAxIpeEngineEvents_programLoopCompletedEventHandler(onProgramLoop);
            Engine.programError +=
                new ipeenginectrlLib.IAxIpeEngineEvents_programErrorEventHandler(onProgramError);
            Engine.programAborted +=
                    new ipeenginectrlLib.IAxIpeEngineEvents_programAbortedEventHandler(onProgramAbort);

            ret = Engine.load(filePath);

            if (ret != ipeenginectrlLib.Result.Ok)
            {
                MessageBox.Show("Could not load program.", "FATAL ERROR", MessageBoxButtons.OK);
                Close();
            }

            axAxIpeDisplay_3DCloud.setDisplayMode(DispMode.Cloud);
            axAxIpeDisplay_3DCloud.setPalette(Palette.SPECTRUM);
            

            axAxIpeDisplay_Mono16.setDisplayMode(DispMode.Image);
            axAxIpeDisplay_Mono16.setMono16Bits(12);

            axAxIpeDisplay_Mono8.setDisplayMode(DispMode.Image);
            Engine.connectDisplay(axAxIpeDisplay_3DCloud.dspHandle, workSpaceToDisplay3Dcloud);

            
            Engine.connectDisplay(axAxIpeDisplay_Mono16.dspHandle, workSpaceToDisplayMono16);

            
            Engine.connectDisplay(axAxIpeDisplay_Mono8.dspHandle, workSpaceToDisplayMono8);
           

            btn_Run.Enabled = true;
            btn_Terminate.Enabled = true;
            label_Status.Text = "Ready";
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            btn_Run.Enabled = false;
            label_Status.Text = "Running...";
            Result ret = Engine.run(1);
            if (ret != ipeenginectrlLib.Result.Ok)
            {
                MessageBox.Show("Could not run program.", "FATAL ERROR", MessageBoxButtons.OK);
                Close();
            }
            
            
        }
        private void btn_Halt_Click(object sender, EventArgs e)
        {

        }

        private void btn_Terminate_Click(object sender, EventArgs e)
        {
            btn_Run.Enabled = false;
            btn_Initialize.Enabled = true;
            btn_Terminate.Enabled = false;
            btn_Halt.Enabled = false;

            label_Status.Text = "Terminating Sherlock Engine.";

            Result ret = Engine.terminate();
            if (ret != ipeenginectrlLib.Result.Ok)
            {
                MessageBox.Show("Could not terminate engine object.", "FATAL ERROR", MessageBoxButtons.OK);
                Close();
            }
            Engine = null;

            label_Status.Text = "Sherlock engine terminated.";
        }
        private void onProgramStart() { }
        private void onProgramStop()
        {
            axAxIpeDisplay_3DCloud.setZoom(-1);
            axAxIpeDisplay_Mono16.setZoom(-1);
            axAxIpeDisplay_Mono8.setZoom(-1);
        }
        private void onProgramLoop()
        {
            textBox_BottomHeight.Text = Engine.value("UnderHeightZ.value").ToString();
            textBox_highHeight.Text = Engine.value("TopHeightZ.value").ToString();
            textBox_Distance.Text = Engine.value("distance.value").ToString();
            btn_Run.Enabled = true;
            label_Status.Text = "Run Complete.";

            
        }
        private void onProgramError(ipeenginectrlLib.Result result)
        {
            
        }
        private void onProgramAbort() { }

        
    }
}
