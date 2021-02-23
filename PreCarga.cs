using System;
using System.Collections;
namespace Sistema_Excursiones
{
	
	public class PreCarga
	{
		public void preCargaEmpleados(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){

			Empleado Empleado1 = new Empleado();
			Empleado Empleado2 = new Empleado();
			Empleado Empleado3 = new Empleado();
			
			
			Empleado1.setNomyApe("Gaston Fernandez");
			Empleado1.setDni("40369879");
			Empleado1.setLegajo(1);
			
			Empleado2.setNomyApe("Sofia Ledesma");
			Empleado2.setDni("37896321");
			Empleado2.setLegajo(2);
			
			Empleado3.setNomyApe("Omar Ramirez");
			Empleado3.setDni("40369869");
			Empleado3.setLegajo(3);
			
			ListaEmpleados.Add(Empleado1);
			ListaEmpleados.Add(Empleado2);
			ListaEmpleados.Add(Empleado3);
			
			
			
			
		}
		public void preCargaClientes(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Cliente cliente1 = new Cliente();
			Cliente cliente2 = new Cliente();
			Cliente cliente3 = new Cliente();
			
			
			cliente1.setNomyApe("Gaston Fernandez");
			cliente1.setDni("39599989");
			cliente1.setNum_Cliente(1);
			
			cliente2.setNomyApe("Gaston Rodriguez");
			cliente2.setDni("40497835");
			cliente2.setNum_Cliente(2);
			
			
			cliente3.setNomyApe("Gaston Gomez");
			cliente3.setDni("39549786");
			cliente3.setNum_Cliente(3);
			
			ListaClientes.Add(cliente1);
			ListaClientes.Add(cliente2);
			ListaClientes.Add(cliente3);
			
		}
		public void preCargaExcursion(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Excursion Excursion1= new Excursion();
			Excursion Excursion2= new Excursion();
			Excursion Excursion3= new Excursion();
			
			ArrayList excursion1 = new ArrayList();
			
			ArrayList dia1 = new ArrayList();
			excursion1.Add("Berazategui");
			excursion1.Add("Florencio varela");
			dia1.Add("Sabado");
			Excursion1.setNombre_excursion("river");
		
			Excursion1.setRecorrido(excursion1);
			
			Excursion1.setHorario_salida("17:00");
			Excursion1.setDuracion("3");
			Excursion1.setDia_salida(dia1);
			Excursion1.setOmnibus_asignado(1);
			Excursion1.setNum(1);
			
			
			ArrayList excursion2 = new ArrayList();
			ArrayList dia2 = new ArrayList();
			excursion2.Add("Berazategui");
			excursion2.Add("Quilmes");
			dia2.Add("Sabado");
			dia2.Add("Viernes");
			Excursion2.setNombre_excursion("boca");
			Excursion2.setRecorrido(excursion2);
			Excursion2.setHorario_salida("17:00");
			Excursion2.setDuracion("3");
			Excursion2.setDia_salida(dia2);
			Excursion2.setOmnibus_asignado(2);
			Excursion2.setNum(2);
			
			ArrayList excursion3 = new ArrayList();
			ArrayList dia3 = new ArrayList();
			excursion3.Add("Lanus");
			excursion3.Add("Avellaneda");
			dia3.Add("Viernes");
			Excursion3.setNombre_excursion("tigre");
			Excursion3.setRecorrido(excursion3);
			Excursion3.setHorario_salida("18:00");
			Excursion3.setDuracion("4");
			Excursion3.setDia_salida(dia3);
			Excursion3.setOmnibus_asignado(3);
			Excursion3.setNum(3);
			
			ListaExcursion.Add(Excursion1);
			ListaExcursion.Add(Excursion2);
			ListaExcursion.Add(Excursion3);
			
			
		}
		public void preCargaOmnibus(ArrayList ListaClientes, ArrayList ListaEmpleados, ArrayList ListaExcursion, ArrayList ListaOmnibus,ArrayList ListaDias,ArrayList ListaCompra,ArrayList ListaVenta){
			Omnibus omnibus1 = new Omnibus();
			Omnibus omnibus2 = new Omnibus();
			Omnibus omnibus3 = new Omnibus();
			
			omnibus1.setMarca("iveco");
			omnibus1.setModelo("2015");
			omnibus1.setCapacidad("40");
			omnibus1.setTipo("Basico");
			omnibus1.setNum_unidad(1);
			
			omnibus2.setMarca("Mercedez benz");
			omnibus2.setModelo("2016");
			omnibus2.setCapacidad("30");
			omnibus2.setTipo("Semi-Cama");
			omnibus2.setNum_unidad(2);
			
			omnibus3.setMarca("iveco");
			omnibus3.setModelo("2017");
			omnibus3.setCapacidad("20");
			omnibus3.setTipo("Suite");
			omnibus3.setNum_unidad(3);
			
			ListaOmnibus.Add(omnibus1);
			ListaOmnibus.Add(omnibus2);
			ListaOmnibus.Add(omnibus3);
		}
		
	}
	
}
