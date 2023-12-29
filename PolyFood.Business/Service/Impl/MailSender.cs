using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using PolyFood.Business.Service.IService;
using PolyFood.Common.Common;
using PolyFood.DTOs.Form;
using PolyFood.Entity.Entity;

namespace PolyFood.Business.Service.Impl;

public class MailSender : IMailSender
{
    public bool ConfirmEmailByUrl(Account account, string token)
    {
        var Url = token;
        var message = new MimeMessage();
        var str = Uri.EscapeDataString(Url);

        message.From.Add(new MailboxAddress(Constant.Mail.From, Constant.Mail.From));
        message.To.Add(new MailboxAddress(account.Username, account.Users.Email));
        message.Subject = Constant.SubjectList.Welcome;
        message.Body = new TextPart(TextFormat.Html)
        {
            Text = "<h1> Welcome " + account.Username + " to join with us </h1> " +
                   "<h2> Please click to the button to start</h2>" +
                   "<a href=\" " + Constant.Mail.ConfirmMailUrl + $"?Token={str}" + " \"> " +
                   Constant.Html.Button + "</a>" +
                   "<h3> This is confidential information. </h3>" +
                   "<h3> Do not share with anyone </h3>"
        };
        using (var client = new SmtpClient())
        {
            try
            {
                client.Connect(Constant.Mail.SmtpServer, Constant.Mail.Port);
                client.Authenticate(Constant.Mail.UserName, Constant.Mail.Password);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Send(message);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                client.Disconnect(true);
            }
        }
    }


    public void SendMail(MailForm mailForm)
    {
        var message = new MimeMessage();

        message.From.Add(new MailboxAddress("", Constant.Mail.From));
        message.To.Add(new MailboxAddress("", mailForm.To));
        message.Subject = mailForm.Subject;
        message.Body = new TextPart(TextFormat.Html) { Text = mailForm.Body };

        using (var client = new SmtpClient())
        {
            try
            {
                client.Connect(Constant.Mail.SmtpServer, Constant.Mail.Port);
                client.Authenticate(Constant.Mail.UserName, Constant.Mail.Password);
                client.AuthenticationMechanisms.Remove(Constant.Mail.XOAUTH2);
                client.Send(message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                client.Disconnect(true);
            }
        }
    }
}