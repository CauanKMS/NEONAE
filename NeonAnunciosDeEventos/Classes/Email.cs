using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Configuration;

namespace NeonAnunciosDeEventos
{
    public class Email
    {
        public static void enviarEmail(string Destinatario, string Nome, string Assunto, string Conteudo)
        {
            string remetenteEmail = "suporte.neonae@gmail.com"; //O e-mail do remetente
            MailMessage mail = new MailMessage();
            mail.To.Add(Destinatario);
            mail.From = new MailAddress(remetenteEmail, Nome, System.Text.Encoding.UTF8);
            mail.Subject = Assunto;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = Conteudo;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High; //Prioridade do E-Mail
            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient();  //Adicionando as credenciais do seu e-mail e senha:
            client.Credentials = new System.Net.NetworkCredential(remetenteEmail, "tccboladao123");
            client.Port = 587; // Esta porta é a utilizada pelo Gmail para envio
            client.Host = "smtp.gmail.com"; //Definindo o provedor que irá disparar o e-mail
            client.EnableSsl = true; //Gmail trabalha com Server Secured Layer
            
            try
            { client.Send(mail); }
            catch { }
        }

        public static void CadConfSenha(String Destinatario, String NomeCadastro, String Senha)
        {
            //executa o evento acima, para enviar a senha ao Func ou Adm
            enviarEmail(Destinatario, "Neon AE", "Neon AE - Confirmação de Senha",
                "<img src='https://lh3.googleusercontent.com/HjzaxhpkwDJrq32R2Ig7l2GvP2h2MufWvY3GCCG71ngi-J5uKiXmftftWbHUm4Sbnmvz5j3a=w1366-h768-rw-no' style='height:230px; width:260px'/><hr />" +
                "A Neon AE manda sua senha para confirmação.<br /> Mãos a Obra e Bom Trabalho!<br /><br />" +
                "<b>" + NomeCadastro +
                                                "</b><hr /><br /><b>Seus dados para login são:</b> " +
                                                "<br /><b>Login:</b> " + Destinatario +
                                                "<br /><b>Senha:</b> " + Senha +
                                                "<br /><hr /><br />Atenciosamente, Neon AE.");
        }

        public static void EsqSenha(String Destinatario, String NomeCadastro, String Senha)
        {
            //caso ele esqueça sua senha, é enviado para seu email
            enviarEmail(Destinatario, "Neon AE", "Neon AE - Nova Senha",
                "<img src='https://lh3.googleusercontent.com/HjzaxhpkwDJrq32R2Ig7l2GvP2h2MufWvY3GCCG71ngi-J5uKiXmftftWbHUm4Sbnmvz5j3a=w1366-h768-rw-no' style='height:230px; width:260px'/><hr />" +
                "A Neon AE manda sua nova senha para que você consiga acessar novamente ao Software.<br /> Mãos a Obra e Bom Trabalho!<br /><br />" +
                "<b>" + NomeCadastro +
                                                "</b><hr /><br /><b>Seus dados para login são:</b> " +
                                                "<br /><b>Login:</b> " + Destinatario +
                                                "<br /><b>Senha:</b> " + Senha +
                                                "<br /><hr /><br />Atenciosamente, Neon AE.");
        }

        public static void RecusouEvento(String Destinatario, String NomeCadastro, String Motivo)
        {
            enviarEmail(Destinatario, "NEON AE", "NEON AE - Seu Evento foi Rejeitado",
                "<div style='border:solid lightgray 2px;padding-bottom:10px;padding-left:10px;height:170px;width:500px;'><div style='float:left;'><img src='https://lh3.googleusercontent.com/SH5iPar4KcJUF7ZdcZWtZdXNTDiSL42szpibbulkQasE_Euweq20Q7Tx169Ky7mroV-uoSSn=w1440-h900-rw-no' style='height: 150px; width: 170px;'/></div>" +
                "<div style=overflow:hidden;'><p>A Equipe NEON AE gostaria de informar o(a) <b>" + NomeCadastro + "</b> que seu evento foi rejeitado por alguma anormalidade.</p><p>Caso queira que seu evento seja aprovado mantenha-o coerente com o nosso meio de exposição e nosso público.</p>" +
                "<b>" + NomeCadastro + "</b><br><b>O Motivo da Rejeição foi:</b> "+Motivo+"</p>" +
                                       "<div style='text-align:right;padding-right:15px;padding-top:7px'>Atenciosamente, Neon AE.</div></div></div >");
        }
    }
}
