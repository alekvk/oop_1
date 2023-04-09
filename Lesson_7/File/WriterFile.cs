using Lesson_7;
namespace Lesson_7;


internal class WriterFile {
    
    public static void writeFile(List<Contact> contacts, String fileName) {
        try (PrintWriter writer = new PrintWriter(new File(fileName))) {
            
            /* Создаем интерфейсную переменную "а". 
               Класс BulderStringComma реализует метод интерфейса 
               InterBuilderString (создание объекта StringBuilder)
               с разделителем в виде запятой (comma) */

            InterBuilderStringComma a = new BuilderStringComma();
            writer.write((a.BuildStringComma(contacts)).ToString());
            
        } catch (FileNotFoundException ex) 
        {
            Console.WriteLine("Файл не найден: " + fileName);
            Console.WriteLine("Source = {0}", ex.Source);
        }
    }
}



/*
package Lesson_6_OOP.File;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.util.List;

import Lesson_6_OOP.PhoneBook.Base.Contact;
import Lesson_6_OOP.PhoneBook.Base.BuilderStringComma;
import Lesson_6_OOP.PhoneBook.Base.Interfaces.*;

public class WriterFile {
    
    public static void writeFile(List<Contact> contacts, String fileName) {
        try (PrintWriter writer = new PrintWriter(new File(fileName))) {
            / Создаем интерфейсную переменную "а". 
               Класс BulderStringComma реализует метод интерфейса 
               InterBuilderString (создание объекта StringBuilder)
               с разделителем в виде запятой (comma) /
            InterBuilderStringComma a = new BuilderStringComma();
            writer.write((a.BuildStringComma(contacts)).toString());
            
        } catch (FileNotFoundException e) {
            System.out.println("Файл не найден: " + fileName);
        }
    }
}
*/