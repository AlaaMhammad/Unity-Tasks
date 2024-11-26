using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano : MonoBehaviour
{
    public GameObject[]  cubes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dis = 1f;
        foreach(GameObject cube in cubes)
        {
            dis += 0.1f;
            float yNew = MathF.Sin(Time.time * dis);
            cube.transform.rotation = Quaternion.Euler(new Vector3(0, yNew * 45f , 0));
        }


            

    }
}
