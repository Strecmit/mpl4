int exit = 0, sum = 0, num = 0;
while(exit == 0){
    Console.Write("Ввод: ");
    string input = Console.ReadLine();
    if(input == "q") {
        exit = 1;
    }      
    
    else if(int.TryParse(input, out num)) {
        while(num > 0){
            sum = num % 10;
            num = num / 10;
        }
     
    }
    if ((sum % 2) == 0) {
        Console.WriteLine("Сумма цифр числа чётная! Выход!"); exit = 1;
    }

    else Console.WriteLine("Неверный ввод!");
}

Console.WriteLine("Введён символ 'q'! Выход!");