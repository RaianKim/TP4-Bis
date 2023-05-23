static class Info
{

private static List<Pais> ListaPaises = new List<Pais>();

private static void IniciarLista()
{
    
    ListaPaises.Add(new Pais("Argentina","BanderaArgentina.png",45810000,new DateTime(1816,07,09),"La Boca es un mítico barrio que se encuentra en la ciudad de Buenos Aires donde se mantiene una estética muy particular que te remonta a los primeros años cuando los inmigrantes llegaron al país."));
    ListaPaises.Add(new Pais("Brasil","BanderaBrasil.png",241300000,new DateTime(1822,9,7), "El Cristo Redentor o Cristo del Corcovado es una estatua art déco que representa a Jesús de Nazaret, con los brazos abiertos, mostrando a la ciudad de Río de Janeiro, Brasil. La estatua tiene una altura de treinta metros sobre un pedestal de ocho metros.​​"));
    ListaPaises.Add(new Pais("Francia","BanderaFrancia.png",67750000,new DateTime(1789,7,14),"París. La ciudad tiene tantos atractivos que debes elegir los principales si vas a pasar pocos días, como la Torre Eiffel, el Museo del Louvre, el Pantheon, el Arco del Triunfo y los Champs Elysees."));
    ListaPaises.Add(new Pais("Corea del Sur","BanderaCoreaDelSur.png",51740000,new DateTime(1945,8,15),"Seúl es el principal destino turístico para los visitantes; los destinos turísticos populares fuera de Seúl incluyen el parque nacional Seorak-san, la ciudad histórica de Gyeongju y la subtropical Jeju."));
    ListaPaises.Add(new Pais("Portugal","BanderaPortugal.png",10300000,new DateTime(1143,5,10),"El Monasterio de los Jerónimos de Lisboa y la Torre de los Clérigos de Oporto son los monumentos portugueses más visitados junto con el Convento de Cristo de Tomar y los Monasterios de Batalha y Alcobaça"));
}
public static List<Pais> ListarPaises()
{
    if(ListaPaises.Count == 0)
        {
            IniciarLista();
        }
    return ListaPaises;
}
public static Pais DetallePais(string nombre)
{
    Pais aux = new Pais();
    foreach (Pais item in ListaPaises)
    {
        if(item.Nombre == nombre)
        {
            return item;
        }
    }
    
    return aux;
}

}