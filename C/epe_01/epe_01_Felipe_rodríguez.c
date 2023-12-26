#include <stdio.h>
#include <stdlib.h>
#define rojo     "\x1b[31m"
#define blanco   "\x1b[37m"

//Ingresamos las variables globales para nuestro programa.
int age;
int YearActual = 2023;
int continuar;
int opcion;


int main()//M�todo principal main.
{


    printf("Bienvenido al programa para identificar a la generaci%cn a cual perteneces seg%cn tu edad.\n", 162,163);//Mensaje de presentaci�n del programa.



    do{    // Creamos ciclo do-while para reiniciar el programa, una vez se haya ejecutada.


    Ejecutador();//Instanciamos la aplicaci�n que permitir� identificar la generaci�n del usuario.

    printf("\n\n%cDesea intentarlo una vez m%cs? \nescriba la opcion segun su respuesta:\n1-si.\n2-no.\n\n",168,160);//Mensaje para elegir opci�n para reiniciar programa.

    scanf("%d", &continuar);//Sc�ner para guardar respuesta en variable �continuar�.



    }while(continuar==1);//Condicion de ciclo do-while

    return 0;
}




int Ejecutador() //Creaci�n de la funci�n "Ejecutador" que contiene el funcionamiento del programa.
{


    printf(rojo"\nPor favor ingresa tu edad: \n");//Mensaje indicando el ingreso de la edad.
    scanf("%d", &age);////Sc�ner para guardar respuesta en variable �age�.

    int operacion = YearActual - age;//Operaci�n matem�tica para calcular la generaci�n.



    /*Condicionales if-else que permiten catalogar, seg�n la fecha de la generaci�n a la que pertenece el usuario
      Asign�ndole un valor a la variable   "opcion" para poder ser usado m�s adelante en el programa*/

    if (operacion >= 1930 && operacion <= 1948)
    {
        opcion=1;
    }
    else
    {
        if (operacion >= 1949 && operacion <= 1968)
        {
           opcion=2;
        }
        else
        {
            if (operacion >= 1969 && operacion <= 1980)
            {
                opcion=3;
            }
            else
            {
                if (operacion >= 1981 && operacion <= 1993)
                {
                    opcion=4;
                }
                else
                {
                    if (operacion >= 1994 && operacion <= 2000)
                    {
                        opcion=5;
                    }
                    else
                    {
                        if (operacion > 2000)
                        {
                            opcion=6;
                        }
                        else
                        {
                            if (operacion < 1930)
                            {
                                opcion=7;
                            }
                        }
                    }
                }
            }
        }
    }

   /*Creaci�n de la condicional switch, la cual permite mostrar el mensaje seg�n la generaci�n del usuario, la cual fue asignada anteriormente en la variable
"Opci�n" mediante el uso de las condicionales if-else.*/

    switch (opcion){
        case 1:
            printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn ni%cos de posguerra (1930-1948).",163, 162, 164);
            break;
        case 2:
             printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn Baby boomers (1949-1968).",163, 162);
            break;
        case 3:
            printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn X (1969-1980).",163, 162);
            break;
        case 4:
            printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn millennials (1981-1993).",163, 162);
            break;
        case 5:
            printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn z (1994-2000).",163, 162);
            break;
        case 6:
            printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn Alpha (Desde el 2000 en adelante).",163, 162);
            break;
        case 7:
            printf(blanco"\nSeg%cn tu edad perteneces a la generaci%cn anterior a ni%cos de posguerra (Antes de 1930).",163, 162, 164);
            break;
        default:
            printf(blanco"\nerror.");
            break;

    }


}
