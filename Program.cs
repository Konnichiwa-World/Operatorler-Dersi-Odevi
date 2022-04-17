using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine(" 'Rakam tahmin etme oyunu'na hosgeldiniz. Lütfen önce cinsiyet belirtiniz: \n Bay için 1, Bayan için 2");
        int a=Convert.ToInt32(Console.ReadLine());
            if(1==a){
        
                System.Console.WriteLine("Oyunun tek bir kurali var; 0,1 yada 2 arasinda, hangi sayinin \n dogru oldugunu bulabilmek. %33 şansın var. Bol Şanslar :)");
            
                Random rastgele = new Random();
                int x = rastgele.Next(0,2);

                int y = Convert.ToInt16(Console.ReadLine());

                if(y==x){Console.WriteLine("ADAAAAM! Sen Kralsın reis, parti kur oy verelim. :D Güzel tahmin. ");}

                if(y!=x){
                Console.WriteLine("Neyse bi hak daha verelim. %50 şansın var :) Hadi dene.");
                int z = Convert.ToInt16(Console.ReadLine());
                if(z==x){Console.WriteLine("ADAAAAM! Kralsın reis, parti kur oy verelim. :D Güzel tahmin. ");}
                else{Console.WriteLine("Başaramadın :) Tekniğin güzel ama geliştirmen lazım çekirge. ");} }
                }

            if(2==a){
        
                System.Console.WriteLine("Oyunun tek bir kurali var; 0,1 yada 2 arasinda, hangi sayinin \n dogru oldugunu bulabilmek. %33 şansın var. Bol Şanslar :)");
            
                Random rastgele = new Random();
                int x = rastgele.Next(0,2);

                int y = Convert.ToInt16(Console.ReadLine());
                if(y==x){Console.WriteLine("BİNGO! Hey millet toplanın, Tanrıça Afrodit'i bulduk! ;) ");}

                if(y!=x){

                Console.WriteLine("Neyse bi hak daha verelim. %50 şansın var :) Hadi dene.");
                int z = Convert.ToInt16(Console.ReadLine());
                if(y==z){Console.WriteLine("BİNGO! Hey millet toplanın, Tanrıça Afrodit'i bulduk! ;) ");}
                else{Console.WriteLine("Başaramadın :) Küçük Hanım, güzel olduğunuz kadar şanssızsınız da. ");} }
            
            }

        }
    }
}
