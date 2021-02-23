using System;
using System.Collections;
namespace Sistema_Excursiones
{
	public class Omnibus
	{
		private string Marca=null;
		private string Modelo=null;
		private string Capacidad=null;
		private int Num_unidad;
		private string Tipo=null;
		
		
		public string getMarca(){
			return this.Marca;
		}
		public void setMarca(string nueva_marca){
			this.Marca=nueva_marca;
		}
		public string getModelo(){
			return this.Modelo;
		}
		public void setModelo(string nuevo_modelo){
			this.Modelo=nuevo_modelo;
		}
		public string getCapacidad(){
			return this.Capacidad;
		}
		public void setCapacidad(string nueva_capacidad){
			this.Capacidad=nueva_capacidad;
		}
		 
		
		public int getNum_unidad(){
			return this.Num_unidad;
		}
		public void setNum_unidad(int nueva_unidad){
			this.Num_unidad=nueva_unidad;
		}
		public string getTipo(){
		return this.Tipo;
		}
		public void setTipo(string nuevo_tipo){
		this.Tipo=nuevo_tipo;
		}
		
		public string mostrarOmnibus(){
			return "\n* Numero de unidad= " + getNum_unidad() +" - Marca= " + getMarca() + " - Modelo= " + getModelo() + " - Capacidad= " + getCapacidad();// +  "Tipo: " + getTipo();
		}
		
		
	}
}
