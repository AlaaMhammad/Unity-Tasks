using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    // Base Class
    public class Creature
    {
        // Virtual method for Speak
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

    // Interface for running
    public interface IRunnable
    {
        void Run();
    }

    // Interface for jumping
    public interface IJumpable
    {
        void Jump();
    }

    // Interface for swimming
    public interface ISwimmable
    {
        void Swim();
    }

    // Kangaroo class implementing IRunnable and IJumpable
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        // Override Speak method for Kangaroo
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }

        // Implement Run method from IRunnable
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }

        // Implement Jump method from IJumpable
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
    }

    // Duck class implementing IRunnable and ISwimmable
    public class Duck : Creature, IRunnable, ISwimmable
    {
        // Override Speak method for Duck
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

        // Implement Run method from IRunnable
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        // Implement Swim method from ISwimmable
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
    }

    // CreatureManager class to manage and demonstrate polymorphism
    public class CreatureManager : MonoBehaviour
    {
        // Start method for demonstration
        void Start()
        {
            // Creating instances of Kangaroo and Duck
            Creature kangaroo = new Kangaroo();
            Creature duck = new Duck();

            // Creating lists for interfaces
            List<Creature> creatures = new List<Creature> { kangaroo, duck };
            List<IRunnable> runnableCreatures = new List<IRunnable> { kangaroo as IRunnable, duck as IRunnable };
            List<IJumpable> jumpableCreatures = new List<IJumpable> { kangaroo as IJumpable };
            List<ISwimmable> swimmableCreatures = new List<ISwimmable> { duck as ISwimmable };

            // Demonstrating polymorphism: Calling Speak() for each creature
            foreach (var creature in creatures)
            {
                creature.Speak();
            }

            // Calling Run() for each creature that is IRunnable
            foreach (var runnable in runnableCreatures)
            {
                runnable.Run();
            }

            // Calling Jump() for each creature that is IJumpable
            foreach (var jumpable in jumpableCreatures)
            {
                jumpable.Jump();
            }

            // Calling Swim() for each creature that is ISwimmable
            foreach (var swimmable in swimmableCreatures)
            {
                swimmable.Swim();
            }
        }
    }
}
