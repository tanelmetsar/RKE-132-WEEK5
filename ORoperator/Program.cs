int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter ypur Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter you Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratiolations! You got accepted");
}
else
{
    Console.WriteLine("Your application can not be approved.");
}