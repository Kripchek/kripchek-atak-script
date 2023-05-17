using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            float p = 40;
            float mpp = 30;
            float pdmg = 16;
            float pdef = 12;
            float m = 25;
            float mdmg = 18;
            float mdef = 5;
            float toPdmg = mdmg / pdef;
            float toMdmg = pdmg / mdef;
            float Php = p - toPdmg;
            float Mhp = m - toMdmg;
            float tohilP = 4;

            float Playerhp = 40;
            float Monsterhp = 25;
                Console.WriteLine("суммарный урон по игроку");
            float sumPDmg = toPdmg;
            Console.WriteLine(sumPDmg);
                Console.WriteLine("суммарный урон по монстру");
            float sumMDmg = toMdmg;
            Console.WriteLine(sumMDmg);
            
            Console.WriteLine("Начало боя");
            while (Playerhp > 0 && Monsterhp > 0)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("новый ход");
                Console.WriteLine("__________________");
                Console.WriteLine("ваша мана восстановлена на 3 ед.");
                mpp += 3;
                Console.WriteLine("Мана персонажа: " + mpp);
                Console.WriteLine("__________________");
                Console.WriteLine("Выберите действие которое хотите использовать:1 - атака, 2 - магия, 3 - лечение");
                Console.WriteLine("__________________");
                int modescroll = int.Parse(Console.ReadLine());
                switch (modescroll)
                {
                    case 1: 
                Console.WriteLine("__________________");
                        Console.WriteLine("Вы использовали атаку");
                Console.WriteLine("__________________");
                        Console.WriteLine("Вы нанесли монстру: " + toMdmg);
                Console.WriteLine("__________________");
                        Console.WriteLine("Здоровье Монстров");
                        Monsterhp -= toMdmg;
                        Console.WriteLine(Monsterhp);

                Console.WriteLine("__________________");
                        Console.WriteLine("Монстр вам нанес: " + toPdmg);
                Console.WriteLine("__________________");
                        Console.WriteLine("Здоровье игрока");
                        Playerhp -= toPdmg;
                        Console.WriteLine(Playerhp);

                        
                        break;
                    case 2:
                Console.WriteLine("__________________");
                        Console.WriteLine("Выберите навык который хотие использовать:1 - Fireball; 2 - Shadow Dance; 3 - First Strike;" +
           " 4 - Reverse Polarity; 5 - Charge of Darkness");
                        int modeskill = int.Parse(Console.ReadLine());
                        switch (modeskill)
                        {
                            case 1:
                Console.WriteLine("__________________");
                                Console.WriteLine("вы выбрали fireball");                    
                                mpp -= 5;
                                Console.WriteLine("вы потратили 5 маны");
                                Console.WriteLine("Вы нанесли монстру: 5 ед. урона") ;
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье Монстров");
                                Monsterhp -= 5;
                                Console.WriteLine(Monsterhp);
                Console.WriteLine("______");
                                Console.WriteLine("Монстр вам нанес: " + toPdmg);
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье игрока");
                                Playerhp -= toPdmg;
                                Console.WriteLine(Playerhp);
                                Console.WriteLine("Мана персонажа: " + mpp);
                Console.WriteLine("__________________");
                                break;
                            case 2: 
                Console.WriteLine("__________________");
                                Console.WriteLine("вы выбрали shadow dance");
                                mpp -= 7;
                                Console.WriteLine("вы потратили 7 маны");
                                Console.WriteLine("Вы нанесли монстру: 2 ед. урона");
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье Монстров");
                                Monsterhp -= 2;
                                Console.WriteLine(Monsterhp);
                                Playerhp += 2;
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье персонажа вылечено на: 2" );
                                Console.WriteLine("Здоровье персонажа: " +Playerhp);
                Console.WriteLine("______");
                                Console.WriteLine("Монстр вам нанес: " + toPdmg);
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье игрока");
                                Playerhp -= toPdmg;
                                Console.WriteLine(Playerhp);
                                Console.WriteLine("Мана персонажа: " + mpp);
                Console.WriteLine("__________________");
                                break;
                            case 3:
                Console.WriteLine("__________________");
                                Console.WriteLine("вы выбрали first strike");
                                mpp -= 8;
                                Console.WriteLine("вы потратили 8 маны");
                                Console.WriteLine("Вы нанесли монстру: 6");
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье Монстров");
                                Monsterhp -= 6;
                                Console.WriteLine(Monsterhp);

                Console.WriteLine("______");
                                Console.WriteLine("Монстр вам нанес: " + toPdmg);
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье игрока");
                                Playerhp -= toPdmg;
                                Console.WriteLine(Playerhp);
                                Console.WriteLine("Мана персонажа: " + mpp);
                Console.WriteLine("__________________");
                                break;
                            case 4:
                Console.WriteLine("__________________");
                                Console.WriteLine("вы выбрали reverse polarity");
                                mpp -= 13;
                                Console.WriteLine("вы потратили 13 маны");
                                Console.WriteLine("вы оглушили врага и нанесли ему 3 ед.урона");
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье Монстров");
                                Monsterhp -= 3;
                                Console.WriteLine(Monsterhp);
                                Console.WriteLine("Здоровье игрока");
                                Console.WriteLine(Playerhp);
                                Console.WriteLine("Мана персонажа: " + mpp);
                Console.WriteLine("__________________");
                                break;
                            case 5:
                Console.WriteLine("__________________");
                                Console.WriteLine("вы выбрали charge of darkness");
                                mpp -= 1;
                                Console.WriteLine("вы потратили 1 маны");
                                Console.WriteLine("вы оглушили врага и нанесли ему 30 ед.урона");
                Console.WriteLine("______");
                                Console.WriteLine("Здоровье Монстров");
                                Monsterhp -= 30;
                                Console.WriteLine(Monsterhp);
                                Console.WriteLine("Здоровье игрока");
                                Console.WriteLine(Playerhp);
                                Console.WriteLine("Мана персонажа: " + mpp);
                Console.WriteLine("__________________");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("__________________");
                        Console.WriteLine("вы использовали лечение");
                        Playerhp += tohilP;
                        Console.WriteLine("______");
                        Console.WriteLine("Здоровье персонажа вылечено на: " + tohilP);
                        Console.WriteLine("______");
                        Console.WriteLine("Здоровье персонажа: " + Playerhp);
                        Console.WriteLine("______");
                        Console.WriteLine("Монстр вам нанес: " + toPdmg);
                        Playerhp -= toPdmg;
                        Console.WriteLine("______");
                        Console.WriteLine("Здоровье персонажа: " + Playerhp);
                        Console.WriteLine("__________________");
                        break;
                }
           
                Console.WriteLine("==================================");
            }
            Console.WriteLine("Итоги битвы:");
            Console.WriteLine("Здоровье оставшееся у Игрока: " + Playerhp);
            Console.WriteLine("Здоровье оставшееся у Монстра " + Monsterhp);
            Console.WriteLine("Урон нанесеный Игроком: " + sumMDmg);
            Console.WriteLine("Урон нанесеный Монстром: " + sumPDmg);
            Console.ReadKey();
        }
    }
}
