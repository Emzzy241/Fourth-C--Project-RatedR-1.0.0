using System;

class RatedR
{
    // in the code below: we add the necessary boilerplate code, including Systme; a RatedR class with a set of curly braces that match our file name and a Main() method
    // Within the Main() method; we add 3 lines of code
    static void Main(){
        Console.WriteLine("How old are you?"); // this prints a message: how old are you tothe console
        string userAgeInString = Console.ReadLine(); //te method: Console.ReadLine() retrieves user input then saves the user input in a string variable
        // Don't forget Console.ReadLine() method can only read a line as a string, hence we need to store the value inside a string a variable
        
        int userAgeInInteger = int.Parse(userAgeInString); // this line converts the Age with datatype string we got from our user into an Age with datatype Integer

        // having done all of this, we can use Branching to return a message based on whether the user is at least 17 years old

        if(userAgeInInteger >= 17){ // we use the relational operator(>=) to check if userAgeInInteger is greater than or equal to 17
            Console.WriteLine("Yay!!! You can see the movie"); // then we use branching to print message that lets userknow if they can see the movie
        }
        else{
            Console.WriteLine("I'm Sorry but you are not allowed to See the movie");
        }

        // Having done all of that, we can compile and launch the Program with the "dotnet run" command
        // don't forget that we can save ourself the stress of having to run dotnet over and over again by just doing 
        // a dotnet watch run which will run our application again by itself after our Application has just been executed
        

    }
}