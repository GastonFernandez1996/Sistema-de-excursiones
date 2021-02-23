using System;
using System.Collections;
using System.Collections.Generic;
namespace Sistema_Excursiones
{
	
	public class Excursion:Cliente
	{
		private string Nombre_excursion=null;
		private ArrayList Recorrido=new ArrayList();
		private string Horario_salida = null;
		private string duracion = null;
		private ArrayList Dias_salida= new ArrayList();
		private string dia=null;
		private string recorrido = null;
		private int omnibus_asignado;
		private int num_excursion;
		
		
				
		public override string ToString()
		{
			return string.Format(Nombre_excursion + "{0}", "<"+ getComprayVenta() +">");
		}
				
		
		
		public string getNombre_excursion(){
			
			return this.Nombre_excursion;
		}
		public void setNombre_excursion(string nuevo_nombre){
			this.Nombre_excursion=nuevo_nombre;
		}
		public string getRecorrido(){
			
			
				return this.recorrido;
			
		}
		
		public void setRecorrido(ArrayList nuevo_recorrido){
			
			foreach(string  recorrido in nuevo_recorrido){
				this.recorrido +=recorrido + " - ";
				
		}
			
		}
		
		public string getHorario_salida(){
			return this.Horario_salida;
		}
		public void setHorario_salida(string nuevo_horario){
			this.Horario_salida=nuevo_horario;
		}
		public string getDuracion(){
			return this.duracion;
		}
		public void setDuracion(string nueva_duracion){
			this.duracion=nueva_duracion;
		}
		
		public string getDia_salida(){
			
				return this.dia;
		}
		public void setDia_salida(ArrayList nuevo_dia){
			foreach(string  dia in  nuevo_dia){
				this.dia +=dia + " " ;
			
		}
			
			
			
		}
		public int getOmnibus_asignado(){
			return this.omnibus_asignado;
		}
		public void setOmnibus_asignado(int nuevo_omnibus){
			this.omnibus_asignado=nuevo_omnibus;
		}
		public int getNum(){
			return this.num_excursion;
		}
		public void setNum(int nuevo_num){
			this.num_excursion=nuevo_num;
		}
		
		
		public string mostrar_excursion(){
				
			
			return "\nExcursion: " + getNombre_excursion() + "\n Recorrido: " + getRecorrido()  + "\n Horario de salida: " + getHorario_salida() + "\n Duracion: " + getDuracion() + "\n Dia de salida: " + getDia_salida() + "\n Omnibus Asignado: " + getOmnibus_asignado();
		}
		
		public string mostrar_excursion1(){
			return "\n"+getNum() + ")" + "\nExcursion: " + getNombre_excursion() + "\n Recorrido: "  + getRecorrido() + "\n Horario de salida: " + getHorario_salida() + "\n Duracion: " + getDuracion() + "\n Dia de salida: " + getDia_salida() + "\n Omnibus Asignado: " + getOmnibus_asignado();
		}
		
		
		
		
		
	}
}




