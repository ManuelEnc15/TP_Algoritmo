using System;

namespace TP_Abogados
{
	/// <summary>
	/// Description of Expediente.
	/// </summary>
	public class Expe
	{
		//ATRIBUTOS
		private int num;
		private string nom;
		private string tipoExp;
		private string status;
		private string nomAbog;
		private string apeAbog;
		private DateTime fecha;
		
		//CONSTRUCTOR
		public Expe(int nro, string nbre, string tipoE, string sta, string nomAbog, string apeAbog, DateTime fecha)
		{
			num = nro;
			nom = nbre;
			tipoExp = tipoE;
			status = sta;
			this.nomAbog = nomAbog;
			this.apeAbog = apeAbog;
			this.fecha = fecha;
		}
		
		//GETTERS Y SETTERS
		public int Num
		{
			get { return num; }
			set { num = value; }
		}
		
		public string Nom
		{
			get { return nom; }
			set { nom = value; }
		}
		
		public string TipoExp
		{
			get { return tipoExp; }
			set { tipoExp = value; }
		}
		
		public string Status 
		{
			get { return status; }
			set { status = value; }
		}
		
		public string NomAbog 
		{
			get { return nomAbog; }
			set { nomAbog = value; }
		}
		
		public string ApeAbog
		{
			get { return apeAbog; }
			set { apeAbog = value; }
		}
		
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}
	}
}
