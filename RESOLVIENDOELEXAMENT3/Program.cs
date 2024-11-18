//Hacer citas y estudiantes 
//menu
//propiedades
//metodo Tostring()
//designarle valores a las propiedas y imprimirlas
//creando el arreglo , y dandole un for para almacenar todo
//utilizando diferentes asignaciones de las propiedades dandoles valores , para no afectar al codigo y en for , dandole a todos
//una sola posicion
//modificar los valores , buscando universidad

using RESOLVIENDOELEXAMENT3;

//Console.Write("INGRESA TU NUMERO: ");
//cita1.Numero = int.Parse(Console.ReadLine());
//Console.Write("Estudiante (Carrera): ");
//cita1.estudiante2 = estudiante11;
//Console.Write("Que enfermedad tienes: ");
//cita1.Enfermedad = Console.ReadLine();
//Console.Write("Cual es el precio: ");
//cita1.Precio = int.Parse(Console.ReadLine());
////////////////////////////////////////////
/*Console.Write("Cual es tu codigo: ");
estudiante11.Codigo = int.Parse(Console.ReadLine());
Console.Write("Cual es tu nombre: ");
estudiante11.Nombre = Console.ReadLine();
Console.Write("Como se llama tu universidad: ");
estudiante11.Universidad = Console.ReadLine();*/

Estudiante estudiante11 = new Estudiante();
Cita cita1 = new Cita();




int respS;
int resp;
int posicion=0;
string buscarUniversidad;


do
{
    Console.WriteLine("¿Cuantos datos deseas ingresar?: ");
    respS = int.Parse(Console.ReadLine());


} while (respS <= 0);

int[] arregloNumeros = new int[respS];
double[] arregloPrecios = new double[respS];
int[] arregloCodigo = new int[respS];
string[] arregloEnfermedad = new string[respS];
string[] arregloNombre = new string[respS];
string[] arregloNombreUNI = new string[respS];
string[] arregloCarrera = new string[respS];


do 
{
    Console.WriteLine("");
    Console.WriteLine("\n**MENU**");
    Console.WriteLine("CREAR [1]: ");
    Console.WriteLine("LISTAR [2]: ");
    Console.WriteLine("MODIFICAR [3]: ");
    Console.WriteLine("FIN [4]: ");
    Console.Write("\n¿Que opcion quieres ingresar?: ");
    resp=int.Parse(Console.ReadLine());
    
    switch (resp)
    {
        case 1:
            for(int i=0; i < respS; i++)
            {
                Console.WriteLine("\n***DATOS DE CITA***");
                Console.Write("INGRESA TU NUMERO: ");
                //arreglo[i]=int.Parse(Console.ReadLine());
                cita1.Numero = int.Parse(Console.ReadLine());
                arregloNumeros[posicion] = cita1.Numero;
                //cita1.Numero = arreglo[i];
                /*Console.Write("Estudiante (Carrera): ");
                cita1.estudiante2 = estudiante11; Console.ReadLine();  //AUN FALTA ARREGLAR, LO DEMAS OK.
                arregloCarrera[posicion] = cita1.estudiante2;*/
                Console.Write("Que enfermedad tienes: ");
                cita1.Enfermedad = Console.ReadLine();
                arregloEnfermedad[posicion] = cita1.Enfermedad;
                
                Console.Write("Cual es el precio $/: ");
                cita1.Precio = double.Parse(Console.ReadLine());
                arregloPrecios[posicion] = cita1.Precio;
                

                Console.WriteLine("\n***DATOS DE ESTUDIANTE***");
                Console.Write("Cual es tu codigo: ");
                estudiante11.Codigo = int.Parse(Console.ReadLine());
                arregloCodigo[posicion] = estudiante11.Codigo;
                
                Console.Write("Cual es tu nombre: ");
                estudiante11.Nombre = Console.ReadLine();
                arregloNombre[posicion] = estudiante11.Nombre;
                
                Console.Write("Como se llama tu universidad: ");
                estudiante11.Universidad = Console.ReadLine();
                arregloNombreUNI[posicion] = estudiante11.Universidad;
                posicion++;

                Console.Clear();
            }
            break;
        case 2: for(int i =0; i<posicion; i++)
            {
                //double sumaTodo = 0;
                Console.Write("\n\n*DATOS*"+ "\nNumero: "+ arregloNumeros[i]+ "\nPrecio: " + arregloPrecios[i]+"\nCodigo: " + arregloCodigo[i]+
                    "\nEnfermedad: " + arregloEnfermedad[i]+"\nNombre: " + arregloNombre[i]+"\nNombre de universidad: " + arregloNombreUNI[i]
               +" ");
                
                //sumaTodo += arregloPrecios[i] + respS;


                //Console.Write(sumaTodo);
           
            }
            /*for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine("POSICION " + i + ": " + arreglo1[i]);
            }*/
            
            /*foreach(int valor in arreglo)
            {
                Console.WriteLine("valor"+arreglo[respS]);
            }*/

            break;
        case 3: Console.Write("Ingrese la universidad que desea Buscar: "); 
            buscarUniversidad = (Console.ReadLine());
            
            foreach(string recorrer in arregloNombreUNI)
            {
                if(recorrer == buscarUniversidad)
                {
                    Console.WriteLine("\nEncontrado universidad: " + estudiante11.Universidad);
                    Console.WriteLine("*");
                    Console.Write("\nEscriba El Nuevo Nombre de la Universidad: ");
                    string cambio = Console.ReadLine();
                    for (int i = 0; i < respS; i++)
                    {
                        if (arregloNombreUNI[i] == buscarUniversidad)
                        { 
                            arregloNombreUNI[i] = cambio;
                            Console.WriteLine("\nLos datos fueron cambiados con exitos");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nNo existe esa universidad");
                    Console.Clear();
                }
            }
            
            break;
        case 4:
            
            break;
        
    }

} while (resp != 4);
Console.ForegroundColor =ConsoleColor.Blue;
Console.WriteLine("\nGracias por usar el programa by:fabri ");
//cambio
//cambio nicolas
//cambio ultimo



