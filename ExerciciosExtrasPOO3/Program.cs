using ExerciciosExtrasPOO3;

Veiculo carro = new Carro();
Veiculo caminhao = new Caminhao();
Veiculo moto = new Moto();

carro.setMarca("Honda");
carro.setModelo("Civic");
carro.setAno(2010);
((Carro)carro).setNumeroPorta(4);

caminhao.setMarca("Mercedez");
caminhao.setModelo("712");
caminhao.setAno(2025);
((Caminhao)caminhao).setCapacidadeCarga(1500);

moto.setMarca("BMW");
moto.setModelo("S1000");
moto.setAno(2026);
((Moto)moto).setCilindrada(1000);

Console.WriteLine();

carro.ExibirInfo();
Console.WriteLine();
caminhao.ExibirInfo();
Console.WriteLine();
moto.ExibirInfo();