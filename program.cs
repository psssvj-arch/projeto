

Equipe equipe1 = new Equipe("Ducati", "Alemanha", 1947);
Equipe equipe2 = new Equipe("Yamaha", "Japão", 1955);
Equipe equipe3 = new Equipe("Honda", "Japão", 1948);


equipe1.MostrarInformacoes();
equipe2.MostrarInformacoes();
equipe3.MostrarInformacoes();


if (equipe1.EhAntiga())
{
    Console.WriteLine("Essa é uma equipe antiga.");
}
else
{
    Console.WriteLine("Essa é uma equipe nova.");
}
equipe1.AlterarPais("Brasil");


if (equipe2.EhAntiga())
{
    Console.WriteLine("Essa é uma equipe antiga.");
}
else
{
    Console.WriteLine("Essa é uma equipe nova.");
}
equipe2.AlterarPais("Brasil");


if (equipe3.EhAntiga())
{
    Console.WriteLine("Essa é uma equipe antiga.");
}
else
{
    Console.WriteLine("Essa é uma equipe nova.");
}
equipe3.AlterarPais("Brasil");


Console.WriteLine(equipe1);
Console.WriteLine(equipe2);
Console.WriteLine(equipe3);





Moto moto1 = new Moto("CB 500", "Honda", 2020);
Moto moto2 = new Moto("R1", "Yamaha", 2020);
Moto moto3 = new Moto("Panigale", "Ducati", 2020);


moto1.MostrarInformacoes();
moto2.MostrarInformacoes();
moto3.MostrarInformacoes();


if (moto1.EhAntiga())
{
    Console.WriteLine("Essa moto é antiga.");
}
else
{
    Console.WriteLine("Essa moto é nova.");
}
moto1.AlterarAno(2025);


if (moto2.EhAntiga())
{
    Console.WriteLine("Essa moto é antiga.");
}
else    
{
    Console.WriteLine("Essa moto é nova.");
}
moto2.AlterarAno(2025);


if (moto3.EhAntiga())
{
    Console.WriteLine("Essa moto é antiga.");
}
else
{
    Console.WriteLine("Essa moto é nova.");
}
moto3.AlterarAno(2025);


Console.WriteLine(moto1);
Console.WriteLine(moto2);
Console.WriteLine(moto3);





Piloto piloto1 = new Piloto("João", 41, "Yamaha");
Piloto piloto2 = new Piloto("Maria", 25, "Honda");
Piloto piloto3 = new Piloto("Pedro", 30, "Ducati");


piloto1.Apresentar();
piloto2.Apresentar();
piloto3.Apresentar();


if (piloto1.EhMaiorDeIdade())
{
    Console.WriteLine("É maior de idade.");
}
piloto1.TrocarEquipe("Ducati");


if (piloto2.EhMaiorDeIdade())
{
    Console.WriteLine("É maior de idade.");
}
piloto2.TrocarEquipe("Ducati");


if (piloto3.EhMaiorDeIdade())
{
    Console.WriteLine("É maior de idade.");
}
piloto3.TrocarEquipe("Ducati");


Console.WriteLine(piloto1);
Console.WriteLine(piloto2);
Console.WriteLine(piloto3);