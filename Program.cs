using csharp_abstract_animals;

Console.WriteLine("Cane: ");
Cane cane = new Cane();
cane.Verso();
cane.Dormi();
cane.Mangia();
cane.Nuota();   

Console.WriteLine("Passerotto: ");
Passerotto passerotto = new Passerotto();
passerotto.Verso();
passerotto.Dormi();
passerotto.Mangia();
passerotto.Vola();

Console.WriteLine("Aquila: ");
Aquila aquila = new Aquila();
aquila.Verso();
aquila.Dormi();
aquila.Mangia();
aquila.Vola();

Console.WriteLine("Delfino: ");
Delfino delfino = new Delfino();
delfino.Verso();
delfino.Dormi();
delfino.Mangia();
delfino.Nuota();
