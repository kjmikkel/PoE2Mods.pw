using System;
using System.Diagnostics;
using System.Windows.Forms;
using Patchwork;
using Patchwork.Utility.Binding;

namespace PatchworkLauncher
{

    public partial class guiHome : Form
    {
        // Main buttons
        private ToolTip launchToolTip = new ToolTip();
        private ToolTip testRunToolTip = new ToolTip();
        private ToolTip launchWithoutModsToolTip = new ToolTip();
        private ToolTip bakeModsIntoGameToolTip = new ToolTip();
        private ToolTip restoreUnmoddedFileToolTip = new ToolTip();

        public LaunchManager Manager
        {
            get;
            private set;
        }

        public guiHome(LaunchManager manager)
        {
            Manager = manager;
            InitializeComponent();

            launchToolTip.SetToolTip(guiLaunchWithMods, "The mods will only run for this session, and all modified files will revert back to normal after the game has been shut down");
            testRunToolTip.SetToolTip(guiTestRun, "Try to integrate the chosen mods into the dll – this will not start the game");
            launchWithoutModsToolTip.SetToolTip(guiLaunchNoMods, "Launch the game without mods");
            bakeModsIntoGameToolTip.SetToolTip(bakeModsIntoGame, "Bake the currently selected mods into the files, so that it can be run independently from this application. This can be reversed from the button below. This will not start the game");
            restoreUnmoddedFileToolTip.SetToolTip(restoreOriginal, "Restore original game files");
        }

        private void guiActiveMods_Click(object sender, EventArgs e)
        {
            Manager.Command_OpenMods();
        }

        private void guiLaunchNoMods_Click(object sender, EventArgs e)
        {
            Manager.Command_Launch();
        }

        private void guiHome_Load(object sender, EventArgs e)
        {
            guiGameIcon.Image = Manager.ProgramIcon;
            guiGameIcon.Refresh();
            guiPwVersion.Text = PatchworkInfo.Version;
            guiGameName.Text = Manager.AppInfo.AppName;
            guiGameVersion.Text = Manager.AppInfo.AppVersion;
            var isEnabled = Manager.State.Convert(x => x == LaunchManagerState.Idle);
            this.Bind(x => x.Enabled).Binding = isEnabled.ToBinding(BindingMode.IntoTarget);
            isEnabled.HasChanged += x =>
            {
                if (x.Value)
                {
                    Invoke((Action)(() => this.Focus()));
                }
            };
        }

        private void guiLaunchWithMods_Click(object sender, EventArgs e)
        {
            Manager.Command_Launch_Modded();
        }

        private void guiChangeFolder_Click(object sender, EventArgs e)
        {
            Manager.Command_ChangeFolder();
        }

        private void guiChangeModFolder_Click(object sender, EventArgs e)
        {
            Manager.Command_ChangeModFolder();
        }

        private void guiTestRun_Click(object sender, EventArgs e)
        {
            Manager.Command_TestRun();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(PatchworkInfo.PatchworkSite);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager.Command_Open_Readme();
        }

        private void bakeModsIntoGame_Click(object sender, EventArgs e)
        {
            Manager.Command_Bake_Mods_Into_Game();
        }

        private void restoreOriginal_Click(object sender, EventArgs e)
        {
            Manager.Command_Restore_Original_Unmodded_File();
        }
    }
}
