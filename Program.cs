using System;
using System.Runtime.CompilerServices;

namespace UMLtoCODE
{

    public abstract class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
    }

    public class Customer : Person
    {
        public DateTime Registration;
        private int CreditStore;
    }
    public class Employee : Person
    {
        public Enum Department;
        private float Salary;
    }

    public class Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;

        public bool Validate()
        {
            return true;
        }
    }

    public class Account
    {
        public string IBAN;
        protected float Amount;

        public bool Transaction(string X)
        {
            return true;
        }
    }

    public class Investing : Account
    {
        public float Interest;
        public void Applyinterest() { }
    }
    public class Savings : Account
    {
        private float ProtectedAmount;
        public void LiberateSavings() { }
    }

    public class Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;
    }
}
