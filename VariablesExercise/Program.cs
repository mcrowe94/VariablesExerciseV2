namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string
            //int
            //char
            //bool
            //double
            //decimal

            string catName = "Gypsy";
            int catAge = 2;
            char middleInitial = 'S';
            bool isLazy = true;
            double catWeight = 9.5;
            decimal foodPrice = 8.50m;


            Console.WriteLine($"My cat's name is {catName}, her middle initial is {middleInitial} for Sue! She is {catAge} years old and she weighs {catWeight} pounds. It's {isLazy}, she sleeps all day! Her bags of food are ${foodPrice}, she eats all the time so that must be why she's so lazy!");
        }

        
    }
}
