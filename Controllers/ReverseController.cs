//Name: Ulises Ortega
//Date: 10.25.22
//Project: Reverse It
//Description: This EndPoint thakes the user input from the URL and out the original string and the reverse string on screen through postman.
//Peer Review: Jessie Lamzon
//Code works and returns reversed value of any input.  I really like the clean code provided.  Very nice!

/*Description: In this Endpoint the user will enter more than 2 characters or more than 2 numbers in order to see the reverse hapening.
//The link below represent the structure to be follow in order for this Endpoint to work
https://localhost:7181/reverse/it/Numbers or Text
When you Run and Debug this Endpoint in your computer the local hos will change, please replace numbers or text with your own numbers or text
Your Output should be: the original input and the reverese input ad bellow

The original was 123 
the Reverse is 321
*/
using Microsoft.AspNetCore.Mvc;
namespace OrtegaUReverse_It___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]

public class ReverseController : ControllerBase
{
    [HttpGet]
    [Route("It/{reverseIt}")]

    public string Reverse(string reverseIt)
    {
        char[] cArray = reverseIt.ToCharArray();
        string rev1 = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            rev1 += cArray[i];
        }
        return $"The original was {reverseIt} \nthe Reverse is {rev1}";
    }


}
