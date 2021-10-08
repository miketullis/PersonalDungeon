using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcertLibrary;

namespace MyDungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CONCERT OF CARNAGE";

            #region IntroScreens
            Console.WriteLine(@" 
      __      _____ _    ___ ___  __  __ ___   _____ ___  
      \ \    / / __| |  / __/ _ \|  \/  | __| |_   _/ _ \ 
       \ \/\/ /| _|| |_| (_| (_) | |\/| | _|    | || (_) |
        \_/\_/ |___|____\___\___/|_|  |_|___|   |_| \___/ 
");
         System.Threading.Thread.Sleep(1500);
         Console.Clear();
         Console.WriteLine(@"

 =======================================================================
 _________ ________  _______  _________ _______________________________
 \_   ___ \\_  __  \ \      \ \_   ___ \\_   _____\______   \__    ___/
  /  \   \/ /  | |  \ |  |\  \ /  \  \/  |    __)  |   __   / |   |   
  \   \____/   |_|   ||  | \  \\   \_____|   |_____|   | |  \ |   |   
   \_____  \_______  ||__|  | / \_____  /_______  /|___| |  / |___|   
         \/        \/       \/        \/        \/        \/           
                       ________  ___________                           
                       \_____  \ \_   _____/                           
                ______  /  | |  \ |    __)  ______                     
               /_____/ /   |_|   \|   |    /_____/                     
                       \_______  ||___|                              
                                \/                                  
_________    _____ __________ _______      _____    ___________________ 
\_   ___ \  /  _  \\______   \\      \    /  _  \  /  _____/\_   _____/ 
 /  \   \/ /  /_\  \|   __   / |  |\  \  /  /_\  \/  \   ___ |    __)  
 \   \___ /    |    |   | |  \ |  | \  \/    |    \   \__\  \|   |_____ 
  \_____  \____|__  |___| |_ / |__|  | /\____|__  /\______  /_______  / 
        \/        \/       \/        \/         \/        \/        \/  

=======================================================================
               A GAME OF GUITAR SOLOS AND GORE GALORE!!! 

                 MUSIC - MONSTERS - MADNESS - MAYHEM

          ");
                      //Sleep Funtion & Clear to show Splash screen before moving to menu
                      System.Threading.Thread.Sleep(6000);
                      Console.Clear();
                      
                      Console.WriteLine("===========================================================================================\n" +
                          "+++++++++++++++++++++++++++++++++++ GAME SYNOPSIS +++++++++++++++++++++++++++++++++++++++++\n" +
                          "===========================================================================================\n\n" +
                          "The day is finally here.  All the hard work has led to your big break, a headlining \n" +
                          "gig at the iconic Hollywood Dome. The stage is set, and the crowd is chanting your name.\n\n" +
                          "Chaos erupts as mere moments before you are set to take the stage, the building is filled \n" +
                          "with the screams of terrified fans as a horde of blood-thirsty monsters invade this bastion \n" +
                          "of hard rock, dead set to rid the world of everything rock n’ roll stands for.\n\n" +
                          "Can you and your bandmates take down these vile, music-hating heathens before they take over \n" +
                          "the world and eliminate live music for all of humanity?\n");
                      
                      //Blinking Message
                      string blink = "Press any key to begin.";

                        while (!System.Console.KeyAvailable)
                        {
                            Console.Write(blink);
                            System.Threading.Thread.Sleep(650);

                            for (int j = 1; j <= blink.Length + 2; j++)
                            {
                                Console.Write("\b" + (char)32 + "\b");
                                if (j == blink.Length + 2) System.Threading.Thread.Sleep(650);
                            }
                        }//End while (blinking message) 

                      Console.ReadKey();//requires key input to proceed
                      Console.Clear();
            #endregion

            //THE GAME
            bool restart = false;

            do //loop to run the entire game
            {
                #region GameObjectCreation
     
                int score = 0; //Variable to keep track of the score

                //INSTRUMENTS
                //minDamage, maxDamage, name, bonusRockstarPower, bool bandRole
                Instrument micStand = new Instrument("Mic Stand", 5, 23, 6, true);
                Instrument guitar1 = new Instrument("Gibson Les Paul", 5, 26, 7, true);
                Instrument guitar2 = new Instrument("Fender Stratocaster", 5, 21, 5, false);
                Instrument bassGuitar1 = new Instrument("Rickenbacker Bass", 6, 28, 7, true);//Lemmy is God
                Instrument bassGuitar2 = new Instrument("Fender Jazz Bass", 5, 22, 4, false);

                //FOOD
                //description, healthRepair
                Food food1 = new Food("a bowl of M&MS with the brown ones removed", 25); //Can you say Van Halen??
                Food food2 = new Food("melon cut into squares", 21);//only availible if player is Axl
                Food food3 = new Food("ham on the bone", 27); //No sliced ham for Aerosmith
                Food food4 = new Food("four fried chickens and a Coke", 35);//Is Jake Blues here??
                Food food5 = new Food("dry white toast", 18); //An Elwood Blues favorite
                Food food6 = new Food("a double shot of Jack and Coke", 45);//only availible if player is Lemmy

                List<Food> foods = new List<Food>()
                { food1, food3, food4, food5 };

                //MONSTERS
                //name, maxHealth, health, maxDamage, minDamage, hitChance, block, description, isPoisonous
                MonsterSpiked ms1 = new MonsterSpiked("Galdor", 40, 40, 12, 5, 60, 9,
                    "Characteristics: Covered in large spikes\nFavorite Food: Raw kidney(preferably human)\nDislikes: Powerballads and Spandex", false);
                MonsterSpiked ms2 = new MonsterSpiked("Slardrax", 40, 40, 16, 5, 55, 11,
                    "Characteristics: Covered in spikes dripping with poison\nFavorite Food: Roasted Lungs\nDislikes: Foo Fighters and Red Hot Chili Peppers", true);
                MonsterSpiked ms3 = new MonsterSpiked("Gridlix", 40, 40, 17, 5, 57, 12,
                    "Characteristics: Covered In Barbed Spikes\nFavorite Food: Whole Smoked Hearts(no species preference)\nDislikes: Jam Sessions", false);
                MonsterClawed mc4 = new MonsterClawed("Klaxnar", 40, 40, 14, 5, 48, 11,
                    "Characteristics: Large Lobster-Like Claws\nFavorite Food: Human Sushi\nDislikes: Extended Guitar Solos", true);
                MonsterClawed mc5 = new MonsterClawed("Tokka", 40, 40, 15, 5, 45, 15,
                       "Characteristics: Mandible Claws And A Spiked Tail\nFavorite Food: Gallbladder Tartare\nDislikes: Excessive Stage Banter", false);
                MonsterClawed mc6 = new MonsterClawed("Rahzar", 40, 40, 14, 5, 48, 11,
                        "Characteristics: Razor Sharp Talons On Right Claw\nFavorite Food: Brain Stew\nDislikes: Cocky Lead Singers", true);
                MonsterBlob mb7 = new MonsterBlob("Klitlix", 40, 40, 18, 5, 51, 13,
                        "Characteristics: Dripping ooze and pulsating\nFavorite Food: Coagulated Blood Mixed With Brain Matter\nDislikes: Fog machines & confetti", true);
                MonsterBlob mb8 = new MonsterBlob("Trexilux", 40, 40, 13, 5, 53, 10,
                        "Characteristics: Secretes Bioluminescent Slime\nFavorite Food: Roasted Femur Bones\nDislikes: Laser Light Shows", false);
                MonsterBlob mb9 = new MonsterBlob("Bendrixlor", 40, 40, 18, 5, 51, 9,
                        "Characteristics: Dripping Ooze And Pulsating\nFavorite Food: Bloody Tounge Burritos\nDislikes: The Smell Of Hairspay", true);
                //Leader of the Monsters for final battle
                //name, maxHealth, health, maxDamage, minDamage, hitChance, block, description
                Monster ms15 = new Monster("King Grimlox", 65, 65, 17, 7, 59, 20,
                     "Characteristics: Leader And Most Powerful monster\n" +
                     "Mission: To destroy all rock music, enslave and/or " +
                     "devour all musicians, and take over the world");

                List<Monster> monsters = new List<Monster>()
                { ms1, ms2, ms3, mc4, mc5, mc6, mb7, mb8, mb9 };

                //ROOMS
                GetRoom rm1 = new GetRoom("You hear a scream and enter the opening act's dressing room to \n" +
                                          "find ", " clutching the band's singer.\n");
                GetRoom rm2 = new GetRoom("Entering the green room you find ", " standing over the freshly dismembered\n" +
                                          "body of the show's promoter. As you gasp, you draw the monster's attention.\n");
                GetRoom rm3 = new GetRoom("As you enter your dressing room, you find ", " destroying your band's\n" +
                                          "equipment and making his way toward a pair of terrified groupies.\n");
                GetRoom rm4 = new GetRoom("Approaching catering you detect the smell of smoked meat and find ",
                                          " \ncovering the catering staff with sauce and forcing them onto a barbeque.\n");
                GetRoom rm5 = new GetRoom("As you charge into what appears to be an office, you find ", " dangling the \n" +
                                          "stage manager over his gaping jaws, about to bite terrified soul’s head off.\n");
                GetRoom rm6 = new GetRoom("Passing the electrical room, you hear snarling and sound of electric surges. \n" +
                                          "You throw open the door and find ", " ripping power cables from the dome’s \n" +
                                          "electrical boxes, sending sparks flying.\n");
                //The Arena for final battle
                GetRoom rm15 = new GetRoom("Now that you have eliminated this monstrous threat from the backstage area it is time to \n" +
                    "take to the arena and ensure the threat has been neutralized and that your fans are safe.\n\n" +
                    "As you enter the arena you find the leader of this evil horde, ", ", a creature far more \n" +
                    "terrifying and powerful than any other you have faced. \n\nHe must be stopped. The music must live on. " +
                    "Rock can never die!\n\nHold on to your leather and spandex, it’s time to take this big boy down!\n");

                List<GetRoom> rooms = new List<GetRoom>()
                { rm1, rm2, rm3, rm4, rm5, rm6 };

                //PLAYERS
                //name, maxHealth, health, hitChance, block, Rocker characterRocker, Instrument equippedInstrument)
                Player player1 = new Player("Axl", 50, 50, 68, 14, Rocker.Rockstar, micStand);
                Player player2 = new Player("Slash", 50, 50, 69, 16, Rocker.Shredder, guitar1);
                Player player3 = new Player("Izzy", 50, 50, 65, 13, Rocker.Strummer, guitar2);
                Player player4 = new Player("Duff", 50, 50, 60, 12, Rocker.Bassist, bassGuitar2);
                Player player5 = new Player("Lemmy", 55, 55, 75, 17, Rocker.Metalhead, bassGuitar1);

                List<Player> players = new List<Player>()
                { player1, player2, player3, player4, player5 };

                Player player = null;
                #endregion

                bool playerSelected = false; //variable to contol exiting playerChoice loop

                while (playerSelected == false) //loop menu until a player is selected
                {
                 #region PlayerSelection
                    //PLAYER SELECTIONS
                    Console.Write("\n======================\n" +
                        "+ Choose Your rocker +\n" +
                        "======================\n" +
                        $" 1) {player1.Name}\n" +
                        $" 2) {player2.Name}\n" +
                        $" 3) {player3.Name}\n" +
                        $" 4) {player4.Name}\n" +
                        $" 5) {player5.Name}\n");

                    ConsoleKey playerChoice = Console.ReadKey(true).Key;//capture user playerChoice

                    switch (playerChoice)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.A:
                            player = player1;
                            Console.Clear();
                            Console.WriteLine(player +"\n\nWould you like to select this player? Y/N");
                            ConsoleKey player1Select = Console.ReadKey(true).Key;
                            switch (player1Select)
                            {
                                case ConsoleKey.Y:
                                case ConsoleKey.Enter:
                                    playerSelected = true;
                                    break;
                                case ConsoleKey.N:
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.S:
                            player = player2;
                            Console.Clear();
                            Console.WriteLine(player + "\n\nWould you like to select this player? Y/N");
                            ConsoleKey player2Select = Console.ReadKey(true).Key;
                            switch (player2Select)
                            {
                                case ConsoleKey.Y:
                                case ConsoleKey.Enter:
                                    playerSelected = true;
                                    break;
                                case ConsoleKey.N:
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.I:
                            player = player3;
                            Console.Clear();
                            Console.WriteLine(player + "\n\nWould you like to select this player? Y/N");
                            ConsoleKey player3Select = Console.ReadKey(true).Key;
                            switch (player3Select)
                            {
                                case ConsoleKey.Y:
                                case ConsoleKey.Enter:
                                    playerSelected = true;
                                    break;
                                case ConsoleKey.N:
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                        case ConsoleKey.NumPad4:
                        case ConsoleKey.D:
                            player = player4;
                            Console.Clear();
                            Console.WriteLine(player + "\n\nWould you like to select this player? Y/N");
                            ConsoleKey player4Select = Console.ReadKey(true).Key;
                            switch (player4Select)
                            {
                                case ConsoleKey.Y:
                                case ConsoleKey.Enter:
                                    playerSelected = true;
                                    break;
                                case ConsoleKey.N:
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    break;
                            }
                            Console.Clear();
                            break;
                        case ConsoleKey.D5:
                        case ConsoleKey.NumPad5:
                        case ConsoleKey.L:
                            player = player5;
                            Console.Clear();
                            Console.WriteLine(player + "\n\nWould you like to select this player? Y/N");
                            ConsoleKey player5Select = Console.ReadKey(true).Key;
                            switch (player5Select)
                            {
                                case ConsoleKey.Y:
                                case ConsoleKey.Enter:
                                    playerSelected = true;
                                    break;
                                case ConsoleKey.N:
                                case ConsoleKey.Escape:
                                    break;
                                default:
                                    break;
                            }
                            Console.Clear();
                            break;
                        default: //user made improper selection
                            Console.Clear();
                            Console.WriteLine("\nHey man, you chose an improper action! Try using a number dude!\n");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            break;
                    }//End Switch (playerChoice)
                }//End While (playerSelected)

                #endregion

                Console.WriteLine("\nIt's time to take these monsters down!!!");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();

                //Outer DoWhile Loop - manages room & monster selection & battles
                bool exit = false; 

                do
                    {
                        //Get randomRoom from list rooms
                        Random rand1 = new Random();
                        GetRoom room = rooms[rand1.Next(rooms.Count)];

                        //Get random monster from list monsters
                        Random rand2 = new Random();
                        Monster monster = monsters[rand2.Next(monsters.Count)];

                     //Display Scene
                    Console.WriteLine(room.Description + monster.Name + room.Description2);

                        //Loop for the menu
                        bool reload = false;
                        do
                        {
                            //MENU
                            #region Menu
                            Console.Write("Choose an action:\n" +
                                          "(A)ttack\n" +
                                          "(R)un Away\n" +
                                          "(P)layer Stats\n" +
                                          "(M)onster Info\n" +
                                          "(E)xit\n");
                            ConsoleKey userChoice = Console.ReadKey(true).Key; //Capture userChoice
                            Console.Clear();

                            switch (userChoice) //Switch for the menu
                        {
                                case ConsoleKey.A:
                                    Console.WriteLine($"{player.Name} attacks {monster.Name}!!\n");
                                    Combat.DoBattle(player, monster);
                                    if (monster.Health <= 0)
                                    {
                                        //monster dead
                                        score++; //add 1 to score
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{player.Name} killed {monster.Name}!\n");
                                        Console.ResetColor();
                                        Console.WriteLine($"{player.Name} has defeated " + score + " monster" + (score == 1 ? "." : "s."));
                                        Console.WriteLine("Health: " + Math.Round((Convert.ToDecimal(player.Health) /
                                                            Convert.ToDecimal(player.MaxHealth)) * 100) + "%");
                                        System.Threading.Thread.Sleep(4000);
                                        Console.Clear();

                                        //Prompt user to eat if player.Health is less that 70%
                                        if (Math.Round((Convert.ToDecimal(player.Health) / Convert.ToDecimal(player.MaxHealth)) * 100) <= 70 && monster.Name != "King Grimlox")
                                        {
                                            //Select Random food from list
                                            Random rand3 = new Random();
                                            Food food = foods[rand3.Next(foods.Count)];
                                            //Eat Food Menu
                                            Console.WriteLine($"\nDude...you're lookin' weak.\n" +
                                                $"I see {food.Description}.\n\n" +
                                                "Do you: \n" +
                                                "(S)tay Skinny\n" +
                                                "(I)ndulge Yourself");
                                            ConsoleKey eatFood = Console.ReadKey(true).Key; //Capture eatFood

                                            switch (eatFood)
                                            {
                                                case ConsoleKey.I:
                                                case ConsoleKey.Enter:
                                                player.Health = player.Health + food.HealthRepair; //add food to player.Health
                                                    Console.Clear();
                                                    Console.WriteLine("That really hit the spot, lets crack some monster skulls!\n" +
                                                        "Health: " + Math.Round((Convert.ToDecimal(player.Health) /
                                                         Convert.ToDecimal(player.MaxHealth)) * 100) + "%");
                                                    System.Threading.Thread.Sleep(1500);
                                                    break;
                                                case ConsoleKey.S:
                                                case ConsoleKey.Escape:
                                                Console.Clear();
                                                    Console.WriteLine("\nProbably a good thing.\n" +
                                                        "Your leather pants are looking a little too tight anyway.");
                                                    System.Threading.Thread.Sleep(2700);
                                                    break;
                                            }
                                            Console.Clear();
                                        }
                                        reload = true;
                                        monsters.Remove(monster); //once killed, remove monster
                                        rooms.Remove(room); //once cleared, remove room
                                    }//End If
                                    break;
                                case ConsoleKey.R:
                                    Console.WriteLine($"{player.Name} runs away from {monster.Name}!\n");
                                    Console.WriteLine($"{monster.Name} attacks {player.Name} as he flees!\n");
                                    Combat.DoAttack(monster, player);
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    reload = true;
                                    break;
                                case ConsoleKey.P:
                                    Console.WriteLine("Name: " + player.Name + "\n" +
                                                      "Health: " + Math.Round((Convert.ToDecimal(player.Health) / Convert.ToDecimal(player.MaxHealth)) * 100) + 
                                                      "%\nMonsters Defeated: " + score + "\n\nPress any key to exit");
                                    Console.ReadKey();//requires key input to proceed and mimics returning to previous
                                    Console.Clear();
                                    Console.WriteLine(room.Description + monster.Name + room.Description2);
                                    break;
                                case ConsoleKey.M:
                                    Console.WriteLine(monster + "\n\nPress any key to exit");
                                    Console.ReadKey();//requires key input to proceed and mimics returning to previous
                                    Console.Clear();
                                    Console.WriteLine(room.Description + monster.Name + room.Description2);
                                    break;
                                case ConsoleKey.X:
                                case ConsoleKey.E:
                                case ConsoleKey.Escape:
                                    Console.WriteLine("Quitters never make it to the Rock 'N Roll Hall of Fame!\n" +
                                        "Do you really want to exit? Y/N");
                                    //User must verify Y to exit game
                                    ConsoleKey userExit = Console.ReadKey(true).Key; //Capture userExit
                                    switch (userExit)
                                    {
                                        case ConsoleKey.Y:
                                        case ConsoleKey.Enter:
                                        exit = true;
                                        restart = false;
                                            Console.Clear();
                                            break;
                                        case ConsoleKey.N:
                                        case ConsoleKey.Escape:
                                        Console.WriteLine("\nI knew you wouldn't give up so quickly.");
                                            System.Threading.Thread.Sleep(1500);
                                            Console.Clear();
                                            Console.WriteLine(room.Description + monster.Name + room.Description2);
                                            reload = false;
                                            break;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Hey man, you chose an improper action! Try again dude!\n");
                                    System.Threading.Thread.Sleep(1500);
                                    Console.Clear();
                                    Console.WriteLine(room.Description + monster.Name + room.Description2);
                                    break;
                            }//END SWITCH
                            #endregion

                            //Check the player's Health
                            if (player.Health <= 0 && players.Count > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Dude...you died. I guess that's game over!\n\n" +
                                    "Maybe another bandmate would have better luck.\n\n" +
                                    "Would you like to try again? Y/N\n");

                                ConsoleKey tryAgain = Console.ReadKey(true).Key; //Capture tryAgain
                                switch (tryAgain)
                                {
                                    case ConsoleKey.N:
                                    case ConsoleKey.Escape:
                                    exit = true;
                                    Console.Clear();
                                        break;
                                    case ConsoleKey.Y:
                                    case ConsoleKey.Enter:
                                    Console.Clear();
                                    exit = true;
                                    restart = true;
                                        break;
                                }
                                break;
                            }

                            //if all monsters are dead (removed) or all rooms cleared, load monster and room for final battle
                            if (monsters.Count <= 0 || rooms.Count <= 0)
                            {
                                monsters.Clear(); //empty list of monsters
                                monsters.Add(ms15); //add big bad guy to monster list as only option
                                rooms.Add(rm15); //add the Arena to list
                            }//End If

                            //SPECIAL PLAYER FOODS
                            if (player.Name == "Lemmy")
                            {
                                foods.Clear(); //remove all foods from list
                                foods.Add(food6); //add Lemmy's signature drink to food list as only option

                            }//End If
                            if (player.Name == "Axl")
                            {
                                foods.Add(food2); //add Axl's special food to list

                            }//End If

                        if (monster.Name == "King Grimlox" && monster.Health <= 0 )// show game ending if final monster is dead
                        {
                            #region PlayerWins

                            Console.WriteLine("You have saved the world from this music-hating menace.  It is time to gather your \n" +
                                "remaining bandmates and treat the surviving fans to what they came here for……LETS ROCK!!!!");
                            Console.WriteLine(@"

                                                           ▄▄█
                                           └█▄         ▐███▀
          ▄▄▄                                ▀█▄        ▀██▌
         █████                                 ▀█▄       ███▄   ▄▄▄
         ▀███▀            ▄▄▄         ▄▄▄      ▐██▌       ███  █████
          ▄▄▄▄             ▀███▄     █████    ▄██▀        ▀███ ▀███▀
       ▄████████        ▄▄▄  ▀████▄  ▀███▀ ▄███▀           ███▄▄▄▄▄▄▄ 
      ▄██████████     ▄███▀▀  █▀▀██▌  ▄▄▄▄████▀             ███████████
      ███████████▄▄███▀▀▀    █    ▀█████████▌                ██████████▌
     ▐███████████████▀      █    █████████████               ███████▌███
      ▀█████▌  ███▀▀       █    ▐██████████████               ██████▌ ██ 
       █████   ▀█         ██    ██████████████▀ ▄▄▄██▄▄▄▄    ▐███████  ██
       ███▌ ▄███         █ █ ▄██████▀▀▀▀▀▀███▄ ▀▀▀███▀▀▀     ████████   ██
       ▀████████▌          █ █████▀          ████  ▐▌       ▄████████▌  ▀▀ 
        ████ ████          █ ████▀            ████ ▐▌       ████  ████
        ████ ████          █  ███              ██  ▐▌      ▐███▌   ███▌
       ▐███▀  ███         ╓█▄  ██              █   ██      ████    ▀███
       ████   ███▌       ▄███▄ ▐█             ▐█  ████    ▄███      ████
       ███▌   ███▌      █▀ █ █▄ ▀█▄          ▄█ ▄█▀▐█ █▄  ███▌      └███▄
       ███    ███      █▀  █  ▀▌ █▀██▄▄▄▄▄▄██▀█▌█  ▐▌  █▄▐██▀        ╙███

");
                            //Blinking Message
                            string blinkEnd = "Press any key to continue.";

                            while (!System.Console.KeyAvailable)
                            {
                                Console.Write(blinkEnd);
                                System.Threading.Thread.Sleep(650);

                                for (int j = 1; j <= blinkEnd.Length + 2; j++)
                                {
                                    Console.Write("\b" + (char)32 + "\b");
                                    if (j == blinkEnd.Length + 2) System.Threading.Thread.Sleep(650);
                                }
                            }//End while (blinking message) 
                            Console.ReadKey();//requires key input to proceed
                            Console.Clear();
                            Console.WriteLine("\nWould you like to play again? Y/N");

                            ConsoleKey tryAgain = Console.ReadKey(true).Key; //Capture tryAgain
                            switch (tryAgain)
                            {
                                case ConsoleKey.N:
                                case ConsoleKey.Escape:
                                    exit = true;
                                    break;
                                case ConsoleKey.Y:
                                case ConsoleKey.Enter:
                                    Console.Clear();
                                    exit = true;
                                    restart = true;
                                    break;
                            }
                            break;
                        }//end If
                        #endregion

                    } while (!exit && !reload);

                } while (!exit);

            } while (restart);

        }//END MAIN
    }//END CLASS
}//END NAMESPACE
