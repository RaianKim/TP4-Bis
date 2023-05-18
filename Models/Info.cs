static class Info
{

private static List<Pais> ListaPaises = new List<Pais>();

private static void IniciarLista()
{
    
    ListaPaises.Add(new Pais("Argentina","BanderaArgentina.png",45810000,new DateTime(09/07/1816),"La Boca es un mítico barrio que se encuentra en la ciudad de Buenos Aires donde se mantiene una estética muy particular que te remonta a los primeros años cuando los inmigrantes llegaron al país."));
    ListaPaises.Add(new Pais("Brasil","BanderaBrasil.png",241300000,new DateTime(7/9/1822), "El Cristo Redentor o Cristo del Corcovado es una estatua art déco que representa a Jesús de Nazaret, con los brazos abiertos, mostrando a la ciudad de Río de Janeiro, Brasil. La estatua tiene una altura de treinta metros sobre un pedestal de ocho metros.​​"));
    ListaPaises.Add(new Pais("Francia","BanderaFrancia.png",67750000,new DateTime(14/7/1789),"París. La ciudad tiene tantos atractivos que debes elegir los principales si vas a pasar pocos días, como la Torre Eiffel, el Museo del Louvre, el Pantheon, el Arco del Triunfo y los Champs Elysees."));
    ListaPaises.Add(new Pais("Corea del Sur","BanderaCoreaDelSur.png",51740000,new DateTime(15/8/1945),"Seúl es el principal destino turístico para los visitantes; los destinos turísticos populares fuera de Seúl incluyen el parque nacional Seorak-san, la ciudad histórica de Gyeongju y la subtropical Jeju."));
    ListaPaises.Add(new Pais("Portugal","BanderaPortugal.png",10300000,new DateTime(5/10/1143),"El Monasterio de los Jerónimos de Lisboa y la Torre de los Clérigos de Oporto son los monumentos portugueses más visitados junto con el Convento de Cristo de Tomar y los Monasterios de Batalha y Alcobaça"));
}
public static List<Pais> ListarPaises()
{
    return ListaPaises;
}
public static Pais DetallePais(string nombre)
{
    int aux = 0;
    bool i = false;
    Pais pais = new Pais();
    while(i != true || ListaPaises.Count > aux)
    {
        if(ListaPaises[aux].Nombre == nombre)
        {
            i = true;
        }
    }
    if(i == true)
    {
        pais = ListaPaises[aux];
    }
    return pais;
}

}