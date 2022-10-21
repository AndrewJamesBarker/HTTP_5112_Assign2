using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_Assign2.Controllers
{
    public class ColdCompressController : ApiController
    {/// <summary>
     /// supposed to output each individual character of a user inputed string along with the number of times it occurs consecutively.
     /// </summary>
     /// <param name="charInput">user input string</param>
     /// <returns>should return the number of occurance followed by the character</returns>
     ///<example>api/coldcompress/charcompresser/Hello => should return 1H 1e 2l 1o</example>
     ///I had so many problems with this. I tried so many different permutations
     ///of nested loops and for loops and foreach loops (in a code pen) that i lost all touch, this got worse and worse, 
     ///and i got further and further away from solving! After giving up and returning to my visual studio code (from the microsoft pen)
     ///the if/else
     ///condition occured to me, so i could log chars that didnt repeat. That made things look a bit better.
     ///I think my main troubles are despite putting - 1 after my charInput.Length, my 'if i == i + 1' still pops out of bounds
     ///hence my i < charInput rather than the appropriate <= charInput condidtion (so i always miss my last character). I dont think my
     ///comparison operator trying to find matches in the index is working at all.
     ///another problem is that it counts reoccuring chars ie: Hello comes out 1H1e2l2l.
     /// it also counts things incorrectly...cant tell why. I think maybe its just giving me index numbers and not adding to my count at all.
     /// or maybe i need to reset my count for each char iteration. i dont know how.
        [HttpGet]
        [Route("api/coldcompress/charcompresser/{charinput}")]
        public string CharCompresser(string charInput)
        {
            
            string output = "";
            int count = 1;

            for (int i = 0; i < charInput.Length - 1; i++)
            {

                if (charInput[i] == charInput[i + 1])

                {
                    count++;
                    output = output + count + charInput[i];

                }
                else
                {

                    output = output + count + charInput[i];
                }


            }
            return output;
        }

        //foreach (var c in charInput)
        //{ 
        //      output = output + c;
        //}


        //foreach(char c in charInput)
        //{

        //    if (c == c + 1)

        //    {
        //        count++;
        //        output = output + count + charInput[c];

        //    }
        //    else
        //    {

        //        output = output + count + charInput[c];
        //    }


        //}
        //return output;




    }
}
