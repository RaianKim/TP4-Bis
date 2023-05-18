static class Info
{

private static List<Pais> ListaPaises = new List<Pais>();

private static void IniciarLista()
{
    
    ListaPaises.Add(new Pais{Nombre = "Argentina", });
    
    
}
public static List<Pais> ListarPaises()
{
    return ListaPaises;
}
//public static Pais DetallePais(string Nombre)
{
    
}
}