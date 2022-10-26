using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GridLines : MonoBehaviour
{
	public int X_Axis_Length = 10;
	public int Y_Axis_Length = 10;
	public bool Z_Plane = true;
	public int font_Size;
	public bool show_Test = true;
	
	private GUIStyle guiStyle = new GUIStyle(); //create a new variable
	public void OnDrawGizmos()
	{
		// Axis
		Gizmos.color = Color.red; // X
		Gizmos.DrawLine(new Vector3((X_Axis_Length / -1), 0, 0), new Vector3((X_Axis_Length), 0, 0));
		Gizmos.color = Color.green; // Y
		Gizmos.DrawLine(new Vector3(0, (Y_Axis_Length / -1), 0), new Vector3(0, (Y_Axis_Length), 0));
		Gizmos.color = Color.blue; // Y
		Gizmos.DrawLine(new Vector3(0, 0, (X_Axis_Length / -1)), new Vector3(0, 0, (X_Axis_Length)));  // assumes Z Axis is the same length as the X


		//Gizmos.DrawWireSphere(centre, Radius);
		guiStyle.fontSize = font_Size;
		int x = -X_Axis_Length;
		int y = -Y_Axis_Length;	
	
		while (x < X_Axis_Length)
		{

			Handles.Label(new Vector3(x, y, 0), (x + "," + y));
			
			while ( y < Y_Axis_Length)
			{
				Handles.Label(new Vector3(x, y, 0), (x + "," + y));
				y++;
			}
			 x++;
			 y = -Y_Axis_Length;
		}
		
		if (Z_Plane)
		{
			int z = -X_Axis_Length;	// Z Axis
			y = -Y_Axis_Length;	
	
			while (z < X_Axis_Length)  // Z Axis
			{

				Handles.Label(new Vector3(0, y, z), (z + "," + y));
				
				while ( y < Y_Axis_Length)
				{
					Handles.Label(new Vector3(0, y, z), (z + "," + y));
					y++;
				}
				z++;
				y = -Y_Axis_Length;
			}
		}
		
		if (show_Test)
		{
		// Test lines
		Gizmos.color = Color.cyan; 
		Gizmos.DrawLine(Vector3.zero, new Vector3(4, 5, 0));
		Gizmos.DrawWireSphere(Vector3.zero, 0.2f);
		Gizmos.DrawCube(new Vector3(4, 5, 0), new Vector3(0.2f, 0.2f, 0.2f));
		
		Gizmos.color = Color.magenta; 
		Gizmos.DrawLine(new Vector3(-3, 3, -3), new Vector3(2, 2, 2)); 
		Gizmos.DrawWireSphere(new Vector3(-3, 3, -3), 0.2f);
		Gizmos.DrawCube(new Vector3(2, 2, 2), new Vector3(0.2f, 0.2f, 0.2f));			
		}
	}
}
