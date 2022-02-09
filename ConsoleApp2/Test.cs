using System;

namespace ConsoleApp2
{
    public class Test
    {
        public Type ThisType { get; set; }
        public Test(Type type)
        {
            ThisType = type;
        }

        public virtual string ToString()
        {
            return $"Тип {ThisType.Name}";
        }
    }
}