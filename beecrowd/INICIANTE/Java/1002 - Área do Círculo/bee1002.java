import java.io.IOException;
import java.util.Scanner;

public class bee1002 {

    public static void main(String[] args) throws IOException {


        Double pi = 3.14159;
        Scanner ler = new Scanner(System.in);
        Double raio = ler.nextDouble();

        Double area = Math.pow(raio, 2) * pi;
        System.out.println(String.format("A=%.4f", area));

    }

}


