public class Cliente {
    public int DNI {get; private set;}
    public string APELLIDO {get; private set;}
    public string NOMBRE {get; private set;}

    public DateTime FECHAINSCRIPCION {get; set;}
    public int TIPOENTRADA {get; set;}
    public int TOTALABONADO {get; set;}

    public Cliente(){}

    public Cliente(int dni, string apellido, string nombre, DateTime fechaInscripcion, int tipoEntrada, int totalAbonado){
        DNI = dni;
        APELLIDO = apellido;
        NOMBRE = nombre;
        FECHAINSCRIPCION = fechaInscripcion;
        TIPOENTRADA = tipoEntrada;
        TOTALABONADO = totalAbonado;
    }

    
}