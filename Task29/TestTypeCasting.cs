using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Task29
{
    public class TestTypeCasting : MonoBehaviour
    {
        void Start()
        {
            Animal myAnimal = new Cat(); // Upcasting
            myAnimal.MakeSound();
            myAnimal.Move();

            Cat myCat = myAnimal as Cat; // Downcasting
            myCat?.MakeSound();
            myCat?.Move();

            List<ICanFight> fighters = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (var fighter in fighters)
            {
                fighter.Attack();
                if (fighter is Cat)
                    Debug.Log("The object is a Cat.");
                else if (fighter is Warrior)
                    Debug.Log("The object is a Warrior.");
            }
        }
        public class Animal
        {
            public virtual void MakeSound() { Debug.Log("Animal sound"); }
            public void Move() { Debug.Log("Animal moves."); }
        }

        public class Cat : Animal, ICanFight
        {
            public override void MakeSound() { Debug.Log("Meow!"); }
            public new void Move() { Debug.Log("Cat runs quickly."); }
            public void Attack() { Debug.Log("Cat attacks with claws!"); }
        }

        public interface ICanFight
        {
            void Attack();
        }

        public class Warrior : ICanFight
        {
            public void Attack() { Debug.Log("Warrior attacks with a sword!"); }
        }


    }
}
