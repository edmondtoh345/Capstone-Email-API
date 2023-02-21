using Email_App_03.Service;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace Email_App_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
            private readonly IEmailService emailService;

            public EmailController(IEmailService emailService)
            {
                this.emailService = emailService;
            }

            [HttpPost]
            public IActionResult SendMail(string to, string subject, string body)
            {
                emailService.SendMail(to, subject, body);
                return Ok("Email sent successfully");
            }
        }
    }

