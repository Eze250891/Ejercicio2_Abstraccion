namespace Ejercicio2_Abstraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente1 = new Gerente()
            {
                Nombre = "Capote",
                Antiguedad = 20,
                Salario = 800000,
            };

            var aguinaldoGerente = gerente1.CalcularSalario();


            Console.WriteLine($"El Gerente {gerente1.Nombre} con {gerente1.Antiguedad} anios de antiguedad, al finalizar de anio se lleva todo este dinero por ser Capote {aguinaldoGerente}");


            Diseniador diseniador1 = new Diseniador()
            {
                Nombre = "Jose",
                Antiguedad = 3,
                Salario = 200000,
            };
            var aguinaldoDiseniador = diseniador1.CalcularSalario();

            Console.WriteLine($"El Diseniador {diseniador1.Nombre} con {diseniador1.Antiguedad} anios de antiguedad, al finalizar de anio se lleva todo este dinero por ser trolito {aguinaldoDiseniador}");

            Programador programador = new Programador()
            {
                Nombre = "Educito",
                Antiguedad = 6,
                Salario = 600000,
            };

            var aguinaldoProgramador = programador.CalcularSalario();
            Console.WriteLine($"El Programador {programador.Nombre} con {programador.Antiguedad} anios de antiguedad, al finalizar anio se lleva todo este dinero por usar los deditos {aguinaldoProgramador}");


        }
    }
}