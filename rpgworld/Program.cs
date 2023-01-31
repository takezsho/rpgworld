

namespace rpgworld;
/* comment
* my rpg world 
* Shoma T
* Period 5
* RPG
*/
internal class Program
{
    static void Main(string[] args)
    {
        bool start5 = false;
        bool engine = true;
        while (engine = true)
        {
            bool mainmenu = true;
            bool start = false;
            bool inv = true;
            bool invcheck = true;
            bool start2 = false;
            bool start3 = false;
            bool start4 = true;
            Console.WriteLine("In my RPG world, you will play as a man that owns an apple farm. But one day the King that lives next to him steals all of his apple trees and put it inside his dungeon.");
            Console.WriteLine("Your objective is to sneak into the dungeon and fight all the knights to retrieve your apple trees. But be careful, the villagers who live in inside the Kings Kingdom says that they hear some mysterious and scary sounds.");
            Console.WriteLine(" You need to defeat enemies to level up and upgrade your character. You can also take their weapon for better attacks.");
            Console.WriteLine("You can also earn coins from enemies or chests to buy stuff from the blacksmith for better weapons.");
            Console.WriteLine("You could also just plant the apple seeds in your house but whats the fun in that?");
            Random rng = new Random();
            int hpmax = 200;
            int hpmin = 55;
            int dmgmax = 35;
            int dmgmin = 20;
            int luckmax = 90;
            int luckmin = 1;
            /* combat in world 1 */
            int losewin = 0;
            string enemyname = "";
            Random rnd = new Random();
            int enemymin = 1;
            int enemymax = 11;
            int critmin = 0;
            int critmax = 151;
            int critical = rnd.Next(critmin, critmax);
            int Enemyid = rnd.Next(enemymin, enemymax);
            string enemynew = Attack(Enemyid, enemyname);
            int level = 0;
            int exptotal = 0;
            bool fighting = true;
            int expmin = 5;
            int expmax = 15;
            int experience = rnd.Next(expmin, expmax);
            Random enemyattack = new Random();
            int attackmin = 25;
            int attackmax = 45;
            int enemyattackincome = enemyattack.Next(attackmin, attackmax);
            bool combat = true;
            int bigattack = 0;
            int win = 0;
            int lose = 0;
            int draw = 0;
            double enemyhp = 0;
            /*combat in world 1 */
            double Health = rng.Next(hpmin, hpmax);
            double Damage = rng.Next(dmgmin, dmgmax);
            double Luck = rng.Next(luckmin, luckmax);
            Console.WriteLine("Your Hit point is = " + Health);
            Console.WriteLine("Your Damage point is = " + Damage);
            Console.WriteLine("Your Luck point is = " + Luck);
            Console.WriteLine("Press enter to Continue");
            Console.ReadLine();
            Console.Clear();
            int tutorial = 0;
            while (mainmenu == true)
            {
                Console.Clear();
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Credits");
                if (tutorial == 1)
                {
                    Console.WriteLine("4. Change Name");
                    Console.WriteLine("5. Fight");
                    Console.WriteLine("6. Lunch with Sonic");

                }
                string answermenu = Console.ReadLine();
                if (answermenu == "1")
                {
                    while (invcheck == true)
                    {
                        if (tutorial == 1)
                        {
                            break;
                        }
                        inv = true;
                        while (inv == true)
                        {
                            if (tutorial == 1)
                            {
                                break;
                            }
                            int sword = 0;
                            int slingshot = 0;
                            int spear = 0;
                            Console.Clear();
                            Console.WriteLine("Before we start the game choose your weapon");
                            Console.WriteLine("1. Sword \n2. Slingshot \n3. Spear");
                            Console.WriteLine("Answer using numbers.");
                            string answerweapon = Console.ReadLine();
                            if (answerweapon == "1")
                            {
                                sword += 1;
                                start = true;
                                answerweapon = "Sword";
                            }
                            if (answerweapon == "2")
                            {
                                slingshot += 1;
                                start = true;
                                answerweapon = "Slingshot";
                            }
                            if (answerweapon == "3")
                            {
                                spear += 1;
                                start = true;
                                answerweapon = "Spear";
                            }
                            while (start == true)
                            {
                                if (tutorial == 1)
                                {
                                    break;
                                }
                                int apple = 0;
                                int pear = 0;
                                int durian = 0;
                                Console.WriteLine("Choose your item");
                                Console.WriteLine("1. Apple \n2. Pear \n3. Durian");
                                string answerfood = Console.ReadLine();
                                if (answerfood == "1")
                                {
                                    apple += 1;
                                    start2 = true;
                                    Console.WriteLine("Apples heal your character by 30% \nPress enter to continue");
                                    answerfood = "Apple";
                                }
                                if (answerfood == "2")
                                {
                                    pear += 1;
                                    start2 = true;
                                    Console.WriteLine("Pears reduce enemy DP by 15% \nPress enter to continue");
                                    answerfood = "Pear";
                                }
                                if (answerfood == "3")
                                {
                                    durian += 1;
                                    start2 = true;
                                    Console.WriteLine("Durians increase your next 15 attacks stronger by 20% \nPress enter to continue");
                                    answerfood = "Durian";
                                }
                                while (start2 == true)
                                {
                                    if (tutorial == 1)
                                    {
                                        break;
                                    }
                                    int attackplus = 0;
                                    int defenseplus = 0;
                                    int luckplus = 0;
                                    Console.ReadLine();
                                    Console.WriteLine("Choose your trait");
                                    Console.WriteLine("1. Attack+ (Makes your attack 25% stronger) \n2. Defense+ (Makes your health 15% higher) \n3. Luck+ (Makes your luck 10% higher)");
                                    string answertrait = Console.ReadLine();
                                    if (answertrait == "1")
                                    {
                                        Damage = Damage * 0.25 + Damage;
                                        Console.WriteLine("Your DP is now " + Damage + ".");
                                        start3 = true;
                                        attackplus += 1;
                                        answertrait = "Attack+";
                                    }
                                    if (answertrait == "2")
                                    {
                                        Health = Health * 0.15 + Health;
                                        Console.WriteLine("Your HP is now " + Health + ".");
                                        start3 = true;
                                        defenseplus += 1;
                                        answertrait = "Defense+";
                                    }
                                    if (answertrait == "3")
                                    {
                                        Luck = Luck * 0.1 + Luck;
                                        Console.WriteLine("Your LK is now " + Luck + ".");
                                        start3 = true;
                                        luckplus += 1;
                                        answertrait = "Luck+";
                                    }
                                    while (start3 == true)
                                    {
                                        if (tutorial == 1)
                                        {
                                            break;
                                        }
                                        Console.WriteLine("Your current starter item is:");
                                        Console.WriteLine(answerweapon);
                                        Console.WriteLine(answerfood);
                                        Console.WriteLine(answertrait);
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Do you want to continue or go back and change loadout? \n1. change \n2. continue");
                                        string answerloadout = Console.ReadLine();
                                        if (answerloadout == "1")
                                        {
                                            inv = false;
                                            start = false;
                                            start2 = false;
                                            start3 = false;
                                            Console.Clear();
                                            sword = 0;
                                            slingshot = 0;
                                            spear = 0;
                                            apple = 0;
                                            pear = 0;
                                            durian = 0;
                                            attackplus = 0;
                                            defenseplus = 0;
                                            luckplus = 0;


                                        }
                                        if (answerloadout == "2")
                                        {
                                            start4 = true;
                                            while (start4 == true)
                                            {
                                                bool start9 = true;
                                                Console.WriteLine("Type your name here");
                                                if (tutorial == 1)
                                                {
                                                    break;
                                                }
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Your character is going to be named " + name + ". Are you sure? \n Y/N");
                                                string answername = Console.ReadLine();
                                                if (answername == "N")
                                                {
                                                    Console.Clear();
                                                }
                                                if (answername == "Y")
                                                {
                                                    while (start9 == true)
                                                    {
                                                        tutorial = 1;
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }


                                }
                            }
                        }
                    }


                }
                if (answermenu == "2")
                {
                    Console.WriteLine("Your current HP is " + Health + ".");
                    Console.WriteLine("Your current DP is " + Damage + ".");
                    Console.WriteLine("Your current LK is " + Luck + ".");
                    Console.WriteLine("Press enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (answermenu == "3")
                {
                    Console.WriteLine("Developer: Shoma");
                    Console.WriteLine("thats all");
                    Console.WriteLine("Press enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (answermenu == "4")
                {
                    start4 = true;
                    while (start4 == true)
                    {
                        Console.WriteLine("Type your name here");
                        string name = Console.ReadLine();
                        Console.WriteLine("Your character is going to be named " + name + ". Are you sure? \n Y/N");
                        string answername = Console.ReadLine();
                        if (answername == "N")
                        {
                            Console.Clear();
                        }
                        if (answername == "Y")
                        {
                            start4 = false;
                        }
                    }
                    Console.WriteLine("ADOAWDIAWDAWDAWDVGFADADYIWDAWDAWDADWDDAWD");
                }
                if (answermenu == "5")
                {
                    Console.Clear();
                    Console.WriteLine("A wild " + Attack(Enemyid, enemyname) + " has appeared!!");
                    do
                    {
                        if (enemynew == "Bug")
                        {
                            enemyhp = 45;
                        }
                        if (enemynew == "Slime")
                        {
                            enemyhp = 51;
                        }
                        if (enemynew == "Grunt")
                        {
                            enemyhp = 72;
                        }
                        if (enemynew == "Spider")
                        {
                            enemyhp = 65;
                        }
                        if (enemynew == "Bandit")
                        {
                            enemyhp = 69;
                        }
                        if (enemynew == "Worm")
                        {
                            enemyhp = 75;
                        }
                        if (enemynew == "Rat")
                        {
                            enemyhp = 56;
                        }
                        if (enemynew == "Big Rat")
                        {
                            enemyhp = 82;
                        }
                        if (enemynew == "Wolf")
                        {
                            enemyhp = 79;
                        }
                        if (enemynew == "Bat")
                        {
                            enemyhp = 52;
                        }
                        if (enemynew == "The Destroyer")
                        {
                            enemyhp = 6000;
                        }
                        Console.WriteLine("You currently have " + Health + " HP.");
                        Console.WriteLine("The " + enemynew + " has " + enemyhp + " HP.");
                        do
                        {
                            fighting = true;
                            Console.WriteLine("1. ATTACK       2. DEFEND     3. FLEE       4. ULTIMATE (" + bigattack + "/3)");
                            string response = Console.ReadLine();
                            if (response == "1")
                            {
                                critical = rnd.Next(critmin, critmax);
                                if (critical < Luck)
                                {
                                    Damage = Damage * 1.25;
                                    Console.WriteLine("That was a critical hit!");
                                    enemyhp -= Damage;
                                    Damage = Damage * 0.8;
                                }
                                else
                                {
                                    enemyhp -= Damage;
                                }
                                enemyattackincome = enemyattack.Next(attackmin, attackmax);
                                Console.WriteLine("The " + enemynew + " has " + enemyhp + " hp!");
                                Thread.Sleep(1000);
                                if (enemyhp <= 0)
                                {
                                    combat = false;
                                    fighting = false;
                                    win += 1;
                                }
                                while (fighting == true)
                                {
                                    Console.WriteLine("The " + enemynew + " did " + enemyattackincome + " damage!");
                                    Health -= enemyattackincome;
                                    Console.WriteLine("Your HP is currently at " + Health + "!");
                                    if (Health <= 0)
                                    {
                                        fighting = false;
                                        combat = false;
                                        lose += 1;
                                        break;
                                    }
                                    fighting = false;
                                }
                            }
                            if (response == "2")
                            {
                                double defendattack = enemyattackincome * 0.25;
                                double defendhealth = Health -= defendattack;
                                Console.WriteLine("The enemy did " + defendattack + " damage!");
                                Console.WriteLine("Your HP is now " + Health + "!");
                                Console.WriteLine("Ultimate charged by 1.");
                                if (Health <= 0)
                                {
                                    fighting = false;
                                    combat = false;
                                    lose += 1;
                                    break;
                                }
                                bigattack += 1;
                            }
                            if (response == "3")
                            {
                                combat = false;
                                draw += 1;
                                Console.ReadLine();
                            }
                            if (response == "4")
                            {
                                if (bigattack > 2)
                                {
                                    double ultimate = Damage * 3.75;
                                    Console.WriteLine("ULTIMATE ATTACK!");
                                    enemyhp -= ultimate;
                                    Thread.Sleep(1000);
                                    Console.WriteLine(@"        __                                           __");
                                    Console.WriteLine(@"       (**)                                         (**)");
                                    Console.WriteLine(@"       IIII                                         IIII");
                                    Console.WriteLine(@"       ####                                         ####");
                                    Console.WriteLine(@"       HHHH     Madness comes, and madness goes     HHHH");
                                    Console.WriteLine(@"       HHHH    An insane place, with insane moves   HHHH");
                                    Console.WriteLine(@"       ####   Battles without, for battles within   ####");
                                    Console.WriteLine(@"    ___IIII___        Where evil lives,          ___IIII___");
                                    Console.WriteLine(@" .-`_._-II-_._`-.      and evil rules         .-`_._-II-_._`-.");
                                    Console.WriteLine(@"|/``  .`\/`.  ``\|    Breaking them up,      |/``  .`\/`.  ``\|");
                                    Console.WriteLine(@"`     }    {     '  just breaking them in    `     }    {     '");
                                    Console.WriteLine(@"      ) () (  Quickest way out, quickest way wins  ) () (");
                                    Console.WriteLine(@"      ( :: )      Never disclose, never betray     ( :: )");
                                    Console.WriteLine(@"      | :: |   Cease to speak or cease to breath   | :: |");
                                    Console.WriteLine(@"      | )( |        And when you kill a man,       | )( |");
                                    Console.WriteLine(@"      | || |          you're a murderer            | || |");
                                    Console.WriteLine(@"      | || |             Kill many                 | || |");
                                    Console.WriteLine(@"      | || |        and you're a conqueror         | || |");
                                    Console.WriteLine(@"      | || |        Kill them all ... Ooh..        | || |");
                                    Console.WriteLine(@"      | || |           Oh you're a God!            | || |");
                                    Console.WriteLine(@"      ( () )                       -Megadeth       ( () )");
                                    Console.WriteLine(@"       \  /                                         \  /");
                                    Console.WriteLine(@"        \/                                           \/");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("Your ultimate did " + ultimate + " damage!");
                                    Console.WriteLine("The enemy now has " + enemyhp + " hp!");
                                    bigattack = 0;
                                    if (enemyhp <= 0)
                                    {
                                        combat = false;
                                        fighting = false;
                                        win += 1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ultimate not charged.");
                                }

                            }

                        }
                        while (combat == true);
                        if (win != 0)
                        {
                            Console.WriteLine("You won!");
                            losewin += 1;
                            win = 0;
                            experience = rnd.Next(expmin, expmax);
                            Console.WriteLine("You got " + experience + " exp!");
                            exptotal += experience;
                            if (exptotal >= 25)
                            {
                                level += 1;
                                Console.WriteLine("Level up! \nYour level is now at " + level + ". \nDamage and Health up!");
                                exptotal = 0;
                                Damage = Damage * 0.05 + Damage;
                                Health = Health * 0.05 + Health;
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();

                        }
                        if (lose != 0)
                        {
                            Console.WriteLine("You lost! \n 0 EXP EARNED");
                            Console.ReadLine();
                            losewin += 1;
                            lose = 0;
                        }
                        if (draw != 0)
                        {
                            draw = 0;
                            losewin += 1;
                            Console.WriteLine("You ran away! \n 0 EXP EARNED");
                            Console.ReadLine();
                        }
                        
                        
                    }
                    while (losewin == 0);
                    Console.Clear();
                    Console.WriteLine("Welcome back");
                    losewin = 0;
                    Console.ReadLine();

                }
                if (answermenu == "6")
                {
                    int boss = 0;
                    string enemyboss = "Sonic";
                    enemyhp = 200;
                    int bossattackincome = enemyattackincome * 69420;
                    Console.WriteLine(@"       ___------__");
                    Console.WriteLine(@" |\__-- /\       _-");
                    Console.WriteLine(@" |/    __      -");
                    Console.WriteLine(@" //\  /  \    /__");
                    Console.WriteLine(@" |  o|  0|__     --_");
                    Console.WriteLine(@" \\____-- __ \   ___-");
                    Console.WriteLine(@" (@@    __/  / /_");
                    Console.WriteLine(@"    -_____---   --_");
                    Console.WriteLine(@"     //  \ \\   ___-");
                    Console.WriteLine(@"   //|\__/  \\  \");
                    Console.WriteLine(@"   \_-\_____/  \-\");
                    Console.WriteLine(@"        // \\--\|   ");
                    Console.WriteLine(@"   ____//  ||_");
                    Console.WriteLine(@"  /_____\ /___\");
                    Console.WriteLine(@"______________________");
                    Console.WriteLine(" \n A wild Sonic appeared!");
                    Console.WriteLine("You currently have " + Health + " HP.");
                    Console.WriteLine("The " + enemyboss + " has " + enemyhp + " HP.");
                    do
                    {
                        fighting = true;
                        Console.WriteLine("1. ATTACK       2. DEFEND     3. FLEE       4. ULTIMATE (" + bigattack + "/3)");
                        string response = Console.ReadLine();
                        if (response == "1")
                        {
                            critical = rnd.Next(critmin, critmax);
                            if (critical < Luck)
                            {
                                Damage = Damage * 1.25;
                                Console.WriteLine("That was a critical hit!");
                                enemyhp -= Damage;
                                Damage = Damage * 0.8;
                            }
                            else
                            {
                                enemyhp -= Damage;
                            }
                            enemyattackincome = enemyattack.Next(attackmin, attackmax);
                            Console.WriteLine("The " + enemyboss + " has " + enemyhp + " hp!");
                            Thread.Sleep(1000);
                            if (enemyhp <= 0)
                            {
                                combat = false;
                                fighting = false;
                                win += 1;
                            }
                            while (fighting == true)
                            {
                                Console.WriteLine("The " + enemyboss + " did " + bossattackincome + " damage!");
                                Health -= bossattackincome;
                                Console.WriteLine("Your HP is currently at " + Health + "!");
                                if (Health <= 0)
                                {
                                    fighting = false;
                                    combat = false;
                                    lose += 1;
                                    break;
                                }
                                fighting = false;
                            }
                        }
                        if (response == "2")
                        {
                            double defendattack = bossattackincome * 0.25;
                            double defendhealth = Health -= defendattack;
                            Console.WriteLine("The enemy did " + defendattack + " damage!");
                            Console.WriteLine("Your HP is now " + Health + "!");
                            Console.WriteLine("Ultimate charged by 1.");
                            if (Health <= 0)
                            {
                                fighting = false;
                                combat = false;
                                lose += 1;
                                break;
                            }
                            bigattack += 1;
                        }
                        if (response == "3")
                        {
                            combat = false;
                            draw += 1;
                            Console.ReadLine();
                        }
                        if (response == "4")
                        {
                            if (bigattack > 2)
                            {
                                double ultimate = Damage * 3.75;
                                Console.WriteLine("ULTIMATE ATTACK!");
                                enemyhp -= ultimate;
                                Thread.Sleep(1000);
                                Console.WriteLine(@"        __                                           __");
                                Console.WriteLine(@"       (**)                                         (**)");
                                Console.WriteLine(@"       IIII                                         IIII");
                                Console.WriteLine(@"       ####                                         ####");
                                Console.WriteLine(@"       HHHH     Madness comes, and madness goes     HHHH");
                                Console.WriteLine(@"       HHHH    An insane place, with insane moves   HHHH");
                                Console.WriteLine(@"       ####   Battles without, for battles within   ####");
                                Console.WriteLine(@"    ___IIII___        Where evil lives,          ___IIII___");
                                Console.WriteLine(@" .-`_._-II-_._`-.      and evil rules         .-`_._-II-_._`-.");
                                Console.WriteLine(@"|/``  .`\/`.  ``\|    Breaking them up,      |/``  .`\/`.  ``\|");
                                Console.WriteLine(@"`     }    {     '  just breaking them in    `     }    {     '");
                                Console.WriteLine(@"      ) () (  Quickest way out, quickest way wins  ) () (");
                                Console.WriteLine(@"      ( :: )      Never disclose, never betray     ( :: )");
                                Console.WriteLine(@"      | :: |   Cease to speak or cease to breath   | :: |");
                                Console.WriteLine(@"      | )( |        And when you kill a man,       | )( |");
                                Console.WriteLine(@"      | || |          you're a murderer            | || |");
                                Console.WriteLine(@"      | || |             Kill many                 | || |");
                                Console.WriteLine(@"      | || |        and you're a conqueror         | || |");
                                Console.WriteLine(@"      | || |        Kill them all ... Ooh..        | || |");
                                Console.WriteLine(@"      | || |           Oh you're a God!            | || |");
                                Console.WriteLine(@"      ( () )                       -Megadeth       ( () )");
                                Console.WriteLine(@"       \  /                                         \  /");
                                Console.WriteLine(@"        \/                                           \/");
                                Thread.Sleep(3000);
                                Console.WriteLine("Your ultimate did " + ultimate + " damage!");
                                Console.WriteLine("The enemy now has " + enemyhp + " hp!");
                                bigattack = 0;
                                if (enemyhp <= 0)
                                {
                                    combat = false;
                                    fighting = false;
                                    win += 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ultimate not charged.");
                            }

                        }

                    }
                    while (combat == true);
                    if (win != 0)
                    {
                        Console.WriteLine("You won!");
                        losewin += 1;
                        win = 0;
                        experience = rnd.Next(expmin, expmax);
                        Console.WriteLine("You got " + experience + " exp!");
                        exptotal += experience;
                        if (exptotal >= 25)
                        {
                            level += 1;
                            Console.WriteLine("Level up! \nYour level is now at " + level + ". \nDamage and Health up!");
                            exptotal = 0;
                            Damage = Damage * 0.05 + Damage;
                            Health = Health * 0.05 + Health;
                        }
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();

                    }
                    if (lose != 0)
                    {
                        Console.WriteLine("You lost! \n 0 EXP EARNED");
                        Console.ReadLine();
                        losewin += 1;
                        lose = 0;
                    }
                    if (draw != 0)
                    {
                        draw = 0;
                        losewin += 1;
                        Console.WriteLine("You ran away! \n 0 EXP EARNED");
                        Console.ReadLine();
                    }


                }
                while (losewin == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome back");
                    losewin = 0;
                    Console.ReadLine();
                    combat = true;
                }
            }




            
        }
    }
    static string Attack(int Enemyid, string enemyname)
    {
        if (Enemyid == 1)
        {
            enemyname = "Bug";
        }
        else if (Enemyid == 2)
        {
            enemyname = "Slime";
        }
        else if (Enemyid == 3)
        {
            enemyname = "Grunt";
        }
        else if (Enemyid == 4)
        {
            enemyname = "Spider";
        }
        else if (Enemyid == 5)
        {
            enemyname = "Bandit";
        }
        else if (Enemyid == 6)
        {
            enemyname = "Worm";
        }
        else if (Enemyid == 7)
        {
            enemyname = "Rat";
        }
        else if (Enemyid == 8)
        {
            enemyname = "Big Rat";
        }
        else if (Enemyid == 9)
        {
            enemyname = "Wolf";
        }
        else if (Enemyid == 10)
        {
            enemyname = "Bat";
        }
        else if (Enemyid == 11)
        {
            enemyname = "The Destoryer";
        }
        return enemyname;
    }
}