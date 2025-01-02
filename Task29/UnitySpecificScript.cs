using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void OnEnable()
        {
            Debug.Log("GameObject Enabled");
        }

        void OnDisable()
        {
            Debug.Log("GameObject Disabled");
        }

        void Start()
        {
            Debug.Log("Game started!");

            // البحث عن كائنات
            GameObject targetObject = GameObject.Find("TargetObject");
            if (targetObject != null)
                Debug.Log("Found object by name: " + targetObject.name);
            else
                Debug.Log("No TargetObject found.");

            GameObject jokerObject = GameObject.FindGameObjectWithTag("Joker");
            if (jokerObject != null)
                Debug.Log("Found object by tag: " + jokerObject.name);
            else
                Debug.Log("No Joker object found.");

            Light lightObject = GameObject.FindObjectOfType<Light>();
            if (lightObject != null)
                Debug.Log("Found object of type Light: " + lightObject.name);
            else
                Debug.Log("No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameObject targetObject = GameObject.Find("TargetObject");
                if (targetObject != null)
                {
                    targetObject.SetActive(false);
                    Debug.Log("TargetObject deactivated!");
                }
            }
        }
    }
}