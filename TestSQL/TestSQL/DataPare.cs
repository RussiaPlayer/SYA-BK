namespace TestSQL
{
    public class DataPare<F,S>
    {
        public F first { get; set; }
        public S second { get; set; }

        public DataPare(F first, S second)
        {
            this.first = first;
            this.second = second;
        }
    }
}