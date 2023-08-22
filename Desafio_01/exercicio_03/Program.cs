class Program {
    static void Main() {
        int a = 7;
        Console.WriteLine("a = " + a);
        int b = a - 6;
        Console.WriteLine("b = " + b);
        int [] v = new int[6];

        while (b<a) {
            v[b] = b + a;
            Console.WriteLine($"v[{b}] = " + v[b]);
            b+=2;
            Console.WriteLine("b = " + b);
        }
    }
}