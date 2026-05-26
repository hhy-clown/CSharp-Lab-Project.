namespace CSharpLab
{
    class Program
    {
        static void Main()
        {
            MathUtils mathUtils;//DSADSA
            global::System.Console.WriteLine(mathUtils.MathUtils());
        }
    }
    public class MathUtils
    {
        public int x;
        public int y;
        public MathUtils(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void MathUtils()
        {
            return x + y;
        }
    }
}
}