using System;
using System.Collections;

namespace TP_Abogados
{
	class Program
	{
		public static void Main(string[] args)
		{
			Estu_Judi estudio=new Estu_Judi("\n Nonmbre");
			estudio.nomestudio();
			int op=0;
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("----------------------");
			Console.WriteLine("----Menú Principal----");
			Console.WriteLine("----------------------");
			Console.WriteLine("\n1) Abogado/a");
			Console.WriteLine("\n2) Expediente");
			Console.WriteLine("\n3) Salir de la app");
			try
			{
				Console.WriteLine("\nElija una opción dada anteriormente:");
				op=int.Parse(Console.ReadLine());
				Console.Clear();
				while(op!=3)
				{
					switch(op)
					{
						case 1://Abogados/as
							int opa=0;
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("-----------------------");
							Console.WriteLine("--Menú de Anogados/as--");
							Console.WriteLine("-----------------------");
							Console.WriteLine("\n1) Agregar abogado/a");
							Console.WriteLine("\n2) Elimiar abogado/a");
							Console.WriteLine("\n3) Ver abogados/as");
							Console.WriteLine("\n4) Salir del menú de abogado/a");
							Console.WriteLine("\nElije una opción: ");
							opa=int.Parse(Console.ReadLine());
							Console.Clear();
							while(opa!=4)
							{
								switch(opa)
								{
										case 1://Agregar Abogado
											try
											{
												Console.WriteLine("\t Ingrese los datos del abogado/a a agregar");
												Console.Write("\nNombre del Abogado/a: ");
												string nombreabogado=Console.ReadLine();
												Console.Write("\nApellido del Abogado/a: ");
												string apellidoabogado=Console.ReadLine();
												Console.Write("\nDni del abogado/a: ");
												int dni=int.Parse(Console.ReadLine());
												Console.Write("\nEspecialidad: ");
												string especialidad=Console.ReadLine();
												Console.Write("\nCantidad de expedientes a cargo: ");
												int cantidadexpedientes = int.Parse(Console.ReadLine());
												Abogados abo = new Abogados(nombreabogado,apellidoabogado,dni,especialidad,cantidadexpedientes);
												estudio.agregarAbo(abo);
											}catch(Opc1 ex)
											{
												Console.WriteLine(ex.Message);
											}
											break;
										case 2://Eliminar los Abogados/as
											Console.WriteLine("\t Listado de abogados/as: ");//Mostramos Abogados/as
											if(estudio.totalAbo()>0){
											foreach(Abogados abos in estudio.plantelAbo())
											{
												Console.WriteLine("--------------------");
												Console.WriteLine("Nombre del abogado/a "+abos.NomAbo+" Apellido del Abogado/a: "+abos.ApeAbo+", Dni del Abogado/a: "+abos.Documento+" , Especialidad: "+abos.Especialidad+" , Cantidad de expedientes a cargo: "+abos.CantExp);
												Console.WriteLine("--------------------");
											}
											}
											if(estudio.totalAbo()==0)
											{
												Console.WriteLine("Estudiio sin abogados/as");}
												Console.Write("Numero del dni del abogado/a a eliminar: ");
												int n=int.Parse(Console.ReadLine());
												int si=0,
												no=0,a=0;
												for(int i=0; i < (estudio.totalAbo()); i++)
												{
													if(n==(estudio.verAbo(i)).Documento)
													{
														a=i;si=1;no=1;break;
													}
												}
													if(si==1)
													{
														estudio.eliminarAbo(estudio.verAbo(a));
														Console.WriteLine("Abogado/a eliminado");
														if(no==0)
														{
															Console.WriteLine("Abogado/a no encontrado/a");
														}
													}
											break;
											
										case 3://Muestra abogados/as
											Console.WriteLine("\t Listado de abogados/as: ");
											if(estudio.totalAbo()>0)
											{
												foreach(Abogados abos in estudio.plantelAbo())
												{
													Console.WriteLine("--------------------");
													Console.WriteLine("Nombre del abogado/a "+abos.NomAbo+" Apellido del Abogado/a: "+abos.ApeAbo+", Dni del Abogado/a: "+abos.Documento+" , Especialidad: "+abos.Especialidad+" , Cantidad de expedientes a cargo: "+abos.CantExp);
													Console.WriteLine("--------------------");
												}
											}
											if(estudio.totalAbo()==0)
											{
												Console.WriteLine("Estudiio sin abogados/as");
											}
											break;
											
										default://Si elije una opción incorrecta
											Console.WriteLine("\nElija bien la opción");
											break;
								}
								
								//Volvemos a preguntar que vamos a hacer
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("-----------------------");
								Console.WriteLine("--Menú de Anogados/as--");
								Console.WriteLine("-----------------------");
								Console.WriteLine("\n1) Agregar abogado/a");
								Console.WriteLine("\n2) Eliminar abogado/a");
								Console.WriteLine("\n3) Ver abogados/as");
								Console.WriteLine("\n4) Salir del menú de abogado/a");
								Console.WriteLine("\nElije una opción: ");
								opa=int.Parse(Console.ReadLine());
								Console.Clear();	
							}
							break;
						case 2: //Expediente
							int ope=0;
							Console.ForegroundColor = ConsoleColor.DarkRed;
							Console.WriteLine("------------------");
							Console.WriteLine("Menú de Expediente");
							Console.WriteLine("------------------");
							Console.WriteLine("\n1) Agregar expediente");
							Console.WriteLine("\n2) Modificar expediente");
							Console.WriteLine("\n3) Eliminar expediente");
							Console.WriteLine("\n4) Lista de expedientes de tipo 'audiencia'");
							Console.WriteLine("\n5) Lista de expedientes");
							Console.WriteLine("\n6) Salir del menú de expediente");
							Console.WriteLine("\nElije una opción: ");
							ope=int.Parse(Console.ReadLine());
							Console.Clear();
							while(ope!=6)
							{
								switch(ope)
								{
									case 1://Agregar Expediente
										if(estudio.totalAbo()==0)
										{
											Console.WriteLine("Estudiio sin abogados/as");
										}
										if(estudio.totalAbo()>0){
											try
											{
												Console.Write("\nNombre de abogado/a a cargo: ");
												string nombreabo=Console.ReadLine();
												Console.Write("\nApellido de abogado/a a cargo: ");
												string apellidoabo= Console.ReadLine();
												foreach(Abogados abog in (estudio.plantelAbo()))
												{
													if((abog.NomAbo==nombreabo)&&(abog.ApeAbo==apellidoabo)&&(abog.CantExp<6))
													{
														Console.Write("\nNumero de expediente: ");
														int num=int.Parse(Console.ReadLine());
														Console.Write("\nNombre del Titular: ");
														string nom=Console.ReadLine();
														Console.Write("\nTipo de expediente: ");
														string tipoexp=Console.ReadLine();
														Console.Write("\nEstado del expediente: ");
														string est=Console.ReadLine();
														Console.Write("\nFecha de presentacion (día/mes/año): ");
														DateTime date = DateTime.Parse(Console.ReadLine());
														Expe exp= new Expe(num,nom,tipoexp,est,nombreabo,apellidoabo,date);
														estudio.agregarExp(exp);
														abog.CantExp++;
														Console.WriteLine();
														Console.WriteLine("Expediente agregado");
														Console.WriteLine();
													}
											else if((abog.NomAbo!=nombreabo)&&(abog.ApeAbo!=apellidoabo)&&(abog.CantExp<6))
											{
												Console.WriteLine("Abogado/a no encontrado/a o Abogado/a sobrecargado con 6 expedientes");
											}
											
											}
											}catch(Opc1 ex)
											{
												Console.WriteLine(ex.Message);}
											}
											break;

										case 2://Modificar expediente
											Console.WriteLine("\t Listado de expedientes");
											if(estudio.cantExp()>0)
											{
												foreach(Expe eexps in estudio.todosExp())
												{
													if((eexps.Num==0)==false)
													{
														Console.WriteLine();Console.WriteLine("Numero de expediente: "+eexps.Num+" Titular: "+eexps.Nom +"Tipo de tramite: "+eexps.TipoExp+" Estado: "+eexps.Status+" Nombre del abogado/a a cargo: "+eexps.NomAbog+" Apellido del abogado/a a cargo: "+eexps.ApeAbog+ "Fecha de presentación: "+eexps.Fecha);
														Console.WriteLine();
													}
												}
											}

											if(estudio.cantExp()==0)
											{
												Console.WriteLine("Sin expedientes");
											}
								
											try
											{
												Console.Write("\nIngrese el numero del expediente al cual quiere modificar: ");
												int nro =int.Parse(Console.ReadLine());
												Console.WriteLine();
												for(int i=0;i<(estudio.cantExp());i++)
												{
													if(nro==(estudio.verExp(i).Num))
													{
														Console.Write("Ingrese el nuevo estado: ");
														string nuevoestado = Console.ReadLine();
														Console.WriteLine();int enuevo=i;
														(estudio.verExp(enuevo)).Status=nuevoestado;
														Console.WriteLine("Estado de expediente modificado");break;}
													if(nro!=(estudio.verExp(i).Num))
													{
														Console.WriteLine("Expediente no encontrado");
													}
												}
											}catch(Opc1 ex)
												{
												Console.WriteLine(ex.Message);
												}
											break;
										case 3://Eliminar expediente
											Console.WriteLine("\t Listado de expedientes");
											if(estudio.cantExp()>0)
											{
												foreach(Expe eexps in estudio.todosExp())
												{
													if((eexps.Num==0)==false)
													{
														Console.WriteLine();
														Console.WriteLine("Numero de expediente: "+eexps.Num+" Titular: "+eexps.Nom +"Tipo de tramite: "+eexps.TipoExp+" Estado: "+eexps.Status+" Nombre del abogado/a a cargo: "+eexps.NomAbog+" Apellido del abogado/a a cargo: "+eexps.ApeAbog+ "Fecha de presentación: "+eexps.Fecha);
														Console.WriteLine();
													}
												}
											}
											if(estudio.cantExp()==0)
											{
												Console.WriteLine("Sin expedientes");
											}
											Console.Write("\nIngrese el numero del expediente que desea eliminar: ");
											int numero = int.Parse(Console.ReadLine()); //Pedimos numero de expediente a eliminar
											for(int i=0;i<(estudio.cantExp());i++)
											{
												if(numero==(estudio.verExp(i).Num))
												{
													foreach(Abogados aabo in (estudio.plantelAbo()))
													{
														if(((estudio.verExp(i)).NomAbog==aabo.NomAbo&&((estudio.verExp(i)).ApeAbog==aabo.ApeAbo)))
														{
															aabo.CantExp--;
															estudio.eliminarExp(estudio.verExp(i));
															Console.WriteLine("Expediente eliminado");
															break;
														}
													}
												}
													
											}
											break;
										case 4://Lista de expedientes de tipo 'audiencia'
											Console.WriteLine("\t Listado de expedientes");
											if(estudio.cantExp()>0)
											{
												foreach(Expe eexps in estudio.todosExp())
												{
													if((eexps.Num==0)==false)
													{
														Console.WriteLine();Console.WriteLine("Numero de expediente: "+eexps.Num+" Titular: "+eexps.Nom +"Tipo de tramite: "+eexps.TipoExp+" Estado: "+eexps.Status+" Nombre del abogado/a a cargo: "+eexps.NomAbog+" Apellido del abogado/a a cargo: "+eexps.ApeAbog+ "Fecha de presentación: "+eexps.Fecha);
														Console.WriteLine();
													}
												}
											}
											if(estudio.cantExp()==0)
											{
												Console.WriteLine("Sin expedientes");
											}
											DateTime fecha= new DateTime(); 
											DateTime fecha1= new DateTime();
											Console.WriteLine("Ingrese la primera fecha(día/mes/año): ");
											fecha= DateTime.Parse(Console.ReadLine());
											Console.WriteLine("\nIngrese la segunda fecha(día/mes/año): ");
											fecha1= DateTime.Parse(Console.ReadLine());
											foreach(Expe expss in estudio.todosExp())
											{
												if((expss.TipoExp == "audiencia")&&(expss.Fecha > fecha)&&(expss.Fecha < fecha1))
												{
													Console.WriteLine("Numero de expediente: "+expss.Num+"Tipo de tramite: "+expss.TipoExp+" Estado: "+expss.Status+" Nombre del abogado/a a cargo: "+expss.NomAbog+" Apellido del abogado/a a cargo: "+expss.ApeAbog);
												}// Si el tipo de expediente es Audiencia y se encuentra entre las dos fechas pasadas por parametro impre por pantalla el expediente
											}
											break;
										case 5://Lista de expedientes
											Console.WriteLine("\t Listado de expedientes");
											if(estudio.cantExp()>0)
											{
												foreach(Expe eexps in estudio.todosExp())
												{
													if((eexps.Num==0)==false)
													{
														Console.WriteLine();Console.WriteLine("Numero de expediente: "+eexps.Num+" Titular: "+eexps.Nom +"Tipo de tramite: "+eexps.TipoExp+" Estado: "+eexps.Status+" Nombre del abogado/a a cargo: "+eexps.NomAbog+" Apellido del abogado/a a cargo: "+eexps.ApeAbog+ "Fecha de presentación: "+eexps.Fecha);
														Console.WriteLine();
													}
												}
											}
											if(estudio.cantExp()==0)
											{
												Console.WriteLine("Sin expedientes");
											}
											break;
										default://Si elije una opción incorrecta
											Console.WriteLine("\nElija bien la opción");
											break;
								}
								Console.ForegroundColor = ConsoleColor.DarkRed;
								Console.WriteLine("------------------");
								Console.WriteLine("Menú de Expediente");
								Console.WriteLine("------------------");
								Console.WriteLine("\n1) Agregar expediente");
								Console.WriteLine("\n2) Modificar expediente");
								Console.WriteLine("\n3) Eliminar expediente");
								Console.WriteLine("\n4) Lista de expedientes de tipo 'audiencia'");
								Console.WriteLine("\n5) Lista de expedientes");
								Console.WriteLine("\n6) Salir del menú de expediente");
								Console.WriteLine("\nElije una opción: ");
								ope=int.Parse(Console.ReadLine());
								Console.Clear();
							}
							break;
							default: 
							Console.WriteLine("--Opción incorrecta. Elija bien la opción--"); 
							break;
					}
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("----Menú Principal----"); 
					Console.WriteLine("\n1) Abogado/a");
					Console.WriteLine("\n2) Expediente");
					Console.WriteLine("\n3) Salir de la app");
					Console.WriteLine("\nElija una opción dada anteriormente:");
					op=int.Parse(Console.ReadLine());
					Console.Clear();
				}
			}catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			// TODO: Implement Functionality Here
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
