// 1.Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1 человек может иметь несколько телефонов.


package Java.Practice5;

import java.util.Map;
import java.util.Scanner;
import java.util.HashMap;
import java.util.List;

public class Task1 {
        
        
    public static Map<String, List<String>> phoneBook = new HashMap<>();
    
        public static void main(String[] args) {
            addPerson();
            Scanner sc = new Scanner(System.in);
            System.out.print("Имя: ");
            String str = sc.nextLine();
            sc.close();
            findPerson(str);
        }
    
        public static void addPerson() {
            phoneBook.put("Kate", List.of("111", "222"));
            phoneBook.put("Ann", List.of("333", "444"));
            phoneBook.put("Vic",List.of("555"));
            phoneBook.put("Masha",List.of("666", "777"));
            phoneBook.put("Alise",List.of("888", "999"));
    
        }
    
        public static void findPerson(String surname) {
            System.out.printf("%s: %s", surname, phoneBook.get(surname));
        }
    }    
    
        
