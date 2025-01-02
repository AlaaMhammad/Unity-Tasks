using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Task29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            // تعريف 3 متغيرات باستخدام var
            var number = 7; // متغير عددي
            var message = "Unity Programming"; // متغير نصي
            var isActive = true; // متغير منطقي

            // التحقق إذا كان الرقم زوجيًا أو فرديًا باستخدام المعامل الثلاثي
            string result = number % 2 == 0 ? "even" : "odd";

            // الطباعة باستخدام المتغيرات
            Debug.Log($"The number {number} is {result}."); // استخدام المتغير العددي
            Debug.Log($"Message: {message}."); // استخدام المتغير النصي
            Debug.Log($"Is the game active? {isActive}."); // استخدام المتغير المنطقي

            // تسجيل التاريخ والوقت باستخدام System.DateTime
            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToShortTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }
    }
}