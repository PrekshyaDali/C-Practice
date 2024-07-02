using System;

namespace datatypes
{
    class Hello
    {
        public void TestFunction()
        {
            // Char data type
            char grade = 'A';

            // Integer data type
            int age = 30;

            // Float data type
            float price = 19.99F;

            // Double data type
            double distance = 12345.6789D;

            // Decimal data type
            // these are used for the high precision, suitable financial and monetary calculations
            decimal salary = 1000.50M;

            // for the boolean value
            bool isBooltrue = true;
            // this question mark will represent the nullable integer
            int? a = null;
            int? b = a ?? 20;
            Console.WriteLine($"a: {b}");
            // DateTime data type
            DateTime currentDate = DateTime.Now;

            // using the if-else
            if (a == null)
            {
                Console.WriteLine("A is a nullable integer");
            }
            else
            {
                Console.WriteLine("A is not a nullabe");
            }

            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Distance: {distance}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Current Date: {currentDate}");
            Console.WriteLine($"Boolean value: {isBooltrue}");
        }

        public void Conditional()

        {
            // if statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }


            // if-else statement
            int number_one = -5;
            if (number_one > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is not positive.");
            }


            // nested if
            int number_three = 15;

            if (number_three > 0)
            {
                Console.WriteLine("The number is positive.");

                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("The number is not positive.");
            }


            // if-else-if
            int marks = 85;

            if (marks >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }



        }


        public void SwitchCase()
        {
            int dayOfWeek = 3;

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }


        }

        // switchcase with condition
        // switchcase with or is used to check for the multiple cases
        public void switch_or
        ()
        {
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                case 'B':
                case 'C':
                    Console.WriteLine("Pass grade");
                    break;
                case 'D':
                case 'E':
                case 'F':
                    Console.WriteLine("Fail grade");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

        }


        public void forLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am printint it 10 times");
            }
        }

        public void forEachLoop()
        {
            // var allows the compiler to determine the appropriate type based on the initialization expression, 
            List<string> names = new List<string> { "prekshya", "Shreya", "Sijan" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }


        // using the while loop
        public void whileLoop()
        {
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("This is example of while loop");
                count++;
            }
        }


        public void BreakContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("the loop at i = 5 will break");
                    break;
                }

                if (i % 2 == 0)
                {
                    Console.WriteLine($"Skipping the even number: {i}");
                    continue; // Skip the rest of the loop body for even numbers
                }

                Console.WriteLine($"Iteration {i}");
            }
        }


        //for type casting
        // in this type of casting . converting integer to double there is no significatn dataloss  
        // WHICH is why it is converted by the compiler itself
        public void ImplicitConversion()
        {
            int intValue = 100;
            double doubleValue = intValue;
        }

        // for explicit conversion
        // here in such case , the case opertor (int) will denote that the conversion is explicit

        public void ExplicitConversion()
        {
            double doubleValue = 7.56;
            int intValue = (int)doubleValue;

        }


        public void ConversionMethods()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }


        //    making a list
        public void List()
        {
            // this is for the list initialization
            List<int> numbers = new List<int>();

            // now adding in the list members
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Console.WriteLine(numbers);
        }


        // Add list to list
        public void AddingList()
        {
            List<int> firstlist = new List<int> { 1, 2, 3, 4 };
            List<int> secondlist = new List<int> { 5, 6, 7 };

            // adding the second list to the first list
            firstlist.AddRange(secondlist);
            foreach (var number in firstlist)
            {
                Console.WriteLine(number);
            }
            List<int> output = firstlist.FindAll(num => num > 4);
            Console.WriteLine("Elements greater than 5:");
            // to print out the list always use the foreach loop
            foreach (var number in output)
            {
                Console.WriteLine(number);
            }
        }

        // finding an element in list
        public void findElement()
        {
           try{
             List<string> names = new List<string> { "Prekshya", "Bitisha", "Avantika" };
            string result = names.Find(name => name.StartsWith("P"));

            if (result != null)
            {
                Console.WriteLine($"Found element: {result}");
            }
            else
            {
                Console.WriteLine("the element is not found");
            }
           }catch(Exception e){
            Console.WriteLine("error is occuring", e);
           }

        }
    }
}
