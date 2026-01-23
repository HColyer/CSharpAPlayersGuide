namespace TheVariableShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables types to store text  
            string name = "Harry"; 
            char firstNameInitail = 'H';      // needs '' instead of "", otherwise computer reads as a string

            // Variable types to store number
            byte byteNumber = 255;      // byte stores a number from 0 to 255, 1 byte
            short shortNumber = 32767;     // short stores a number from -32768 to 32767, 2 byte
            int intNumber = 0;     // int data type store a number from -2,147,483,648 to 2,147,483,647 
            long longNumber = -1200000000000000000;      // Long data type stores a number from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807. 8 Bytes

            sbyte sByteNumber = -127; // signed byte can store a number raging from -128 to 127
            ushort uShortNumber = 30; // unsigned short can store a number from 0 to 65,535
            uint uIntNumber = 4000000000; // unsigned int can store a number from 0 to 4,294,967,295
            ulong uLongNumber = 18446744073709551615; // unsigned long can store a number from 0 to 18,446,744,073,709,551,615

            // Float type numbers (decimal numbers)
            float floatNumber = 2f; //  can store decimal number ranging from ±1.0 × 10**-45 to ±3.4 × 10**38
            double doubleNumber = 0.780000000000000; // can store a decimal number ranging from ±5 × 10**-324 to ±1.7 × 10**308
            decimal decimalNumber = 0.677777m; // can store a decimal number ranging from ±1.0 × 10**-28 to ±7.9 × 10**28
            // Boolean type (true/false)
            bool isAlive = true;

            

            Console.WriteLine(name + " " + firstNameInitail + " " + byteNumber + " " + shortNumber + " " + intNumber + " " + longNumber + " " + sByteNumber + " " + uShortNumber + " " + uIntNumber + " " + uLongNumber + " " + floatNumber + " " + doubleNumber + " " + decimalNumber + " " + isAlive);

            // Rewriting variables as challenge suggests
            name = "Ron";
            firstNameInitail = 'R';
            byteNumber = 100;
            shortNumber = 25000;
            intNumber = -1000000;
            longNumber = 1500000000000000000;
            sByteNumber = 120;
            uShortNumber = 60000;
            uIntNumber = 3000000000;
            uLongNumber = 9000000000000000000;
            floatNumber = 3.5f;
            doubleNumber = 0.123456789012345;
            decimalNumber = 0.9999999999999999999999999999m;
            isAlive = false;

            Console.WriteLine(name + " " + firstNameInitail + " " + byteNumber + " " + shortNumber + " " + intNumber + " " + longNumber + " " + sByteNumber + " " + uShortNumber + " " + uIntNumber + " " + uLongNumber + " " + floatNumber + " " + doubleNumber + " " + decimalNumber + " " + isAlive);
            
            Console.ReadKey();

        }
    }
}
