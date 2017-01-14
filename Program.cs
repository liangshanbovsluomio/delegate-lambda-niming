using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托_匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal("老鹰","俯冲抓捕猎物");
            ani.eatFood = EagleEat;
            ani.Eating();

            //使用匿名方法及Lambda表达式好处：
            //1.当方法只是临时使用则没必要另外开辟 
            //2.有些方法可能要写在别的文件，不如匿名方法方便检测
            Animal ani2 = new Animal("毒蛇", "用剧毒麻痹猎物");
            ani2.eatFood = (Animal a) =>
            {
                Console.WriteLine("我是{0},我会{1},我吃青蛙", a.Type, a.Jineng);
            };
            ani2.Eating();
        
            
        }
        public static void EagleEat(Animal a)
        {
            Console.WriteLine("我是{0},我会{1},我吃肉",a.Type,a.Jineng);
        }
    }
}
