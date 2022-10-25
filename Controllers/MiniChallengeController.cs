using Microsoft.AspNetCore.Mvc;

namespace MannAMiniCh_1.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCHallengeController : ControllerBase
{
  [HttpGet]
  [Route("SayHello")]

  public string SayHello() {
    return "Good day to you friend!";
  }

  [HttpGet]
  [Route("AddNumbers")]

  public string AddNumbers() {
    int num1 = 5;
    int num2 = 10;
    return $"{num1} plus {num2} equals {num1 + num2}";
  }

  [HttpGet]
  [Route("AskQuestions")]

  public string AskQuestions() {
    string name = "Jeff";
    string wakeTime = "10am";
    return $"Hello {name}! You woke up at {wakeTime} today? Wild";
  }

  [HttpGet]
  [Route("GreaterThan")]

  public string GreaterThan() {
    int num1 = 5;
    int num2 = 10;
    string relation;
    if (num1 > num2) {
      relation = "is greater than";
    } else if(num2 > num1) {
      relation = "is less than";
    } else {
      relation = "is equal to";
    }
    return $"{num1} {relation} {num2}";
  }

  [HttpGet]
  [Route("MadLib")]

  public string MadLib()
  {
    string[] words = new string[10];
    words[0] = "Jimmy G";
    words[1] = "dreadful";
    words[2] = "lint licker";
    words[3] = "The Partridge Family";
    words[4] = "stupid";
    words[5] = "deceptively handsome";
    words[6] = "power of love";
    words[7] = "mushrooms";
    words[8] = "warm and fuzzy";
    words[9] = "coming to his surprise birthday party";
    return $"Did you ever hear the tragedy of Darth {words[0]} the {words[1]}?  I thought not. It\'s not a story a {words[2]} would tell you. Its a {words[3]} legend. Darth {words[0]} was a Dark Lord of {words[3]}, so {words[4]} and so {words[5]} he could use the {words[6]} to influence midichlorians to create {words[7]}. He had such a knowledge of the {words[8]} side of The Force that he could even keep the ones he cared about from {words[9]}.";
  }

  [HttpGet]
  [Route("OddOrEven")]

  public string OddOrEven() {
    int num = 10;
    string type;
    if (num % 2 == 0) {
      type = "even";
    } else {
      type = "odd";
    }
    return $"{num} is an {type} number.";
  }

  [HttpGet]
  [Route("ReverseIt")]

  public string ReverseIt() {
    string words = "This is forward.";
    char[] array = words.ToCharArray();
    Array.Reverse(array);
    return new String(array);
  }

  [HttpGet]
  [Route("Magic8Ball")]

  public string Magic8Ball() {
    string[] eightBallArray = new string[] {"Indubitably my dear Watson", "Maybe when hell freezes over", "My sources say no, but they also said Hillary would win so...", "Uhhh.. Trust me you don't want to know", "DON'T BET THE FARM ON IT!", "Pop champagne, do the Dougie, eat some cake. It's a sure thing", "Yes. YES. A thousand times YES!", "Bruh. You know. You've always known.", "Search your feelings, you know it to be true", "I looked forward in time and saw 14,000,605 possible futures. It's true in exactly one of them", "*Astronaut meme intensifies* Always"};
    Random randNum = new Random();
    int randIndex = randNum.Next(1,4);
    return $"Magic 8-Ball says:\n{eightBallArray[randIndex]}";
  }

  [HttpGet]
  [Route("RestaurantPicker")]

  public string RestaurantPicker() {
    string[] mexPlaces = {"Taco Bell", "Chipotle", "Tacos Chapala", "Flakkos Tacos", "Jimboy's Tacos", "Tepa Taqueria", "El Senor Frogs", "Tacos La Palmita", "Taqueria El Grullense", "Casa Flores"};
    string[] fastPlaces = {"McDonalds", "Taco Bell", "Burger King", "Carl's Jr", "Wendy's", "Papa John's", "Pizza Hut", "Jack in the Box", "In-n-Out", "Raising Cane's"};
    string[] asianPlaces = {"Panda Express", "Pho Island", "Spice It Up!", "Jimmies Place", "Maroo Korean BBQ", "Thai Me Up", "Green Papaya", "ShoMi", "Komachi Sushi", "Jitaro Japanese Food Truck"};
    Random randNum = new Random();
    int userNumInt = randNum.Next(1,4);
    string[] userPlaces = {};
    if (userNumInt == 1) {
      userPlaces = mexPlaces;
    } else if (userNumInt == 2) {
      userPlaces = fastPlaces;
    } else if (userNumInt == 3) {
      userPlaces = asianPlaces;
    }
    return $"You should try {userPlaces[randNum.Next(0, userPlaces.Length)]}!";
  }
}
