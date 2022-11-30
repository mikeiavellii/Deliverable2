using System;

namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCoffee = 0;
            int numWater = 0;
            string drinkOrder = string.Empty;

            Console.WriteLine("Hi there, I'm Jennifer. Welcome to All You Can Eat Buffet #3, don't ask about the other two. \n\nHaha haha haha, oh I'll never financially recover from that. \n\nMoving on, we have all you can eat for only $9.99! We only charge extra for drinks. \nCurrently, we only have enough space to accomodate parties of six or less. \n\nHow many people are in your party?");
            int partySize = int.Parse(Console.ReadLine());

            if (partySize <= 6)
            {
                Console.WriteLine("Fantastic, table for " + partySize + ". Follow me right this way. Watch your step, your table will be right over here. \n\nHuh? What was that, oh the bathroom. Right down the hallway to your left if you reach the sign that says \nNA Anonyomus meetings you've gone too far. David will be with you shortly to take your order.");
                Console.WriteLine("\nHi, my name is David. Can I start you off with something to drink?\nPop.\nOh, no pop. Due to a bad batch of syrup that turned out to be explosive, the subsequent lawsuit that resulted in the \nclosure of Buffet #2, and the death of all of the owner's family besides the hostess and owner, we are legally \nnot allowed to serve any carbonated beverages or live inside of the resturant. \nWith that in mind your choices of drink is limited to water and coffee.\n");
                for (int i = 1; i <= partySize; i++)
                {
                    Console.WriteLine("What would you like guest number " + i + "? Coffee or water?\n");
                    drinkOrder = Console.ReadLine();
                    if (drinkOrder.ToLower().Trim() == "water")
                    {
                        numWater++;
                        Console.WriteLine("\nGood choice, this water is so yummy and definitely doesn't contain any nuerotoxins or damaging nerve agents anymore.;)");
                    }
                    else if (drinkOrder.ToLower().Trim() == "coffee")
                    {
                        numCoffee++;
                        Console.WriteLine("\nGood choice, I ensure this coffee won't explode.");
                    }
                    else
                    {
                        Console.WriteLine($"We do not serve {drinkOrder} here, no drink for you. \nPlease hold out your fingers, Jason will be with over his cleaver to collect them shortly. He will teach you to listen.");
                    }
                }
                double buffetTotal = (partySize * 9.99);
                double coffeeTotal = (numCoffee * 2);
                double totalBill = (coffeeTotal + buffetTotal);

                Console.WriteLine($"Alright, so that's {numCoffee} coffee and {numWater} water. Feel free to grab your food.\nPay no attention to the man punching the salad bar. That's Joe, he does that every Friday for 3.2785 hours. \nHe should be done in about 6 minutes and 43 seconds. He's usually harmless as long as you don't take any items \nhe's thinking about.\n\n");
                Console.WriteLine("How was everything? I see someone grabbed something Joe was thinking about. Oooh and you're missing an eye now. Sorry \nabout him, he's such a scamp. I wish Jennifer would stop bringing Joe here, especially with those sharp claws of his.\nNo, you're right. That is completely unacceptable. Given what happened I won't charge you our usual \nmanadatory 800% gratuity fee. Even if that means I won't have enough to get my daughter back from those loan sharks now.\nNo you're right, your eye is more important. I'll just sell one my kidneys to make ends meat. That's the reason we \nhave three of them after all.\n\nAnyways, here's your bill! Total price: $" + totalBill + ".");

                //tabulation time
                Console.WriteLine(partySize + " buffets = " + partySize + " x 9.99 = $" + buffetTotal);
                Console.WriteLine(numCoffee + " coffees = " + numCoffee + " x 2.00 = $" + coffeeTotal);
                Console.WriteLine(numWater + " waters = free");
                Console.WriteLine("total = $" + totalBill);
                Console.WriteLine("\nIf everything is in order, please sign at the bottom, here is the pen. Alright perfect, thank you for that.\nThis is your copy, please hold onto that. By signing this you agree to legally agreed not to hold us liable for \nany injuries that may have occurred during your current or any future visits resulting from \ngross negligence on our parts. Have a good day.");
            }
            else
            {
                Console.WriteLine("I see someone doesn't listen. As I said before, we do not seat any parties over six. \nPlease vacate the premises, before I have the hounds I adopted as tax writeoff to keep this place afloat chase you out.\nWe haven't been able to afford to feed them in weeks and I'm sure they need the nutrients that come with eating you.\nYou have til the count of one to get out of here.\n10\n9\n8\n1 \n\nRUN! Mu-wa-hahaha-ha. Yes run for your lives.\n\nAnything they don't eat will be ground up and added to our famous Monday Mystery Meatloaf that's served on Tuesdays.\nOops. Looks as though you've fallen into our trapdoor containing the hounds. Did I forget to mention that's there? \nOh well. See you on Tuesday. Bye.");
            }
        }
    }
}
