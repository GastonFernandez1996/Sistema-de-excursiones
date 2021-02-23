using System;
using System.Collections;
namespace Sistema_Excursiones
{
	
	public class Gestion_de_empleados
	{
		public void gestion_empleados(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Console.Clear();
			Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
			Console.WriteLine ("* * *                       MODULO  GESTION  de  EMPLEADOS                * * *");
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			
			Console.WriteLine("\nSeleccione una opcion del menu\n");
			
			Console.WriteLine("1) Alta de Emplado\n" +
			                  "2) Baja de Empleado\n" +
			                  "3) Listado de Empleados\n" +
			                  "4) Volver");
			Console.WriteLine("");
			string ac= Console.ReadLine();
			try{
				int accion =int.Parse(ac);
				while(accion !=4){
					switch(accion){
						case 1:
							Console.Clear();
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
							Console.WriteLine ("* * *                       SUBMODULO  ALTA  de  EMPLEADOS                * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
							
							string nomyape ,dni;
							int num_legajo;
							Console.WriteLine("\nIngrese el nombre y apellido del empleado");
							nomyape=Console.ReadLine();
							Console.WriteLine("\nIngrese dni del empleado");
							dni=Console.ReadLine();
							num_legajo=ListaEmpleados.Count;//cuenta la cantidad de empleados que hay y los agrega a num_legado
							
							//Validad si el Empleado existe en el sistema
							bool existe=false;
							foreach(Empleado empleado1 in ListaEmpleados){
								if(empleado1.getDni()==dni){
									Console.WriteLine("\nYa existe un Empleado con ese DNI en el sistema");
									existe=true;
								}
								
							}
							//si no existe , crea un empleado , lo setea y lo agrega a listaempleados.
							if(existe==false){
								//
								Empleado empleado = new Empleado();
								empleado.setNomyApe(nomyape);
								empleado.setDni(dni);
								empleado.setLegajo(num_legajo+1);
								ListaEmpleados.Add(empleado);
								Console.WriteLine("\nEl empleado fue dado de alta correctamente con el numero:" + empleado.getLegajo());
							}
							
							Console.WriteLine("\nIngrese una tecla para continuar");
							Console.ReadKey(true);
							Console.Clear();
							this.gestion_empleados(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							break;
							
						case 2:
							Console.Clear();
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
							Console.WriteLine ("* * *                       SUBMODULO  BAJA  de  EMPLEADOS                * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
							
							
							foreach(Empleado emplea in ListaEmpleados){
								Console.WriteLine(emplea.mostrarempleado());
							}
							Console.WriteLine("\nIngrese el numero de legajo a dar de baja");
							num_legajo=int.Parse(Console.ReadLine());
							foreach(Empleado empleado1 in ListaEmpleados){
								//verifica que el numero de legajo exista , si existe elimina el empleado.
								if(num_legajo==empleado1.getLegajo()){
									ListaEmpleados.Remove(empleado1);
								}
							}
							Console.WriteLine("Lista actualizada");
							foreach(Empleado empl in ListaEmpleados){
								Console.WriteLine(empl.mostrarempleado());
							}
							Console.WriteLine("\nIngrese una tecla para continuar");
							Console.Clear();
							Console.ReadKey(true);
							//vuelve al modulo gestion de empleados
							this.gestion_empleados(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta); // vuelve al menu gestion de empleados
							
							
							
							break;
						case 3:
							Console.Clear();
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
							Console.WriteLine ("* * *                       SUBMODULO  LISTADO  de  EMPLEADOS             * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							//muestra el listado de los empleados.
							Console.WriteLine("\nListado de empleados\n");
							foreach(Empleado empleados in ListaEmpleados){
								Console.WriteLine(empleados.mostrarempleado());
							}
							Console.WriteLine("\nPresione una tecla para volver");
							Console.ReadKey(true);
							this.gestion_empleados(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							break;
						default:
							Console.Clear();
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
							Console.WriteLine ("* * *                       MODULO  GESTION  de  EMPLEADOS                * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							
							
							Console.WriteLine("\nSeleccione una opcion del menu\n");
							
							Console.WriteLine("1) Alta de Emplado\n" +
							                  "2) Baja de Empleado\n" +
							                  "3) Listado de Empleados\n" +
							                  "4) Volver");
							Console.WriteLine ("\nEl número ingresado no es valido, vuelva a ingresar:\n");
							ac=Console.ReadLine();
							accion =int.Parse(ac);
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
				
				this.gestion_empleados(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			}
			this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			
			Console.ReadKey(true);
			
			
		}
		
		public void volver(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Console.Clear();
			Excursiones excursion1 = new Excursiones(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			excursion1.iniciar();
		}
	}
}
