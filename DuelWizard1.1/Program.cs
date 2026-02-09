Wizard wizardA = new Wizard("Gojo", 20);
Wizard wizardB = new Wizard("sukuna", 30);

Console.WriteLine("Pertarungan Dimulai!!!\n");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardB.Heal();
//wizardA.Attack(wizardB);


string pilihan;

while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nMasukkan pilihan anda (1/2/3/4): ");
    pilihan = Console.ReadLine();
    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if (pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan anda tidak ada");
    }
}

Console.WriteLine("Pertarungan Berakhir!!!\n");
wizardA.ShowStats();
wizardB.ShowStats();
public class Wizard
{
    public string Name;
    public int Energy;
    public int Damage;


    // deklarasi construktor
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 50;
        Damage = damage;



    }



    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energy: {Energy} \n");


    }

    public void Attack(Wizard wizardLawanobj)
    {
        wizardLawanobj.Energy -= Damage;
        Console.WriteLine($"{Name} Menyerang{wizardLawanobj.Name}");
        Console.WriteLine($"Sisa Energi {wizardLawanobj.Name} adalah {wizardLawanobj.Energy} \n");
    }

    public void Heal()
    {
        Energy += 5;

        if (Energy <= 100)
        {
            Console.WriteLine($"{Name} melakukan heal! Energi meningkat mmenjadi{Energy}"); 
        }
        else
        {
            Energy = 100; 
            Console.WriteLine("Sudah mencapai energi maksimal");
        }
    }


}
