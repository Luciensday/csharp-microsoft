﻿/*
The following code reverse the str. in additional, it calculates how many time charactor 'o' appears in the sentence
*/


string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
     if (letter == 'o') 
     {
         letterCount++; 
     } 
}

string newMessage = new String(message);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");


// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

/*
string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
*/


// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");

// string[] OrderId = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"}; 

// foreach ( string item in OrderId ){
//     if ( item.StartsWith("B")){
//         Console.WriteLine(item); 
//     }
// }
// // string[] names = { "Rowena", "Robin", "Bao" };
// // foreach (string name in names)
// // {
// //     Console.WriteLine(name);
// // }

// int sum = 0; 
// int bin = 0;
// int[] inventory = { 200, 450, 700, 175, 250 };

// foreach (int items in inventory){
//     sum += items; 
//     bin++; 
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");


// }; 
// Console.WriteLine($"We have {sum} items in inventory.");


// // string[] fraudulentOrderIDs = new string[3];
// // // 3 mean there are three elements in this array

// // fraudulentOrderIDs[0] = "A123";
// // fraudulentOrderIDs[1] = "B456";
// // fraudulentOrderIDs[2] = "C789";
// // // fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


// // ----completed if else statement

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// // Your code goes here



// if (daysUntilExpiration <= 10)
// {
//     if (daysUntilExpiration <= 5 ){
//         if (daysUntilExpiration == 0 ){
//         Console.WriteLine("Your subscription has expired."); } 
//         else if ( daysUntilExpiration == 1 )
//         { 
//         discountPercentage = 20; 
//         Console.WriteLine($"Your subscription expires in a day. " + $"Renew now and save {discountPercentage}%!") ;
//         } else {
//          discountPercentage = 10; 
//         Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days" + ". " + $"Renew now and save {discountPercentage}%!") ;
//     }
//     }
//     else {
//         Console.WriteLine("Your subscription will expire soon. Renew now!"); 
//     }
// } 


// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     } else{
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//         }
//          Console.WriteLine($"Your total including the bonus: {total}");
// }




// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }
