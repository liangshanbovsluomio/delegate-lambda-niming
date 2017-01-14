using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace 委托_匿名方法
{
    public delegate void EatFood(Animal a);
    
    public class Animal
    {
        public Animal() { }
        public Animal(string type,string jineng)
        {
            Type = type;
            Jineng = jineng;
        }
        string type;
        string jineng;

        public string Type { get => type; set => type = value; }
        public string Jineng { get => jineng; set => jineng = value; }

        public EatFood eatFood;

        public void Eating()
        {
            if (eatFood!=null)
            {
                eatFood(this);
            }
        }
    }

    
}