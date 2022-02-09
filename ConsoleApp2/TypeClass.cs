namespace ConsoleApp2
{
    public class TypeClass : Test
    {
        public TypeClass() : base(typeof(TypeClass))
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}