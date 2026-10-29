using System;
class Programm
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        Console.Write("Введите начальный баланс: ");
        double balance;

        if (double.TryParse(Console.ReadLine(), out balance)
            && balance >= 0)
        {
            Console.WriteLine("Выберите тип счета:");
            Console.WriteLine("0 - Current");
            Console.WriteLine("1 - Savings");

            int typeNumber;

            if (int.TryParse(Console.ReadLine(), out typeNumber)
                && (typeNumber == 0 || typeNumber == 1))
            {
                AccountType type = (AccountType)typeNumber;

                account.SetData(balance, type);

                Console.WriteLine("\nИнформация о счете:");
                account.Print();

                Console.Write("\nВведите сумму пополнения: ");
                double sum;

                if (double.TryParse(Console.ReadLine(), out sum))
                {
                    account.Deposit(sum);
                    account.Print();
                }
                else
                {
                    Console.WriteLine("Ошибка ввода.");
                }

                Console.Write("\nВведите сумму снятия: ");

                if (double.TryParse(Console.ReadLine(), out sum))
                {
                    account.Withdraw(sum);
                    account.Print();
                }
                else
                {
                    Console.WriteLine("Ошибка ввода.");
                }

                // Проверка генерации нового номера
                BankAccount account2 = new BankAccount();

                Console.WriteLine("\nВторой счет:");
                account2.Print();
            }
            else
            {
                Console.WriteLine("Неверный тип счета.");
            }
        }
        else
        {
            Console.WriteLine("Неверный баланс.");
        }
    }
}