

namespace _9._4;
class strudent
{


    string s_code;
    string s_name;
    int s_age;
    double s_mark;
    public void input()// nhap thong tin học sinh
    {
        Console.Write("Ma sinh vien: ");
        s_code = Console.ReadLine();
        Console.Write("Ho va ten:");
        s_name = Console.ReadLine();
        Console.Write("Tuoi: ");
        s_age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Diem TB: ");
        s_mark = Convert.ToDouble(Console.ReadLine());
    }

    public string get_name()//trả về tên
    {
        return s_name;
    }
    public string get_code()//tra ve ma sinh vien
    {
        return s_code;
    }
    public double get_mark()//tra ve Diem TB
    {
        return s_mark;
    }
    public void set_mark(double newmark)
    {
        this.s_mark = newmark;
    }
    public void printline()
    {
        Console.WriteLine("-------------------------------------");
    }
    public void printitle()
    {
        printline();
        Console.WriteLine("|{0,-5}|{1,-12}|{2,-10}|{3,-15}|{4,-20}|", "STT", "Masinhvien", "Tensinhvien", "Tuoi", "DiemTB");
    }
    public void ouput(int STT)
    {
        Console.WriteLine("|{0,-5}|{1,-12}|{3,-15}|{3,-15}|{4,-20}", STT, s_code, s_name, s_age, s_mark);
    }
    public void ouput()
    {
        Console.WriteLine("|{0,-23}|{1,-18}|{2,-14}|{3,-10}|", s_code, s_name, s_age, s_mark);
    }
}
