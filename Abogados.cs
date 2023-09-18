using System;

namespace TP_Abogados
{
	/// <summary>
	/// Description of Abogados.
	/// </summary>
	public class Abogados
	{
		//ATRIBUTOS
		private string nomAbo;
		private string apeAbo;
		private int documento;
		private string especialidad;
		private int cantExp;
		
		//CONSTRUCTOR
		public Abogados(string nAbo, string aAbo, int dni, string espe, int cantE){
			nomAbo = nAbo;
			apeAbo = aAbo;
			documento = dni;
			especialidad = espe;
			cantExp = cantE;
		}
		
		//GETTERS Y SETTERS 
		public string NomAbo
		{
			get { return nomAbo; }
			set { nomAbo = value; }
		}
		
		public string ApeAbo
		{
			get { return apeAbo; }
			set { apeAbo = value; }
		}
		
		public int Documento
		{
			get { return documento; }
			set { documento = value; }
		}
		
		public string Especialidad 
		{
			get { return especialidad; }
			set { especialidad = value; }
		}
		
		public int CantExp
		{
			get { return cantExp; }
			set { cantExp = value; }
		}
	}
}
