﻿int exit = 0, sum = 0, num = 0;
string input = "s";
while(exit == 0)
{
    Console.Write("Ввод: ");
    input = Console.ReadLine();
    num = 0; sum = 0;
    if((input == "q") || (input == "Q"))
    {
        exit = 1;
    }      
    
    else if(int.TryParse(input, out num)) 
    {
        while(num > 0)
        {
            sum = num % 10 + sum;
            num = (int) num / 10;          
        }
        //Console.WriteLine($"сумма цифр = {sum}");
        if ((sum % 2) == 0)
        {
            Console.WriteLine($"Сумма цифр числа '{input}' равна {sum}, чётное число! Выход!"); exit = 2;     
        }
        else  Console.WriteLine($"Сумма цифр числа '{input}' равна {sum}, нечётное число!");    
    }

    else Console.WriteLine("Неверный ввод!");
}

if (exit == 1) Console.WriteLine($"Введён символ '{input}'! Выход!");