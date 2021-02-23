using System;
using System.Collections;
namespace Sistema_Excursiones
{
	
	public class Excursiones
	{
		//Crea nueva listas de atributos vacios para la clase Excursiones
		ArrayList ListaClientes = new ArrayList();
		ArrayList ListaEmpleados = new ArrayList();
		ArrayList ListaExcursion= new ArrayList();
		ArrayList ListaOmnibus = new ArrayList();
		ArrayList ListaDias= new ArrayList();
		ArrayList ListaCompra= new ArrayList();
		ArrayList ListaVenta= new ArrayList();
		
		
		//Creo el constructor Excursiones con los parametros que necesita y  recibe
		
		public Excursiones(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			//Reemplazo los atributos de las listas con los parametros recibidos
			this.ListaClientes=ListaClientes;
			this.ListaEmpleados=ListaEmpleados;
			this.ListaExcursion=ListaExcursion;
			this.ListaOmnibus=ListaOmnibus;
			this.ListaDias=ListaDias;
			this.ListaCompra=ListaCompra;
			this.ListaVenta=ListaVenta;
		}
		
		public void iniciar()
		{
			Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			Console.WriteLine ("* * *                         E X C U R S I O N E S                      * * *");
			Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			
			Console.WriteLine ("Seleccione una opcion del menu:\n\n"+
			                   "1 --> Armado de Excursiones\n"+
			                   "2 --> Gestion de empleados\n"+
			                   "3 --> Venta de excursiones\n"+
			                   "4 --> Estadisticas\n"+
			                   "5 --> Salir del sistema");
			string ac = Console.ReadLine();
			
			
			try {
				int accion =int.Parse(ac);
				while (accion !=6){
					switch(accion){
						case 1:
							Console.Clear();
							// Inicia modulo armado de excursiones
							Armado_Excursion modulo_armado = new Armado_Excursion();
							modulo_armado.Armado_de_excursion(this.ListaClientes,this.ListaEmpleados,this.ListaExcursion,this.ListaOmnibus,this.ListaDias,this.ListaCompra,this.ListaVenta);
							break;
						case 2:
							Console.Clear();
							// Inicia modulo gestion de empleados
							Console.Clear();
							Gestion_de_empleados modulo_gestion= new Gestion_de_empleados();
							modulo_gestion.gestion_empleados(this.ListaClientes,this.ListaEmpleados,this.ListaExcursion,this.ListaOmnibus,this.ListaDias,this.ListaCompra,this.ListaVenta);
							break;
						case 3 :
							Console.Clear();
							//Inicia modulo venta de excursiones
							Venta_de_excursiones modulo_venta= new Venta_de_excursiones();
							modulo_venta.venta_excursion(this.ListaClientes,this.ListaEmpleados,this.ListaExcursion,this.ListaOmnibus,this.ListaDias,this.ListaCompra,this.ListaVenta);
							break;
						case 4 :
							Console.Clear();
							//Inicia modulo estadisticas
							Estadisticas modulo_estadistica = new Estadisticas();
							modulo_estadistica.estadisticas(this.ListaClientes,this.ListaEmpleados,this.ListaExcursion,this.ListaOmnibus,this.ListaDias,this.ListaCompra,this.ListaVenta);
							break;
						case 5:
							Console.Clear ();
							Console.WriteLine ("Fin del Programa");
							Console.WriteLine ("");
							Console.WriteLine ("Hasta Luego");
							Console.ReadKey(true);	
							Environment.Exit (-1); //fin del programa
							break;
							
						default:
							
							Console.Clear();
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *                         E X C U R S I O N E S                      * * *");
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("Seleccione una opcion del menu:\n");
							Console.WriteLine ("1 --> Armado de Excursiones\n"+
							                   "2 --> Gestion de empleados\n"+
							                   "3 --> Venta de excursiones\n"+
							                   "4 --> Estadisticas\n"+
							                   "5 --> Salir del sistema");
							Console.WriteLine ("El número ingresado no es valido, vuelva a ingresar:");
							
							accion =int.Parse(Console.ReadLine());
							break;
							
					}
					
				}
				
			}
			catch{
				Console.Clear ();
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("Ha ingresado carácteres no válidos vuelva a intentarlo");
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("");
				this.iniciar();
			}
			
			
			
			
		}
		
		
	}
}
