using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
	public int slotsX, slotsY;
	public List<Item> inventory = new List<Item>();
	public List<Item> slots = new List<Item>();
	private bool showInventory;
	private ItemDatabase database;
	private bool showTooltip;
	private string tooltip;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < (slotsX * slotsY); i++)
		{
			slots.Add(new Item());
			inventory.Add (new Item());
		}
		database = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase>();
		AddItem (1);
		AddItem (1);
		AddItem (1);
		AddItem (2);
		AddItem (2);

	}
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetButtonDown ("Inventory"))
		{
			showInventory = !showInventory;
		}
	}
	void OnGUI()
	{
		tooltip = "";
		if (showInventory)
		{
			DrawInventory ();
		}
		if(showTooltip)
		{
			GUI.Box (new Rect(Event.current.mousePosition.x + 15f, Event.current.mousePosition.y, 200, 100), tooltip);
		}
	}

	void DrawInventory()
	{
		Event e = Event.current;
		int i = 0;
		for(int y = 0; y < slotsX; y++)
		{
			for(int x = 0; x < slotsY; x++)
			{
				Rect slotRect = new Rect(x * 42, y * 42, 40, 40);
				GUI.Box (slotRect, "");
				slots[i] = inventory[i];
				if(slots[i].itemName != null)
				{
					GUI.DrawTexture(slotRect,slots[i].itemIcon);
					GUI.Label(slotRect,slots[i].itemStack.ToString());
					if(slotRect.Contains(Event.current.mousePosition))
					{
						tooltip = CreateTooltip (slots[i]);
						showTooltip = true;
					}
				}
				if(tooltip == "")
				{
					showTooltip = false;
				}

				i++;
			}
		}
	}

	string CreateTooltip(Item item)
	{
		tooltip = "<color=#ffffff>" + item.itemName + "</color>\n\n" + "<color=#D4D4D4>" + item.itemDesc + "</color>\n" + "Quantity: " + item.itemStack + "\nPrice: £" + item.itemPrice;
		return tooltip;
	}

	void AddItem(int id)
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			if (inventory[i].itemName == null && inventory[id].itemID != id)
			{
				for(int j = 0; j < database.items.Count; j++)
				{
					if(database.items[j].itemID == id)
					{
						inventory[i] = new Item(database.items[j]);
						inventory[i].itemStack = 1;
					}
				}
				break;
			}
			if (inventory[i].itemName != null && inventory[i].itemID == id)
			{
				inventory[i].itemStack++;
				break;
			}
		}
	}

	void RemoveItem(int id)
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			if(inventory[i].itemID == id)
			{
				inventory[i] = new Item();
				break;
			}
		}
	}

	bool InventoryContains(int id)
	{
		for(int i = 0; i < inventory.Count; i++)
		{
			if(inventory[i].itemID == id) return true;
		}
		return false;

	}
}
