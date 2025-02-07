namespace DIKUCanteen
{
    public class Student : Person
    {
        public bool HasCup { get; private set; }

        public Student(string name, string occupation, int age) : base(name, occupation, age)
        {
            HasCup = false;
        }

        public void TakeCup(Canteen canteen)
        {
            if (!HasCup && canteen.Cups > 0)
            {
                canteen.RemoveCup();
                HasCup = true;
            }
        }

        public void ReturnCup(Canteen canteen)
        {
            if (HasCup)
            {
                canteen.AddCup();
                HasCup = false;
            }
        }
    }
}
