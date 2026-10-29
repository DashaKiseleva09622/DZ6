class BankAccount
{
    // Задание 7.1: закрытые поля
    private int number;
    private double balance;
    private AccountType type;

    // Задание 7.2: генерация уникального номера
    private static int lastNumber = 1000;

    private static int GenerateNumber()
    {
        lastNumber++;
        return lastNumber;
    }
    // Заполнение полей
    public void SetData(double b, AccountType t)
    {
        balance = b;
        type = t;
    }

    // Задание 7.3: пополнение счета
    public void Deposit(double sum)
    {
        if (sum > 0)
        {
            balance = balance + sum;
            Console.WriteLine("Счет пополнен.");
        }
        else
        {
            Console.WriteLine("Сумма должна быть больше нуля.");
        }
    }

    // Задание 7.3: снятие денег со счета
    public void Withdraw(double sum)
    {
        if (sum > 0 && sum <= balance)
        {
            balance = balance - sum;
            Console.WriteLine("Деньги сняты.");
        }
        else
        {
            Console.WriteLine("Нельзя снять эту сумму.");
        }
    }

    // Вывод информации о счете
    public void Print()
    {
        Console.WriteLine("Номер счета: " + number);
        Console.WriteLine("Баланс: " + balance);
        Console.WriteLine("Тип счета: " + type);
    }
}