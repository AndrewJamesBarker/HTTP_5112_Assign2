using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_Assign2.Controllers
{
    public class CalorieCounterController : ApiController
    {
       /// <summary>
         /// takes four meal components (burger choice, drink choice, side choice, dessert choice) from the user numerical entry 1-4,
         /// each of which has four different calorie counts, and calculates the total calorie count. 
         /// </summary>
         /// <param name="burger">burger choice. Four options, 1 - Cheeseburger (461 Calories) 2 - Fish Burger(431 Calories)
         ///  3- Veggie Burger(420 Calories) 4- No burger (0 Calories) </param>
         /// <param name="drink">drink choice. Four options, 1 - Soft Drink (130 Calories) 2 - Orange Juice(160 Calories)
         ///  3 - Milk(118 Calories) 4 - No drink (0 Calories)</param>
         /// <param name="side">side choice. Four options, 1 - Fries (100 Calories) 2 - Baked Potato(57 Calories)
         ///  3 - Chef Salad(70 Calories) 4 - No side order (0 Calories)</param>
         /// <param name="dessert">dessert choice. Four options, 1 - Apple Pie (167 Calories) 2 - Sundae(266 Calories)
         ///  3 - Fruit Cup(75 Calories) 4 - No Dessert (0 Calories)</param>
         /// <returns>a string stating the total calorie count</returns>
         /// <example>localhost:57330/api/caloriecounter/menu/1/2/4/3 returns: Your total calorie count is 696</example>
            [HttpGet]
            [Route("api/Calories/menu/{burger}/{drink}/{side}/{dessert}")]
            public string Menu(int burger, int drink, int side, int dessert)
            {
                int burgerCalories = 0;
                int drinkCalories = 0;
                int sideCalories = 0;
                int dessertCalories = 0;
                string message = "Your total calorie count is ";



                for (int i = burger; burger <= 3; burger++)
                    if (i == 1)
                    {
                        burgerCalories = 461;
                    }
                    else if (i == 2)
                    {
                        burgerCalories = 431;
                    }
                    else if (i == 3)
                    {
                        burgerCalories = 420;
                    }
                    else
                    {
                        burgerCalories = 0;
                    }


                for (int i = drink; drink <= 3; drink++)
                    if (i == 1)
                    {
                        drinkCalories = 130;
                    }
                    else if (i == 2)
                    {
                        drinkCalories = 160;
                    }
                    else if (i == 3)
                    {
                        drinkCalories = 118;
                    }
                    else
                    {
                        drinkCalories = 0;
                    }

                for (int i = side; side <= 3; side++)
                    if (i == 1)
                    {
                        sideCalories = 100;
                    }
                    else if (i == 2)
                    {
                        sideCalories = 57;
                    }
                    else if (i == 3)
                    {
                        sideCalories = 70;
                    }
                    else
                    {
                        sideCalories = 0;
                    }

                for (int i = dessert; dessert <= 3; dessert++)
                    if (i == 1)
                    {
                        dessertCalories = 167;
                    }
                    else if (i == 2)
                    {
                        dessertCalories = 266;
                    }
                    else if (i == 3)
                    {
                        dessertCalories = 75;
                    }
                    else
                    {
                        dessertCalories = 0;
                    }


                int totalCal = (burgerCalories + drinkCalories + sideCalories + dessertCalories);
                return message + totalCal;
            }

        
    }
}
