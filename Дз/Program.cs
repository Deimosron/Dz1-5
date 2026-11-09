///---Дз 1---\\\

//string dop = "=================================";
//string food = "Жареная картошка";
//Console.WriteLine(dop); //Название
//Console.WriteLine($"Рецепт: {food}");

////Количество продуктов 
//int kol = 5;
//int kol1 = 3;
//int kol2 = 30;
//Console.WriteLine(dop);
//Console.WriteLine($"Ингредиенты: \n-Картофель {kol} штук \n-Растительное масло {kol1} ст. л. \n-Соль {kol2} г");
//Console.WriteLine(dop); //Рецепт
//Console.WriteLine("Приготовление: \n1. Чистим картошку и нарезаем её брусочками \n2. Разогреваем сковородку и наливаем подсолнечное масло");
//Console.WriteLine("3. Складываем картошку в сковородку и начинаем жарить \n4. Жарим и перемешивая 10 минут на среднем огне \n5. Выключаем огонь и добавляем соль");
//Console.Read();


///---Дз 2---\\\


///---Дз 3---\\\

//Console.WriteLine("---Улучшеный калькулятор---");
//Console.WriteLine("Введите первое число");
//double nimb1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число");
//double nimb2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите знак (+, -, *, /)");
//string znak = Console.ReadLine();

//if (znak == "+")
//{
//    Console.WriteLine($"Результат:{nimb1} + {nimb2} = {nimb1 + nimb2}");
//}
//else if (znak == "-")
//{
//    Console.WriteLine($"Результат:{nimb1} - {nimb2} = {nimb1 - nimb2}");
//}
//else if (znak == "*")
//{
//    Console.WriteLine($"Результат:{nimb1} * {nimb2} = {nimb1 * nimb2}");
//}
//else if (znak == "/" && nimb2 != 0)
//{
//    Console.WriteLine($"Результат:{nimb1} / {nimb2} = {nimb1 / nimb2}");
//}
//else if (nimb2 == 0)
//{
//    Console.WriteLine("Ошибка второе число равно нулю");
//}
//else
//{
//    Console.WriteLine("Ошибка! Виденый знак не существует!");
//}



///---Дз 4---\\\

//Random random = new Random();
//int secretNumber = random.Next(1, 101);

//int userGuess = 0;
//int atters = 0;

//Console.WriteLine("Я загадал число от 0 до 100! Попробуй отгадать!");

//while (userGuess != secretNumber)
//{
//    Console.WriteLine("Ваша догадка?");
//    userGuess = Convert.ToInt32(Console.ReadLine());
//    atters++;

//    if (userGuess > secretNumber)
//    {
//        Console.WriteLine("Загадонное число меньше!");
//    }
//    else if (userGuess < secretNumber)
//    {
//        Console.WriteLine("Загадонное число больше!");
//    }


//}
//Console.WriteLine($"Поздровляю вы отгадали число {secretNumber}");
//Console.WriteLine("Конец игры");


///---Дз 5---\\\

//Console.WriteLine("---Улучшеный калькулятор (методы)---");
//Console.WriteLine("Доступны символы +, -, *, /");
//Console.WriteLine("Введите первое число:");
//int nimb1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int nimb2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите знак работы:");
//string znak = Console.ReadLine();
//switch (znak)
//{
//    case "+":
//        Console.WriteLine($"Результат: {nimb1} + {nimb2} = {Sum(nimb1, nimb2)}");
//        break;
//    case "-":
//        Console.WriteLine($"Результат: {nimb1} - {nimb2} = {Min(nimb1, nimb2)}");
//        break;
//    case "*":
//        Console.WriteLine($"Результат: {nimb1} * {nimb2} = {Pom(nimb1, nimb2)}");
//        break;
//    case "/":
//        Console.WriteLine($"Результат:{nimb1} / {nimb2} = {Div(nimb1, nimb2)}");
//        break; 
//} 

//int Sum(int x, int y)
//{
//    int summa = x + y;
//    return summa;
//}
//int Min(int x, int y)
//{
//    int minma = x - y;
//    return minma;
//}
//int Pom(int x, int y)
//{
//    int milti = x * y;
//    return milti;
//}
//int Div(int x, int y)
//{
//    int divis = x / y;
//    return divis;
//}


///---Дз 6---\\\

Console.Read();