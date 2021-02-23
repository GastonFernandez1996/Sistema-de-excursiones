using System;
using System.Collections;
namespace Sistema_Excursiones
{
	
	public class Venta_de_excursiones
	{
		public void venta_excursion(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra, ArrayList ListaVenta){
			Console.Clear();
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			Console.WriteLine ("* * *                       MODULO  VENTA  de  EXCURSIONES              * * *");
			Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
			Console.WriteLine("\nSeleccione una opcion del menu\n");
			Console.WriteLine("1) Alta de Cliente\n" +
			                  "2) Compra de pasajes\n" +
			                  "3) Devolucion de pasajes\n" +
			                  "4) Volver\n");
			string ac = Console.ReadLine();
			
			try{
				int accion =int.Parse(ac);
				while(accion!=4){
					switch(accion){
						case 1 :
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *                       SUBMODULO  ALTA de CLIENTE                    * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							
							string nomyape,dni;
							int num_cliente;
							Console.WriteLine("Ingrese el Nombre y Apellido del cliente");
							nomyape=Console.ReadLine();
							Console.WriteLine("Ingrese el dni del cliente");
							dni=Console.ReadLine();
							num_cliente=ListaClientes.Count;
							//Validad si el Cliente existe en el sistema
							bool existe_cliente=false;
							foreach(Cliente cliente in ListaClientes){
								if(dni==cliente.getDni()){
									existe_cliente=true;
									Console.WriteLine("Ya existe un Empleado con ese DNI en el sistema");
									Console.ReadKey(true);
									
								}
							}
							// si no existe , crea un cliente , lo setea y lo agrega a ListaClientes.
							if(existe_cliente==false){
								Cliente clientes = new Cliente();
								clientes.setNomyApe(nomyape);
								clientes.setDni(dni);
								clientes.setNum_Cliente(num_cliente + 1);
								ListaClientes.Add(clientes);
								Console.WriteLine("El Cliente fue dado de alta correctamente con el numero:" + clientes.getNum_Cliente());
								Console.ReadKey(true);
							}
							//vuelve al modulo venta de excursion
							this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							break;
						case 2:
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *                       SUBMODULO  COMPRA de PASAJES                * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							
							Console.WriteLine("\nIngrese el numero de cliente");
							num_cliente=int.Parse(Console.ReadLine());
							Console.WriteLine("\nIngrese el dni del cliente");
							dni=Console.ReadLine();
							const int suma=1;// constante para sumar al cliente una compra y al empleado una venta.
							existe_cliente=false;
							//verifica si el cliente existe en el sistema
							foreach(Cliente client in ListaClientes){
								if((client.getNum_Cliente()==num_cliente)&&(client.getDni()==dni))
								{
									existe_cliente=true;
									bool existe_excursion= false; //booleano para saber si existe la excursion en el sistema.
									foreach(Excursion ex in ListaExcursion){
										
										Console.WriteLine(ex.mostrar_excursion1()); // muestra las excursiones existentes.
										
									}
									Console.WriteLine("\nIngrese el numero de la excursion a comprar");
									int seleccion=int.Parse(Console.ReadLine());
									//valida si la excursion existe en el sistema.
									foreach(Excursion excur in ListaExcursion){
										if(excur.getNum()==seleccion){
											existe_excursion=true;
											Console.WriteLine("\nIngrese cantidad de pasajes:");
											int cantidad=int.Parse(Console.ReadLine());
											client.setComprayVenta(suma);//suma una compra mas al cliente .
											excur.setComprayVenta(suma);
											excur.setDni(dni);
											excur.setNum_Cliente(num_cliente);
											Console.WriteLine("\nVenta exitosa");
										}
										
									}
									
									//Si la numero de excursion ingresada no coincide con ninguna excursion , pide que ingrese de nuevo el numero de excursion
									while(existe_excursion!=true){
										existe_excursion=false;
										Console.WriteLine("\nLa excursion solicitada no se encuentra en el sistema,\n por favor vuelva a interntarlo");
										seleccion=int.Parse(Console.ReadLine());
										foreach(Excursion excur in ListaExcursion){
											if(excur.getNum()==seleccion){
												existe_excursion=true;
												Console.WriteLine("\nIngrese cantidad de pasajes:");
												int cantidad=int.Parse(Console.ReadLine());
												client.setComprayVenta(suma);
												excur.setComprayVenta(suma);
												excur.setDni(dni);
												excur.setNum_Cliente(num_cliente);
												Console.WriteLine("\nVenta exitosa");
												
												
											}
											
											
										}
									}
									Console.WriteLine("\nIngrese el numero de empleado para adicionarle la venta");
									int num_empleado=int.Parse(Console.ReadLine());
									bool existe_empleado=false;
									//valida que el empleado existe en el sistema
									foreach(Empleado empleado2 in ListaEmpleados){
										if(empleado2.getLegajo()==num_empleado){
											existe_empleado=true;
											empleado2.setComprayVenta(suma);//suma una venta mas al empleado
										}
										//si no existe , pide que ingrese de nuevo el numero de empleado
										
									}while(existe_empleado !=true){
										existe_empleado=false;
										Console.WriteLine("\nEl empleado no existe en el  sistemas,\n por favor vuelva a interntarlo");
										num_empleado=int.Parse(Console.ReadLine());
										foreach(Empleado empleado in ListaEmpleados){
											if(empleado.getLegajo()==num_empleado){
												existe_empleado=true;
												empleado.setComprayVenta(suma);
												
											}
										}
										
									}
									
								}
							}
							//si el usuario no existe en el sistema , vuelve al modulo venta de excursion.
							if(existe_cliente==false){
								
								Console.WriteLine("\nEl usuario solicitado no existe en el sistema");
								Console.ReadKey(true);
								this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
								
							}
							
							
							
							
							Console.WriteLine("\nIngrese una tecla para continuar");
							Console.ReadKey(true);
							Console.Clear();
							this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							
							break;
						case 3:
							
							DateTime hoy = DateTime.Today;
							int dia = (int)hoy.DayOfWeek;
							int dia_bus=0;
							

							string [ ] dias = new string [ ] { "Domingo","Lunes","Martes","Miercoles","Jueves","Viernes","Sabado"};
							
							
							
							Console.WriteLine("Ingrese el dni del cliente");
							dni = Console.ReadLine();
							Console.WriteLine("Ingrese el numero de cliente");
							int num= int.Parse(Console.ReadLine());
							existe_cliente=false;
							foreach(Cliente cl in ListaClientes){
								if((cl.getNum_Cliente()==num)&&(cl.getDni()==dni)){
									existe_cliente=true;
									bool compra= false;
									foreach(Excursion excursion in ListaExcursion){
										if((excursion.getDni()==dni)&&(excursion.getNum_Cliente()==num)){
											compra=true;
											Console.WriteLine(excursion.mostrar_excursion1());
											Console.WriteLine("\nIngrese el numero de la excursion a devolver");
											int num_excursion=int.Parse(Console.ReadLine());
											
											foreach(Excursion ex in ListaExcursion){
												
												int dif=0;
												if(ex.getNum()==num_excursion){
													if(ex.getDia_salida()==dias[0]){
														dia_bus=1;
													}
													if(ex.getDia_salida()==dias[1]){
														dia_bus=2;
													}
													if(ex.getDia_salida()==dias[2]){
														dia_bus=3;
													}
													if(ex.getDia_salida()==dias[3]){
														dia_bus=4;
													}
													if(ex.getDia_salida()==dias[4]){
														dia_bus=5;
													}
													if(ex.getDia_salida()==dias[5]){
														dia_bus=6;
													}
													if(ex.getDia_salida()==dias[6]){
														dia_bus=7;
													}
													
													dif = dia_bus- dia;
													if(dif<0){
													dif=7+dif;
													}
													
													   Console.WriteLine("El dia del bus es"+dif);
													   Console.WriteLine("Se le devolvera 90%");
													   Console.ReadKey(true);
													   this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
													   
													}
											}
										}
									}
									if(compra ==false){
										Console.WriteLine("El cliente ingresado no realizo ninguna compra");
										Console.ReadKey(true);
										this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
										
									}
									
									
								}
								
							}
							if(existe_cliente==false){
								Console.WriteLine("El numero o dni del cliente no son validos");
								Console.ReadKey(true);
								this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
							}
							
							break;
						default:
							Console.Clear();
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine ("* * *                       MODULO  VENTA  de  EXCURSIONES              * * *");
							Console.WriteLine ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
							Console.WriteLine("\nSeleccione una opcion del menu\n");
							Console.WriteLine("1) Alta de Cliente\n" +
							                  "2) Compra de pasajes\n" +
							                  "3) Devolucion de pasajes\n" +
							                  "4) Volver\n");
							Console.WriteLine ("\nEl número ingresado no es valido, vuelva a ingresar:");
							ac=Console.ReadLine();
							accion =int.Parse(ac);
							break;
							
					}
					
					
					
				}
			}
			
			
			catch{
				
				Console.Clear();
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("Ha ingresado carácteres no válidos vuelva a intentarlo");
				Console.WriteLine ("*******************************************************");
				Console.WriteLine ("");
				
				this.venta_excursion(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			}
			Console.Clear ();
			this.volver(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			
			


			
		}
		public void volver(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Console.Clear();
			Excursiones excursion1 = new Excursiones(ListaClientes,ListaEmpleados,ListaExcursion,ListaOmnibus,ListaDias,ListaCompra,ListaVenta);
			excursion1.iniciar();

		}
		
		
		
	}

}