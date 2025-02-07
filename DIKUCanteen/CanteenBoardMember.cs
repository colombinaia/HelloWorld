namespace DIKUCanteen
{
    public class CanteenBoardMember : Student
    {
        public static int CupBudget { get; private set; } = 50;

        public CanteenBoardMember(string name, string occupation, int age) : base(name, occupation, age) { }

        public void BuyCup(Canteen canteen)
        {
            if (CupBudget > 0)
            {
                canteen.AddCup(); // Use the AddCup method instead of directly modifying Cups
                CupBudget--;
            }
        }
    }
}
