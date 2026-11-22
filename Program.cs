using System;

namespace Cast_Convert_If_else_04._21._25
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            // =========================== UTF8 ===============================
            /* 
              OutputEncoding ekrana yazılan hərflər üçündür,
              InputEncoding isə klaviaturadan yazdığın hərflər üçün (məsələn, Console.ReadLine()).
            */
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            
            // =========================== IMPLICIT CASTING ===============================
            byte imageByte = 20;
            int imageConvertToInt = imageByte;
            //Console.WriteLine(imageConvertToInt.GetType());

            // =============================== EXPILICIT CASTING ===============================

            int ageInt = 500;
            byte ageConvertToByte = (byte)ageInt;
            //Console.WriteLine(ageConvertToByte.GetType());

            double ageDouble = 3.8;
            int ageConvertToInt = (int)ageDouble;
            //Console.WriteLine(ageConvertToInt.GetType());

            // =============================== CONVERT ===============================
            
            string value = "true";
            bool valueConvertToBool = Convert.ToBoolean(value);
            //Console.WriteLine(valueConvertToBool.GetType());

             // =============================== type.Pasre() || type.TryParse() ===============================
            string ageString = "true";
            bool.Parse(ageString);
            //Console.WriteLine(bool.Parse(ageString));

            string tryToConvertToInt = "matrix";
            decimal result;
            bool isCheck = decimal.TryParse(tryToConvertToInt, out result);
            //Console.WriteLine(isCheck + " = false " + result + "=0");


            // =========================== Ternary Operator AND If ElSE =========================
            var age = 20;
            
            if (age == 18)
            {
                Console.WriteLine("Yaş 18 deyil.");
            }
            else if (age < 18)
            {
                Console.WriteLine("Siz hələ yetkin deyilsiniz");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Yaşınız 21-dən kiçikdir");
            }
            else
            {
                Console.WriteLine("Yaşınız müəyyən edilmədi.");
            }
            
            string result2 = age == 25 ? "Yaş 25-dir" : "Yaş müəyyən edilmədi";
        }
        
        static void Main(string[] args)
        {
            /* istifadəçidən iki ədəd alın(string formatında).Onları int-ə çevirin və cəmini ekrana verin. */

            Console.WriteLine("İlk ədədi daxil edin:");
            string? firstNumber = Console.ReadLine();
            Console.WriteLine("Ikinci ədədi daxil edin:");
            string? secondNumber = Console.ReadLine();
            
            var IsTrue = int.TryParse(firstNumber, out int checkFirstNumber);
            var IsFalse = int.TryParse(secondNumber, out int checkSecondNumber);
            
            var result = IsTrue ? IsFalse ? (checkFirstNumber + checkSecondNumber).ToString() : 
                "The first number hasn't been entered correctly." :
                "The second number hasn't been entered correctly."
            Console.WriteLine(result);
            
            if (!IsTrue)
            {
                Console.WriteLine("The first number wasn't entered correctly");
            }
            else if (!IsFalse)
            {
                Console.WriteLine("The second number wasn't entered correctly");
            }
            else
            {
                Console.WriteLine($"Cəmi: {checkFirstNumber + checkSecondNumber}");
            }

            // double tipində verilmiş dəyəri int tipinə cast edin.

            double value = Convert.ToDouble(Console.ReadLine());
            int convertToInt = (int)value;
            Console.WriteLine(convertToInt.GetType() + " " + convertToInt);

            // int.TryParse() metodunu istifadə edərək istifadəçinin daxil etdiyi dəyərin ədəd olub
            // olmadığını yoxlayın

            Console.WriteLine("Enter number");
            var number = Console.ReadLine();
            bool isInt = int.TryParse(number, out int result);
            bool isDouble = double.TryParse(number, out double result1);
            var a = 5;
            Console.WriteLine(result == 0 || result1 == 0 ? "Congratulate !! " : "entered value is not number");

            // İstifadəçidən yaş alın və yoxlayın: 18 - dən kiçikdirsə — "Siz hələ yetkin deyilsiniz"
            // 18 və ya daha böyükdürsə — "Yetkin şəxssiniz"

            Console.WriteLine("You must entered number");
            var getAge = Console.ReadLine();
            var ageCheck = int.TryParse(getAge, out int getAgeCheck);

            if (!ageCheck)
            {
                Console.WriteLine("Entered keys is not correct");
            }
            else if (getAgeCheck > 0 && getAgeCheck < 18)
            {
                Console.WriteLine("Siz hələ yetkin deyilsiniz");
            }
            else
            {
                Console.WriteLine("Yetkin şəxssiniz");
            }

            var resulAge = !ageCheck ? "Entered keys is not correct" : getAgeCheck > 0 && getAgeCheck <= 18 ? "Siz hələ yetkin deyilsiniz" : "Yetkin şəxssiniz";
            Console.WriteLine(resulAge);


            // İstifadəçidən yaş və bal al.Yoxla ki, yaş 18 - dən böyük və bal 50 - dən çoxdursa, keçib.

            var userAge = Console.ReadLine();
            var userScore = Console.ReadLine();
            var totalResultAge = int.TryParse(userAge, out int resultAge);
            var totalResultScore = int.TryParse(userScore, out int resultScore);

            var result3 = !totalResultAge || !totalResultScore ? "One of the keys is not number" :
                resultAge > 0 && resultAge <= 18 && resultScore > 50 ? "You pass the exam" : "You failed the exam";
            Console.WriteLine(result3);


            // İki ədəd daxil edin və ternary operatorla hansının daha böyük olduğunu təyin edib console-a yazdirin.

            Console.WriteLine("You entered number");
            var getNum_1 = Console.ReadLine();
            Console.WriteLine("You entered number");
            var getNum_2 = Console.ReadLine();

            var resultCheckNum_1 = int.TryParse(getNum_1, out int getNumCheck_1);
            var resultCheckNum_2 = int.TryParse(getNum_2, out int getNumCheck_2);

            var result4 = getNumCheck_1 > getNumCheck_2 ? getNumCheck_1 + " boyukdur" : getNumCheck_2 + "boyukdur";
            Console.WriteLine(result4);

            /* İstifadəçidən qiymət (məsələn, 19.99) daxil etməsini istə. Onu double-a çevir, sonra (int) cast ilə tam hissəsini göstər.*/

            Console.WriteLine("Qiymət daxil edin: ");
            var value = Console.ReadLine();
            
            var isValid = double.TryParse(value, out double price);
            
            if (isValid)
            {
                Console.WriteLine($"Entered price: {price}");
                Console.WriteLine($"The full price: {(int)price}");
            }
            else
            {
                Console.WriteLine("Düzgün qiymət daxil edin!");
            }
            
            /*
             Kalkulyator (üçlü operator ilə)
            
            İstifadəçidən iki ədəd və əməliyyat (+ və ya -) daxil etməsini istə.
            
            İki ədəd də TryParse ilə yoxlanılsın, səhv varsa uyğun xəta mesajı çıxsın.
             */
            
            Console.WriteLine("Ədədi daxil et: ");
            var number = Console.ReadLine();
            Console.WriteLine("Ikinci ədədi daxil et: ");
            var number2 = Console.ReadLine();
            Console.WriteLine("Əməliyyatı seç: + / - ");
            var operation = Console.ReadLine();
            
            var isFirstValue = int.TryParse(number, out int first);
            var isSecondValue = int.TryParse(number2, out int second);
            
            
            if (isFirstValue && isSecondValue)
            {
            
                var sum = operation == "+" ? (first + second).ToString() :
                    operation == "-" ? (first - second).ToString() : "Əməliyyat seçilməyib";
                Console.WriteLine("Nəticə: " + sum);
            }
            else
            {
                Console.WriteLine("Daxil olunan ədədlər duzgun deyil");
            }
        }
    }
}
