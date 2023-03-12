using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1.OOP
{

   class super_hero_game_character
    {
        public string name;
        public string gender;
        public string nickname;
        public int age;
        public int level = 0;
        public string ablity1;
        public string ablity2;
        public string ablity3;

        public void flying()
        {
            Console.WriteLine("hero is flaying");

        }

        public void smashing()
        {
            Console.WriteLine("hero is smashing villains");

        }

       
         public void using_abilties() 
        
        {
            
            Console.WriteLine("hero is using his abilities to save peoble"); 
        }



        public void levelup()
        {
            Console.WriteLine("level up");

             level ++;
        } 
    
        public void healing() 
        {
            Console.WriteLine(""); 
        }

     public   super_hero_game_character()
        {

        }

  public  super_hero_game_character(string name, string nickname,string gander,int age,int level) 
    
    { 
        this.name = name;
        this.nickname = nickname;
        this.gender = gander;
        this.age = age;
        this.level = level;
    }
    
  public  super_hero_game_character(string ablity1) 
    {
       this .ablity1 = ablity1;
    }
    
    
        public super_hero_game_character(string ability2,string ability3,string ablity1) 
    
    {
        this .ablity2 = ability2;
        this .ablity3 = ability3;
        this .ablity1 = ablity1;
    
    }
    
    
     public super_hero_game_character(int level)
    {
        this.level = level;
    }







    }
    internal class Program
    {
        static void Main(string[] args)
        {

            super_hero_game_character hero1 = new super_hero_game_character();

            hero1.levelup();
            hero1.levelup();
            hero1.levelup();
            Console.WriteLine(hero1.level);



        }
    }
}
