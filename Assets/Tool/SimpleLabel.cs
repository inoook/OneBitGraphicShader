using UnityEngine;
using System.Collections;

public class SimpleLabel : MonoBehaviour {

	public string str = "";
	public Rect rect = new Rect(10,10,200,200);
	public Color color = Color.white;
	// Use this for initialization
	void Start () {
	
	}

	void OnGUI () {
		GUILayout.BeginArea(rect);
		GUI.color = color;
		GUILayout.Label(str);
		GUILayout.EndArea();
	}
}
