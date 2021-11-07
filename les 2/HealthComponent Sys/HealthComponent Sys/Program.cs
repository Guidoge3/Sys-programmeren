using System;

namespace HealthComponent_Sys
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy healthy = new Enemy();
            healthy.Attack(69); 
        }

        public class Enemy
        {
            int health = 100;


            public void Attack(int damage)
            {
                Console.WriteLine("The enemy health is: " + health);
                Console.WriteLine("wanna punch the enemy? press X");
                ConsoleKeyInfo weirdInfo= Console.ReadKey();
                if (weirdInfo.KeyChar == 'x')
                {
                    Console.Clear();
                    Console.WriteLine("you charge up a punch");
                    Console.WriteLine("you hit! you did :" + damage +" damage");
                    health -= damage;
                    Console.WriteLine("The enemy's remaining health is: " + health);
                    Console.WriteLine("big bonk almost killed it!");
                }
            }
        }
    }
}
