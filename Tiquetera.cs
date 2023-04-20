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
        }
        return cambioValido;
    }

    public static List<string> EstadisticasTicketera(){
        List<string> Estadisticas = new List<string>();
        Estadisticas.Add($"La cantidad de personas inscriptas es {DicClientes.Count}");
        int entradas1 = 0;
        int entradas2 = 0;
        int entradas3 = 0;
        int entradas4 = 0;


        for(int i=1; i<=DicClientes.Count; i++){
            if(DicClientes[i].TIPOENTRADA == 1){
                entradas1++;
            }
            else if(DicClientes[i].TIPOENTRADA == 2){
                entradas2++;
            }
            else if(DicClientes[i].TIPOENTRADA == 3){
                entradas3++;
            }
            else {
                entradas4++;
            }
        }
        Estadisticas.Add("El porcentaje de entradas tipo 1 es "+(entradas1*100/DicClientes.Count)+"\n"+"el procentaje de entradas 2 es "+(entradas2*100/DicClientes.Count)+"\n"+"el procentaje de entradas 3 es "+(entradas3*100/DicClientes.Count)+"\n"+"el procentaje de entradas 4 es "+(entradas4*100/DicClientes.Count)+"\n");
        Console.WriteLine(Estadisticas[1]);
    return Estadisticas;
    
    }
}