using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;

namespace VueBase.Controllers
{
    [Route("[controller]/Send")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail([FromBody] EmailModel model)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("pc.hardware.projekt@gmail.com", "udii dcfj emcs qmtq"),
                    EnableSsl = true,
                };

                smtpClient.Send(model.Email, "pc.hardware.projekt@gmail.com", $"Contact Form Message from {model.Email}", $"From: {model.Email}\n\nMessage: {model.Message}");

                return Ok("Email sent successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to send email: {ex.Message}");
            }
        }
    }

    public class EmailModel
    {
        public string Email { get; set; }
        public string Message { get; set; }
    }
}