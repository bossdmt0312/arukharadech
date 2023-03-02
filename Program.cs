class Program {
    static void Main(string[] args) {
    Console.Write("Password :");
    int AR = int.Parse(Console.ReadLine());
    Console.Write("institution :");
    string B = (Console.ReadLine());
    if(AR <= 999999 && 12 >= 0) {
        int d = AR / 100000 % 10;
        int g = AR / 10000 % 10;
        int o = AR / 1000 % 10;
        int k = AR / 100 % 10;
        int r = AR / 10 % 10;
        int y = AR % 10;
        if(B == "CIA") {
            if(o >= 6 && o != 8 && r != 1 && r != 3 && r != 5 && y % 3 == 0) {
                Console.WriteLine("True");
                
            }
            else {
                Console.WriteLine("False");
                }
        }
        if(B == "FBI"){
            if(d >= 4 && d <= 7 && k % 2 == 0 && k != 6) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
    }
          if(B == "NSA"){
            if(k % 3 == 0 && k %2 != 0 && y % 30 == 0 && y == 7 || r == 7 || k == 7 || o == 7 || g == 7 || d == 7 ) {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
        }
          }
    }
}
}
