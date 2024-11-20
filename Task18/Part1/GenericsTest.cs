using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                // Create a GameContainer and store "Healing Potion"
        GameContainer<string> potionContainer = new GameContainer<string>();
        potionContainer.SetItem("Healing Potion");
        
        // Log the saved item
        string savedItem = potionContainer.GetItem();
        Debug.Log("Stored item: " + savedItem);
        
        // Describe the saved item and log the description
        string description = GameUtils.DescribeItem(savedItem);
        Debug.Log(description);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
