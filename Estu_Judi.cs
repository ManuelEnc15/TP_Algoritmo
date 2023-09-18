using System;
using System.Collections;
using System.Collections.Generic;

namespace TP_Abogados
{
	/// <summary>
	/// Description of Estudio.
	/// </summary>
	public class Estu_Judi
	{
		//ATRIBUTOS
		private string nomEst;
		private int contAbo;
		private int contExp;
		private ArrayList listaAbogados;
		private ArrayList listaExpedientes;
		
		//CONSTRUCTOR 
		public Estu_Judi(string nomEst)
		{
			this.nomEst= nomEst;
			this.contAbo = 0;
			this.contExp = 0;
			listaExpedientes = new ArrayList();
			listaAbogados = new ArrayList();
		}
		
		//GETTERS Y SETTERS
		public string NomEst
		{
			get { return nomEst; }
			set { nomEst = value; }
		}
		
		public int ContAbo
		{
			get { return contAbo; }
			set { contAbo = value; }
		}
		
		public int ContExp
		{
			get{return contExp;}
			set{contExp=value;}
		}
		
		public ArrayList ListaAbogados
		{
			get{return listaAbogados;}
		}
		
		public ArrayList ListaExpedientes
		{
			get{return listaExpedientes;}
		}
		
		//Metodos

		//Metodo de Estudio
		
		public void nomestudio()
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("Ingrese el nombre del estudio de abogados: ");
			nomEst = Console.ReadLine();
			Console.WriteLine(" Bienvenido \n a la app de \n Estudio de Abogados "+ nomEst);
		}
		
		//Metodos de Abogados
		public void agregarAbo(Abogados abo)
		{
			listaAbogados.Add(abo);
			contAbo++;
			Console.WriteLine();
			Console.WriteLine("El abogado/da se a ingresado");
		}
		
		public void eliminarAbo(Abogados abo)
		{
			listaAbogados.Remove(abo);
		}
		
		public bool existeAbo(Abogados abo)
		{
			return listaAbogados.Contains(abo);
		}
		
		public int totalAbo()
		{ 
			return contAbo;
		}
		
		public Abogados verAbo(int a)
		{
			return (Abogados)listaAbogados[a];
		}
		
		public ArrayList plantelAbo()
		{
			return listaAbogados;
		}
		
		
		//Metodos de Expedientes
		public void agregarExp(Expe exp)
		{
			listaExpedientes.Add(exp);
			contExp++;
		}
		
		public void eliminarExp(Expe exp)
		{
			listaExpedientes.Remove(exp);
		}
		
		public int cantExp()
		{
			return contExp;
		}
		
		public bool existeExp(Expe exp)
		{
			return listaExpedientes.Contains(exp);
		}
		
		public Expe verExp(int e)
		{
			return (Expe)listaExpedientes[e];
		}
		
		public ArrayList todosExp()
		{
			return listaExpedientes;
		}
	}
}
