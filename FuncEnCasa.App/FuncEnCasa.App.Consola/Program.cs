using System;
using FuncEnCasa.App.Dominio;
using FuncEnCasa.App.Persistencia;

namespace FuncEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPais _repoPais= new RepositorioPais(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            AgregarPais();
            //BuscarPais();
            //ModificarPais();
            //BorrarPais();
            //ObtenerTodosPaises();
        }
        private static void ObtenerTodosPaises()
        {
            var paises=_repoPais.ObtenerTodos();
            foreach (var pais in paises)
            {
                Console.WriteLine("ID: "+pais._Id+" Pais: "+pais.nombrePais);
            }
        }
        private static void AgregarPais()
        {
            Console.WriteLine("Agregue un pais");
            Pais pais= new Pais();
            Console.WriteLine("Escriba el nombre del pais");
            pais.nombrePais=Console.ReadLine();
           
            _repoPais.Agregar(pais);
        }
        private static void BuscarPais()
        {
            Console.WriteLine("Ingrese el Id del cliente a buscar: ");
            int id=int.Parse(Console.ReadLine());

            Pais pais=_repoPais.ObtenerId(id);
            Console.WriteLine("Nombre: "+pais.nombrePais+" ID:"+pais._Id);
        }
        private static void ModificarPais()
        {
            Console.WriteLine("Ingrese el id del pais que desea modificar");
            int id= int.Parse(Console.ReadLine());

            Pais pais=_repoPais.ObtenerId(id);
            Console.WriteLine("Ingrese el nombre nuevo del pais");
            pais.nombrePais=Console.ReadLine();
            _repoPais.Modificar(pais);
        }
        private static void BorrarPais()
        {
            Console.WriteLine("Ingrese el id del pais a borrar");
            int id=int.Parse(Console.ReadLine());
            var aux=_repoPais.ObtenerId(id);
            Console.WriteLine("Esta seguro que desea eliminar?"+aux._Id+" "+aux.nombrePais+" 1 para si 2 para no.");
            int res=int.Parse(Console.ReadLine());
            if(res==1)
            {
                _repoPais.Eliminar(id);
                Console.WriteLine("Se elimino el registro correctamente");
            }else if(res==2)
            {
                Console.WriteLine("No se elimino el registro");
            }else{
                Console.WriteLine("Opcion Erronea..");
            }
        }
    }
}
