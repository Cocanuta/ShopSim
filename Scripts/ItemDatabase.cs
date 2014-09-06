using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item> ();

	void Start()
	{
		items.Add (new Item("Fish", 1, "It's wet and cold.", 5, Item.ItemType.Food, 0));
		items.Add (new Item("Soup", 2, "It's hot and wet.", 3, Item.ItemType.Food, 0));
	}
}
