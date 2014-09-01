using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public Inventory invScript;

	public string fishNumber;
	public string soupNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		fishNumber = invScript.inv [1].ToString();

		soupNumber = invScript.inv [2].ToString();

	}

	void OnGUI() {

		GUILayout.Space (10f);
		GUILayout.Label (fishNumber + " x Fish.");
		GUILayout.Space (10f);
		if (GUILayout.Button("Add Fish")) {
			invScript.inv[1]++;
			Debug.Log("Added Fish");
		}
		if (GUILayout.Button("Subtract Fish")) {
			invScript.inv[1]--;
			Debug.Log("Added Fish");
		}
		GUILayout.Space (10f);
		GUILayout.Label (soupNumber + " x Soup.");
		GUILayout.Space (10f);
		if (GUILayout.Button("Add Soup")) {
			invScript.inv[2]++;
			Debug.Log("Added Fish");
		}
		if (GUILayout.Button("Subtract Soup")) {
			invScript.inv[2]--;
			Debug.Log("Added Fish");
		}
		GUILayout.Space (20f);
		if (GUILayout.Button("Save")) {
			invScript.Save();
			Debug.Log("Saved Inventory");
		}
	}
}
