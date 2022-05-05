import java.util.*;

public class EjeTres {
    Scanner scanner = new Scanner(System.in);
    //"txt", "txt", "image", "txt"
    //"b", "b", "b", "b", "img", "b", "img"
    //"file", "file", "video", "video"
    public void menu(){
        List<String> filtrar = Arrays.asList("file", "file", "video", "video");
        Set<String> sinRepetir = new HashSet<>();
        Collections.sort(filtrar);
        int contador = 1;
        for(String name : filtrar) {
            if(!sinRepetir.add(name)) {
                String nuevo = name + "("+contador+")";
                sinRepetir.add(nuevo);
                contador++;
            }else {
                contador=1;
            }
        }
        System.out.print(Arrays.toString(sinRepetir.toArray()));
    }
}
