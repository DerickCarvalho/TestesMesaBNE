class Program {
    static void Main() {
        int a = 10;
        Console.WriteLine("a = " + a);
        int b = 20;
        Console.WriteLine("b = " + b);
        int c = (a + b) / 2;
        Console.WriteLine("c = " + c);
        c -=40;
        Console.WriteLine("c = " + c);
        int[] v = new int[4];
        v[3] = a+b+c;

        Console.WriteLine("v[3] = " + v[3]);        
    }
}