namespace awo
{
    class HelloWorld
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola,awo");
            Console.WriteLine("Escriba la cantidad de clientes que se van a registrar");
            int cantidad = int.Parse(Console.ReadLine());
            int exactos = 0;
            int incompletos = 0;
            int vueltas = 0;
            double totaldinerorecibido = 0;
            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"ingrese el nombre del cliente #{i}");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese el saldo a pagar");
                double saldo = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el monto con el que va a pagar");
                double monto = double.Parse(Console.ReadLine());
                totaldinerorecibido += monto;
                if (saldo == monto)
                {
                    Console.WriteLine("su pago fue exacto");
                    exactos++;
                }
                else if (monto > saldo)
                {
                    Console.WriteLine("su pago tiene vueltas ");
                    Console.WriteLine(monto - saldo);
                    vueltas++;
                }
                else
                {
                    Console.WriteLine("su pago fue incompleto");
                    incompletos++;
                }
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("RESUMEN FINAL");
            Console.WriteLine($"Total de clientes: {cantidad}");
            Console.WriteLine($"Exactos: {exactos}");
            Console.WriteLine($"Con vueltas: {vueltas}");
            Console.WriteLine($"Incompletos: {incompletos}");
            Console.WriteLine($"total dinero recibido {totaldinerorecibido}");
        }
    }
}