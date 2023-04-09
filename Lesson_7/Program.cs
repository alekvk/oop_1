using Lesson_7;



public class Program {

    public static void main(String[] args) {

        PhoneBook phoneBook = new PhoneBook();
        View consoleView = new View(phoneBook);
        consoleView.start();
        
    }

}


/*
package Lesson_6_OOP;

import Lesson_6_OOP.PhoneBook.PhoneBook;

public class Program {

    public static void main(String[] args) {

        PhoneBook phoneBook = new PhoneBook();
        View consoleView = new View(phoneBook);
        consoleView.start();
        
    }

}
*/
