using System;

namespace ForeachLoopAndSwitchStatementChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputValueInt;
            bool valid = false;
            string inputValueType;


            Console.Write("Enter any value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");
            Console.Write("Enter datatype: ");

            int inputType = int.Parse(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                        valid = IsAllAlphabetic(inputValue);
                        inputValueType = "String";
                        break;
                case 2:
                        int retValue = 0;
                        valid = int.TryParse(inputValue, out retValue);
                        inputValueType = "Integer";
                        break;
                case 3:
                        bool retFlag = false;
                        valid = bool.TryParse(inputValue, out retFlag);
                        inputValueType = "Boolean";
                        break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("not able to detect input type");
                    break;
            }

            Console.WriteLine($"You have entered a value: {inputValue}");
            if (valid)
            {
                Console.WriteLine($"It is valid: {inputValueType}");
            }
            else
            {
                Console.WriteLine($"It is not valid: {inputValueType}");
            }
        }

        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

//switch (userDatatypeSelection)
//{
//    case 1:
//        int isIntegerCouner = 0;
//        for (int i = 0; i < inputValue.Length; i++)
//        {
//            bool isInteger = int.TryParse(inputValue.Substring(i, 1), out inputValueInt);
//            isIntegerCouner += (isInteger ? 1 : 0);
//        }
//        if (isIntegerCouner > 0)
//        {
//            Console.WriteLine("invalid string");
//        }
//        else
//        {
//            Console.WriteLine("valid string");
//        }
//        break;
//    case 2:
//        {
//            bool isInteger = int.TryParse(inputValue, out inputValueInt);
//            if (isInteger)
//            {
//                Console.WriteLine("valid int");
//            }
//            else
//            {
//                Console.WriteLine("invalid int");
//            }
//            break;
//        }
//    case 3:

//        break;

//    default:

//        Console.WriteLine("incorrect selection");
//        break;
