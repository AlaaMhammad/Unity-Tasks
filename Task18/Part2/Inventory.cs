using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> items = new List<string>();

    // Add an item to the inventory
    public void AddItem(string item)
    {
        items.Add(item);
    }

    // Display all items in the inventory
    public void ShowItems()
    {
        foreach (var item in items)
        {
            Debug.Log(item);
        }
    }

    // Overload the + operator to combine inventories
    public static Inventory operator +(Inventory inv1, Inventory inv2)
    {
        Inventory combinedInventory = new Inventory();

        // Add all items from inv1
        foreach (var item in inv1.items)
        {
            combinedInventory.AddItem(item);
        }

        // Add all items from inv2
        foreach (var item in inv2.items)
        {
            combinedInventory.AddItem(item);
        }

        return combinedInventory;
    }
}