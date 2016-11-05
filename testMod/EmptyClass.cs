using System;

using KSPPluginFramework;
namespace Empty
{
	//#region Starter Classes
	//[KSPAddon(KSPAddon.Startup.Flight, false)]
	//public class TransferWindowPlannerFlight : TransferWindowPlanner { }
	//[KSPAddon(KSPAddon.Startup.EditorAny, false)]
	//public class TransferWindowPlannerEditor : TransferWindowPlanner { }
	//[KSPAddon(KSPAddon.Startup.SpaceCentre, false)]
	//public class TransferWindowPlannerSpaceCenter : TransferWindowPlanner { }
	//[KSPAddon(KSPAddon.Startup.TrackingStation, false)]
	//public class TransferWindowPlannerTrackingStation : TransferWindowPlanner { }
	//#endregion

	[KSPAddon(KSPAddon.Startup.Flight, false)]
	public class MyAddOn: MonoBehaviourExtended
	{
		internal override void Start()
		{
			LogFormatted("TEST ADDON!------------------------------------");
			base.Start();
		}
	}
}
