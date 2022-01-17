product a = new product();
int n;
Console.WriteLine(
    "Chuong trinh quan li danh sach sinh vien su dung Arraylist.\n" +
    "===========================================================\n" +
    "1-khoi tao danh sach.\n" +
    "2-them 1 sinh vien vao danh sach.\n" +
    "3-duyet danh sach.\n" +
    "4-tim thong tin sinh vien theo ten sinh vien.\n" +
    "5-sua diem cho sinh vien.\n" +
    "6-danh sach sinh vien duoc nhan hoc bong.\n" +
    "7-xem diem cua sinh vien.\n" +
    "8-sap xep danh sach giam dan theo diem TB.\n" +
    "9-sap xep danh sach theo diem TB, tang len theo ten.");
Console.Write("Moi chon: ");
n = Convert.ToInt32(Console.ReadLine());
do
{
    switch (n)
    {
        case 2:
            strudent c = new strudent();
            Console.WriteLine("Ban muon them vao danh sach");
            c.input();
            a.themvaodanhsach(c);
            break;
        case 3:
            a.duyetdanhsach();
            break;
        case 4:
            a.timtheotensinhvien();
            break;
        case 5:
            a.suadiemchosinhvien();
            break;
        case 6:
            a.nhanhocbong();
            break;
        case 7:
            a.timtheomasosinhvien();
            break;
        default:
            Console.WriteLine("Vui long chon 1-9");
            break;

    }

} while (n != 0);
