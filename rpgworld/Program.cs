

namespace rpgworld;
/* comment
* my rpg world 
* Shoma T
* Period 2
* RPG
*/
internal class Program
{
    static void Main(string[] args)
    {
        int tutorial = 0;
        bool start5 = false;
        bool engine = true;
        bool mainmenu = true;
        bool start = false;
        bool inv = true;
        bool playerinv = true;
        bool invcheck = true;
        bool start2 = false;
        bool start3 = false;
        bool start4 = true;
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
        int weaponworld1min = 1;
        int weaponworld1max = 10;
        int weaponworld1 = rng.Next(weaponworld1min, weaponworld1max);
        int weaponid = 0;
        int weaponcurrent = 0;
        string weaponname = "";
        double health = rng.Next(hpmin, hpmax);
        double damage = rng.Next(dmgmin, dmgmax);
        double Luck = rng.Next(luckmin, luckmax);
        //var (weaponName, damageValue) = Weapon(weaponid, weaponname, damage);
        /*  weapon check id 
         */
        int weaponcheckid1 = 0;
        int weaponcheckid2 = 0;
        int weaponcheckid3 = 0;
        int weaponcheckid4 = 0;
        int weaponcheckid5 = 0;
        int weaponcheckid6 = 0;
        int weaponcheckid7 = 0;
        int weaponcheckid8 = 0;
        int weaponcheckid9 = 0;
        int weaponcheckid10 = 0;
        int weaponidchecker1 = 0;
        int weaponidchecker2 = 0;
        int weaponidchecker3 = 0;
        int weaponidchecker4 = 0;
        int weaponidchecker5 = 0;
        int weaponidchecker6 = 0;
        int weaponidchecker7 = 0;
        int weaponidchecker8 = 0;
        int weaponidchecker9 = 0;
        int weaponidchecker10 = 0;
        int[] weaponchecker = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        var weaponName = string.Empty;
        double attackvalue = rng.Next(dmgmin, dmgmax);

        while (engine = true)
        {


            Console.WriteLine("Type your name here");
            //Console.WriteLine("DP:" + attackvalue);
            //Console.WriteLine("Base:" + damage);
            string name = Console.ReadLine();
            Console.WriteLine("Your character is going to be named " + name + ". Are you sure? \n Y/N");
            string answername = Console.ReadLine();
            if (answername == "N")
            {
                Console.WriteLine("You can change your name again after the intro");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            if (answername == "n")
            {
                Console.WriteLine("You can change your name again after the intro");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            if (answername == "Y")
            {
                Console.WriteLine("Your name is " + name + ".");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
            if (answername == "y")
            {
                Console.WriteLine("Your name is " + name + ".");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
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
                        weaponid = 1;
                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                    }
                    if (answerweapon == "2")
                    {
                        slingshot += 1;
                        start = true;
                        answerweapon = "Slingshot";
                        weaponid = 9;
                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                    }
                    if (answerweapon == "3")
                    {
                        spear += 1;
                        start = true;
                        answerweapon = "Spear";
                        weaponid = 17;
                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                    }
                    while (start == true)
                    {
                        if (tutorial == 1)
                        {
                            break;
                        }
                        weaponcurrent = 1;
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
                                attackvalue = damage * 0.25 + damage;
                                Console.WriteLine("Your DP is now " + damage + ".");
                                start3 = true;
                                attackplus += 1;
                                answertrait = "Attack+";
                            }
                            if (answertrait == "2")
                            {
                                health = health * 0.15 + health;
                                Console.WriteLine("Your HP is now " + health + ".");
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
                                Console.WriteLine("Do you want to continue or go back and change loadout? \n1. change and reroll\n2. continue");
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
                                    tutorial = 1;
                                    Console.Clear();
                                    (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                }
                            }


                        }
                    }
                }
            }




            Console.WriteLine("In my RPG world, you will play as a man that owns an apple farm. But one day the King that lives next to him steals all of his apple trees and put it inside his dungeon.");
            Console.WriteLine("Your objective is to sneak into the dungeon and fight all the knights to retrieve your apple trees. But be careful, the villagers who live in inside the Kings Kingdom says that they hear some mysterious and scary sounds.");
            Console.WriteLine(" You need to defeat enemies to level up and upgrade your character. You can also take their weapon for better attacks.");
            Console.WriteLine("You can also earn coins from enemies or chests to buy stuff from the blacksmith for better weapons.");
            Console.WriteLine("You could also just plant the apple seeds in your house but whats the fun in that?");
            Console.WriteLine("Your Hit point is = " + health);
            Console.WriteLine("Your Damage point is = " + attackvalue);
            Console.WriteLine("Your Luck point is = " + Luck);
            Console.WriteLine("Go to intro to start the game");
            Console.WriteLine("Press enter to Continue");
            Console.ReadLine();
            Console.WriteLine("ADOAWDIAWDAWDAWDVGFADADYIWDAWDAWDADWDDAWD");
            Console.Clear();
            while (mainmenu == true)
            {
                Console.Clear();
                Console.WriteLine("1. Intro");
                Console.WriteLine("2. Stats");
                Console.WriteLine("3. Credits");
                if (tutorial == 1)
                {
                    Console.WriteLine("4. Change Name");
                    Console.WriteLine("5. Fight");
                    Console.WriteLine("6. Lunch with Sonic");
                    Console.WriteLine("\n7. Start game\n8. Inventory");

                }
                string answermenu = Console.ReadLine();
                if (answermenu == "1")
                {
                    Console.WriteLine(@"                T\ T\");
                    Console.WriteLine(@"                | \| \");
                    Console.WriteLine(@"                |  |  :");
                    Console.WriteLine(@"           _____I__I  |");
                    Console.WriteLine(@"         .'            '.");
                    Console.WriteLine(@"       .'                '");
                    Console.WriteLine(@"       |   ..             '");
                    Console.WriteLine(@"       |  /__.            |");
                    Console.WriteLine(@"       :.' -'             |");
                    Console.WriteLine(@"      /__.                |");
                    Console.WriteLine(@"     /__, \               |");
                    Console.WriteLine(@"        |__\        _|    |");
                    Console.WriteLine(@"        :  '\     .'|     |");
                    Console.WriteLine(@"        |___|_,,,/  |     |    _..--.");
                    Console.WriteLine(@"     ,--_-   |     /'      \../ /  /\\");
                    Console.WriteLine(@"    ,'|_ I---|    7    ,,,_/ / ,  / _\\");
                    Console.WriteLine(@"  ,-- 7 \|  / ___..,,/   /  ,  ,_/   '-----.");
                    Console.WriteLine(@" /   ,   \  |/  ,____,,,__,,__/            '\");
                    Console.WriteLine(@",   ,     \__,,/                             |");
                    Console.WriteLine(@"| '.       _..---.._                         !.");
                    Console.WriteLine(@"! |      .' z_M__s. '.                        |");
                    Console.WriteLine(@".:'      | (-_ _--')  :          L            !");
                    Console.WriteLine(@".'.       '.  Y    _.'             \,         :");
                    Console.WriteLine(@" .          '-----'                 !          .");
                    Console.WriteLine(@" .           /  \                   .          .");
                    Console.ReadLine();
                    Console.Clear();


                }
                if (answermenu == "2")
                {
                    Console.WriteLine("Your current HP is " + health + ".");
                    Console.WriteLine("Your current DP is " + damage + ".");
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
                    Console.WriteLine("your current name is: " + name + ".");
                    Console.WriteLine("Type your name here");
                    name = Console.ReadLine();
                    Console.WriteLine("Your new name is " + name + ".");
                    Console.ReadLine();
                    start4 = false;
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
                        Console.WriteLine("You currently have " + health + " HP.");
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
                                    attackvalue = attackvalue * 1.25;
                                    Console.WriteLine("That was a critical hit!");
                                    enemyhp -= damage;
                                    attackvalue = attackvalue * 0.8;
                                }
                                else
                                {
                                    enemyhp -= attackvalue;
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
                                    health -= enemyattackincome = enemyattack.Next(attackmin, attackmax);
                                    Console.WriteLine("Your HP is currently at " + health + "!");
                                    if (health <= 0)
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
                                double defendattack = enemyattack.Next(attackmin, attackmax) * 0.25;
                                double defendhealth = health -= defendattack;
                                Console.WriteLine("The enemy did " + defendattack + " damage!");
                                Console.WriteLine("Your HP is now " + health + "!");
                                Console.WriteLine("Ultimate charged by 1.");
                                if (health <= 0)
                                {
                                    fighting = false;
                                    combat = false;
                                    lose += 1;
                                    health = 5;
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
                                    double ultimate = damage * 3.75;
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
                                damage = damage * 0.05 + damage;
                                health = health * 0.05 + health;
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            weaponworld1 = rng.Next(weaponworld1min, weaponworld1max);
                            string weaponnameworld1 = string.Empty;
                            Console.WriteLine($"The enemy dropped a weapon!");
                            Console.WriteLine("Pick up? \n1.Yes\n2.No");
                            string pickupanswer = Console.ReadLine();
                            if (pickupanswer == "1")
                            {
                                if (weaponworld1 == 1)
                                {
                                    weaponnameworld1 = "Wooden Sword";
                                    if (weaponcurrent < 1)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 1)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 1)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 1;
                                        weaponcurrent = 1;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid1 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 2)
                                {
                                    weaponnameworld1 = "Slingshot";
                                    if (weaponcurrent < 1)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 1)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 1)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 9;
                                        weaponcurrent = 1;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid9 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 3)
                                {
                                    weaponnameworld1 = "Wooden Spear";
                                    if (weaponcurrent < 1)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 1)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 1)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 4;
                                        weaponcurrent = 1;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid4 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 4)
                                {
                                    weaponnameworld1 = "Iron Sword";
                                    if (weaponcurrent < 2)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 2)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 2)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 2;
                                        weaponcurrent = 2;
                                        Console.WriteLine("Item selected.");

                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid2 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }

                                }
                                if (weaponworld1 == 5)
                                {
                                    weaponnameworld1 = "Steelshot";
                                    if (weaponcurrent < 2)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 2)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 2)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 10;
                                        weaponcurrent = 2;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid10 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 6)
                                {
                                    weaponnameworld1 = "Iron Spear";
                                    if (weaponcurrent < 2)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 2)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 2)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 5;
                                        weaponcurrent = 2;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid5 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 7)
                                {
                                    weaponnameworld1 = "Steel Sword";
                                    if (weaponcurrent < 3)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 3)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 3)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 3;
                                        weaponcurrent = 3;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid3 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 8)
                                {
                                    weaponnameworld1 = "Bow";
                                    if (weaponcurrent < 3)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 3)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 3)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 8;
                                        weaponcurrent = 3;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid8 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                }
                                if (weaponworld1 == 9)
                                {
                                    weaponnameworld1 = "Steel Spear";
                                    if (weaponcurrent < 3)
                                    {
                                        Console.WriteLine("This weapon does less damage than what you have!");
                                    }
                                    if (weaponcurrent == 3)
                                    {
                                        Console.WriteLine("This weapon does the same damage than what you have!");
                                    }
                                    if (weaponcurrent > 3)
                                    {
                                        Console.WriteLine("This weapon does more damage than what you have!");
                                    }
                                    Console.WriteLine("Are you sure? \n1.Yes\n2.No");
                                    string pickupansweralt = Console.ReadLine();
                                    if (pickupansweralt == "1")
                                    {
                                        weaponid = 6;
                                        weaponcurrent = 3;
                                        Console.WriteLine("Item selected.");
                                        (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                        weaponcheckid6 = 1;
                                    }
                                    if (pickupansweralt == "2")
                                    {
                                        Console.WriteLine("Item ignored.");
                                    }
                                    Console.WriteLine("Press Enter to continue");
                                    Console.ReadLine();
                                    Console.Clear();
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
                                    Console.WriteLine("You ran away! \n0 EXP EARNED");
                                    Console.ReadLine();
                                }
                                Console.Clear();
                                Console.WriteLine("Welcome back");
                                Console.ReadLine();
                            }



                        }

                    }
                    while (losewin == 0);
                    losewin = 0;
                    if (answermenu == "6")
                    {
                        int boss = 0;
                        string enemyboss = "Sonic";
                        enemyhp = 50;
                        double bossattackincome = enemyattackincome * 1;
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
                        Console.WriteLine("You currently have " + health + " HP.");
                        Console.WriteLine("The " + enemyboss + " has " + enemyhp + " HP.");
                        do
                        {
                            fighting = true;
                            Console.WriteLine("1. ATTACK       2. DEFEND     3. FLEE       4. ULTIMATE (" + bigattack + "/5)");
                            string response = Console.ReadLine();
                            if (response == "1")
                            {
                                critical = rnd.Next(critmin, critmax);
                                if (critical < Luck)
                                {
                                    attackvalue = attackvalue * 1.25;
                                    Console.WriteLine("That was a critical hit!");
                                    enemyhp -= damage;
                                    attackvalue = attackvalue * 0.8;
                                }
                                else
                                {
                                    enemyhp -= attackvalue;
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
                                    Console.WriteLine("Sonic used sneeze!");
                                    Console.WriteLine("The " + enemyboss + " did " + bossattackincome + " damage!");
                                    health -= bossattackincome;
                                    Console.WriteLine("Your HP is currently at " + health + "!");
                                    if (health <= 0)
                                    {
                                        fighting = false;
                                        combat = false;
                                        lose += 1;
                                        health = 5;
                                        break;
                                    }
                                    fighting = false;
                                }
                            }
                            if (response == "2")
                            {
                                double defendattack = bossattackincome * 0.25;
                                double defendhealth = health -= defendattack;
                                Console.WriteLine("The enemy did " + defendattack + " damage!");
                                Console.WriteLine("Your HP is now " + health + "!");
                                Console.WriteLine("Ultimate charged by 1.");
                                if (health <= 0)
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
                            }
                            if (response == "4")
                            {
                                if (bigattack > 4)
                                {
                                    double ultimate = damage * 3.75;
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
                                damage = damage * 0.05 + damage;
                                health = health * 0.05 + health;
                            }
                            Console.WriteLine("Sonic dropped a weapon!");
                            /* Weapon needed here */
                            Console.WriteLine("Pick it up? \n y/n");
                            string answersonic = Console.ReadLine();
                            if (answersonic == "y")
                            {
                                weaponid = 5;
                                (weaponName, attackvalue, weaponidchecker1, weaponidchecker2, weaponidchecker3, weaponidchecker4, weaponidchecker5, weaponidchecker6, weaponidchecker7, weaponidchecker8, weaponidchecker9, weaponidchecker10) = Weapon(weaponid, weaponname, attackvalue, damage, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
                                weaponcheckid5 = 1;
                            }
                            if (answersonic == "n")
                            {

                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();

                        }
                        if (lose != 0)
                        {
                            Console.WriteLine("You lost! \n0 EXP EARNED");
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
                        while (losewin == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome back");
                            losewin = 0;
                            Console.ReadLine();
                            combat = true;
                        }

                    }
                    
                    /* Inventory selection */
                    /* WEAPONS SWORDS
            * 
            * 1.Wooden Sword
            * 2.Iron Sword         
            * 3.Steel Sword
            * 4.Fire Sword
            * 5.FIre Blade
            * 6.Lava Blade
            * 7.Volcano
            * 8.The Destructer
            * WEAPONS SLINGSHOT
            * 
            *9. Slingshot
            * 10.Steelshot
            * 11.Bow
            * 12.Crossbow
            * 13.Pickle Launcher
            * 14.Fat Man
            * 15.Scar-L
            * 16. Ragnarok
            * WEAPON SPEAR
            * 
            * 17.Wooden Spear
            * 18.Iron Spear
            * 19.Steel Spear
            * 20.Ice Spear
            * 21.Ice Cube
            * 22.Galcier
            * 23.Niflheim
            * 24. Wand of Ullr
            * ITEM FRUITS
            * 
            * 1.Apple - heals your character by 30%
            * 2.Pear - Reduce enemy dp by 15% for 8 turns
            * 3.Durian - Increases your attack by 20%
            * 4.Dragon Fruit - Every attack for 5 turns does fire damages
            * 5.Passion Fruit - Increases luck by 30%
            * 6.Banana - Chance to slip and loose a turn
            * 7.Strawberry - heals you by 50% but lose 10% attack for 5 turns
            * 8.Tomato - Heals you by 20% but makes you flee
            * 9.Raspberry - heals your character by 10%
            * 10.Rotten Apple - Makes player lose 50 health each turn
            * 11.Wild Berry - Reduce enemy dp by 40% but for only 3 turns
            * 12.Blueberry - Heals your character by 5%
            * 13.ITEM Drinks
            * 
            * 14.Chug Jug - Heals you by 75% but enemy gets a free hit
            * 15.Slurp Juice - Heals you by 10% for 4 turns
            * 16.Mini Pot - Heals you by 25%
            * 17.Guzzle Juice - Double Attack for 1 turn
            * 18.Water - Feels refreshing. Heals you by 10%
            * 19.Coconut - Somewhat refreshing. Heals you by 5%
            * 20.Prime - MORE ENERGY MORE POWER Increases your attack by 45% for only 1 attack
            * 21.Nicholas's Milk - Increases attack for 1 turn by 75%
            * 22.Monster Energy - Concentration up! Double Damage for 1 turn
            * 23.Keagan's Milk - Clones you 2 times. TRIPLE DAMAGE
            * 24.Ice Tea - relax and lose a turn
            * 25.ITEM GENERAL
            * .
            * 26.Xbox Controller - Turn on aim assist and half their health (only works with normal enemies)
            * 27.Nintendo Switch - Control the enemy and make him suffer. (Chance to insta kill)
            * 28.Pencil - Stab them to do 15 damage
            * 29.Tape - Blind their eyes. Get another turn
            * 30.Hustlers Notebook - Double the exp you earn from this battle (excluding boss fights)
            * 31.Keagans Laptop - Use his big cursor to enhance your attack by 50%
            * 32.Quagmires laugh - His laugh will make the enemy stunned. Get another turn.
            * 33.ARMOR
            * .
            * .World 1
            * 1.Leather - 5% more health
            * 2.Iron 10% more health
            * 3.Steel 15% more health
            * .World 2
            * 4.Keagan - 20% more health
            * 5.Shield of Faith 25% more health
            * 6.Relentless Vest of the Breaking Storm 30% more health
            * .World 3
            * 7.Nikocado - no need for armor when you got fat, 75% more health
            * 8.Boulder - Wear the boulder, become the boulder 80% more health
            * 9.Eliots Rizz - 85% more health
            * 1.World 4
            * 10.Shepherd of Fury - 140% more health
            * 11.Adamantite Cuirass of Fleeting Punishment - 145% more health
            * 12.Spite Titanium Tunic - 150% more health
            * 13.Yannick - 155% more health
            * 14.Plot Armor - hp what for? 500000% more health
            */
                    /* Item od */

                }
                if (answermenu == "7")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Water or Milk?");
                    string answermilk = Console.ReadLine();
                    if (answermilk == "Water")
                    {
                        Console.WriteLine("valid");
                    }
                    if (answermilk == "Milk")
                    {
                        Console.WriteLine("valid");
                    }
                }
                if (answermenu == "8")
                {
                    playerinv = true;
                    while (playerinv == true)
                    {
                        Console.WriteLine("Hello " + name + "!");
                        Console.WriteLine($"Your current weapon is {weaponName} Your weapon currently does {attackvalue} damage.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;

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
        static (string, double, int, int, int, int, int, int, int, int, int, int) Weapon(int weaponid, string weaponname, double attackvalue, double damage, int weaponcheckid1, int weaponcheckid2, int weaponcheckid3, int weaponcheckid4, int weaponcheckid5, int weaponcheckid6, int weaponcheckid7, int weaponcheckid8, int weaponcheckid9, int weaponcheckid10)
        {
            if (weaponid == 0)
            {
                weaponname = "Fist";
            }
            else if (weaponid == 1)
            {
                weaponname = "Wooden Sword";
                if (weaponcheckid1 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid1 = 1;
                }
            }
            else if (weaponid == 2)
            {
                weaponname = "Iron Sword";
                if (weaponcheckid2 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid2 = 1;
                }
            }
            else if (weaponid == 3)
            {
                weaponname = "Steel Sword";
                if (weaponcheckid3 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid3 = 1;
                }
            }
            else if (weaponid == 4)
            {
                weaponname = "Wooden Spear";
                if (weaponcheckid4 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid4 = 1;
                }
            }
            else if (weaponid == 5)
            {
                weaponname = "Iron Spear";
                if (weaponcheckid5 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid5 = 1;
                }
            }
            else if (weaponid == 6)
            {
                weaponname = "Steel Spear";
                if (weaponcheckid6 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid6 = 1;
                }
            }
            else if (weaponid == 7)
            {
                weaponname = "Volcano";
                if (weaponcheckid7 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid7 = 1;
                }
            }
            else if (weaponid == 8)
            {
                weaponname = "Bow";
                if (weaponcheckid8 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid8 = 1;
                }
            }
            else if (weaponid == 9)
            {
                weaponname = "Slingshot";
                if (weaponcheckid9 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid9 = 1;
                }
            }
            else if (weaponid == 10)
            {
                weaponname = "Steelshot";
                if (weaponcheckid10 > 1)
                {
                    attackvalue = damage * 1.25;
                    weaponcheckid10 = 1;
                }
            }
            return (weaponname, attackvalue, weaponcheckid1, weaponcheckid2, weaponcheckid3, weaponcheckid4, weaponcheckid5, weaponcheckid6, weaponcheckid7, weaponcheckid8, weaponcheckid9, weaponcheckid10);
        }
    }
}