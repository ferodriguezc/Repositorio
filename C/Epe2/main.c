#include <stdio.h>
#include <string.h>

#define MAX_CAMIONES 100

struct Camion {
    char patente[10];
    float carga;
};

void ordenamiento_Rapido_Descendente(struct Camion camiones[], int primero, int ultimo) {
    int i, j, medio;
    struct Camion pivote, temp;
    medio = (primero + ultimo) / 2;
    pivote = camiones[medio];
    i = primero;
    j = ultimo;
    do {
        while (camiones[i].carga > pivote.carga && i < ultimo) {
            i++;
        }
        while (camiones[j].carga < pivote.carga && j > primero) {
            j--;
        }
        if (i <= j) {
            temp = camiones[i];
            camiones[i] = camiones[j];
            camiones[j] = temp;
            i++;
            j--;
        }
    } while (i <= j);
    if (primero < j) {
        ordenamiento_Rapido_Descendente(camiones, primero, j);
    }
    if (ultimo > i) {
        ordenamiento_Rapido_Descendente(camiones, i, ultimo);
    }
}

int main() {
    struct Camion camiones[MAX_CAMIONES];
    int n = 0;

    while (n < MAX_CAMIONES) {
        printf("Ingrese la patente del camion %d (o ingrese fin para terminar): ", n + 1);
        scanf("%s", camiones[n].patente);

        if (strcmp(camiones[n].patente, "fin") == 0) {
            break;
        }

        printf("Ingrese la carga en toneladas del camion %d: ", n + 1);
        scanf("%f", &camiones[n].carga);

        n++;
    }

    ordenamiento_Rapido_Descendente(camiones, 0, n - 1);

    printf("Informe de camiones:\n");
    printf("Patente\t\tCarga (ton)\n");
    for (int i = 0; i < n; i++) {
        printf("%s\t\t%.2f\n", camiones[i].patente, camiones[i].carga);
    }

    return 0;
}
