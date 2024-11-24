namespace InSoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InSoNT();
        }
        public static void InSoNT()
        {
            Console.WriteLine("Nhap n (Gioi han cua day so): ");
            string str = Console.ReadLine();
            bool passSucess = int.TryParse(str, out int n);
            if( passSucess ) 
            {
                int dem = 0;
                for (int i = 2; i <= n; i++)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        if( i % j == 0 )
                        {
                            dem += 1;
                        }  
                    }    
                    if (dem == 2)
                    {
                        Console.WriteLine(i);
                    }
                    dem = 0;
                }
            }
            else 
            {
                Console.WriteLine("Loi nhap so nguyen cho n!");
            }
            
        }
    }
}
