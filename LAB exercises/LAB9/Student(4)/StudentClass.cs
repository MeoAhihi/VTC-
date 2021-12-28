public class Student : IComparable
{
    private string s_code;
    private string s_name;
    private byte s_age;
    private float s_mark;
    public Student()//nhập thông tin 1 sinh viên
    {
        System.Console.Write("Student's name: ");
        s_name =  Console.ReadLine();
        System.Console.Write($"{s_name}'s code: ");
        s_code =  Console.ReadLine();
        System.Console.Write($"{s_name}'s age: ");
        s_age =  byte.Parse(Console.ReadLine());
        System.Console.Write($"{s_name}'s mark: ");
        s_mark =  float.Parse(Console.ReadLine());
    }
    public Student(string name, string code, byte age, float mark)//nhập thông tin 1 sinh viên
    {
        s_name = name;
        s_code = code;
        s_age = age;
        s_mark = mark;
    }
    public void output_student()//xuất thông tin 1 sinh viên
    {
        System.Console.WriteLine(
            "=======================\n"+
            "Name: {0}\n"+
            "Code: {1}\n"+
            "Age:  {2}\n"+
            "Mark: {3}\n"+
            "=======================",
            s_name, s_code, s_age, s_mark
        );
    }
    //kiểm tra xem sinh viên có được học bổng không (nếu s_mark>8)?
    public bool check_scholarship()
    {
        return s_mark > 8;
    }
    public string get_name()//trả về tên sinh viên
    {
        return s_name;
    }
    public string get_code()//trả về mã sinh viên
    {
        return s_code;
    }
    public float get_mark()//trả về ĐTB của sinh viên
    {
        return s_mark;
    }
    public void set_mark(float newMark)//sửa điểm cho sinh viên
    {
        s_mark = newMark;
    }
    public int CompareTo(object obj)
    {
        Student otherStudent = obj as Student;
        return this.s_mark.CompareTo(otherStudent.s_mark);
    }
}