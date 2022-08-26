//I can be placed before V (5) and X (10) to make 4 and 9. 
//X can be placed before L (50) and C(100) to make 40 and 90. 
//C can be placed before D (500) and M(1000) to make 400 and 900.
/*Symbol Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000*/
Console.WriteLine("Büyük harflerle romen rakamı giriniz");

string sayi=Console.ReadLine();
string[] romen = new string[7]{"M","D","C","L","X","V","I"};
int[] onluksay = new int[7]   {1000,500,100,50, 10, 5,  1 };
int sonuc = 0;
for(int i=0; i < sayi.Length; i++) 
{
    string hane = sayi[i].ToString();
    
    
    for(int j = 0; j < 7; j++) 
    {
        if (hane == romen[j]) { sonuc += onluksay[j]; }
    }
}
for(int i=0; i<sayi.Length; i++) 
{
    if (sayi[i]=='I' && i+1<sayi.Length && (sayi[i + 1] == 'V' || sayi[i+1]=='X')) { sonuc -= 2; }
    if (sayi[i] == 'X' && i + 1 < sayi.Length && (sayi[i + 1] == 'L' || sayi[i + 1] == 'C')) { sonuc -= 20; }
    if (sayi[i] == 'C' && i + 1 < sayi.Length && (sayi[i + 1] == 'D' || sayi[i + 1] == 'M')) { sonuc -= 200; }
}    
Console.WriteLine("Decimal karşılığı={0}",sonuc);
Console.ReadLine();