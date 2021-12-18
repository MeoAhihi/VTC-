System.Console.Write("SO THICH CA NHAN\n====================\n1.Doc sach\n2.Nghe nhac\n3.Choi the thao\n4.May tinh\n5.Thoat\n====================\nChon: ");
switch (Console.ReadLine()) {
    case "1": System.Console.WriteLine("Ban chon doc sach"); break;
    case "2": System.Console.WriteLine("Ban chon nghe nhac"); break;
    case "3": System.Console.WriteLine("Ban chon choi the thao"); break;
    case "4": System.Console.WriteLine("Ban chon choi may tinh"); break;
    case "5": System.Console.WriteLine("Hen gap lai"); break;
    default: System.Console.WriteLine("Cai qq j z?"); break;
}