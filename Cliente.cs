
using System;

namespace Sistema_Excursiones
{

	public class Cliente:Persona
	{
		private int Num_cliente;
	    
	    
		public int getNum_Cliente(){
			return this.Num_cliente;
		}
		public void setNum_Cliente(int nuevo_numcliente){
		this.Num_cliente=nuevo_numcliente;
		}
	
		
		public string mostrar(){
			return "Cliente" + getNomyApe() + "Compras: " + getComprayVenta();
		}
	
		
	}
}
