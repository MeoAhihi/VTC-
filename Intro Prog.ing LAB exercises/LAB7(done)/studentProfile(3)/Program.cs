var Profile = new List<Subject>();
byte length = 2;

Subject maxAverage()
{
    Subject max = new Subject("", 0, 0);
    max = Profile[0];
    for (byte i = 1; i < length; i++) if (max.Average() < Profile[i].Average()) max = Profile[i];
    return max;
}

System.Console.WriteLine(
    "=============================\n" +
    "1 - Nhap danh sach mon hoc\n" +
    "2 - Hien thi danh sach\n" +
    "3 - Diem trung binh cao nhat\n" +
    "4 - Thoat"
);

bool loop = true;
while (loop)
{
    System.Console.Write("Chon: ");
    switch (Console.ReadLine())
    {
        case "1":
            for (byte i = 0; i < length; i++)
            {
                System.Console.Write("=============================\nPlease enter your subject: ");
                string subject = Console.ReadLine();
                System.Console.Write("Please enter your writting score: ");
                float writtingScore = float.Parse(Console.ReadLine());
                System.Console.Write("Please enter your practice score: ");
                float practiceScore = float.Parse(Console.ReadLine());
                Profile.Add(new Subject(subject, writtingScore, practiceScore));
            }
            System.Console.WriteLine("=============================\n");
            break;

        case "2":
            System.Console.WriteLine("STUDENT PROFILE");
            foreach (Subject s in Profile)
            {
                s.print();
            }
            System.Console.WriteLine("=============================\n");
            break;

        case "3":
            System.Console.WriteLine("SUBJECT WITH HIGHEST AVERAGE SCORE");
            maxAverage().print();
            System.Console.WriteLine("=============================\n");
            break;

        case "4":
            loop = false;
            System.Console.WriteLine("Good Bye");
            break;

        default:
            System.Console.WriteLine("I don't understand");
            break;
    }
}