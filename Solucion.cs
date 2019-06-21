namespace EJERCICIO_4{
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
    public class Solucion{

        public int ContarParesDeAutos(int[] autos){
            int pares = 0;

            for(int i=0; i<autos.Length; i++){
                if(autos[0]==0){
                    if(autos[i]==0){
                        for(int x=i; x<autos.Length; x++){
                            if(autos[x]==1){
                                pares++;
                            }
                        }
                    }
                }else if(autos[0]==1){
                    if(autos[i]==1){
                        for(int x=i; x<autos.Length; x++){
                            if(autos[x]==0){
                                pares++;
                            }
                        }
                    }
                }
            }

            if(pares>1000000000){
                pares = -1;
            }
            return pares;
        }

    }
}