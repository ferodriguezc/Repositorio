#include <stdio.h>
#include <stdlib.h>


//Estableceremos las variables globales para nuestro programa.
int numero;
char palabra[10];
int day;
int month;
int year;
int continuar;
int longitud;


//Método principal main.
//////////////////////////////////////////////////////////////////////////////
int main()
{





//Creamos un ciclo do-while en caso de que el usuario  quisiera usar el programa nuevamente.

    do {




//Colocamos una bienvenida y las instrucciones del programa.

    printf("\Bienvenido a mi primera aplicaci\242n en C.\n");
    printf("A continuaci\225n se indicar\205 una serie de especificaciones con  tal de guardar la informaci\225n dentro de una variable.\n\n");


//Insertamos separaciones con el signo slash junto con las funciones hechas para guardar los datos en las variables.


    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    pal();
    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    num();

    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    fecha();
    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
    printf("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");

//Colocamos un mensaje que muestre los datos guardados en las variables.
    printf("\n\nLos datos guardados son los siguientes: \n");
    printf("\nPalabra: %s",palabra);
    printf("\nNumero: %d ",numero);
    printf("\nFecha de nacimiento: %d,%d,%d\n",day,month,year);

//Condición del do-while.

    printf("\nDesea intentarlo nuevamente:\n1-si\n2-no\n");
    scanf("%d",&continuar);

    }


    while (continuar==1);


}

//Creación de las funciones.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Función para pedir un número.
void  num (){




//Creamos un ciclo do-while en caso de que el número ingresado sea incorrecto la función se reinicie.
 do {


//Indicaciones de la función
    printf("\n\nIngrese un n\243mero del 0 al 99: \n");
//uso de scanf para guardar un valor en la variable número
   scanf("%d",&numero);
//Uso de condicional is-else para verificar que el número ingresado este en el rango especificado.
 if (numero>=0 && numero<=99){



  printf("El n\243mero est\205 en el rango\nel n\243mero ingresado \"%d\"  se ha guardado correctamente.\n",numero);


 }else{


 printf("El n\243mero no est\205 en el rango.\n");

}}
//Condición para que el ciclo se repita.
 while (numero>0 && numero>99);

return 0;
 }

 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Función para pedir una palabra.

void pal (){



//Creamos un ciclo do-while en caso de que la palabra ingresada sea incorrecto la función se reinicie.
 do {


//Indicaciones de la función
   printf("\n\nIngrese una palabra de m\205ximo diez letras: \n");
  scanf("%s",&palabra);
  longitud = strlen(palabra);
//Uso de condicional is-else para verificar que la palabra ingresada esté en el rango especificado.
 if (longitud<= 10){



  printf("La palabra ingresada cuenta con no m\205s de 10 letras\nla palabra ingresada \"%s\" se ha guardado correctamente.\n",palabra);

 }else{


 printf("La palabra excede el rango.\n");

 } }
 //Condición del ciclo while.
 while (longitud> 10);

}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Función para pedir fecha de cumpleaños.

void fecha (){




//Creamos un ciclo do-while en caso de que el día ingresado sea incorrecto la función se reinicie.
 do {



   printf("Ingrese d\215a de nacimiento: \n");
 scanf("%d",&day);
//Uso de condicional is-else para verificar que el día ingresado esté en el rango especificado.
 if (day>0 && day<=31){



  printf("El d\215a \"%d\" fue ingresado  correctamente.\n",day);

 }else{


 printf("El d\215a ingresado  es incorrecto.\n");

 }}
//Condición de ciclo while
 while (day>31);


//Creamos un ciclo do-while en caso de que el mes ingresado sea incorrecto la función se reinicie.
 do {



   printf("Ingrese mes de nacimiento: \n");
 scanf("%d",&month);
//Uso de condicional is-else para verificar que el mes ingresado esté en el rango especificado.
 if (month>0 && month<=12){



  printf("El mes \"%d\" fue ingresado correctamente.\n",month);

 }else{


 printf("El mes ingresado es incorrecto.\n");

 }}
//Condicion de cicclo while.
 while (month>12);

//Creamos un ciclo do-while en caso de que el año ingresado sea incorrecto la función se reinicie.

 do {


    printf("Ingrese a\xA4o de nacimiento: \n");
    scanf("%d",&year);
//Uso de condicional is-else para verificar que el año ingresado esté en el rango especificado.
 if (year>1900 && year<=2023){



  printf("El a\xA4o \"%d\"  fue ingresado correctamente.\n",year);

 }
 else{


 printf("El a\xA4o \"%d\"  ingresado es incorrecto.\n",year);
 }}
 //Condicion de cicclo while.
 while (year>2023);
}

