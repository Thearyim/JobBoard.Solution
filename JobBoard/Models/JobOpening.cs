using System.Collections.Generic;

namespace JobOpenings.Models
{
  public class JobOpening
  {
    private string _title;
    private string _description;
    private Contact _contact;

    public JobOpening (string title, string description, Contact contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public string GetContactName()
    {
      return _contact.GetName();
    }

    public string GetContactEmail()
    {
      return _contact.GetEmail();
    }

    public string GetContactPhone()
    {
      return _contact.GetphoneNumber();
    }
  }
}
