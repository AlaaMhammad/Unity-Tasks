using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class man : MonoBehaviour
{
    // Start is called before the first frame update
    public float m = 0f;
    public float u = 0f;
    public float R = 0f;

    public float x = 0.001f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m += x;
            R = 90;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            m -= x;
            R = -90;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            u += x;
            R = 0;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            u -= x;
            R = -180;
            
        }
        transform.position = new Vector3(m,0,u);
        transform.rotation = Quaternion.Euler(new Vector3(0,R, 0));

    }
}
