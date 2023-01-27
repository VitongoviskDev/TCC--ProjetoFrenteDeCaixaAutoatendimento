using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_frente_de_Caixa.Model;
using Projeto_frente_de_Caixa.Control;

namespace Projeto_frente_de_Caixa.Util
{
    public static class EmailSender
    {

        private const string DISPLAYED_NAME = "Frente de Caixa Autoatendimento";
        private const string SUBEJECT = "FCA";

        public static void TestEmail(string log, string senha, string verificationCode)
        {
            string subject = $"{SUBEJECT} - Validação do e-mail";
            string content = "<h2>Por favor, não responda este e-mail.</h2>" +
                                $"<h2 style=\"font-family: Century Gothic;\">Ultilize este código para validar o o-email:</h2>" +
                                $"<h1 style=\"color:#191970;font-size:46px;font-weight: bold;font-family: Century Gothic;\">{verificationCode}</h1>";

            NetworkCredential login = new NetworkCredential(log, senha);

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = login;

            MailMessage msg = new MailMessage { From = new MailAddress(log, DISPLAYED_NAME, Encoding.UTF8) };
            msg.To.Add(new MailAddress(log));

            msg.Subject = subject;
            msg.Body = content;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";
            client.SendAsync(msg, userstate);
        }
        public static void SendVerificationCodeEmail(string to, string code) {

            string subject = $"{SUBEJECT} - Redefinição de Senha";
            string content = "<h2 style=\"font-family: Century Gothic;\">Ultilize este código para redefinir sua senha: </h2>" +
                                "\n<h1 style=\"color:#191970;font-size:46px;font-weight: bold;font-family: Century Gothic;\">" + code + "</h1>";

            ConfigControll configControll = new ConfigControll();
            ConfigModel config = configControll.GetConfig();

            NetworkCredential login = new NetworkCredential(config.Email, config.Password);

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = login;

            MailMessage msg = new MailMessage { From = new MailAddress(config.Email, DISPLAYED_NAME, Encoding.UTF8) };
            msg.To.Add(new MailAddress(to));

            msg.Subject = subject;
            msg.Body = content;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";
            client.SendAsync(msg, userstate);
        }
        public static void SendPasswordChangedEmail(string to) {

            string subject = $"{SUBEJECT} - Senha Alterada";
            string content = $"<h1 style=\"font-family: Century Gothic;\">Sua senha acaba de ser alterada</h1>" +
                            $"<p style=\"font-family: Century Gothic; Fore-Color = red;\">Você não fez essa atualização?" +
                            $"<br>Entre em contato com o adioministrador do sistema!</p>";

            ConfigControll configControll = new ConfigControll();
            ConfigModel config = configControll.GetConfig();

            NetworkCredential login = new NetworkCredential(config.Email, config.Password);

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = login;

            MailMessage msg = new MailMessage { From = new MailAddress(config.Email, DISPLAYED_NAME, Encoding.UTF8) };
            msg.To.Add(new MailAddress(to));

            msg.Subject = subject;
            msg.Body = content;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";
            client.SendAsync(msg, userstate);
        }
        public static void SendStorageLevelAlertEmail(ProductModel product) {

            string subject = $"{SUBEJECT} - Alerta de Estoque";
            string content = $"<h1 style=\"font-family: Century Gothic;\">O produto \"{product.Code} - {product.Description}\" atingiu a quantidade de {product.StorageLevelAlert.ToString()}<br> items acionando o alerta de estoque.</h1>";

            ConfigControll configControll = new ConfigControll();
            ConfigModel config = configControll.GetConfig();

            NetworkCredential login = new NetworkCredential(config.Email, config.Password);

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = login;

            MailMessage msg = new MailMessage { From = new MailAddress(config.Email, DISPLAYED_NAME, Encoding.UTF8) };
            msg.To.Add(new MailAddress(config.Email));

            msg.Subject = subject;
            msg.Body = content;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";
            client.SendAsync(msg, userstate);
        }
        public static void SendStorageLevelZeroEmail(ProductModel product) {

            string subject = $"{SUBEJECT} - Alerta de Estoque";
            string content = $"<h1 style=\"font-family: Century Gothic;\">O produto \"{product.Code} - {product.Description}\" foi esgostado do estoque.</h1>";

            ConfigControll configControll = new ConfigControll();
            ConfigModel config = configControll.GetConfig();

            NetworkCredential login = new NetworkCredential(config.Email, config.Password);

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = login;

            MailMessage  msg = new MailMessage { From = new MailAddress(config.Email, DISPLAYED_NAME, Encoding.UTF8) };
            msg.To.Add(new MailAddress(config.Email));

            msg.Subject = subject;
            msg.Body = content;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";
            client.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show($"{e.UserState} send canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show($"{e.UserState} {e.Error}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
