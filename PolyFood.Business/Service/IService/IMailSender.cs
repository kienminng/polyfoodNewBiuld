using PolyFood.DTOs.Form;
using PolyFood.Entity.Entity;

namespace PolyFood.Business.Service.IService;

public interface IMailSender
{
    void SendMail(MailForm mailForm);
    public bool ConfirmEmailByUrl(Account account,string Token);
}