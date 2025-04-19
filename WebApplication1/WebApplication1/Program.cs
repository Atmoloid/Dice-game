using System;

namespace dice_game{


  class Program
  {
    static void Main(string[] args){
       int playerRandomNum;
       int enemyrandomNum;

       int playerPoints = 0;
       int enemyPoints = 0;

       Random random = new Random();

       for(int i = 0; i < 10; i++){
       Console.WriteLine("Press any key to roll the dice");
       
       Console.ReadKey();
       playerRandomNum = random.Next(1,7);
       Console.WriteLine("You rolled a " + playerRandomNum);

       Console.WriteLine("...");
       Thread.Sleep(1000);

       enemyrandomNum = random.Next(1,7);
       Console.WriteLine("Enemy rolled a " + enemyrandomNum);

       if(playerRandomNum > enemyrandomNum){
             playerPoints++;
             Console.WriteLine("Player wins this round");
       }
       else if(enemyrandomNum > playerRandomNum){
        enemyPoints++;
        Console.WriteLine("Enemy wins this round");
        }
        else{
          Console.WriteLine("Draw");  
         }
         Console.WriteLine("Player score: " + playerPoints + " Enemy score: " + enemyPoints + ".");
         Console.WriteLine();
       }
       if(playerPoints > enemyPoints){ 
         Console.WriteLine("Player wins the game");
       }
       else if(enemyPoints > playerPoints){ 
        Console.WriteLine("Enemy won the game");
       }
       else{
        Console.WriteLine("Draw");
       }
       Console.ReadKey();
    }
  }
    
};