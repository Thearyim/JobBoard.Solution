using System.Collections.Generic;

namespace JobOpenings.Models
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phoneNumber;

    public Contact(string name, string email, string phoneNumber)
    {
      _name = name;
      _email = email;
      _phoneNumber = phoneNumber;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }

    public string GetphoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
  }


}
