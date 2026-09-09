
Equipe equipe = new Equipe("Ducati", "Alemanha", 1947);
Equipe equipe2 = new Equipe("Yamaha", "Japão", 1955);
Equipe equipe3 = new Equipe("Honda", "Japão", 1948);
equipe.MostrarInformacoes();
equipe2.MostrarInformacoes();
equipe3.MostrarInformacoes();

if (equipe.EhAntiga())
{
    Console.WriteLine("Essa é uma equipe antiga.");
}
else
{
    Console.WriteLine("Essa é uma equipe nova.");
}

equipe.AlterarPais("Brasil");

Console.WriteLine(equipe);




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

moto2.MostrarInformacoes();

if (moto2.EhAntiga())
{
    Console.WriteLine("Essa moto é antiga.");
}
else    
{
    Console.WriteLine("Essa moto é nova.");
}

moto2.AlterarAno(2025);

moto3.MostrarInformacoes();

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



Piloto piloto = new Piloto("João", 41, "Yamaha");

piloto.Apresentar();

if (piloto.EhMaiorDeIdade())
{
    Console.WriteLine("É maior de idade.");
}

piloto.TrocarEquipe("Mercedes");

Console.WriteLine(piloto);
