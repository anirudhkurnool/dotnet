using System;


namespace MyNameSpace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("========= OOPS =========");
            //below line works only when there is not constructor(default)
            //Person p1 = new() { firstName = "John", lastName = "Doe", age = 30 ,dateOfBirth = new DateOnly(1984 ,01, 01) };

            Person p11 = new Person("Jane", "Roe", 32, new DateOnly(1984, 05, 01));

            p11.Pets.Add(new Dog("dg1", "dog", 3));

            Console.WriteLine(p11);

            Person p12 = new("John", "Doe", 22, new DateOnly(1902, 01, 01));

            p12.Pets.Add(new Cat("ct1", "cat", 2));

            Person2 p21 = new Person2("Jane", "Roe", 32, new DateOnly(1984, 05, 01));

            p21.Pets.Add(new Cat("ct2", "cat", 5));

            Person2 p22 = new("John", "Doe", 22, new DateOnly(1902, 01, 01));

            p22.Pets.Add(new Dog("dg2", "dog", 2));

            Console.WriteLine(p22);
        }
    }

    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        private DateOnly dateOfBirth;

        public List<Pet> Pets;

        public Person(string firstName, string lastName, int age, DateOnly dateOfBirth)
        {
            //primary constructors ??? 
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
            this.Pets = new();
        }

        //to print a person using Console.WriteLine()
        //Object class
        public override string ToString()
        {
            var displayPerson = $"Person: \n Firstname : {this.firstName} \n Lastname : {this.lastName} \n Age : {this.age} \n Pets: ";
            foreach (Pet pet in this.Pets)
            {
                displayPerson += $" Type : {pet.GetType().Name}" + pet.ToString() + "\n";
            }
            return displayPerson;
        }
    }

    //fields vs properties ??? 

    public class Person2(string firstName, string lastName, int age, DateOnly dateOfBirth)
    {
        //{ get; } means only get on those propeties is allowed set is not allowed
        //{ get; set; } means both get and set are allowed
        public string FirstName { get; } = firstName;

        public string LastName { get; } = lastName;

        public int Age { get; } = age;

        public DateOnly DateOfBirth { get; } = dateOfBirth;

        public List<Pet> Pets { get; } = new();

        public override string ToString()
        {
            var displayPerson = $"Person: \n Firstname : {FirstName} \n Lastname : {LastName} \n Age : {Age} \n Pets: ";
            foreach (Pet pet in this.Pets)
            {
                displayPerson += $" Type : {pet.GetType().Name}" + pet.ToString() + "\n";
            }
            return displayPerson;
        }
    }

    public abstract class Pet(string firstName, string lastName, int age)
    {
        public string FirstName { get; } = firstName;

        public string LastName { get; } = lastName;

        public int Age { get; } = age;

        public abstract string SignatureSound();

        public override string ToString()
        {
            return $"\n\t Firstname : {FirstName} \n\t Lastname : {LastName} \n\t Age : {Age} \n\t";
        }
    }

    //Inheritance
    public class Cat(string firstName, string lastName, int age) : Pet(firstName, lastName, age)
    {
        public override string SignatureSound()
        {
            return "Meow";
        }
    }

    public class Dog(string firstName, string lastName, int age) : Pet(firstName, lastName, age)
    {
        //expression bodied functions
        public override string SignatureSound() => "Bark";
    }
}

