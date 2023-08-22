class Program {
    static void Main() {
        int a = 2;
        Console.WriteLine("a = " + a);
        int[] v = new int[6];
        while (a < 6) {
            v[a] = 10 * a;
            Console.WriteLine($"v[{a}] = " + v[a]);
            a+=1;
            Console.WriteLine("a = " + a);
        }
    }
}