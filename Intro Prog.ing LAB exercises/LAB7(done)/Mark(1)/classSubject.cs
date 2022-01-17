public class Subject
{
    private string subject = "";
    private float writtingScore;
    private float practiceScore;

    public float Average() {return (writtingScore + practiceScore)/2.0f;}

    public Subject() {
        System.Console.Write("Please enter your subject: ");
        subject = Console.ReadLine();
        System.Console.Write("Please enter your writting score: ");
        writtingScore = float.Parse(Console.ReadLine());
        System.Console.Write("Please enter your practice score: ");
        practiceScore = float.Parse(Console.ReadLine());
    }

    public void print() {
        System.Console.WriteLine(
            "SUBJECT INFOMATION\n"+
            "=============================\n"+
            "Subject: {0}\n"+
            "Writting score: {1}\n"+
            "Practice Score: {2}\n"+
            "Average score: {3}",
            subject, writtingScore, practiceScore, Average());
    }
}