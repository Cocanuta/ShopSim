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

		inv = new int[3];

		inv = PlayerPrefsX.GetIntArray ("Inventory");


		for (int i = 1; i < inv.Length; i++) {
			
			itemScript.GetName(i, out itemName);
			
			Debug.Log(inv[i] + " x " + itemName + " added to inventory.");

		}



	}
	
	// Update is called once per frame
	void Update () {




	}

}
