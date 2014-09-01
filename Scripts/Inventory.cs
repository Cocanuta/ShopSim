using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	public int itemID;
	public string itemName;
	public string itemDescription;
	
	public Items itemScript;

	public int[] inv;


	// Use this for initialization
	void Start () {

		inv = new int[2];

		inv [0] = 1;
		inv [1] = 8;

		for (int i = 0; i < inv.Length; i++) {
			
			itemScript.Info(i, out itemName, out itemDescription);
			
			Debug.Log(inv[i] + " x " + itemName + " added to inventory.");
			
			
		}

	}
	
	// Update is called once per frame
	void Update () {




	}

}
