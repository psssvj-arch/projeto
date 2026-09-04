Equipe equipe = new Equipe("Ducati", "Alemanha", 1947);
Equipe equipe2 = new Equipe("Yamaha", "Japão", 1953);
Equipe equipe3 = new Equipe("Honda", "Japão", 1948);

Moto moto1 = new Moto("Ducati Panigale V4", "Ducati", 2021);
Moto moto2 = new Moto("Yamaha YZF-R1", "Yamaha", 2021);
Moto moto3 = new Moto("Honda CBR1000RR", "Honda", 2021);

Piloto piloto1 = new Piloto("Matheus", 42, "Yamaha");
Piloto piloto2 = new Piloto("Carlos", 38, "Ducati");
Piloto piloto3 = new Piloto("Pedro", 07, "Honda");

piloto1.Idade = 26;
piloto2.Equipe = "Honda";

equipe1.Pais = "Japão";
equipe2.Nome = "Honda Moto Racing";

moto1.Ano = 2025;
moto2.Modelo = "RC213V 2026";

Console.WriteLine("===== PILOTOS =====");
Console.WriteLine(piloto1);
Console.WriteLine(piloto2);

Console.WriteLine();

Console.WriteLine("===== EQUIPES =====");
Console.WriteLine(equipe1);
Console.WriteLine(equipe2);

Console.WriteLine();

Console.WriteLine("===== MOTOS =====");
Console.WriteLine(moto1);
Console.WriteLine(moto2);