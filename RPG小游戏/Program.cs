// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

namespace RPG小游戏
{
    class Program
    {
       public static void Main(string[] args)
        {
            int commandNum;
            Character character = new Character();
            CommonCommand command = new CommonCommand();
            while(true)
            {
                Console.WriteLine("指令：1、冒险探索；2、购买道具");
                Console.WriteLine("请输入指令");
                string input = Console.ReadLine();
                input = input.Length > 0 ? input : "114514";
                commandNum = Convert.ToInt32(input);


                command.CommandChoice(commandNum,character);

            }
        }
    }
    class CommonCommand
    {
        public void CommandChoice(int CommandNum,Character character)
        {

            switch (CommandNum)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("开始冒险探索");
                    this.Adventure(character);
                    break;
                case 2:
                    Console.Clear();
                    this.Shop(character);
                    break;
                case 114514:
                    Console.Clear();
                    break;//防止空输入
            }
        }
        public void Adventure(Character character)
        {
            //用于探索，具备触发怪物，获取道具功能
            Random random = new Random();
            int chance = random.Next(1, 10);
            if(chance <= 5)
            {
                Enemies enemy = new Enemies();                    
                Console.WriteLine("遇到怪物，进入战斗");
                while (enemy.Blood > 0)
                {

                    Console.WriteLine($"目前怪物有 {enemy.Blood} 点血");
                    Console.WriteLine("战斗指令：1、攻击");
                    string? commandInput = Console.ReadLine();
                    commandInput = commandInput.Length > 0 ? commandInput : "114514";
                    int CommandNum = Convert.ToInt32(commandInput??"114514");
                    character.Command(CommandNum, enemy); }
                Console.WriteLine("怪物被击败，点击任意键继续");
                Console.ReadKey();
                Console.Clear();
                //怪物被击败怎么能没有战利品
            }
            else
            {
                Console.WriteLine("没有发现什么，点击任意键继续");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Shop(Character character)
        {
            //用于购买道具
        }

    }

}
