Func<int, string> checkAge = a => a >= 18 ? "Adult" : "Minor";
Console.WriteLine(checkAge(20));
Console.WriteLine(checkAge(15));

Func<int, string> checkEvenOdd = n => n % 2 == 0 ? "Even" : "Odd";
Console.WriteLine(checkEvenOdd(4));
Console.WriteLine(checkEvenOdd(7));

Func<double, string> checkFever = t => t >= 37.5 ? "Has fever" : "No fever";
Console.WriteLine(checkFever(41.5));
Console.WriteLine(checkFever(23.4));

Func<int, string> classifyAge = a =>
    a < 12 ? "Child" :
    a < 18 ? "Teenager" :
    a > 60 ? "Elderly" : "Adult";

Console.WriteLine(classifyAge(11));
Console.WriteLine(classifyAge(17));
Console.WriteLine(classifyAge(40));
Console.WriteLine(classifyAge(80));

Func<string, string> validateName = n => n.Length >= 3 ? "Valid name" : "Invalid name";
Console.WriteLine(validateName("Ana"));
Console.WriteLine(validateName("Li"));

Func<decimal, string> checkTax = salary => salary > 2500 ? "Must pay tax" : "No tax required";
Console.WriteLine(checkTax(3000));
Console.WriteLine(checkTax(1500));

Func<string, string> validatePassword = pwd => pwd.Length >= 8 ? "Strong password" : "Weak password";
Console.WriteLine(validatePassword("password_234$%#**"));
Console.WriteLine(validatePassword("passw"));

Func<double, string> getGradeStatus = grade => grade >= 7.0 ? "Passed" :
    grade >= 5.0 ? "Recovery" : "Failed";

Console.WriteLine(getGradeStatus(8.0));
Console.WriteLine(getGradeStatus(5.0));
Console.WriteLine(getGradeStatus(4.0));

Func<string, string> validateEmail = email => email.Contains("@") ? "Valid email" : "Invalid email";
Console.WriteLine(validateEmail("jrdomingosjr@gmail.com"));
Console.WriteLine(validateEmail("jrdomingosjr.gmail.com"));

Func<int, string> describeNumber = n => n > 0 ? "Positive" :
    n < 0 ? "Negative" : "Zero";

Console.WriteLine(describeNumber(2));
Console.WriteLine(describeNumber(-3));
Console.WriteLine(describeNumber(0));