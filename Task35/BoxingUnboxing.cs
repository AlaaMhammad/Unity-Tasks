using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxedHealth = health; // Boxing
            int unboxedHealth = (int)boxedHealth; // Unboxing
            unboxedHealth += 50;

            Debug.Log($"Original value: {health}");
            Debug.Log($"Boxed value: {boxedHealth}");
            Debug.Log($"Unboxed and modified value: {unboxedHealth}");
        }
    }
}
