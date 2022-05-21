import java.util.Scanner;

public class EjeDos {
    Scanner scanner = new Scanner(System.in);
    Integer paquetes;

    public void menu(){
        System.out.println("Ingrese los paquetes hechos: ");
        paquetes = scanner.nextInt();
        Integer cajas = (int) Math.ceil(paquetes/6);
        Integer restante = (paquetes%6);
        System.out.println("Las cajas necesarias son: " + cajas);
        if (restante == 0){
            System.out.println("No hubo producto restante");
        }else{
            System.out.println("Hubo " + restante + " paquetes restantes");
        }
    }

}
