bool CheckAmistoso(int numero1, int numero2){
    if(numero2 == Suma(numero1) && numero1 == Suma(numero2)){
        return true;
    }
    else{
        return false;
    }
}
int Suma(int numero){
    int resultado1 = 1;
    for(int i = 2; i<= numero/2; i++){
        if(numero%i==0){
            resultado1 += i;
        }
    }
    return resultado1;
}
void BuscarAmistoso(){
    for(int i = 1000; i<=1500; i++){
        for(int j = 1000; j<=1500; j++){
            if(CheckAmistoso(i,j)){
                Console.WriteLine("El valor: " + i + " y el valor: " + j + " son amistosos");
            }
        }
    }
}

BuscarAmistoso();

