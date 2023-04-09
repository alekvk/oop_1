using System.Text;

using Lesson_7;
namespace Lesson_7;


public class BuilderStringComma:InterBuilderStringComma {
  
    
    public StringBuilder BuildStringComma(List<Contact> contacts) {
        
        StringBuilder sb = new StringBuilder();
        sb.Append("id, Имя, Отчество, Фамилия, Телефон, Комментарий\n");
        foreach (Contact contact in contacts) {
            sb.Append(contact.getIdContact()).Append(",");
            sb.Append(contact.getFirstName()).Append(",");
            sb.Append(contact.getPatronymic()).Append(",");
            sb.Append(contact.getLastName()).Append(",");
            sb.Append(contact.getPhone()).Append(",");
            sb.Append(contact.getComment()).Append("\n");
        }  
        return sb;
    }
    
}


/*
package Lesson_6_OOP.PhoneBook.Base;

import java.util.List;


import Lesson_6_OOP.PhoneBook.Base.Interfaces.*;


public class BuilderStringComma implements InterBuilderStringComma {
  
    @Override
    public StringBuilder BuildStringComma(List<Contact> contacts) {
        
        StringBuilder sb = new StringBuilder();
        sb.append("id, Имя, Отчество, Фамилия, Телефон, Комментарий\n");
        for (Contact contact : contacts) {
            sb.append(contact.getIdContact()).append(",");
            sb.append(contact.getFirstName()).append(",");
            sb.append(contact.getPatronymic()).append(",");
            sb.append(contact.getLastName()).append(",");
            sb.append(contact.getPhone()).append(",");
            sb.append(contact.getComment()).append("\n");
        }  
        return sb;
    }
    
}


*/
