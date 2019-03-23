using System;
using Patchwork.AutoPatching;
using Patchwork.Engine;

namespace PatchworkLauncher
{
    public class PatchInstruction : IDisposable
    {

        public PatchInstruction()
        {

        }

        public PatchingManifest Patch
        {
            get;
            set;
        }

        public AppInfo AppInfo
        {
            get;
            set;
        }

        public string PatchLocation
        {
            get;
            set;
        }

        public string PatchOriginalLocation
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get;
            set;
        }

        public string Requirements => Patch.PatchInfo.Requirements;

        public string Version => Patch.PatchInfo.PatchVersion;

        public string Name => Patch.PatchInfo.PatchName;

        public string Target => Patch.PatchInfo.GetTargetFile(AppInfo).Name;

        public void Dispose()
        {
            Patch.Dispose();
        }
    }

}
