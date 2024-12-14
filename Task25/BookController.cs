using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BookController : MonoBehaviour
{
    public Transform frontCover; // الغلاف الأمامي
    public Transform SCALING;
    public float openSpeed = 2.0f; // سرعة الفتح
    private bool isOpening;
    private float currentAngle = 0.0f;
    private float currentScal = 0.0f;


    void Update()
    {


        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            isOpening = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isOpening = false;
        }

        if (isOpening)
        {
            if (currentAngle < 180f)
            {
                currentAngle += openSpeed * Time.deltaTime;
                frontCover.localRotation = Quaternion.Euler(currentAngle, 0, 0);
                if (currentAngle >30f )
                {
                    if (currentScal < 1)
                    {
                    currentScal += openSpeed * Time.deltaTime * 0.02f;
                    SCALING.transform.localScale = new Vector3(1,currentScal,1);
                    }
                    else{
                        currentScal= 1;
                    }
                }
            }
        }else{
            if (currentAngle > 1f)
            {
                --currentAngle;
                currentAngle += openSpeed * Time.deltaTime;
                frontCover.localRotation = Quaternion.Euler(currentAngle, 0, 0);

                if (currentAngle <95f )
                {
                    if (currentScal !=0 && currentScal > 0)
                    {
                        // currentScal--;
                    currentScal += openSpeed * Time.deltaTime * -0.02f;
                    // math.floor(currentScal);
                    SCALING.transform.localScale = new Vector3(1,currentScal,1);
                    }
                    else{
                        currentScal= 0;
                    }
                }
            }
        }
    }
}