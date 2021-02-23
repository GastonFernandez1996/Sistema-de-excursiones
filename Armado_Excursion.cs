using System;
using System.Collections;
using System.Collections.Generic;
namespace Sistema_Excursiones
{

	public class Armado_Excursion
	{
		public void Armado_de_excursion(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Console.Clear();
			Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
			Console.WriteLine ("* * *                       MODULO  ARMADO  de  EXCURSION                 * * *");
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			
			
			Console.WriteLine("Seleccione una opcion del menu\n");
			
			Console.WriteLine("1) Alta de Excursiones\n" +
			                  "2) Baja de Excursiones\n" +
			                  "3) Alta de Omnibus\n" +
			                  "4) Baja de Omnibus\n" +
			                  "5) Listado de excursiones disponibles\n" +
			                  "6) Volver\n");
			string ac= Console.ReadLine();
			
			try{
				int accion =int.Parse(ac);
				while(accion !=6){
					switch(accion){
							
						case 1:
							Console.Clear();
							
							string nombre,recorrido,horario,duracion,dia;
							
							ArrayList recorrido1 = new ArrayList();
							ArrayList dia1= new ArrayList();
							int num,omnibus_asignado;
							
							Console.WriteLine("Ingrese nombre de la excursion");
							nombre=Console.ReadLine();
							nombre=nombre.ToLower();
							Console.WriteLine("Ingrese el recorrido, Enter Finaliza");
							recorrido=Console.ReadLine();
							
							while(recorrido !=""){
								recorrido1.Add(recorrido +"," );
								
								
								Console.WriteLine("Ingrese el recorrido, Enter Finaliza");
								recorrido=Console.ReadLine();
							}
							Console.WriteLine("Ingrese horario de salida hh:mm");
							horario=Console.ReadLine();
							Console.WriteLine("Ingrese duracion en horas");
							duracion=Console.ReadLine();
							Console.WriteLine("Ingrese el dia de salida de la excursion, Enter finaliza");
							dia=Console.ReadLine();
							while(dia != ""){
								dia1.Add(dia);
								Console.WriteLine("Ingrese el dia de salida de la excursion, Enter finaliza");
								dia=Console.ReadLine();
							}
							Console.WriteLine("Ingrese el omnibus asignado");
							omnibus_asignado=int.Parse(Console.ReadLine());
							bool existe_omnibus=false;
							foreach(Omnibus omnibus1 in ListaOmnibus){
								if( omnibus1.getNum_unidad()== omnibus_asignado){
									existe_omnibus=true;
								}
								
							}
							while(existe_omnibus != true){
								Console.WriteLine("\nEl omnibus ingresado no existe en el sistema,\n Por favor vuelva a ingresar");
								omnibus_asignado=int.Parse(Console.ReadLine());
								foreach(Omnibus omnibus2 in ListaOmnibus){
									if( omnibus2.getNum_unidad()==omnibus_asignado){
										existe_omnibus=true;
									}
								}
							}
							
							
							num=ListaExcursion.Count;
							Console.WriteLine("Desea guardar la excursion ? Si / No " );// pregunta si quiera guardar la excursion
							string guardar = Console.ReadLine();
							guardar=guardar.ToLower();
							if(guardar =="si"){ // si es si ,crea una excursion , la setea y la agrega a listaexcursion.
								
								Excursion excursion = new Excursion();
								excursion.setNombre_excursion(nombre);
								excursion.setRecorrido(recorrido1);
								
								excursion.setHorario_salida(horario);
								excursion.setDuracion(duracion);
								excursion.setDia_salida(dia1);
								excursion.setOmnibus_asignado(omnibus_asignado);
								excursion.setNum(num+1);
								
								ListaExcursion.Add(excursion);
								Console.WriteLine("La excursion fue dada de alta correctamente");
								Console.ReadKey(true);
								this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
								
							}
							if(guardar=="no"){ // si es no , vuelve al modulo armado de excursion
								Console.Clear();
								this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							}
							break;
							
							
						case 2:
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *         SUBMODULO BAJA de E X C U R S I O N E S         * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine("\nListado de excursiones\n");
							//muestra la lista de excursion
							foreach(Excursion excu1 in ListaExcursion){
								Console.WriteLine(excu1.mostrar_excursion());
							}
							Console.WriteLine("\nIngrese nombre de la excursion a borrar");
							string borrar= Console.ReadLine();
							borrar=borrar.ToLower();
							bool eliminar= false;
							foreach(Excursion excu in ListaExcursion){
								
								if(borrar==excu.getNombre_excursion()){
									eliminar=true;
									ListaExcursion.Remove(excu);
									Console.Clear();
									Console.WriteLine("\nListado modificado de excursiones");
									foreach(Excursion excur in ListaExcursion){
										Console.WriteLine(excur.mostrar_excursion());
									}
									Console.ReadKey(true);
								}
								
								
								
							}
							if(eliminar==false){
								Console.WriteLine("Ha ingresado datos no validos");
								Console.ReadKey(true);
								this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							}
							
							borrar=Console.ReadLine();
							break;
							
						case 3:
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *         S U B M O D U L O  A L T A  de  O M N I B U S         * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							
							Omnibus omnibus = new Omnibus();
							string marca,modelo,capacidad,tipo;
							int numero_unidad;
							
							Console.WriteLine("\nIngrese la marca del omnibus");
							marca=Console.ReadLine();
							Console.WriteLine("\nIngrese el modelo del omnibus");
							modelo=Console.ReadLine();
							Console.WriteLine("\nIngrese la capacidad");
							capacidad=Console.ReadLine();
							Console.WriteLine("\nIngrese el tipo del omnibus\n <Basico, Semi-Cama, Coche-Cama, suite>");
							tipo=Console.ReadLine();
							Console.WriteLine("\nIngrese el numero de unidad");
							numero_unidad=int.Parse(Console.ReadLine());
							bool unidad= false;
						
							foreach(Omnibus omni in ListaOmnibus){
								if(omni.getNum_unidad()==numero_unidad){
									unidad=true;
									Console.WriteLine("\nYa existe un omnibus con ese numero de unidad,\nVuelva a intentarlo");
									numero_unidad=int.Parse(Console.ReadLine());
									
								}
								
									
									}
							while(unidad!=false){
								foreach(Omnibus omnibus1 in ListaOmnibus){
									if(omnibus1.getNum_unidad()==numero_unidad){
									unidad=true;
									Console.WriteLine("Vuelva a intentarlo");
									numero_unidad=int.Parse(Console.ReadLine());
									}
									unidad=false;
								}
							}
								
							
							
							omnibus.setMarca(marca);
							omnibus.setModelo(modelo);
							omnibus.setCapacidad(capacidad);
							omnibus.setTipo(tipo);
							omnibus.setNum_unidad(numero_unidad);
							ListaOmnibus.Add(omnibus);
							Console.WriteLine("\nPresione una tecla para continuar");
							Console.ReadKey(true);
							this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							break;
							
						case 4:
							int baja;
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *         S U B M O D U L O  B A J A  de  O M N I B U S         * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							
							foreach(Omnibus omnibuS in ListaOmnibus){
								Console.WriteLine(omnibuS.mostrarOmnibus());
							}
							Console.WriteLine("\nIngrese el numero de unidad a dar de baja");
							baja=int.Parse(Console.ReadLine());
							
							string confirmacion;
							existe_omnibus=false;
							foreach(Omnibus omni in ListaOmnibus){
								if(baja == omni.getNum_unidad()){
									existe_omnibus=true;
									Console.WriteLine("\nDesea dar de baja el omnibus numero " + baja + " ? Si/No");
									confirmacion=Console.ReadLine();
									confirmacion=confirmacion.ToLower();
									if(confirmacion=="si"){
										ListaOmnibus.Remove(omni);
										Console.Clear();
										
										Console.WriteLine("\n\nEl omnibus fue dado de baja correctamente\n\nPresione una tecla para continuar");
										Console.ReadKey(true);
									}
									if(confirmacion =="no"){
										this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
									}
								}
								
							}
							
							if(existe_omnibus==false){
								Console.WriteLine("El omnibus ingresado no existe en el sistema");
								Console.ReadKey(true);
								this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							}
							
							
							
							break;
						case 5:
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *                       SUBMODULO  LISTADO  de  EXCURSIONES         * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							

							Console.WriteLine("\nListado de excursiones\n");
							foreach(Excursion excu1 in ListaExcursion){
								Console.WriteLine(excu1.mostrar_excursion());
								
							}
							Console.WriteLine("\nPresione una tecla para volver");
							Console.ReadKey(true);
							this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							
							
							
							break;
							
						default:
							Console.Clear();
							Console.WriteLine ("* * * * * *  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  * * *");
							Console.WriteLine ("* * *                       MODULO  ARMADO  de  EXCURSION                 * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							
							
							Console.WriteLine("Seleccione una opcion del menu\n");
							
							Console.WriteLine("1) Alta de Excursiones\n" +
							                  "2) Baja de Excursiones\n" +
							                  "3) Alta de Omnibus\n" +
							                  "4) Baja de Omnibus\n" +
							                  "5) Listado de excursiones disponibles\n" +
							                  "6) Volver ");
							Console.WriteLine ("\nEl número ingresado no es valido, vuelva a ingresar:\n");
							ac=Console.ReadLine();
							accion =int.Parse(ac);
							break;
					}
					
				}
			}
			
			
			
			
			
			
			
			
			
			
			
			
			catch{
				Console.Clear ();
				
				this.Armado_de_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("Ha ingresado carácteres no válidos vuelva a intentarlo");
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("");
				
			}
			this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
		}
		public void volver(ArrayList ListaClientes, ArrayList ListaEmpleados,ArrayList ListaExcursion,ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Console.Clear();
			Excursiones excursion1 = new Excursiones(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			excursion1.iniciar();
		}
	}
}
