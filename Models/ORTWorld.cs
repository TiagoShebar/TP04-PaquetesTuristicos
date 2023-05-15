class ORTWorld {
    public static List<string> ListaDestinos {get; private set;} = new List<string>(){"Buenos Aires", "Paris", "Madrid", "Roma", "Santiago de Chile", "Berlin", "Amsterdam", "Bogota", "Caracas", "Brasilia"};

    public static List<string> ListaHoteles {get; private set;} = new List<string>(){"hotel1.jpg", "hotel2.jpg", "hotel3.jpg", "hotel4.jpg", "hotel5.jpg", "hotel6.jpg", "hotel7.jpg", "hotel8.jpg", "hotel9.jpg", "hotel10.jpg"};
    public static List<string> ListaAereos {get; private set;} = new List<string>(){"aereo1.jpg", "aereo2.jfif", "aereo3.jfif", "aereo4.jfif","aereo5.jfif", "aereo6.jfif", "aereo7.jfif", "aereo8.jfif", "aereo9.jfif", "aereo10.jfif"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string>(){"excursion1.jpg", "excursion2.jpg", "excursion3.jpg", "excursion4.jpg", "excursion5.jpg", "excursion6.jpg", "excursion7.jpg", "excursion8.jpg", "excursion9.jpg", "excursion10.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        bool seAgrega;
        if(Paquetes.ContainsKey(destinoSeleccionado)){
            seAgrega = false;
        }
        else{
            Paquetes.Add(destinoSeleccionado, paquete);
            seAgrega = true;
        }
        return seAgrega;
    }
}