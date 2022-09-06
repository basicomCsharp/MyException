// See https://aka.ms/new-console-template for more information
try
{
    throw new MyExceptionClass("Тестовое исключение");
}
catch(ArgumentNullException)
{
    Console.WriteLine("Аргумент, передаваемый в метод — null.");
}
catch(ArgumentOutOfRangeException)
{
    Console.WriteLine("Аргумент находится за пределами диапазона допустимых значений.");
}
catch (ArgumentException)
{
    Console.WriteLine("Непустой аргумент, передаваемый в метод, является недопустимым.");
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("Недопустимая часть пути к каталогу.");
}
catch (MyExceptionClass)
{
    Console.WriteLine("Программа вызвала исключение MyExceptionClass." );
}

finally
{
    Console.WriteLine("Выполняется блок finally.");
 }

//public ExceptionCollection (System.Collections.ArrayList exceptions);
class MyExceptionClass: Exception
{
    public MyExceptionClass(string message)
        : base(message) { }
}
