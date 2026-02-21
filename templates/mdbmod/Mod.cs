using System;
using GameSDK.ModHost;
//#if (imgui)
using GameSDK.ModHost.ImGui;
//#endif

namespace MDBModTemplate
{
    /// <summary>
    /// Main mod entry point.
    /// </summary>
    [Mod("MOD_ID_TOKEN", "MDBModTemplate", "1.0.0",
        Author = "MOD_AUTHOR",
        Description = "MOD_DESCRIPTION")]
    public class Mod : ModBase
    {
        /// <summary>Called once when the mod is loaded.</summary>
        public override void OnLoad()
        {
            Logger.Info("MDBModTemplate loaded!");
//#if (imgui)
            ImGuiWindow.Register(Logger);
//#endif
        }

        /// <summary>Called every frame.</summary>
        public override void OnUpdate()
        {
            // Your per-frame logic here
        }

        /// <summary>Called when the mod is unloaded.</summary>
        public override void OnUnload()
        {
//#if (imgui)
            ImGuiWindow.Unregister();
//#endif
            Logger.Info("MDBModTemplate unloaded.");
        }
    }
}
