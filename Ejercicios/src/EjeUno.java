import java.util.Scanner;

public class EjeUno {
    /*
    * 32 lápices, 10 plumas, 7 cuadernos, 1 goma
    */
    Scanner scanner = new Scanner(System.in);
    String productos;

    public boolean esNumero(String numero){
        try {
            Integer.parseInt(numero);
            return true;
        }catch (NumberFormatException e){
            return false;
        }
    }

    public void menu(){
        System.out.println("Ingrese todos sus productos");
        productos = scanner.nextLine();
        String numeros[] = productos.split("[^0-9]");
        int suma = 0;
        for (int i = 0; i < numeros.length; i++) {
            if (esNumero(numeros[i])){
                suma += Integer.parseInt(numeros[i]);
            }
        }
        System.out.println(suma);
    }
}
