using Homework_9;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Contacts
{
    private string _mobileNumber;
    private string _email;
    private string _fax;

    public string MobileNumber
    {
        get { return _mobileNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Mobile Number cannot be NULL or empty!");
                return;
            }


            string trimmed = value.Trim();


            if (!IsPhoneNumber(trimmed))
            {
                Console.WriteLine("Mobile Number should follow the standard: +555555555 or 555555555");
                return;
            }

            _mobileNumber = trimmed;
        }
    }
    public string Email
    {
        get { return _email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Email cannot be NULL or empty!");
                return;
            }

            string trimmed = value.Trim();

            if (!isEmail(trimmed))
            {
                Console.WriteLine("Email is not in a valid format (example: test@gmail.com)");
                return;
            }

            _email = trimmed;
        }
    }
    public string Fax
    {
        get { return _fax; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Fax cannot be NULL or empty!");
                return;
            }


            string trimmed = value.Trim();


            if (!IsPhoneNumber(trimmed))
            {
                Console.WriteLine("Fax should follow the standard: +555555555 or 555555555");
                return;
            }

            _fax = trimmed;
        }
    }

    public Contacts(string mobileNumber, string email, string fax)
    {
        MobileNumber = mobileNumber;
        Email = email;
        Fax = fax;
    }

    public Contacts()
    {
    }

    private bool IsPhoneNumber(string phoneNumber)
    {
        //Phone Number can start with + or with digit 
        if (!(phoneNumber[0] == '+' || char.IsDigit(phoneNumber[0])))
        {
            return false;
        }

        //Other parts must be digit
        for (int i = 1; i < phoneNumber.Length; i++)
        {
            if (!char.IsDigit(phoneNumber[i]))
            {
                return false;
            }
        }

        return true;
    }

    private bool isEmail(string email)
    {
        int atIndex = email.IndexOf('@');

        //Eaail must have only one @ in the middle
        if (atIndex <= 0 || atIndex != email.LastIndexOf('@') || atIndex == email.Length - 1)
        {
            return false;
        }

        //other part of email after @
        string secondPart = email.Substring(atIndex + 1);

        // Second Part must contain a dot
        if (!secondPart.Contains("."))
        {
            return false;
        }

        // In Second Part dot cannot be first or last 
        if (secondPart.StartsWith(".") || secondPart.EndsWith("."))
        {
            return false;
        }

        return true;
    }

}