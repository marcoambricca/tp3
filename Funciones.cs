public static class Funciones{
    public static int[] vec = {15000, 30000, 10000, 40000};

    public static int IEnteroRango(string msg, int min, int max){
        Console.WriteLine(msg);
        int num = int.Parse(Console.ReadLine());
        while (num < min || num > max){
            num = int.Parse(Console.ReadLine());
        }
        return num;
    }

    public static string IString(string msg){
        Console.WriteLine(msg);
        return Console.ReadLine();
    }

    public static void nuevaInscripcion(){
        
    int DNI = Funciones.IEnteroRango("Ingrese su DNI: ", 0, int.MaxValue);
    string apellido = Funciones.IString("Ingrese su apellido: ");
    string nombre = Funciones.IString("Ingrese su nombre: ");
    DateTime fechaInscripcion = DateTime.Now;
    int tipoEntrada = Funciones.IEnteroRango("Ingrese el tipo de entrada: ", 1, 4);
    int totalAbonado = vec[tipoEntrada-1];
    Cliente nuevaInscripcion = new Cliente(DNI, apellido, nombre, fechaInscripcion, tipoEntrada, totalAbonado);
    Tiquetera.AgregarCliente(nuevaInscripcion);
    }
}