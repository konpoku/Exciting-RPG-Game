using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG小游戏
{
    internal class Enemies
    {
        //怪物属性
        private int blood = 100;
        private int shield = 10;
        private int attack = 10;
        private int speed = 5;//闪避系统
        //初始化
        public Enemies() { }
        //属性
        public int Blood
        {
            get { return blood; }
            set { blood = value; }
        }

        public int Shield
        {
            get { return shield; }
            set { shield = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
