// See https://aka.ms/new-console-template for more information
using Abstraindo_um_Jogo_de_RPG_Usando_POO.src.Entities;

Knight arus = new Knight("Arus", 42, "Knight", 749, 72);

Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);

Wizard jenica = new Wizard("Jennica", 42, "White Wizard", 325, 601);

Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 385, 641);





do 
{
    System.Console.WriteLine("Whats your next Action? (1 - Attack, 2 - Show Stats or Any other number to Exit)");
    int.TryParse(System.Console.ReadLine(), out var nextAction);
    if (nextAction == 1)
    {
        System.Console.WriteLine("What character will you attack with? (1 - Arus, 2 - Wedge, 3 - Jenica or 4 - Topapa");
        int.TryParse(System.Console.ReadLine(), out var choseCaracterToAttack);
        if (choseCaracterToAttack == 1)
        {
            System.Console.WriteLine("What type o attack? (1 - Fisical, 2 - Magical");
            int.TryParse(System.Console.ReadLine(), out var attackType);
            if (attackType == 1)
            {
                Console.WriteLine(arus.FisicalAttack());
            }
            else if (attackType == 2)
            {
                Console.WriteLine(arus.MagicalAttack(1, 15)); 
            }
            else{
                System.Console.WriteLine("Attack type invalid.");
            }
        }
        else if (choseCaracterToAttack == 2)
        {
            System.Console.WriteLine("What type o attack? (1 - Fisical, 2 - Magical");
            int.TryParse(System.Console.ReadLine(), out var attackType);
            if (attackType == 1)
            {
                Console.WriteLine(wedge.FisicalAttack());
            }
            else if (attackType == 2)
            {
                Console.WriteLine(wedge.MagicalAttack(4, 20)); 
            }
            else{
                System.Console.WriteLine("Attack type invalid.");
            }
        }
        else if (choseCaracterToAttack == 3)
        {
            System.Console.WriteLine("What type o attack? (1 - Fisical, 2 - Magical");
            int.TryParse(System.Console.ReadLine(), out var attackType);
            if (attackType == 1)
            {
                Console.WriteLine(jenica.FisicalAttack());
            }
            else if (attackType == 2)
            {
                Console.WriteLine(jenica.MagicalAttack(10, 10)); 
            }
            else{
                System.Console.WriteLine("Attack type invalid.");
            }
        }
        else if (choseCaracterToAttack == 4)
        {
            System.Console.WriteLine("What type o attack? (1 - Fisical, 2 - Magical");
            int.TryParse(System.Console.ReadLine(), out var attackType);
            if (attackType == 1)
            {
                Console.WriteLine(topapa.FisicalAttack());
            }
            else if (attackType == 2)
            {
                Console.WriteLine(topapa.MagicalAttack(15, 20)); 
            }
            else{
                System.Console.WriteLine("Attack type invalid.");
            }
        }
        else 
        {
            System.Console.WriteLine("Character Invalid.");
        }
    }
    else if (nextAction == 2)
    {
        System.Console.WriteLine(arus.ToString());

        System.Console.WriteLine(wedge.ToString());

        System.Console.WriteLine(jenica.ToString());

        System.Console.WriteLine(topapa.ToString());
    }
    else 
    {
        break;
    }
} while (true);


