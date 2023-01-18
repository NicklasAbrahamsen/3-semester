public class MailBox
{
    public List<Mail> Mails {get; set;}

    public MailBox()
    {
        Mails = new List<Mail>();
    }

    public Mail ModtagMail(string afsender, string emne)
    {
        var nmail = new Mail {Afsender = afsender, Emne = emne};
        Mails.Add(nmail);
        return nmail;
    }

    public Mail LæstMail(Mail mail)
    {
        mail.Læst = true;
        return mail;
    }

    public Mail SletMail(Mail mail)
    {
        Mails.Remove(mail);
        return mail;
    }
}

