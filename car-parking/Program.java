import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.nio.file.Files;
import java.nio.file.Paths;

public class Program {
    public static void main(String[] args) throws IOException {
        try (OutputStream fos = new FileOutputStream("./output.txt")) {
            fos.write(("Hello " +
                Files.lines(Paths.get("./input.txt"))
                    .reduce((prev, after) -> prev + " " + after).get()).getBytes("UTF-8"));
        }
    }
}
