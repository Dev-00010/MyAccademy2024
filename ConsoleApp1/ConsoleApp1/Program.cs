//string x = "Hello Word ";
//string y = "Gente ";
//string z = x + y;
//Console.WriteLine(z);


//string x = "hello word ";
//string y = x.Substring(0, 5);    //server a dividere o contare le lettere di una parola .Substring
//Console.WriteLine(y);


//string x = "123";
//int z = int.Parse(x); // .Parse serve a contare le stringhe o sommarle e sottrarle
//Console.WriteLine(z);



//string input = "1.9";
//double numberWithComma = double.Parse(input);
//int roundedNumber = (int) Math.Round(numberWithComma);  //Ceiling prende il numero piu' alto. // Math e' un contenitore di codici
//Console.WriteLine(roundedNumber);


//string input = "16";
//double numberWithComma = double.Parse(input);
//double squaredRoom = Math.Sqrt(numberWithComma);  //Ceiling prende il numero piu' alto. // Math e' un contenitore di codici
//Console.WriteLine(squaredRoom);  // Sqrt e' per calcolare la radice


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




//Console.WriteLine("Rectangle area and perimeter calculator");

//Console.Write("Insert base side lenght: ");
//string baseSideInput = Console.ReadLine();
//double baseSide = double.Parse(baseSideInput);

//if (baseSide < 0)
//{
//    Console.WriteLine("You inserted a negative base side. retry!!");
//    return;
//}


//Console.Write("Insert height side lenght: ");
//string heightSideInput = Console.ReadLine();
//double heightSide = double.Parse(heightSideInput);

//if (heightSide < 0)
//{
//    Console.WriteLine("You inserted a negative heght side retry");
//    return;
//}



//double p = (baseSide + heightSide) * 2;
//double a = baseSide * heightSide;

//Console.Write("Perimeter: ");
//Console.WriteLine(p);
//Console.Write("Area: ");
//Console.WriteLine(a);


//// i = sqrt(a * a + b * b)



Console.Write("Inserisci il 1 numero ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Inserisci il 2 numero ");
double num2 = double.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Ilnumero maggiore e': {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"Il numero maggiore e': {num2}");
}
else
{
    Console.WriteLine("I due numeri sono uguali. ");
}








//Console.Write("Inserisci il 1 numero");
//string num1Input = Console.ReadLine();
//bool isNum1Valid = double.TryParse(num1Input,out double num1 );

//Console.Write("Inserisci il 2 numero");
//string num2Input = Console.ReadLine();
//bool isNum2Valid = double.TryParse(num2Input, out double num2);  // Tryparse forza al parse e si puo usare su "tutto".

//if (num1 >= num2)
//{
//    Console.WriteLine($"Ilnumero maggiore e': {num1}");
//}
//else if (num1 > num2)
//{
//    Console.WriteLine($"Il numero maggiore e': {num2}");
//}
//else
//{
//    Console.WriteLine("I due numeri sono uguali ");
//}




