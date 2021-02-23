using System;
using System.Collections;
namespace Sistema_Excursiones
{
	
	public class Persona : IComparable
	{
		private string Nombre = null;
		private string Dni= null;
		private int excursion=0;
		
		
		private int compra_venta=0;
	
		
		public int getComprayVenta(){
		return this.compra_venta;
		}
		public void setComprayVenta(int n_compra_venta){
		
		this.compra_venta += n_compra_venta;
		}
		public string getNomyApe(){
			return this.Nombre;
		}
		public void setNomyApe(string nuevo_nombre){
			this.Nombre=nuevo_nombre;
		}
		public string getDni(){
			return this.Dni;
		}
		public void setDni(string nuevo_dni){
			this.Dni=nuevo_dni;
		}
		public int MostrarExcursionComprada(){
			return this.excursion;
				}
		public void CargarExcursionComprada(int nueva_excursion){
		this.excursion = nueva_excursion;
		}
		
		public int comprayventa{
			get{return compra_venta;}
		}
		
		
		public int CompareTo(object c1)
		{
			if(this.comprayventa < ((Persona)c1).comprayventa)
				return -1;
			else
			if(this.comprayventa > ((Persona)c1).comprayventa)
				return 1;
			else
				return 0;
			
		}
		public override string ToString()
		{
			return string.Format(Nombre + "{0}", "<"+compra_venta+">");
		}
	}
}
