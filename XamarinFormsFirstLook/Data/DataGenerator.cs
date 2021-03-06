﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook.Data
{
    public class DataGenerator
    {
        private static List<string> FirstNames = new List<string> {
            "Aiden", "Liam", "Lucas", "Noah", "Mason", "Ethan", "Caden", "Jacob", "Logan", "Jayden", "Elijah", "Jack", "Luke", "Michael", "Benjamin",
            "Alexander", "James", "Jayce", "Caleb", "Connor", "William", "Carter", "Ryan", "Oliver", "Matthew", "Daniel", "Gabriel", "Henry", "Owen",
            "Grayson", "Lincoln", "Jordan", "Tristan", "Jason", "Josiah", "Xavier", "Camden", "Chase", "Declan", "Carson", "Colin", "Brody", "Asher",
            "Jeremiah", "Micah", "Easton", "Xander", "Ryder", "Nathaniel", "Elliot", "Sean"
        };

        private static List<string> LastNames = new List<string> {
            "SMITH", "JOHNSON", "WILLIAMS", "BROWN", "JONES", "MILLER", "DAVIS", "GARCIA", "RODRIGUEZ", "WILSON", "MARTINEZ", "ANDERSON", "TAYLOR", "THOMAS HERNANDEZ",
            "RICHARDSON", "WOOD", "WATSON", "BROOKS", "BENNETT GRAY", "JAMES", "REYES", "CRUZ", "HUGHES", "PRICE", "MYERS", "LONG", "FOSTER SANDERS", "ROSS",
            "MORALES", "POWELL", "SULLIVAN", "RUSSELL ORTIZ", "JENKINS", "GUTIERREZ", "PERRY", "BUTLER", "BARNES FISHER", "HENDERSON", "COLEMAN", "SIMMONS", "PATTERSON",
            "JORDAN", "REYNOLDS"
        };

        public static List<Contact> GetContacts() {

            var random = new Random();
            List<Contact> contacts = new List<Contact>();

            for (int i = 0; i < 25; i++) {
                Contact contact = new Contact();
                contact.FirstName = FirstNames [i];
                contact.LastName = LastNames [i];
                contact.Email = FirstNames [i] + "@gmail.com";
                contact.IsFavorite = ((random.Next(FirstNames.Count) % 2) == 0);
                contacts.Add(contact);
            }
            return  contacts;
        }

        public static ObservableCollection<Contact> GetObservableContacts() {

            var random = new Random();
            var contacts = new ObservableCollection<Contact>();

            for (int i = 0; i < 25; i++) {
                Contact contact = new Contact();
                contact.FirstName = FirstNames [i];
                contact.LastName = LastNames [i];
                contact.Email = FirstNames [i] + "@gmail.com";
                contact.IsFavorite = random.Next(FirstNames.Count) % 2 == 0;
                contacts.Add(contact);
            }
            return  contacts;
        }
    }
}