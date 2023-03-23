using csharp_abstract_animals;

Console.WriteLine("Cane: ");
Cane cane = new Cane();
cane.Verso();
cane.Dormi();
cane.Mangia();
cane.Nuota();
cane.FaiNuotare(cane);
Console.WriteLine();

Console.WriteLine("Passerotto: ");
Passerotto passerotto = new Passerotto();
passerotto.Verso();
passerotto.Dormi();
passerotto.Mangia();
passerotto.Vola();
passerotto.FaiVolare(passerotto);
Console.WriteLine();

Console.WriteLine("Aquila: ");
Aquila aquila = new Aquila();
aquila.Verso();
aquila.Dormi();
aquila.Mangia();
aquila.Vola();
aquila.FaiVolare(aquila);
Console.WriteLine();

Console.WriteLine("Delfino: ");
Delfino delfino = new Delfino();
delfino.Verso();
delfino.Dormi();
delfino.Mangia();
delfino.Nuota();
delfino.FaiNuotare(delfino);
Console.WriteLine();

Console.WriteLine("Pulcinella: ");
PulcinellaDiMare pulcinella = new PulcinellaDiMare();
pulcinella.Verso();
pulcinella.Dormi();
pulcinella.Mangia();
pulcinella.FaiNuotare(pulcinella);
pulcinella.FaiVolare(pulcinella);
Console.WriteLine();

