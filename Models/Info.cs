static class Info
{

private static List<Pais> ListaPaises = new List<Pais>();

private static void IniciarLista()
{
    
    ListaPaises.Add(new Pais("Argentina","/Imagenes/BanderaArgentina.png",45810000,new DateTime(09/07/1816),"La Boca es un mítico barrio que se encuentra en la ciudad de Buenos Aires donde se mantiene una estética muy particular que te remonta a los primeros años cuando los inmigrantes llegaron al país."));
    
    
}
public static List<Pais> ListarPaises()
{
    return ListaPaises;
}
//public static Pais DetallePais(string Nombre)
{
    
}
}