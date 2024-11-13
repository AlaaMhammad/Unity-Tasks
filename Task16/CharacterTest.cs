using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Character[] characters = new Character[2];
            characters[0] = new Soldier();  // Using default constructor
            characters[1] = new Officer("Commander", 90, new Position(1, 2, 3));

            foreach (Character character in characters)
            {
                character.DisplayInfo();  // Demonstrating polymorphism
            }

            // Demonstrate attack
            Officer officer = (Officer)characters[1];
            Soldier soldier = (Soldier)characters[0];
            Debug.Log("Before Attack - Soldier Health: " + soldier.Health);
            officer.Attack(20, soldier, "Shooting");
            Debug.Log("After Attack - Soldier Health: " + soldier.Health);
        }
    }
}