Wizard wizardA = new Wizard("Gojo", 20);
Wizard wizardB = new Wizard("sukuna", 30);

Console.WriteLine("Pertarungan Dimulai!!!\n");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);
wizardB.Attack(wizardA);

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
        Energy = 100;
        Damage = damage;



    }



    public void ShowStats()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energy: {Energy} \n");


    }

    public void Attack(Wizard wizardLawanobj)
    {
        wizardLawanobj.Energy -= Energy;
        Console.WriteLine($"{Name} Menyerang{wizardLawanobj}");
        Console.WriteLine($"Sisa Energi {wizardLawanobj.Name} adalah {wizardLawanobj.Energy} \n");
    }









    }
