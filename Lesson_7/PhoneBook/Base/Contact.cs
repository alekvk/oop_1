using Lesson_7;
namespace Lesson_7;

public class Contact {

     private String idContact;
     private String firstName;
     private String patronymic;
     private String lastName;
     private String phone;
     private String comment;

    public Contact(String idContact, String firstName, String patronymic, String lastName, String phone, String comment) {
        this.idContact = idContact;
        this.firstName = firstName;
        this.patronymic = patronymic;
        this.lastName = lastName;
        this.phone = phone;
        this.comment = comment;
    }

    // Setters
    
    public void setIdContact(String idContact) {
        this.idContact = idContact;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setPatronymic(String patronymic)  {
        this.patronymic = patronymic;
    }
    
    public void setLastName(String lastName) {
        this.lastName = lastName;
    }
    
    public void setPhone(String phone) {
        this.phone = phone;
    }

    public void setComment(String phone) {
        this.phone = phone;
    }

    // Getters

    public String getIdContact() {
        return idContact;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getPatronymic() {
        return patronymic;
    }
    
    public String getLastName() {
        return lastName;
    }
    public String getPhone() {
        return phone;
    }

    public String getComment() {
        return comment;
    }
  

    public override String ToString() {
        return idContact + "_Контакт{" +
                "Имя='" + firstName + '\'' +
                "Отчество='" + patronymic + '\''+
                ", Фамилия='" + lastName + '\'' +
                ", Телефон='" + phone + '\'' +
                ", Комментарий='" + comment + '\'' +
                '}';
    }
}








/*

package Lesson_6_OOP.PhoneBook.Base;


public class Contact {

    private String idContact;
    private String firstName;
    private String patronymic;
    private String lastName;
    private String phone;
    private String comment;

    public Contact(String idContact, String firstName, String patronymic, String lastName, String phone, String comment) {
        this.idContact = idContact;
        this.firstName = firstName;
        this.patronymic = patronymic;
        this.lastName = lastName;
        this.phone = phone;
        this.comment = comment;
    }

    // Setters
    
    public void setIdContact(String idContact) {
        this.idContact = idContact;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setPatronymic(String patronymic)  {
        this.patronymic = patronymic;
    }
    
    public void setLastName(String lastName) {
        this.lastName = lastName;
    }
    
    public void setPhone(String phone) {
        this.phone = phone;
    }

    public void setComment(String phone) {
        this.phone = phone;
    }

    // Getters

    public String getIdContact() {
        return idContact;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getPatronymic() {
        return patronymic;
    }
    
    public String getLastName() {
        return lastName;
    }
    public String getPhone() {
        return phone;
    }

    public String getComment() {
        return comment;
    }
  

    @Override
    public String toString() {
        return idContact + "_Контакт{" +
                "Имя='" + firstName + '\'' +
                "Отчество='" + patronymic + '\''+
                ", Фамилия='" + lastName + '\'' +
                ", Телефон='" + phone + '\'' +
                ", Комментарий='" + comment + '\'' +
                '}';
    }
}

*/