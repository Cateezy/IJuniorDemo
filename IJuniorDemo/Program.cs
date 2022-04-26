using System;

namespace IJuniorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 1000;
            int enemyHealth = 1600;
            int damage = 50;
            int enemyDamage = 60;
            int manaPool = 500;
            int spiritsInvokeManaCost = 100;
            int volleyManaCost = 200;
            int stunManaCost = 200;
            int stunTimer = 0;
            bool isSpiritsActive = false;
            int playerChoose;

            while (health > 0 && enemyHealth > 0)
            {

                if (manaPool > 0)
                {
                    Console.WriteLine($"Введите 1, чтобы призвать духов которые повысят урон на 20 и позволят использовать Залп, маны потратится: {spiritsInvokeManaCost}");
                    Console.WriteLine($"Введите 2, чтобы сделать Залп совместно с духами, который нанесет 350 урона, маны потратится: {volleyManaCost}");
                    Console.WriteLine($"Введите 3, чтобы застанить босса на 2 удара, маны потратится: {stunManaCost}");
                    Console.WriteLine($"Отавшаяся мана: {manaPool}");
                    playerChoose = Convert.ToInt32(Console.ReadLine());

                    if (playerChoose == 1 && isSpiritsActive == false)
                    {
                        manaPool -= spiritsInvokeManaCost;
                        isSpiritsActive = true;
                        damage += 20;
                    }
                    else if (playerChoose == 1 && isSpiritsActive == true)
                    {
                        Console.WriteLine("Духи уже активны!");
                    }

                    if (isSpiritsActive == true && playerChoose == 2)
                    {
                        manaPool -= volleyManaCost;
                        enemyHealth -= 350;
                    }
                    else if (isSpiritsActive == false && playerChoose == 2)
                    {
                        Console.WriteLine("Духи не активны, невозможно использовать заклинание");
                    }

                    if (playerChoose == 3)
                    {
                        manaPool -= stunManaCost;
                        stunTimer = 2;
                    }

                }

                if (stunTimer == 0)
                {
                    health -= enemyDamage;
                }
                else
                {
                    stunTimer--;
                }

                enemyHealth -= damage;
                Console.WriteLine($"Здоровье героя: {health}\nЗдоровье босса: {enemyHealth}");

            }

            if (health <= 0)
            {
                Console.WriteLine("Победил босс!");
            }

            if (enemyHealth <= 0)
            {
                Console.WriteLine("Победил герой!");
            }
        }
    }
}
