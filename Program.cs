using System;
using System.Collections;
namespace Sistema_Excursiones
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList ListaClientes = new ArrayList();
			ArrayList ListaEmpleados = new ArrayList();
			ArrayList ListaExcursion= new ArrayList();
			ArrayList ListaOmnibus = new ArrayList();
			ArrayList ListaDias= new ArrayList();
			ArrayList ListaVentas=new ArrayList();
			ArrayList ListaCompra= new ArrayList();
			ArrayList ListaVenta= new ArrayList();
			
			
			
			PreCarga pre=new PreCarga();
			
			
			pre.preCargaClientes(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			pre.preCargaEmpleados(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			pre.preCargaExcursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			pre.preCargaOmnibus(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			Excursiones excursion = new Excursiones(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			excursion.iniciar();
			Console.ReadKey(true);
		}
	}
}