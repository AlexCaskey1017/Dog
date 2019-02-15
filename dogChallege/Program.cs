using System;

namespace dogChallege {
    class Dog {
        private string name;
        private string owner;
        private int age;
        private Gender gender;



        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        public void Line()
        {
            Console.WriteLine("");
        }

        public void SetName(string georgia)
        {
            this.name = name;
        }

        public void SetOwner(string owner)
        {
            this.owner = owner;
        }

        public void SetAge(int num)
        {
            this.age = age;

        }

        public void SetGender(Gender gender)
        {
            this.gender = gender;
        }

        public string GetTag()
        { 

            return " If lost, call " + this.owner + " her name is " + this.name + " and she is " + this.age + " years old ";

        }

        public void Bark(int num)
        {
            for (int counter = 0;counter <= num; counter++)
            {

                Console.WriteLine("Woof!");

            }
        }


    }

    public enum Gender
    { Male, Female }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Georgia", "Alex", 2, Gender.Female);

            myDog.Bark(1);
            myDog.SetAge(2);
            myDog.SetName("georgia");
            myDog.SetOwner("Alex");
            myDog.SetGender(Gender.Female);

            Console.WriteLine(myDog.GetTag());

        }

    }
}

