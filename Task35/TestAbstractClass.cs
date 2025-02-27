using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public abstract class AbstractBaseClass
    {
        public abstract void PerformAction();

        public void PrintInfo()
        {
            Debug.Log("This is a concrete method in the abstract base class.");
        }
    }

    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformAction()
        {
            Debug.Log("PerformAction is implemented in the derived class.");
        }
    }

    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample derived = new DerivedClassExample();
            derived.PerformAction();
            derived.PrintInfo();
        }
    }
}