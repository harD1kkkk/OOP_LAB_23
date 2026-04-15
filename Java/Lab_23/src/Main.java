import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.println("1 - Lab15_1");
            System.out.println("2 - Lab15_2");
            System.out.println("0 - Exit");

            int choice = sc.nextInt();

            switch (choice) {
                case 1:
                    Lab23_1.run();
                    break;

                case 2:
                    Lab23_2.run();
                    break;

                case 0:
                    return;
            }
        }
    }
}
