using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Task29
{
    public class TestCustomObject : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            CustomObject obj = new CustomObject(1, "Example");
            Debug.Log(obj.ToString());
        }

        // Update is called once per frame
        void Update()
        {

        }


        public class CustomObject
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public CustomObject(int id, string name)
            {
                ID = id;
                Name = name;
            }

            public override string ToString()
            {
                return $"Object [ID: {ID}, Name: {Name}]";
            }
        }

    }
}
