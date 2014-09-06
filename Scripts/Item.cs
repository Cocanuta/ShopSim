using UnityEngine;
using System.Collections;

	[System.Serializable]
public class Item {
	public string itemName;
	public int itemID;
	public string itemDesc;
	public Texture2D itemIcon;
	public int itemPrice;
	public ItemType itemType;
	public int itemStack;

	public enum ItemType {
		Food,
		Technology,
		Game
	}

	public Item(string name, int id, string desc, int price, ItemType type, int stack)
	{
		itemName = name;
		itemID = id;
		itemDesc = desc;
		itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
		itemPrice = price;
		itemType = type;
		itemStack = stack;
	}

	public Item()
	{
	}

	public Item(Item i)
	{
		this.itemName = i.itemName;
		this.itemID = i.itemID;
		this.itemDesc = i.itemDesc;
		this.itemIcon = i.itemIcon;
		this.itemPrice = i.itemPrice;
		this.itemType = i.itemType;
		this.itemStack = i.itemStack;
	}
}
