namespace ConsoleApp1 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            String a = Console.ReadLine(); 
            int max = Math.Max( 
                (int)(a[0] - '0'), Math.Max((int)(a[1] - '0'), Math.Max((int)(a[2] - '0'), (int)(a[3] - '0')))); 
            int min = Math.Min( 
                (int)(a[0] - '0'), Math.Min((int)(a[1] - '0'), Math.Min((int)(a[2] - '0'), (int)(a[3] - '0')))); 
 
            Console.WriteLine(min + max); 
        } 
    } 
}