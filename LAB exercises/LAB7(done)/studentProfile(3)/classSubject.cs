public class Subject
{
    private string subject = "";
    private float writtingScore;
    private float practiceScore;

    public Subject(string subject, float writtingScore, float practiceScore)
    {
        this.subject = subject;
        this.writtingScore = writtingScore;
        this.practiceScore = practiceScore;
    }

    public float Average() { return (writtingScore + practiceScore) / 2.0f; }

    public void print()
    {
        System.Console.WriteLine(
            "=============================\n" +
            "Subject: {0}\n" +
            "Writting score: {1}\n" +
            "Practice Score: {2}\n" +
            "Average score: {3}",
            subject, writtingScore, practiceScore, Average()
        );
    }

    
}

