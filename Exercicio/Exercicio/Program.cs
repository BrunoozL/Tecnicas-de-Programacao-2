using Exercicio;
Fabrica fabrica1 = new Fabrica("Fabrica 1", "Modelo 1", "2h", "Obs", "Máquina de costura", DateTime.Now);
fabrica1.AdicionarMaquinas("Modelo 3", "1h", "Obs", "Máquina de costura", DateTime.Now);

var maquina = new Maquina("Modelo 2", "2h", "Obs", "Máquina de costura", DateTime.Now);
fabrica1.ListarMaquinas(maquina);

var operador = new Operador("Bruno", maquina);
await operador.OperarMaquinaAsync(fabrica1, "Modelo 1");

Console.ReadKey();