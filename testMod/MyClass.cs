using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace MyKSPProject
{
	/// <summary> 
	/// My first part!
	/// </summary>\
	public class HelloKerbinMod : PartModule
	{
		protected Rect windowPos;

		private void WindowGUI(int windowID)
		{
			GUIStyle mySty = new GUIStyle(GUI.skin.button);
			mySty.normal.textColor = mySty.focused.textColor = Color.white;
			mySty.hover.textColor = mySty.active.textColor = Color.yellow;
			mySty.onNormal.textColor = mySty.onFocused.textColor = mySty.onHover.textColor = mySty.onActive.textColor = Color.green;
			mySty.padding = new RectOffset(8, 8, 8, 8);

			GUILayout.BeginVertical();
			if (GUILayout.Button("DESTROY", mySty, GUILayout.ExpandWidth(true)))//GUILayout.Button is "true" when clicked
			{

			}
			GUILayout.EndVertical();

			//DragWindow makes the window draggable. The Rect specifies which part of the window it can by dragged by, and is 
			//clipped to the actual boundary of the window. You can also pass no argument at all and then the window can by
			//dragged by any part of it. Make sure the DragWindow command is AFTER all your other GUI input stuff, or else
			//it may "cover up" your controls and make them stop responding to the mouse.
			GUI.DragWindow(new Rect(0, 0, 10000, 20));

		}


		private void drawGUI()
		{
			GUI.skin = HighLogic.Skin;
			windowPos = GUILayout.Window(1, windowPos, WindowGUI, "Self Destruct", GUILayout.MinWidth(100));
		}

		public override void OnStart(PartModule.StartState state)
		{

			base.OnStart(state);
			print("HELLOonFlightStart");
			Debug.Log("HELLOonFlightStart");
			Debug.LogWarning("HELLOonFlightStart");
			Debug.LogError("HELLOonFlightStart");
		}

		//protected override void onFlightStart()  //Called when vessel is placed on the launchpad
		//{
		//	RenderingManager.AddToPostDrawQueue(3, new Callback(drawGUI));//start the GUI
		//	print("HELLOonFlightStart");
		//	Debug.Log("HELLOonFlightStart");
		//	Debug.LogWarning("HELLOonFlightStart");
		//	Debug.LogError("HELLOonFlightStart");

		//}
		//protected override void onPartStart()
		//{
		//	print("HELLOonPartStart");
		//	Debug.Log("HELLOonPartStart");
		//	Debug.LogWarning("HELLOonPartStart");
		//	Debug.LogError("HELLOonPartStart");
		//	if ((windowPos.x == 0) && (windowPos.y == 0))//windowPos is used to position the GUI window, lets set it in the center of the screen
		//	{
		//		windowPos = new Rect(Screen.width / 2, Screen.height / 2, 10, 10);
		//	}
		//}
		//protected override void onPartDestroy()
		//{
		//	RenderingManager.RemoveFromPostDrawQueue(3, new Callback(drawGUI)); //close the GUI
		//}

	}
}