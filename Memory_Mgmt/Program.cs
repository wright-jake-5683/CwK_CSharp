using System;

class Program
{

    static void ChangeMessage(string messageCopy)
    {
        Console.WriteLine(messageCopy);
        //messageCopy is a copy of the reference to the data of "message" stored in the heap. To start both message and messageCopy are referencing the same data in the same memory location
        messageCopy = "Hello, I am a copy of the Main frame's message reference, but now I am being dereferenced in the ChangeMessage function's stack frame";
        //when assigning a new value to messageCopy, we are "dereferencing" the reference to the data it was originally pointing at and creating new data in the heap for messageCopy to reference
        Console.WriteLine(messageCopy);
        //Once messsageCopy is displayed, ChangeMessage ends and is popped off the stack frame along with messageCopy and both are destroyed in memory
    }

    static void ChangeMessageByRef(ref string messageRef)
    {
        messageRef = "Hello, I am the same message reference as in Main, I am overwritting the data referenced whlie in the ChangeMessage function's stack frame";
        Console.WriteLine(messageRef);
    }

    static void ChangeNumber(int numberCopy)
    {
        //A copy of the value type number was passed to function parameter numberCopy. Both have the same value but exist separately of each other
        numberCopy = 10;
        //here the variable numberCopy is changed to value of 10. This updates the value of numberCopy without altering number back in main
        Console.WriteLine(numberCopy);
        //Once numberCopy is displayed, ChangeNumber function is popped off stack frame and both the function and all data inside the function are destroyed in memory
    }

    static void Main(string[] args)
    {
        /*
        int number = 5;
        Console.WriteLine(number);
        ChangeNumber(number);
        Console.WriteLine(number);
        */

        /*
        string message = "Hello, I am a reference variable currently in the Main function's stack frame referencing this data";
        Console.WriteLine(message);
        ChangeMessage(message);
        Console.WriteLine(message);
        */

        
        string message = "Hello, I am a reference variable currently in the Main function's stack frame referencing this data";
        Console.WriteLine(message);
        ChangeMessageByRef(ref message);
        Console.WriteLine(message);
        
    }
}