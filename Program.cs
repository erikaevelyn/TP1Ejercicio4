using System;
/*Se proporciona un array no vacío A que consta de N enteros. 
Los elementos consecutivos del array A representan autos consecutivos en una carretera.
array A contiene solo 0s y / o 1s:
• 0 representa un carro que viaja al este,
• 1 representa un automóvil que viaja hacia el oeste.
El objetivo es contar los coches que pasan. Decimos que un par de autos (P, Q), 
donde 0 ≤ P <Q <N, está pasando cuando P está viajando hacia el este y Q está viajando hacia el oeste.
Por ejemplo, considere la matriz A tal que:
  A [0] = 0
  A [1] = 1
  A [2] = 0
  A [3] = 1
  A [4] = 1
Tenemos cinco pares de carros que pasan: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).
Escribe una función:
solución de clase {solución pública int (int [] A); }
que, dado un array no vacío A de N enteros, devuelve el número de pares de autos que pasan.
La función debe devolver −1 si el número de pares de autos que pasan supera los 1,000,000,000.
Por ejemplo, dado:
  A [0] = 0
  A [1] = 1
  A [2] = 0
  A [3] = 1
  A [4] = 1
la función debe devolver 5, como se explicó anteriormente.
Escriba un algoritmo eficiente para las siguientes suposiciones:
• N es un número entero dentro del rango [1..100,000];
• cada elemento del array A es un número entero que puede tener uno de los siguientes valores: 0, 1.
 */

namespace EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadAutos;
            int[] autos;
            Solucion sol = new Solucion();
            Console.WriteLine("Ingrese la cantidad de autos que quiere ingresar:");
            bool conversion = Int32.TryParse(Console.ReadLine(), out cantidadAutos);
            if(!conversion || cantidadAutos<1 || cantidadAutos>100000){
                do{
                Console.WriteLine($"El dato ingresado no es valido. Solo se aceptan numeros enteros positivos menores al 100001."); 
                Console.WriteLine("Ingrese la cantidad de autos que quiere ingresar:");
                conversion = Int32.TryParse(Console.ReadLine(), out cantidadAutos);
                }while(!conversion || cantidadAutos<1 || cantidadAutos>100000);
            }
            

            autos = new int[cantidadAutos];

            for(int i=0; i<autos.Length; i++){
                Console.WriteLine($"Ingrese un 1 o 0 para determinar direccion de auto nro. {i+1}: ");
                bool conversion2 = Int32.TryParse(Console.ReadLine(), out autos[i]);
                    if((!conversion2) || (autos[i]!=1) && (autos[i]!=0)){
                        do{
                        Console.WriteLine($"El dato ingresado no es valido. Solo se acepta 1 o 0."); 
                        Console.WriteLine($"Ingrese un 1 o 0 para determinar direccion de auto nro. {i+1}: ");
                        conversion2 = Int32.TryParse(Console.ReadLine(), out autos[i]);
                        }while((!conversion2) || (autos[i]!=1) && (autos[i]!=0));
                    }
            }

            int resultado = sol.ContarParesDeAutos(autos);
            Console.WriteLine($"La cantidad de pares de autos que pasan es: {resultado}");
        }
    }
}
