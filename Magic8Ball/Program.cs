using System;

namespace Magic8Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ask me your question child");
            Console.ReadLine();

            Random ballResponse = new Random();
            int answerNum;
            answerNum = ballResponse.Next(1, 21);
            if(answerNum == 1)
            {
                Console.WriteLine("It is certain");
            }
            else if (answerNum == 2)
            {
                Console.WriteLine("Reply hazy, try again");
            }
            else if (answerNum == 3)
            {
                Console.WriteLine("Don’t count on it");
            }
            else if (answerNum == 4)
            {
                Console.WriteLine("It is decidedly so");
            }
            else if (answerNum == 5)
            {
                Console.WriteLine("Ask again later");
            }
            else if (answerNum == 6)
            {
                Console.WriteLine("My reply is no");
            }
            else if (answerNum == 7)
            {
                Console.WriteLine("Without a doubt");
            }
            else if (answerNum == 8)
            {
                Console.WriteLine("Better not tell you now");
            }
            else if (answerNum==9)
            {
                Console.WriteLine("My sources say no");
            }
            else if (answerNum ==10)
            {
                Console.WriteLine("Yes definitely");
            }
            else if (answerNum == 11)
            {
                Console.WriteLine("Cannot predict now");
            }
            else if (answerNum == 12)
            {
                Console.WriteLine("Outlook not so good");
            }
            else if (answerNum == 13)
            {
                Console.WriteLine("You may rely on it");
            }
            else if (answerNum == 14)
            {
                Console.WriteLine("Concentrate and ask again");
            }
            else if (answerNum == 15)
            {
                Console.WriteLine("Very doubtful");
            }
            else if (answerNum == 16)
            {
                Console.WriteLine("As I see it, yes");
            }
            else if (answerNum == 17)
            {
                Console.WriteLine("Most likely");
            }
            else if (answerNum == 18)
            {
                Console.WriteLine("Outlook good");
            }
            else if (answerNum == 19)
            {
                Console.WriteLine("Yes");
            }
            else if (answerNum == 20)
            {
                Console.WriteLine("Signs point to yes");
            }
        }
    }
}
