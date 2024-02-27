using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 
    class Cat : Animal
    {
        public string color;
        public int age;
        public double weight;

        public Cat()
            :base()
        {
            color = "";
            age = 0;
            weight = 0;
        }

        public Cat(string name, string color, int age, double weight)
            : base(name)
        {
            this.color = color;
            this.age = age;
            this.weight = weight;
        }
        public void newDisplay()
        {
            Console.WriteLine($"Color:{color} Age:{age} Weight:{weight}");
        }
    }

    class Fish : Animal
    {
        public string type;
        public string color;
        public string habitat;

        public Fish()
            : base()
        {
            type = "";
            color = "";
            habitat = "";
        }

        public Fish(string name, string type, string color, string habitat)
            : base(name)
        {
            this.type = type;
            this.color = color;
            this.habitat = habitat;
        }

        public void fishDisplay()
        {
            Console.WriteLine($"Type:{type} Color:{color} Habitat:{habitat}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Cat cat = new Cat();
            cat.name = "Moocow";
            cat.display();
            cat.color = "grey";
            cat.age = 3;
            cat.weight = 13;
            cat.newDisplay();

            //derived class object using parameterized constructor
            Cat gem = new Cat("Gem", "Orange", 5, 16);
            gem.display();
            gem.newDisplay();

            Fish fish = new Fish();
            fish.name = "nemo";
            fish.display();
            fish.type = "clownfish";
            fish.color = "orange and white";
            fish.habitat = "ocean";
            fish.fishDisplay();

            Fish fish2 = new Fish("Bob","perch","gold","lake");
            fish2.display();
            fish2.fishDisplay();
        }

    }
}