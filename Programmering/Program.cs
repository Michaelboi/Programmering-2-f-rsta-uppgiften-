using Programmering2Exempel;
using System;

int beräknaArea(int sida1, int sida2)
{
    return sida1 * sida2;
}
Console.WriteLine(beräknaArea(5, 4));

string Bilinfo = Console.ReadLine();


Bil Bil1 = new Bil();
Bil Bil2 = new Bil();
Bil Bil3 = new Bil();


Bil1.setFärg("Röd");
Bil2.setFärg("Svart");
Bil3.setFärg("Gul");
Bil2.sethjul(6);
Bil3.sethjul(7);

// get/set

Bil[] Array = new Bil[5];
Array[0] = Bil1;
Array[1] = Bil2;
Array[2] = Bil3;

// skriver man bil så får man fram information om en bil
if (Bilinfo == "bil")
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine("Bilen har " + Array[1].getHjul() + " hjul");
        Console.WriteLine("Bilens färg är " + Array[1].getFärg());
        break;
    
    }



}