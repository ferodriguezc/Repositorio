
from tkinter import *
ventana=Tk(
ventana=mainloop() 
)


x = 0


while x < 1 :


    print("Ingrese primer numero")
    num1 =  int(input())
    print("Ingrese Segundo numero")
    num2 =  int(input())
    suma = num1+ num2
    print("La suma de los numeros es: ", suma)
    
    print ("Queres continuar:\n1-si\n2-no")
    option = int(input())
    
    
    if option == 1 :
        x=0
    else :
        x=1
        


     