namespace Task2
{
    class Program
    {
        static void Main()
        {
            string fullName = "Иванов Иван Иванович";
            int age = 28;
            string eMail = "ivanov@gmail.com";
            float programmingScore = 3.5f;
            float mathScore = 4.2f;
            float physicsScore = 2.75f;
            float totalScore;
            float averageScore;

            totalScore = mathScore + physicsScore + programmingScore;
            averageScore = totalScore / 3;

            Console.WriteLine($"Имя: {fullName} \nВозраст: {age} " +
                $"\nЭлектронная почта: {eMail} " +
                $"\nБалл по программированию: {programmingScore} " +
                $"\nБалл по математике: {mathScore} " +
                $"\nБалл по физике: {physicsScore} "); ;
            Console.ReadLine();
            string totalScoreFormated = totalScore.ToString("#.##");
            string averageScoreFormated = averageScore.ToString("#.##");
            Console.WriteLine($"Общий балл: {totalScoreFormated}" +
                $"\nСредний балл: {averageScoreFormated}");
            Console.ReadLine();
        }
    }
}