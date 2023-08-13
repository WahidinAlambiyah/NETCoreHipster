using System.Threading.Tasks;
using NETCoreHipster.Domain.Entities;

namespace NETCoreHipster.Domain.Services.Interfaces;

public interface IMailService
{
    Task SendPasswordResetMail(User user);
    Task SendActivationEmail(User user);
    Task SendCreationEmail(User user);
}
