namespace LearningDataTypes
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //string refers to phrases
            string variableOne = "This is a string phrase and here is some random info - ";
            string variableTwo = "John is ";
            string variableThree = " and he has $";

            //bool is a boolean and can be true or false;
            bool isMale = true;


            //int refers to an integer (whole number)
            int wholeNumberVariable = 69;

            //float - double - decimal all can have decimals with decimal being the most accurate, and float being the least. 
            double moneyVariable = 42.56;

            Console.WriteLine(variableOne + variableTwo + wholeNumberVariable + variableThree + moneyVariable);
        }
    }
}

