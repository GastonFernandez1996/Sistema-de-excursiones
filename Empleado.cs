using System;
using System.Collections;
namespace Sistema_Excursiones
{
	public class Empleado:Persona
	{
		private int legajo;
		
		
		public int getLegajo(){
			return this.legajo;
		}
		public void setLegajo(int nuevo_legajo){
			this.legajo=nuevo_legajo;
		}
		
	
		public override string ToString()
		{
			return string.Format(getNomyApe() + "{0}"," - Legajo:" + getLegajo() + " <"+ getComprayVenta() +">");
		}
		public string mostrarempleado(){
			return "Nombre y Apellido= "+getNomyApe() + " - DNI= "+ getDni() + " - Legajo= " + getLegajo();
			
		}
		public string mostrarempleado1(){
			return "Empleado " + getNomyApe() + " Legajo " + getLegajo().ToString() + " Ventas " + getComprayVenta().ToString();
			
		}
	}
	
	
}
