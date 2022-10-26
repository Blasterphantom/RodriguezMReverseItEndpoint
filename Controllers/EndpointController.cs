//Marcel Rodriguez
//10-26-22
//Reverse It Endpoint
//This controller will use the user's input from the url and output it backwards
//Peer review - Isaiah Ferguson - A very Thorough code! program works as intended he used a different formula in the for loop thatn i did and that was really cool! Excellent job!
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("reverse/{wordInput}")]

    public string ReverseIt(string wordInput)
    {
        Console.Clear();

        string end = "yes";
        string inputOne = "";
        string inputReverse = "";
        string numberChoice = "";
        string wordReverse = "";
        string inputReverseCheck = "";
        long validForReal = 0;

        while(end == "yes" || end == "YES" || end == "Yes")
        {

            bool isContainer = true;
            bool issaNumber;
            
            
            while(isContainer == true)
            {
                Console.WriteLine("Please enter a number and i will reverse it");
                inputOne = "347";
                issaNumber = Int64.TryParse(inputOne, out validForReal);

                inputReverse = string.Empty;

                if(issaNumber == true)
                {
                    for(int i = inputOne.Length - 1; i>=0; i--)
                    {
                        inputReverse += inputOne[i];
                    }
                    Console.WriteLine(inputReverse);
                    inputReverseCheck = inputReverse;
                    isContainer = false;
                    
                    long daNumber = 0;
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("Aw you don't beleive it's an int? give me another number: ");


                    bool containerAdd = false;
                    bool isNumberCheck;
                    while(containerAdd == false)
                    {
                        numberChoice = "42";
                        isNumberCheck = Int64.TryParse(numberChoice, out daNumber);

                        if (isNumberCheck == true)
                        {
                            containerAdd = true;
                        }
                        else
                        {
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("That is not a number >_>");
                            Console.WriteLine("_________________________________");
                            Console.WriteLine("Please give me another number: ");
                        }
                    }
                    long sum = validForReal + daNumber;
                    Console.WriteLine("The sum of " +validForReal+ " and " +daNumber+ " equals " +sum);
                    Console.WriteLine("BOOM, m a t h");
                    Console.WriteLine("_________________________________");

                }
                else
                {
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("That is not a number >_>");
                    Console.WriteLine("_________________________________");
                }
            }

            
            bool isContainer2 = true;
            bool issaNumber2;
            long validForReal2 = 0;

            while(isContainer2 == true)
            {
                Console.WriteLine("Please enter a string and i will reverse it");

                wordReverse = string.Empty;

                for(int j = wordInput.Length - 1; j>=0; j--)
                {
                    wordReverse += wordInput[j];
                }
                Console.WriteLine(wordReverse);
                isContainer2 = false;
                Console.WriteLine("_________________________________");
                Console.WriteLine("yeah that's pretty much a string lol");

            }

            Console.WriteLine("Do you want to play again? yes/no");
            end = "no";
            Console.WriteLine("_________________________________");

        }
        return wordReverse;
    }
}
