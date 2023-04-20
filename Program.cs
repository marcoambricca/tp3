int menu = 0;
 

do {
    Console.WriteLine("1 - Nueva inscripción");
    Console.WriteLine("2 - Obtener Estadisticas del Evento");
    Console.WriteLine("3 - Buscar Cliente");
    Console.WriteLine("4 - Cambiar entrada de un Cliente");
    Console.WriteLine("5 - Salir");
    menu = Funciones.IEnteroRango("", 1, 5);

    switch(menu){
        case 1:
            Console.Clear();
            Console.WriteLine("Precio entradas: (tipo entrada) \nDia 1: $15000 - Dia 2: $30000 - Dia 3: $10000 - Full Pass: $40000");
            Funciones.nuevaInscripcion();
            break;
        case 2:
            Tiquetera.EstadisticasTicketera();
            break;
        case 3:
            int busqueda = Funciones.IEnteroRango("Ingrese el ID del cliente que busca: ", 0, int.MaxValue);
            Cliente buscado = Tiquetera.BuscarCliente(busqueda);
            Console.WriteLine($"DNI: {buscado.DNI}");
            Console.WriteLine($"Apellido: {buscado.APELLIDO}");
            Console.WriteLine($"Nombre: {buscado.NOMBRE}");
            Console.WriteLine($"Tipo entrada: {buscado.TIPOENTRADA}");
            Console.WriteLine($"Tipo abonado: {buscado.TOTALABONADO}");
            break;
        case 4:
            int id = Funciones.IEnteroRango("Ingrese el ID del cliente que busca: ", 0, int.MaxValue);
            int tipo = Funciones.IEnteroRango("Ingrese el tipo de entrada nuevo: ", 1, 4);
            int total = Funciones.vec[tipo-1];
            Tiquetera.CambiarEntrada(id, tipo, total);
            break;
    }
}
while(menu != 5);