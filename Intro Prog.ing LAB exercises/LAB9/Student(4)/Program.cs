using System.Collections;

int input(string saySthg)
{
    System.Console.Write(saySthg);
    return int.Parse(Console.ReadLine());
}

System.Console.WriteLine(
"Chuong trinh quan ly danh sach sinh vien su dung ArrayList\n" +
"================================================\n" +
"1- khoi tao danh sach\n" +
"2- them 1 sinh vien vao danh sach\n" +
"3- duyet danh sach\n" +
"4- tim thong tin sinh vien theo ten sinh vien\n" +
"5- sua diem cho sinh vien\n" +
"6- danh sach sinh vien duoc nhan hoc bong\n" +
"7- xem diem cua sinh vien\n" +
"8- sap xep danh sach giam dan theo DTB\n" +
"9- sap xep danh sach giam dan theo DTB, tang dan theo ten\n" +
"0- thoat chuong trinh"
);

bool loop = true;

int mode = -1; //not 0 to avoid unattempted end of program

while (mode != 1)
{
    mode = input("You choose: ");
    if (mode == 0)
    {
        loop = false;
        System.Console.WriteLine("Good bye, hope to see you again.");
        break;
    }
    else if ((mode >= 2) & (mode <= 9))
    {
        System.Console.WriteLine("Error: List hasn't been declared!");
    }
    else if (mode != 1)
    {
        System.Console.WriteLine("Sorry, I didn't understand");
    }
}

var list = new ArrayList();
System.Console.WriteLine("List declared.");

while (loop)
{
    System.Console.Write("You choose: ");
    switch (Console.ReadLine())
    {
        case "1":
            list.Clear();
            System.Console.WriteLine("New list was declare.");
            break;
        case "2":
            System.Console.WriteLine("A new student have been added!\nPlease give me his/her infomation:");
            list.Add(new Student());
            break;
        case "3":
            foreach (Student s in list)
            {
                s.output_student();
            }
            break;
        case "4":
            bool absence = true;
            System.Console.Write("Studnet look up. Please enter his/her name: ");
            string search = Console.ReadLine();
            uint index = 0;
            foreach (Student obj in list)
            {
                if (obj.get_name() == search)
                {
                    obj.output_student();
                    absence = false;
                }
            }
            if (absence) System.Console.WriteLine("No '{0}' found in list.", search);
            break;
        case "5":
            absence = true;
            System.Console.Write("Student code: ");
            string code = Console.ReadLine();
            foreach (Student obj in list)
            {
                if (obj.get_code() == code)
                {
                    absence = false;
                    System.Console.Write("Student {0} ({1}) has mark changing to: ", obj.get_name(), obj.get_code());
                    obj.set_mark(float.Parse(Console.ReadLine()));
                    break;
                }
            }
            if (absence) System.Console.WriteLine("No student with code {0} found in list.", code);
            break;
        case "6":
            System.Console.WriteLine("List of student has sholarship:");
            foreach (Student student in list) {
                if (student.check_scholarship()) {System.Console.WriteLine($"{student.get_name()} ({student.get_code()})");}
            }
            break;
        case "7":
            System.Console.Write("Student code: ");
            code = Console.ReadLine();
            foreach (Student obj in list)
            {
                if (obj.get_code() == code)
                {
                    System.Console.WriteLine("Student: {0} ({1}) has mark: {2}", obj.get_name(), obj.get_code(), obj.get_mark());
                    break;
                }
            }
            break;
        case "8":
            list.Sort();
            System.Console.WriteLine("List of students has been sorted by average mark.");
            break;
        case "9":
            list.Sort(new CompareByMarkName());
            System.Console.WriteLine("List of students has been sorted by mark and name.");
            break;
        case "0":
            System.Console.WriteLine("Bye bye!");
            loop = false;
            break;
        default:
            System.Console.WriteLine("Sorry, I didn't understand.");
            break;

    }
}

