using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create an inventory for potions
        Inventory potionInventory = new Inventory();
        potionInventory.AddItem("Healing Potion");
        potionInventory.AddItem("Strength Potion");

        // Create an inventory for elixirs
        Inventory elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");

        // Combine both inventories using the + operator
        Inventory combinedInventory = potionInventory + elixirInventory;

        // Display the items in the combined inventory
        combinedInventory.ShowItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
