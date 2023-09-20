namespace RPG小游戏
{
    internal class Character
    {
        //角色数值
        private int blood;
        private int energy;
        private int shield;
        private int attack;
        private string name; 
        private int speed;//闪避系统
        //初始化角色数值
        public Character() 
        {
            blood = 100;
            energy = 100;
            shield = 0;
            attack = 10;
            speed = 20;
            Console.Write("请输入角色名称：");
            name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "八十一";
            }
            Console.WriteLine($"创建了默认角色 {this.name}");
            Console.WriteLine("角色属性：");
            Console.WriteLine($"血量：{blood}");
            Console.WriteLine($"能量：{energy}");
            Console.WriteLine($"防御：{shield}");
            Console.WriteLine($"攻击力:{attack}");
        }
        //外部访问角色数值
        public int Blood
        {
            get { return blood; }
            set { blood = value; }
        }

        public int Energy
        { 
            get { return energy; } 
            set {  energy = value; } 
        }

        public int Shield
        { 
            get { return shield; } 
            set {  shield = value; }
        }
        public int Attack
        { 
            get { return attack; } 
            set {  attack = value; } 
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        //角色行为

        //角色攻击方法
        public void Do_Attack(Enemies enemy)
        {
            //缺少异常处理
            if( enemy.Blood <= 0 | enemy.Shield < 0)
            {
                Console.WriteLine("角色属性错误");
            }
            this.Energy -= 10;
            //闪避规则，速度越高
            Random random = new Random(); 
            int randomNum = random.Next(1, this.Speed);
            if ( randomNum > enemy.Speed ) 
            {
                Console.WriteLine($"攻击成功，造成{this.Attack - enemy.Shield / 2}点伤害");
                enemy.Blood = enemy.Blood - this.attack + enemy.Shield / 2;//这里需要做血量和伤害大小的非负判断
                Console.WriteLine($"现在怪物还有{enemy.Blood}点血");
            }
            else
            {
                Console.WriteLine("攻击被躲闪");
            }
            
        }
        public void Command(int CommandNum,Enemies enemy)
        {
            if (CommandNum == 1)
            {
                Do_Attack(enemy);
                //调用攻击方法
            }
            else if (CommandNum == 2)
            {
                //调用道具方法
            }
            else if (CommandNum == 3)
            {
                //调用逃跑方法
            }
        }
    }
}
