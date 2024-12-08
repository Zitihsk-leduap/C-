using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {


                 
//             Console.WriteLine("Hello, OOP!");

//             // Object Oriented Programming
//             // OOP is all about creating objects that contains both data and methods
//             // Its concept is all about DRY:Dont't Repeat Yourself.

//             // Contains class and objects
//             //  class is a template for object and an object is an instance of a class
//             // When the individual objects are created, they inherit all the variables and methods from the class.
            

//             Car myCar=new Car();
//             Car myAnotherCar= new Car();
            
//             Console.WriteLine(myCar.color);
//             Console.WriteLine(myAnotherCar.mk);

//         }
//     }

// public class Car
// {
// public string color="red";
// public string mk="set";



// Public and static:
      // a static method can be accessed witout creating an object of the class
      // public methods can only be accessed by objects.



      // C# Constructors
        // A constructor is a special method that is used to intialize objects.
        // The advantage of a constructor is that it is called when an object of a class is created.
        // It can be used to set initial values for fields.
        // Note that the constructor name must match the class name, and it cannot have a return type (like void or int).


            // Create an instance of MyClass
            MyClass myC = new MyClass("Ford",23333.22);

            try
            {
                // Use the public method to get the name
                string name = myC.GetName();
                Console.WriteLine("The name is: " + name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The parameter is private and cannot be accessed from here: " + ex.Message);
            }

            // Call the func() method
            myC.Func();
            // Console.WriteLine(myC.model);
            Console.WriteLine("The name of the car is :"+myC.model +"and the price of the model is:"+myC.price);
       
       
    //  Calling the MyNewClass  class;
    MyNewClass myNewClass=new MyNewClass();
    myNewClass.PublicMethod();  
       
        }
    }

    public class MyClass
    {
        // Private fields
        private string name = "zitihsk";
        private int maxSpeed = 200;
        public string model;
        public double price;

        // Public method to get the value of the private 'name' field
        public string GetName()
        {
            return name;
        }

        // Public method to display a message
        public void Func()
        {
            Console.WriteLine("The car is going as fast as it can at the moment.");
        }

        public MyClass(string modelName,double Price){
          model=modelName; 
          price=Price ;// Constructor and it can take parameter as well.Constructors can be overloaded by using different number of parameters.



            //  Access Modifier
            // Example:public string name;

            // public: The code is accessible for all classes.
            // private:The code is accessible only within the same class.

            // protected:The code is accessible within the same class or the class that is inherited from that class.

            // internal:The code is only accessible within its own assembly,but not from another assemb


 
            // Properties and Encapsulation;
            // Encapsulation: // To make sure that the sensitive data is hidden from the users.
            // How??:

                        // 1.declare fields/variables as private
                        // 2.provide public Get and set methods,through properties,to access and update the values of the private field.



                        // Properties:
                        // We have learned that the private variables can only be accessed within the same class,
                        // However ,sometimes we have to access them, and it can be done with properties.

                        // IT has two methods:
                        // GetandSet

                    // examplegivenbelow

                    Person myPerson= new Person();
                    myPerson.Name="Zitihsk";
                    Console.WriteLine(myPerson.Name);



                    // Inheritance:
                        // keyword:DerivedClass,ParentClass;
// To inherit from other class,use the (:) symbol;
        // ExampleGivenBelow;
        Car myCar=new Car();
        myCar.honk();
        Console.WriteLine($"The brand is {myCar.brand} and the modelName is {myCar.modelName}");
                        
    //  if you don't want other classes inherit from a class,use the sealed keyword.
                        
             
            //  C# Polymorphism
            // This means many forms and it occurs when we have many classes that are related to each other by inheritance.

            // The base class method overwrites the derived class methods,when they share the same name.

           Animal myDog =new Dog();
           Animal myCat =new Cat();

           myDog.SoundOfAnimal();
           myCat.SoundOfAnimal();


        //    Hence in order to make the derived class inherit its own feature rather than the base class method,we can use the keyword (virtual) while declaring the base class and (override ) for the derived class functions.

        // Abstract classes and methods
        // Data abstraction is the process of hiding certain details and showing only essential information to the user.
          
        //   Abstract Class: is a restricted class that cannot be used to create objects(to access it ,it must be inherited from another class)
        // Abstract Method:can only be used in an abstract class and it does not have a body.The body is provided by the derived class(inherited from).
       
       Zone myZone= new Zone();
       myZone.districtName(); // call the abstract method
       myZone.capital();


    //    Interfaces;
    // An interface is a completely "abstract class",whcih can only contain abstract methods and properties(with empty bodies)

    // egGivenBelow


    // enum
    // An enum is a special "class" that represents a group of constants(unchangeable/read-only variables)
       
       Level myVar=Level.Medium;
       Console.WriteLine(myVar);


    //    By default ,the first item of an enum has the value 0.The second has the value 1, and so on.


//     enum Months
//     {
       

//   January,    // 0
//   February,   // 1
//   March,      // 2
//   April,      // 3
//   May,        // 4
//   June,       // 5
//   July        // 6


//     }

//     int myNum=(int) Months.April;
      
       
       
       
        }
    }







    public class MyNewClass
    {
        private void PrivateMethod(){
            Console.WriteLine("This is a private method and this can only be used by this class but not other.");

        }

        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.It can be used by any other classes inside this namespace");
            Console.WriteLine("Calling the PrivateMethod from this class to see it it works or not.");
            PrivateMethod();
        }
    }




    class Person{
        private string name;

        public string Name  //Property
        {
            get{return name;}  //when you call myPerson.Name,the get block executes,returning the value of name;

            set{name=value;} 

                // fields can only be read-only if you use the get method and only write-only if you use the set method.
        }
    }




class Vehicle  //Base class;
{
    public string brand="Ferrari";
    public void honk()
    {
        Console.WriteLine("Get out of the way ...");
    }
}



class Car: Vehicle  //Parent Class
{

public string modelName="G_Wagon";
}
}



class Animal
{
    public  virtual void SoundOfAnimal(){
        Console.WriteLine("The animal says bhau bhau");
    }
}


class Dog:Animal
{
    public  override void SoundOfAnimal(){
        Console.WriteLine("The dog bark apparently");
    }
}

class Cat:Animal
{
    public void SoundOfAnimal(){
        Console.WriteLine("The cat says meow meow");
    }
}


abstract class Nepal
{
    public abstract void districtName();
    public void capital(){
        Console.WriteLine("Kathmandu");
    }
}

class Zone:Nepal
{
    public override void districtName()
    {
        Console.WriteLine("The capital is in Nepal");
    }
}



interface Student
{

    // By default, members of an interface are abstract and public.
    void id();
    void name();
    // To access them,it is to be used as the above Nepal and Zonal classes.
}



 enum Level
       {
        Low,
        Medium,
        High
       }
       
