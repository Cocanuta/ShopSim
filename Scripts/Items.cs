using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {

	public int[] relation1;
	public int[] relation2;

	void Start(){

		relation1 = new int[3];
		relation2 = new int[3];

	}

	public void Info(int i, out string name, out string description, out int type, out string icon, out int rrp) {

		name = "null item";
		description = "null description.";
		type = 0;
		icon = "null";
		rrp = 0;

		switch(i) {

		case 0:
			break;
		case 1:
			name = "Fish";
			description = "It's cold and wet.";
			type = 1;
			icon = "null";
			rrp = 1;
			break;
		case 2:
			name = "Soup";
			description = "It's hot and wet.";
			type = 1;
			icon = "null";
			rrp = 1;
			break;
		}

	}

	public void GetName(int i, out string name)
	{
		string itemName;
		string itemDescription;
		int type;
		string icon;
		int rrp;
		Info(i, out itemName, out itemDescription, out type, out icon, out rrp);

		name = itemName;
	}

	public void GetDescription(int i, out string description)
	{
		string itemName;
		string itemDescription;
		int type;
		string icon;
		int rrp;
		Info(i, out itemName, out itemDescription, out type, out icon, out rrp);
		
		description = itemDescription;
	}

	public void GetType(int i, out int itemType)
	{
		string itemName;
		string itemDescription;
		int type;
		string icon;
		int rrp;
		Info(i, out itemName, out itemDescription, out type, out icon, out rrp);
		
		itemType = type;
	}

	public void GetIcon(int i, out string itemIcon)
	{
		string itemName;
		string itemDescription;
		int type;
		string icon;
		int rrp;
		Info(i, out itemName, out itemDescription, out type, out icon, out rrp);
		
		itemIcon = icon;
	}

	public void GetRRP(int i, out int itemRRP)
	{
		string itemName;
		string itemDescription;
		int type;
		string icon;
		int rrp;
		Info(i, out itemName, out itemDescription, out type, out icon, out rrp);
		
		itemRRP = rrp;
	}
}
