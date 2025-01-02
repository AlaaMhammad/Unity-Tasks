using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
namespace Task29
{
    public class TestUtilities : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // اختبار دالة Add
            int sum = Utilities.Add(1, 2, 3, 4, 5); // الناتج = 15
            Debug.Log($"Sum of numbers: {sum}");

            // اختبار طريقة RepeatString
            string repeatedString = "Hello".RepeatString(3); // الناتج = "HelloHelloHello"
            Debug.Log($"Repeated string: {repeatedString}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public static class Utilities
    {
        // دالة ثابتة لحساب مجموع الأرقام باستخدام params
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // طريقة امتداد لتكرار النص
        public static string RepeatString(this string str, int times)
        {
            return string.Concat(Enumerable.Repeat(str, times));
        }
    }


}

