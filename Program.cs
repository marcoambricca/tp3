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
            Console.WriteLine("Precio entradas: (tipo entrada) \nDia 1: $15000 - Dia 2: $30000 - Dia 3: $10000 - Full Pass: $40000");
            Funciones.nuevaInscripcion();
            break;
        case 2:
            
            Tiquetera.EstadisticasTicketera();
            break;
    }
}
while(menu != 5);