﻿// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;



class NameReturn{
  public void Name(string fname, string lname, int age){
    string nameOfthePerson=$"The person is{fname} {lname} and his age is{age}";
    Console.WriteLine(nameOfthePerson);
  }

}


class MathUtils{
  public static int Add(int a,int b){
    return a+b;
  }
}

class Program
{

  static int PlusMethod(int x, int y){
    return x+y;
  }


   public  void MyAnotherMethod(string name){
          Console.WriteLine("My name is :"+name);
          
        }


    static void func(string fname, int age=23){
      Console.WriteLine(fname +" is"+age);  
    }
  static void Main(string[] args)
  {


//      Output
//     int a =1;
//     Console.WriteLine(a);
//     Console.WriteLine("I am learning C#");
//     Console.Write("I am not learning C#");
//     Console.WriteLine("I am learning C#")
//     ;

//     // The main difference between write and writeline is that Write() doesnot insert a new line at the end of the output.


//     // Variables



//     //  int,double,char,string,bool
    
//     #Syntax
//     Type variableName= Value;

//     string name="Kshitiz";
//     Console.WriteLine(name);

//     // Can do this as well;
//     int myNumber;
//     myNumber=10;
//     Console.WriteLine(myNumber);

//    The later value overwrites the previous value if redeclared/

//    int number=10;
//    double myDoublenumber=20.222;
//    char letter="D";
//    bool myBool=true;
//    string text="kshitiz";


//   Constants;
//   The value cannot be changed once it is initialized.


//  Display Variables
//  To combine both the text and a variable ,use the + character.

//  string name="Nepal";
//  Console.WriteLine("Hello" +name);


//  string firstName="John";
//  string lastName="Duran";
//  string fullName=firstName+lastName;
//  Console.WriteLine(fullName);



//     Identifiers
//     All the variables must be identified with unique names.These names are called identifiers.

// The general rules for naming variables are:

// Names can contain letters, digits and the underscore character (_)
// Names must begin with a letter or underscore
// Names should start with a lowercase letter, and cannot contain whitespace
// Names are case-sensitive ("myVar" and "myvar" are different variables)
// Reserved words (like C# keywords, such as int or double) cannot be used as names



//         // TypeCasting

//     Implicit Casting(automatically)-Converting a smaller type to a larger type size
//     char->int->ling->float->double

//  Explicit Casting (manually) - converting a larger type to a smaller size type
// double -> float -> long -> int -> char

//     int myInt=10;
//     double myDouble=myInt; //int to double(automatic)
    
//     Console.WriteLine(myInt);
//     Console.WriteLine(myDouble);


//     double myDouble=99.99;
//     int myInt=(int)myDouble;  //Manual Casting:double to int
//     Console.WriteLine(myDouble);
//     Console.WriteLine(myInt);



    
// int myInt = 10;
// double myDouble = 5.25;
// bool myBool = true;

// Console.WriteLine(Convert.ToString(myInt));    // convert int to string
// Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
// Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
// Console.WriteLine(Convert.ToString(myBool));   // convert bool to string



// //User Input
// Console.WriteLine("Enter the Username");
// string userName = Console.ReadLine();
// //The Console.ReadLine method returns a string.Therefore,we cannot use the same for other dtypes like int,bool,etc.

// Console.WriteLine("The Username is:"+userName);

   

//    For Integer dataTypes;
//    Console.WriteLine("Enter your age");
//    int age=Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Your age is:"+age);



//   Operators:

//   Math():
//   Console.WriteLine(Math.Max(5,10));
//   Min,Sqrt,etc


//   string.length gives the length of the string
//   string text="Hello world";
//   Console.WriteLine(text.ToUpper());


//   Concat() function concatenates the strings .This can be done by using the + opeator as well.

//     String Interpolation:
//     This is the another option of string concatenation, which substitues the values of the variable into 
//     placeholders in a string.


//     string firstName="Kshitiz";
//     string lastName="Paudel";
//     string name=$"My full name is: {firstName} {lastName}";
//     Console.WriteLine(name);



//     C# Access Strings
//     string myString="Hellofromtheotherside";
//     Console.WriteLine(myString[3]);

//     //Can also use indexOf() method for finding the specific character in a string;
//     Console.WriteLine(myString.IndexOf("s"));

//     int myAge=20;
//     int MarriageAge=25;

//     if(myAge>MarriageAge)
//     {
//       Console.WriteLine("Its time you get married");

//     }
//     else{
//       Console.WriteLine("You are not aged enough to get married");
//     }


//     Ternary Operator
//     This is also called short-hand if else because it consists of three operands.

//           Syntax
//         variable = (condition) ? expressionTrue : expressionFalse;

//           string result = (myAge>MarriageAge) ? "You should get married now" : "You have got ounces of time with you";
//           Console.WriteLine(result);



//           //Switch Statements

//           int day=10;

//           switch(day)
//           {
//             case 1:
//              Console.WriteLine("Sunday");
//              break;

//             case 2:
//               Console.WriteLine("Monday");
//               break;

//             case 5:
//               Console.WriteLine("Tuesday");
//               break;

//             case 10:
//               Console.WriteLine("Friday");
//               break;

//             case 20:
//               Console.WriteLine("Wednesday");
//               break;
//           }

            
//             // While Loop
//             int myAge=20;
//             int marraigeAge=30;

//             while(myAge<=marraigeAge){
//               if(myAge%2 ==0){
//                 int remainingAge=marraigeAge-myAge;

//                 Console.WriteLine("You are on year "+myAge+".You can get married on "+remainingAge+"years");

//               }
//               myAge+=1;


//             }


//               foreach Loop: This is used to loop through elements in an array

//                   Syntax:
//                   foreach (type variableName in arrayName) 
// {
//   // code block to be executed
// }

//     string[] cars ={"bmw","mercedes","ford","ferrari"};
//     foreach(string i in cars)
//     {
//       Console.WriteLine(i);
//     }

//     break and continue:
//       //  break is used to jump out of the loop and get out of the switch statements;
//       // continue statement breajs one iteration in a loop .


//         Arrays:
//         To declare the arrays , use the []  the variable type.
         
//          int[] num={1,2,3,4,5};
//          for(int i=0;i<5;i++){
//           Console.WriteLine(num[0]);
//          }


//     for(int i=0;i<cars.Length;i++){
//       Console.WriteLine(cars[i]);
//     }


//     for sorting you can use Arrays.Sort(variablename)


//         MultiDimensional Arrays
//         if you want to store data as a tabular form, like a table with rows and columns, you need to get familiar with multidimensional arrays

//       int[,] numbers={{1,2,3},{4,5,6}};  // 2-D array
//       Console.WriteLine(numbers[0,1]);

      
//       foreach(int i in numbers){
//         Console.WriteLine(i);
//       }

//       for(int i=0;i< numbers.GetLength(0);i++){

//         for(int j=0;j<numbers.GetLength(1);j++){
//           Console.WriteLine(numbers[i,j]);
//         }

//       }


        // Methods/Functions in C#;
         
         //like we have made a function main in the program class and the
        //  static parameter means the function belongs to the class itself not
        // the instances of the class Program.

        // better to use UpperCase for the method Name


        // for example:

       
  //       static void MyMethod(){
  //         Console.WriteLine("I am here and yes this is it.");

  //       }
  //       MyMethod();
  // }



        // Parameters and arguements in Methods
       
        // Program program= new Program();
        // program.MyAnotherMethod("KshitizPaudel");



    //  In c#,you cannot call a method directly in the class scope outside a method.
    // Method calls need to be placed inside a method or a constructor.
    // But if you want to avoid creating an instance ,you can modify the method as follows:
      
      
      // using System;

// class Program
// {
//     public static void MyAnotherMethod(string name)
//     {
//         Console.WriteLine("My name is: " + name);
//     }

//     static void Main(string[] args)
//     {
//         MyAnotherMethod("KshitizPaudel"); // Direct call to the static method
//     }
// }


  //   Multiple parameters;
  // func("Kshitiz",20);
  // func("VivianRichards",25);
  // func("GulshanJha");


  // Default Parameters:
  // We can use the default parameter value ,by using the equal sign(=) like we have done above for Gulshan Jha


  // static in functions and other parts:

//   In the Context of a Function:
// When you declare a method as static, it means:

// Belongs to the Class, Not an Instance:

// The method can be called without creating an instance of the class.
   
  // int result= MathUtils.Add(5,2);
  // Console.WriteLine(result);




  // Cannot Access Instance Members Directly:

// A static method cannot directly access non-static fields, methods, or properties of the class because it does not operate on an instance.



  // Return Values:done above

  // NameReturn namereturn=new NameReturn();
  // namereturn.Name("Zitihsk","Leduap",20);



  // if the static method needs to call non-static,then the instance of the class must be created to provoke them.
  


  // Method Overloading
  // With method overloading ,multiple methods can have the same name with different parameters.

  // example:

    //  int MyMethod(int x);
    //  float MyMethod(int x,float y);
    //  double MyMethod(double x, double y);

   int answer=PlusMethod(10,20);
   Console.WriteLine(answer)


  }
  
}

