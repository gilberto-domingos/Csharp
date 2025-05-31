using LogicExercises.Entities;

namespace LogicExercises;

internal class Program
{
    private static void Main(string[] args)
    {
        var variaveis = new Variables();

        variaveis.VByte = 255;
        variaveis.VSByte = -128;
        variaveis.VShort = -32768;
        variaveis.VUShort = 65535;
        variaveis.VInt = -2147483648;
        variaveis.VUInt = 4294967295;
        variaveis.VLong = -9223372036854775808;
        variaveis.VULong = 18446744073709551615;

        variaveis.VFloat = 5.35f;
        variaveis.VDouble = 3.464894444984;
        variaveis.VDecimal = 494564984984944494m;

        variaveis.VChar = 'A';
        variaveis.VBool = true;

        variaveis.VString = "My text phrase...";
        variaveis.VObjectInt = 12345;
        variaveis.VObjectString = "12345";
        // Unboxing to int or string
        var valor = (int)variaveis.VObjectInt;
        var valor2 = (string)variaveis.VObjectString;

        variaveis.VDateTime = DateTime.Now;
        variaveis.VTimeSpan = TimeSpan.FromHours(1.5);
        variaveis.VTimeSpan = TimeSpan.FromMinutes(90);

        variaveis.Id = Guid.NewGuid();

        variaveis.VDaysWeek = DaysWeek.Wednesday;

        variaveis.VPoint = new Point { X = 10, Y = 20 };

        variaveis.VIntNullable = null;
        variaveis.VBoolNullable = true;
        variaveis.VDateTimeNullable = DateTime.Today;

        variaveis.VDynamic = "Dynamic string";

        Console.WriteLine($"VByte = {variaveis.VByte}");
        Console.WriteLine($"VSByte = {variaveis.VSByte}");
        Console.WriteLine($"VShort = {variaveis.VShort}");
        Console.WriteLine($"VUShort = {variaveis.VUShort}");
        Console.WriteLine($"VInt = {variaveis.VInt}");
        Console.WriteLine($"VUInt = {variaveis.VUInt}");
        Console.WriteLine($"VLong = {variaveis.VLong}");
        Console.WriteLine($"VULong = {variaveis.VULong}");

        Console.WriteLine($"VFloat = {variaveis.VFloat}");
        Console.WriteLine($"VDouble = {variaveis.VDouble}");
        Console.WriteLine($"VDecimal = {variaveis.VDecimal}");

        Console.WriteLine($"VChar = {variaveis.VChar}");
        Console.WriteLine($"VBool = {variaveis.VBool}");

        Console.WriteLine($"object: {variaveis.VString}");
        Console.WriteLine($"object: {variaveis.VObjectInt}");
        Console.WriteLine($"object: {variaveis.VObjectString}");
        Console.WriteLine($"object (unboxed int): {valor}");
        Console.WriteLine($"object (unboxed string): {valor2}");

        Console.WriteLine($"VDateTime = {variaveis.VDateTime}");
        Console.WriteLine($"VTimeSpan = {variaveis.VTimeSpan}");
        Console.WriteLine($"VGuid = {variaveis.Id}");

        Console.WriteLine($"VDaysWeek = {variaveis.VDaysWeek}");

        Console.WriteLine($"VPoint = {variaveis.VPoint}");

        Console.WriteLine(
            $"VIntNullable = {(variaveis.VIntNullable.HasValue ? variaveis.VIntNullable.Value.ToString() : "null")}");
        Console.WriteLine(
            $"VBoolNullable = {(variaveis.VBoolNullable.HasValue ? variaveis.VBoolNullable.Value.ToString() : "null")}");
        Console.WriteLine(
            $"VDateTimeNullable = {(variaveis.VDateTimeNullable.HasValue ? variaveis.VDateTimeNullable.Value.ToString() : "null")}");

        Console.WriteLine($"VDynamic = {variaveis.VDynamic}");
    }
}