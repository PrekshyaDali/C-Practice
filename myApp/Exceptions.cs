using datatypes;
namespace datatypes
{
    public class Exceptions
    {
        public int Age { get; set; }


        public Exceptions(int age)
        {

            Age = age;
        }


        // using try and catch
        public void TryCatch()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // using finally
        // regardless of the result the finally block will execute
        public void Finally()
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("This will execute regardless of the try catch");
            }

        }


        // throw keyword
        public void Throw(){
            if  (Age < 18){
                throw new ArithmeticException("You should be over 18 to have access");

            }
            else{
                Console.WriteLine("You are granted permission for this throw part.");
            }
        }

        //argument exceptions
        public void ArgumentEx(){
            if(Age < 0){
                throw new ArgumentException("The age should be greater than 0");
            }
            else{
                Console.WriteLine("You have passed the Argument Exception");
            }
        }

        
    }
}