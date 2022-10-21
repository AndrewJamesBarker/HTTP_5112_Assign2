using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_Assign2.Controllers
{
    public class DiceSideCounterController : ApiController
    {
         /// <summary>
         /// Counts how many possible ways the sum of ten can be rolled dependant on user input of the die's sidecount.
         /// included an edgecase if only one die is rolled and it's a ten (say the other die fell off the table into a black hole).
         /// Adjusted return message for correct grammar depending on if return count was singular or plural.
         /// </summary>
         /// <param name="sideOne">user input how many sides die one</param>
         /// <param name="sideTwo">user nput how many sides die two</param>
         /// <returns>
         /// Count of how many possible times the sum can equal 10.
         /// </returns>
         /// <example>
         /// api/DiceSideCounter/TenCount/5/5 => "There is 1 possible way to roll a ten."
         /// </example>
            [HttpGet]
            [Route("api/DiceSideCounter/TenCount/{sideOne}/{sideTwo}")]
            public string TenCount(int sideOne, int sideTwo)
            {

                int sumTen = 0;
                if (sideOne == 10 && sideTwo == 0 || sideTwo == 10 && sideOne == 0)
                {
                    return "There is 1 possible way to roll a ten.";
                }
                else
                {
                    for (int i = 1; i <= sideOne; i++)
                    {
                        for (int j = 1; j <= sideTwo; j++)
                            if (i + j == 10)
                            {
                                sumTen++;
                            }
                    }
                    if (sumTen > 1 || sumTen == 0)
                    {
                        return "There are " + sumTen + " possible ways to roll a ten.";
                    }
                    else
                    {
                        return "There is " + sumTen + " possible way to roll a ten.";
                    }
                }
            }
        }
    
}
