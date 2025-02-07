namespace DIKUCanteen
{
    public class Canteen : Room
    {
        public int Cups { get; private set; }

        public Canteen(string name) : base(name)
        {
            Cups = 100;
        }

        public Canteen(string name, int cups) : base(name)
        {
            Cups = cups;
        }

        public void RemoveCup()
        {
            if (Cups > 0)
            {
                Cups--;
            }
        }

        public void AddCup()
        {
            Cups++;
        }

        public override string ToString()
        {
            return $"{Name} has {Cups} cups.";
        }
    }
}
