using System.Collections.Generic;

public static  class Tiquetera{
    private static Dictionary<int, Cliente> DicClientes = new Dictionary<int, Cliente>();
    private static int UltimoIDEntrada = 1;
    public static int DevolverUltimoID(){
        return UltimoIDEntrada;
    }
    public static int AgregarCliente(Cliente cliente){
        DicClientes.Add(UltimoIDEntrada, cliente);
        Console.WriteLine(DicClientes.Count);
        return UltimoIDEntrada++;
    }
    public static Cliente BuscarCliente(int idEntrada){
        Cliente busqueda = new Cliente();
        foreach (int n in DicClientes.Keys){
            if (n == idEntrada){
                busqueda = DicClientes[n];
            }
        }
        return busqueda;
    }

    public static bool CambiarEntrada(int id, int tipo, int total){
        Cliente cambio = BuscarCliente(id);
        bool cambioValido = false;
        if(cambio.TOTALABONADO<total){
            cambio.TIPOENTRADA = tipo;
            cambio.TOTALABONADO = total;
            cambioValido = true;
            Console.WriteLine("Se cambio el tipo de entrada correctamente.");
        }
        else {
            Console.WriteLine("La entrada nueva es de menor valor a la anterior");
        }
        return cambioValido;
    }

    public static List<string> EstadisticasTicketera(){
        List<string> Estadisticas = new List<string>();
        if (DicClientes.Count > 0){
            Estadisticas.Add($"La cantidad de personas inscriptas es {DicClientes.Count}");
        int entradas1 = 0;
        int entradas2 = 0;
        int entradas3 = 0;
        int entradas4 = 0;
        int[] totales = {0, 0, 0, 0};


        for(int i=1; i<=DicClientes.Count; i++){
            if(DicClientes[i].TIPOENTRADA == 1){
                entradas1++;
                totales[0] += 15000;
            }
            else if(DicClientes[i].TIPOENTRADA == 2){
                entradas2++;
                totales[1] += 30000;
            }
            else if(DicClientes[i].TIPOENTRADA == 3){
                entradas3++;
                totales[2] += 10000;
            }
            else {
                entradas4++;
                totales[3] += 40000;
            }
        }
        int total = totales[0]+totales[1]+totales[2]+totales[3];
        Estadisticas.Add("El porcentaje de entradas dia 1 es %"+(entradas1*100/DicClientes.Count)+"\n"+"El porcentaje de entradas dia 2 es %"+(entradas2*100/DicClientes.Count)+"\n"+"El porcentaje de entradas dia 3 es %"+(entradas3*100/DicClientes.Count)+"\n"+"El porcentaje de entradas full pass es %"+(entradas4*100/DicClientes.Count)+"\n");
        Estadisticas.Add($"Recaudacion dia 1: ${totales[0]}\nRecaudacion dia 2: ${totales[1]}\nRecaudacion dia 3: ${totales[2]}\nRecaudacion full pass: ${totales[3]}\n");
        Estadisticas.Add($"Recaudacion total: ${total}");
        Console.WriteLine(Estadisticas[0]);
        Console.WriteLine(Estadisticas[1]);
        Console.WriteLine(Estadisticas[2]);
        Console.WriteLine(Estadisticas[3]);
        }
        else {
            Console.WriteLine("Aun no se anoto nadie.");
        }

        return Estadisticas;
    }
}