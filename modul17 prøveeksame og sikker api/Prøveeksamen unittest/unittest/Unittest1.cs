using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyProject.Tests
{
    [TestClass]
    public class MailBoxTests
    {
        [TestMethod]
        public void ModtagMail_AddsMailToMailBox()
        {
            // Arrange
            var mailbox = new MailBox();
            string afsender = "tom";
            string emne = "Frokost";

            // Act
            mailbox.ModtagMail(afsender, emne);

            // Assert
            Assert.AreEqual(1, mailbox.Mails.Count);
            Assert.AreEqual(afsender, mailbox.Mails[0].Afsender);
            Assert.AreEqual(emne, mailbox.Mails[0].Emne);
            Assert.IsFalse(mailbox.Mails[0].Læst);
        }
          [TestMethod]
        public void SletMail_RemovesMailFromMailBox()
        {
            // Arrange
            var mailbox = new MailBox();
            var mail = mailbox.ModtagMail("tom", "Frokost");

            // Act
            mailbox.SletMail(mail);

            // Assert
            Assert.AreEqual(0, mailbox.Mails.Count);
            CollectionAssert.DoesNotContain(mailbox.Mails, mail);
        }
        [TestMethod]
        public void LæstMail_MarksMailAsRead()
        {
            // Arrange
            var mailbox = new MailBox();
            var mail = mailbox.ModtagMail("tom", "Frokost");

            // Act
            mailbox.LæstMail(mail);

            // Assert
            Assert.IsTrue(mail.Læst);
        }
    }
}

/*/når du kører "dotnet test" i terminalen, vil det køre alle testfunktioner, der er markeret med 
[TestMethod]-attributten i dit projekt.

dette eksempel tester "ModtagMail_AddsMailToMailBox" -metoden om ModtagMail-metoden i MailBox-klassen 
fungerer som forventet. Den tester om:

At der er blevet tilføjet en mail til Mails-listen i MailBox-objektet
At afsender-egenskaben i den tilføjede mail er lig med "tom"
At emne-egenskaben i den tilføjede mail er lig med "Frokost"
At læst-egenskaben i den tilføjede mail er false.

SletMail_RemovesMailFromMailBox tester om SletMail-metoden i MailBox-klassen fungerer som forventet. 
Den arrangerer et MailBox-objekt og et mail-objekt, som er oprettet ved hjælp af ModtagMail-metoden på 
MailBox-objektet. Derefter kalder den SletMail-metoden på objektet med mail-objektet som argument og 
asserterer, at Mails-listen i objektet ikke længere indeholder mail-objektet og at Mails-listen har en 
længde på 0.

 LæstMail_MarksMailAsRead tester om LæstMail metoden i MailBox klassen fungere som forventet. 
 Den arrangerer et MailBox objekt og et mail objekt, som er oprettet ved hjælp af ModtagMail metoden på 
 MailBox objektet. Derefter kalder den LæstMail metoden på objektet med mail objektet som argument og 
 asserterer at mail objektets Læst-egenskab er ændret til true.

/*/

