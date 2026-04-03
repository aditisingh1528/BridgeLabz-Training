using System;

public class SnakeAndLadder{
    static Random random = new Random(); //random object to roll the dice

    static int[] board = new int[101];
	
    static void CreateBoard(){
        board[4] = 14;
        board[9] = 31;
        board[20] = 38;
        board[28] = 84;
        board[40] = 59;
        board[71] = 91; //ladders' starting and ending positions
		
        board[17] = 7;
        board[54] = 34;
        board[62] = 19;
        board[87] = 24;
        board[99] = 78; //snakes's starting and ending positions
    }
	
    static int RollDice(){
        return random.Next(1, 7); //method to roll dice
    }
	
    static int ApplySnakeOrLadder(int position, out string message){
        message = "";

        if (board[position] != 0){ //if position has a snake or ladder
            if (board[position] > position){ //checking if there is ladder or snake on current position
                message = "Ladder";
            }
            else{
                message = "Snake";
            }

            position = board[position];
        }

        return position;
    }

    static bool CheckWin(int position){
        if (position == 100){
            return true; //method to check winning condition
        }
        return false;
    }

    //Method to start game
    static void StartGame(){
        CreateBoard(); //method to start the game

        Console.Write("Enter number of players (2–4): ");
        int playerCount = Convert.ToInt32(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4){
            Console.WriteLine("Invalid number of players.");
            return;
        }

        string[] players = new string[playerCount]; //storing player names
        int[] positions = new int[playerCount]; //storing positions of players

        for (int i = 0; i < playerCount; i++){
            Console.Write("Enter player name: "); //taking player names
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        bool gameWon = false;

        while (!gameWon){
            for (int i = 0; i < playerCount; i++){
                Console.WriteLine($"\n{players[i]}'s turn. Press ENTER to roll dice.");
                Console.ReadLine();

                int dice = RollDice();
                int oldPosition = positions[i];

                Console.WriteLine("Dice rolled: " + dice);

                if (oldPosition + dice > 100){
                    Console.WriteLine("Move exceeds 100. Turn skipped."); //check if move exceeds hundred
                    continue;
                }

                int newPosition = oldPosition + dice;

                string message;
                newPosition = ApplySnakeOrLadder(newPosition, out message);

                positions[i] = newPosition; //updating player position

                Console.WriteLine(
                    players[i] + ": " + oldPosition + " → " + newPosition +
                    (message != "" ? " (" + message + ")" : "")
                );

                if (CheckWin(newPosition)){
                    Console.WriteLine("\n " + players[i] + " wins the game!");
                    gameWon = true; //checking for win
                    break;
                }
            }
        }
    }
    static void Main(string[] args){
        int choice;

        do{
            Console.WriteLine("\n=== Snake & Ladder Game ===");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    StartGame();
                    break;

                case 2:
                    Console.WriteLine("Exiting game...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        }
		while (choice != 2);
    }
}
