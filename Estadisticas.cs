using System;
using System.Collections;
using System.Collections.Generic;
namespace Sistema_Excursiones
{
	
	public class Estadisticas
	{
		public void estadisticas(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra, ArrayList ListaVenta)
		{
			
			Console.Clear();
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			Console.WriteLine ("* * *                             MODULO  ESTADISTICAS                  * * *");
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
			Console.WriteLine("Seleccione una opcion del menu\n");
			Console.WriteLine("1) Consultar la cantidad de excursiones vendidas\n" +
			                  "2) Consultar los clientes que mas viajan\n" +
			                  "3) Consultar la excursion mas solicitada\n" +
			                  "4) Consultar el operador que mas excursiones vende\n" +
			                  "5) Volver\n");
			string ac = Console.ReadLine();
			try{
				int accion = int.Parse(ac);
				while(accion !=5){
					switch(accion){
						case 1:
							Console.Clear();
							
							this.menu();
							int sumatotal=0;
							foreach(Empleado empleado in ListaEmpleados){
								sumatotal +=empleado.getComprayVenta();
								
							}
							Console.WriteLine("La cantidad de excursiones vendidas es: " + sumatotal);
							Console.WriteLine("\nPresione una tecla para volver");
							Console.ReadKey(true);
							this.estadisticas(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							break;
						case 2 :
							//int cswap;
							List<IComparable> clientes = new List<IComparable>();
							foreach(Cliente cl in ListaClientes){
								clientes.Add(cl);
							}
						
							ordenarPorIntercambio(new List<IComparable>(clientes));
							
						
							
							Console.WriteLine("\nPresione una tecla para volver");

							Console.ReadKey(true);
							this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							break;
						case 3:
							List<IComparable> excursion = new List<IComparable>();
							foreach(Excursion ex in ListaExcursion){
								excursion.Add(ex);
							}
							
							ordenarPorIntercambio(new List<IComparable>(excursion));
							Console.ReadKey(true);
							this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
						
							break;
						case 4:
							List<IComparable> emplea = new List<IComparable>();
							foreach(Empleado em in ListaEmpleados){
								emplea.Add(em);
							}
							ordenarPorIntercambio(new List<IComparable>(emplea));
							Console.ReadKey(true);
														this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
						break;
					}
					
				}
			}
			catch{}
			this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			
			Console.ReadKey(true);
		}
		public void volver(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Console.Clear();
			Excursiones excursion1 = new Excursiones(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			excursion1.iniciar();
		}
		public void menu(){
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			Console.WriteLine ("* * *                             MODULO  ESTADISTICAS                  * * *");
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
		}
		private static int ordenarPorIntercambio(List<IComparable> datos){
			
			
			int n = datos.Count;
			for(int i=0; i<(n-1); i++)
				for(int j=i+1; j<n; j++)
					if(datos[i].CompareTo(datos[j]) < 0){
				IComparable swap = datos[i];
				datos[i] = datos[j];
				datos[j] = swap;
				
			}
			
			
			
			foreach(object v in datos)
			 
				Console.WriteLine(v);
			
			
			return n;
		}
		
		
		
		
	}
	
}











