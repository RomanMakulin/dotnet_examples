// Есть магазин "Ромашка"
// Охранник ведёт журнал посещения
// 11-13
// 10-14
// 9-10
// 11-22
// 18-18
// 0-23
// 4-5
// 4-5
// 4-5

// Суть: показать интервалы, когда было больше всего 
// людей в магазине
// string s = "11-44";
// var pos = s.IndexOf('-');
// System.Console.WriteLine(s.Substring(0, pos));
// System.Console.WriteLine(s.Substring(pos + 1));

// string[] arg = s.Split('-');
// System.Console.WriteLine(arg[0]);
// System.Console.WriteLine(arg[1]);
// 1 2 3 4 5 6 

// 11-13
// 10-14
// 9-10
// 11-22
// 18-18


    string str = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24";
    
    string user1 = str.Substring(20, 10);
    string user2 = str.Substring(18, 14);
    string user3 = str.Substring(16, 5);
    string user4 = str.Substring(20, 36);
    string user5 = str.Substring(41, 3);

    string[] arg = str.Split('-');
    Console.WriteLine(arg[0]);
    

    


