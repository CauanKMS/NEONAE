using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace NeonAnunciosDeEventos
{
    class acessoADM
    {
        #region inserir
        //variaveis de inserir,pesquisar,alterar
        int id_tipousu, id_usu;
        string nome, dataTela, email, senha, cel, sx, img, rg, cpf, cep, numcasa, comp, respsec, pergsec;

        public string Pergsec
        {
            get { return pergsec; }
            set { pergsec = value; }
        }

        public string Respsec
        {
            get { return respsec; }
            set { respsec = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Comp
        {
            get { return comp; }
            set { comp = value; }
        }

        public string Numcasa
        {
            get { return numcasa; }
            set { numcasa = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        public string Sx
        {
            get { return sx; }
            set { sx = value; }
        }

        public string Cel
        {
            get { return cel; }
            set { cel = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string DataTela
        {
            get { return dataTela; }
            set { dataTela = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Id_tipousu
        {
            get { return id_tipousu; }
            set { id_tipousu = value; }
        }
        public int Id_usu
        {
            get { return id_usu; }
            set { id_usu = value; }
        }
        #endregion

        #region Verificar
        //verificação de email,cpf existente
        //pegar o nome do usuario
        string email_usu, cpf_usu, nome_usu;

        public string Nome_usu
        {
            get { return nome_usu; }
            set { nome_usu = value; }
        }

        public string Cpf_usu
        {
            get { return cpf_usu; }
            set { cpf_usu = value; }
        }

        public string Email_usu
        {
            get { return email_usu; }
            set { email_usu = value; }
        }
        //pegar o id do evento
        int id_even;

        public int Id_even
        {
            get { return id_even; }
            set { id_even = value; }
        }
        #endregion

        Criptografia cripto = new Criptografia("NEON");

        // variaveis para acessar o MySql
        MySqlDataAdapter comando_sql;
        MySqlCommandBuilder executar_comando;
        DataTable tabela_memoria;

        // método private de acesso ao BD
        private void carregar_tabela(string comando)
        {
            ConexaoPrincipal.criar_Conexao();
            // criar uma sacolinha vazia
            tabela_memoria = new DataTable();
            // converter um texto (string) para um comando SQL
            comando_sql = new MySqlDataAdapter(comando, ConexaoPrincipal.Conectar);
            // executar o comando SQL 
            executar_comando = new MySqlCommandBuilder(comando_sql);
            // resposta que será armazenada na sacolinha
            comando_sql.Fill(tabela_memoria);
        }

        //evento do inserir
        public void inserir(string id_tipousu, string nome, string dataTela, string email, string senha, string cel,
            string sx, string img, string rg, string cpf, string cep, string numcasa, string comp, string pergsec, string respsec)
        {
            //criptografando as variaveis necessárias
            nome = cripto.Encrypt(nome);
            dataTela = cripto.Encrypt(dataTela);
            email = cripto.Encrypt(email);
            senha = cripto.Encrypt(senha);
            cel = cripto.Encrypt(cel);
            sx = cripto.Encrypt(sx);
            img = cripto.Encrypt(img);
            rg = cripto.Encrypt(rg);
            cpf = cripto.Encrypt(cpf);
            cep = cripto.Encrypt(cep);
            numcasa = cripto.Encrypt(numcasa);
            comp = cripto.Encrypt(comp);
            pergsec = cripto.Encrypt(pergsec);
            respsec = cripto.Encrypt(respsec);

            carregar_tabela("insert into usuario values(0,'" + id_tipousu + "','" + nome + "','" + dataTela + "','" + email + "','" + senha + "','" + cel + "','" + sx + "','" + img + "','" + rg + "','" + cpf + "','" + cep + "','" + numcasa + "','" + comp + "','"+pergsec+"','"+respsec+"','0','1');");
        }
        
        public void contaDesativada(string email, string senha)
        {
            try
            {
                email = cripto.Encrypt(email);
                senha = cripto.Encrypt(senha);
                carregar_tabela("select id_usu,email_usu,senha_usu from usuario where email_usu='" + email + "' and senha_usu='" + senha + "' and ativo_usu=0");
                if (tabela_memoria.Rows.Count != 0)
                {
                    carregar_tabela("update usuario set primeiraentrada_usu=0, ativo_usu=1");
                }
            }
            catch { }
        }

        public Boolean PrimeiroAdm()
        {
            try
            {
                carregar_tabela("select id_usu from usuario where id_tusu=1");

                if (tabela_memoria.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }

        public void IDPrimeiroADM()
        {
            carregar_tabela("select id_usu from usuario where id_tusu=1");
            id_usu = Convert.ToInt32(tabela_memoria.Rows[0]["id_usu"].ToString());
        }

        public Boolean verificar(string email, string cpf)
        {
            try
            {
                email = cripto.Encrypt(email);
                cpf = cripto.Encrypt(cpf);
                try
                {
                    //verifica se o email e o cpf ja existe
                    carregar_tabela("select email_usu,cpf_usu from usuario where email_usu='" + email + "' and cpf_usu='" + cpf + "'");
                    if (tabela_memoria.Rows.Count != 0)
                    {
                        return true;
                    }
                    else
                    { return false; }
                }
                catch
                {
                    return false;
                }
            }
            catch { return false; }
        }

        public Boolean verificarApenasCpf(string cpf)
        {
            try
            {
                cpf = cripto.Encrypt(cpf);
                
                try
                {
                    //verifica se o email e o cpf ja existe
                    carregar_tabela("select email_usu,cpf_usu from usuario where cpf_usu='" + cpf + "'");
                    if (tabela_memoria.Rows.Count != 0)
                    {
                        return true;
                    }
                    else
                    { return false; }
                }
                catch
                {
                    return false;
                }
            }
            catch { return false; }
        }

        public DataTable listarAdms()
        {
            //cria uma tabela temporária
            DataTable tabelaTemp = new DataTable();

            //com o id,nome e email do usuario
            tabelaTemp.Columns.Add("id_usu", typeof(int));
            tabelaTemp.Columns.Add("nome_usu", typeof(String));
            tabelaTemp.Columns.Add("email_usu", typeof(String));

            //seleciona o id,nome e o email dos usuarios do tipo ADM ativos
            carregar_tabela("select id_usu,nome_usu,email_usu from usuario where id_tusu='1' and ativo_usu='1'");

            //for para carregar todos os registros pesquisados
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                //cria uma linha com essas informações
                DataRow linha = tabelaTemp.NewRow();

                linha["id_usu"] = tabela_memoria.Rows[i]["id_usu"].ToString();
                linha["nome_usu"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_usu"].ToString());
                linha["email_usu"] = cripto.Decrypt(tabela_memoria.Rows[i]["email_usu"].ToString());

                //a tabela temporaria recebe a linha criada
                tabelaTemp.Rows.Add(linha);
            }
            //e retorn a tabela temporaria
            return tabelaTemp;
        }

        public DataTable listarFuncs()
        {
            //cria uma tabela temporária
            DataTable tabelaTemp = new DataTable();

            //com o id,nome e email do usuario
            tabelaTemp.Columns.Add("id_usu", typeof(int));
            tabelaTemp.Columns.Add("nome_usu", typeof(String));
            tabelaTemp.Columns.Add("email_usu", typeof(String));

            //seleciona o id,nome e o email dos usuarios do tipo Func ativos
            carregar_tabela("select id_usu,nome_usu,email_usu from usuario where id_tusu='2' and ativo_usu='1'");

            //for para carregar todos os registros pesquisados
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                //cria uma linha com essas informações
                DataRow linha = tabelaTemp.NewRow();

                linha["id_usu"] = tabela_memoria.Rows[i]["id_usu"].ToString();
                linha["nome_usu"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_usu"].ToString());
                linha["email_usu"] = cripto.Decrypt(tabela_memoria.Rows[i]["email_usu"].ToString());

                //a tabela temporaria recebe a linha criada
                tabelaTemp.Rows.Add(linha);
            }
            //e retorn a tabela temporaria
            return tabelaTemp;
        }

        public DataTable ListarEmp()
        {
            //cria uma tabela temporária
            DataTable tabelaTemp = new DataTable();

            //com o id,nome e email do usuario
            tabelaTemp.Columns.Add("id_emp", typeof(int));
            tabelaTemp.Columns.Add("nome_emp", typeof(String));
            tabelaTemp.Columns.Add("email_emp", typeof(String));

            //seleciona o id,nome e o email da empresa com o status ativo
            carregar_tabela("select id_emp,nome_emp,email_emp from cliente_emp where ativo_emp='1'");

            //for para carregar todos os registros pesquisados
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                //cria uma linha com essas informações
                DataRow linha = tabelaTemp.NewRow();

                linha["id_emp"] = tabela_memoria.Rows[i]["id_emp"].ToString();
                linha["nome_emp"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_emp"].ToString());
                linha["email_emp"] = cripto.Decrypt(tabela_memoria.Rows[i]["email_emp"].ToString());

                //a tabela temporaria recebe a linha criada
                tabelaTemp.Rows.Add(linha);
            }
            //e retorn a tabela temporaria
            return tabelaTemp;
        }

        public DataTable ListarUsu()
        {
            //cria uma tabela temporária
            DataTable tabelaTemp = new DataTable();

            //com o id,nome e email do usuario
            tabelaTemp.Columns.Add("id_usu", typeof(int));
            tabelaTemp.Columns.Add("nome_usu", typeof(String));
            tabelaTemp.Columns.Add("email_usu", typeof(String));

            //seleciona o id,nome e o email da tabela usuario e tipo usuarios ativos
            carregar_tabela("select id_usu,nome_usu,email_usu from usuario where id_tusu='3' and ativo_usu='1'");

            //for para carregar todos os registros pesquisados
            for (int i = 0; i < tabela_memoria.Rows.Count; i++)
            {
                //cria uma linha com essas informações
                DataRow linha = tabelaTemp.NewRow();

                linha["id_usu"] = tabela_memoria.Rows[i]["id_usu"].ToString();
                linha["nome_usu"] = cripto.Decrypt(tabela_memoria.Rows[i]["nome_usu"].ToString());
                linha["email_usu"] = cripto.Decrypt(tabela_memoria.Rows[i]["email_usu"].ToString());

                //a tabela temporaria recebe a linha criada
                tabelaTemp.Rows.Add(linha);
            }
            //e retorn a tabela temporaria
            return tabelaTemp;
        }
        public void DesativaConta()
        {
            try
            {
                carregar_tabela("update usuario set ativo_usu='0' where id_usu='" + abstractClasse.Id_logon + "'");
            }
            catch { }
        }

        public Boolean UltimoADM(int id)
        {
            try
            {
                //verifica quantos adm estão ativos
                carregar_tabela("select count(*) from usuario where id_tusu='1' and ativo_usu='1'");

                //caso tenha mais do que 1
                if (Convert.ToInt32(tabela_memoria.Rows[0]["count(*)"].ToString()) > 1)
                {
                    //ele desativa a conta
                    carregar_tabela("update usuario set ativo_usu='0' where id_usu='" + id + "'");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }

        //evento de pesquisa
        public Boolean Pesq(string EmailP, string tipousu)
        {
            //criptografa o email pra pesquisar
            EmailP = cripto.Encrypt(EmailP);
            carregar_tabela("select nome_usu,dtnasc_usu,email_usu,senha_usu,cel_usu,sx_usu,img_usu,rg_usu,cpf_usu,cep_usu,numcasa_usu,compl_usu,pergsec_usu,respsec_usu from usuario where id_tusu='" + tipousu + "' and email_usu='" + EmailP + "' and ativo_usu='1'");

            if (tabela_memoria.Rows.Count != 0)
            {
                //descriptografando todas as informações necessárias
                Nome = cripto.Decrypt(tabela_memoria.Rows[0]["nome_usu"].ToString());
                dataTela = cripto.Decrypt(tabela_memoria.Rows[0]["dtnasc_usu"].ToString()).Replace(",", ".");
                Email = cripto.Decrypt(tabela_memoria.Rows[0]["email_usu"].ToString());
                Senha = cripto.Decrypt(tabela_memoria.Rows[0]["senha_usu"].ToString());
                Cel = cripto.Decrypt(tabela_memoria.Rows[0]["cel_usu"].ToString()).Replace(",", ".");
                Sx = cripto.Decrypt(tabela_memoria.Rows[0]["sx_usu"].ToString());
                Img = cripto.Decrypt(tabela_memoria.Rows[0]["img_usu"].ToString());
                Rg = cripto.Decrypt(tabela_memoria.Rows[0]["rg_usu"].ToString()).Replace(",", ".");
                Cpf = cripto.Decrypt(tabela_memoria.Rows[0]["cpf_usu"].ToString()).Replace(",", ".");
                Cep = cripto.Decrypt(tabela_memoria.Rows[0]["cep_usu"].ToString());
                Numcasa = cripto.Decrypt(tabela_memoria.Rows[0]["numcasa_usu"].ToString());
                Comp = cripto.Decrypt(tabela_memoria.Rows[0]["compl_usu"].ToString());
                Pergsec = cripto.Decrypt(tabela_memoria.Rows[0]["pergsec_usu"].ToString());
                Respsec = cripto.Decrypt(tabela_memoria.Rows[0]["respsec_usu"].ToString());

                return true;
            }
            else
            {
                return false;
            }
        }

        public void update(string nome, string dataTela, string email, string senha, string cel, string sx, string img, string rg, string cep, string numcasa, string comp, string pergsec, string respsec)
        {
            try
            {
                //criptografando todas as informações que não são primory key ou foreign key
                nome = cripto.Encrypt(nome);
                dataTela = cripto.Encrypt(dataTela);
                email = cripto.Encrypt(email);
                senha = cripto.Encrypt(senha);
                cel = cripto.Encrypt(cel);
                sx = cripto.Encrypt(sx);
                img = cripto.Encrypt(img);
                rg = cripto.Encrypt(rg);
                cep = cripto.Encrypt(cep);
                numcasa = cripto.Encrypt(numcasa);
                comp = cripto.Encrypt(comp);
                pergsec = cripto.Encrypt(pergsec);
                respsec = cripto.Encrypt(respsec);

                carregar_tabela("update usuario set nome_usu='" + nome + "',dtnasc_usu='" + dataTela + "',senha_usu='" + senha + "',cel_usu='" + cel + "',sx_usu='" + sx + "',img_usu='" + img + "',rg_usu='" + rg + "',cep_usu='" + cep + "',numcasa_usu='" + numcasa + "',compl_usu='" + comp + "', pergsec_usu='" + pergsec + "', respsec_usu='" + respsec + "' where email_usu='" + email + "'");
            }
            catch
            {
            }
        }

        public string CreatePassword(int length)//Gerando senha para enviar no email
        {
            const string NewPassword = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";
            StringBuilder res = new StringBuilder();
            Random random = new Random();
            while (0 < length--)
            {
                res.Append(NewPassword[random.Next(NewPassword.Length - 1)]);
            }
            return res.ToString();
        }
        public Boolean VerificarEmailPraTroca(string email)
        {
            //verificar se é o email atual do usuário para poder altera-lo
            try
            {
                email = cripto.Encrypt(email);
                carregar_tabela("select email_usu from usuario where email_usu='" + email + "'");
                if (tabela_memoria.Rows.Count != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }

        public void TrocarEmail(string NovoEmail)
        {
            //Atualiza o Email caso o usuário deseje
            NovoEmail = cripto.Encrypt(NovoEmail);
            carregar_tabela("update usuario set email_usu='" + NovoEmail + "' where id_usu='" + abstractClasse.Id_logon + "'");
        }

        public void SenhaEmail(string senha)
        {
            //a senha criada pelo software é colocado como a senha do usuário para ser enviado ao email
            senha = cripto.Encrypt(senha);
            carregar_tabela("update usuario set senha_usu='" + senha + "' where id_usu='" + abstractClasse.Id_logon + "'");
        }

        public void UpdatePergSec(string pergSec, string respSec) 
        {
            //caso não haja uma pergunta e uma resposta secreta no banco é adiconado
            pergSec = cripto.Encrypt(pergSec);
            respSec = cripto.Encrypt(respSec);

            if (SemPergSecRespSec(pergSec, respSec) == true)
            {
                carregar_tabela("update usuario set pergsec_usu='" + pergSec + "', respsec_usu='" + respSec + "' where id_usu='" + abstractClasse.Id_logon + "'");
            }
        }
        
        public Boolean SemPergSecRespSec(string perg,string resp)
        {
            //Existe Alguma Pergunta Secreta e Resposta Secreta no banco 
            carregar_tabela("select pergsec_usu,respsec_usu from usuario where id_usu='" + abstractClasse.Id_logon + "'");
            if (tabela_memoria.Rows[0]["pergsec_usu"].ToString() != "")
                return true;
            else
                return false;
        }

        public Boolean CarregarPergRespSecPrimeiraEntrada(int id_usu)
        {
            //caso exista uma pergunta e resposta secreta ele exibirá
            carregar_tabela("select pergsec_usu,respsec_usu from usuario where id_usu='" + id_usu + "'");
            try
            {
                if (tabela_memoria.Rows.Count != 0)
                {
                    pergsec = cripto.Decrypt(tabela_memoria.Rows[0]["pergsec_usu"].ToString());
                    respsec = cripto.Decrypt(tabela_memoria.Rows[0]["respsec_usu"].ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public Boolean Valida(string cpf)//CPF válido

        {
            try
            {
                //cria 2 arrays
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                //cria 4 variaveis
                string tempCpf;
                string digito;
                int soma;
                int resto;

                //tira todos os caracteres desnecessários do cpf
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");

                //se não houver 11 caracteres ele retorna falso
                if (cpf.Length != 11)
                    return false;

                //cpf temporário
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                //for que multiplica os primeiros 9 digitos do cpf pelo primeiro array
                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                //depois de somar os frutos da multiplicação dos números do cpf pela respectiva ordem do 1º array
                //divide por 11 pra checar se é menor que 2
                resto = soma % 11;

                //se sim
                if (resto < 2)
                    //o resto recebe 0
                    resto = 0;

                else
                    //senão, o resto vai ser 11 menos o resultado da divisão por 11
                    resto = 11 - resto;

                //digito recebe o resto
                digito = resto.ToString();
                //o cpf temporário recebe o digito(resto)
                tempCpf = tempCpf + digito;
                //zera a soma
                soma = 0;  

                //multiplica os 10 digitos do cpf temporário pelo 2 array
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                //o resto é a soma da multiplicação dos digitos do cpf pelo 2º array
                resto = soma % 11;

                //se for menor que 2
                if (resto < 2)
                    //o resto recebe 0
                    resto = 0;

                else
                    //senão, o resto recebe 11 menos o resto
                    resto = 11 - resto;
                //digito vai receber o primeiro valor do digito + o segundo resto
                digito = digito + resto.ToString();
                //a resposta boolean é armazenada na variável abstrata
                abstractClasse.Cpf_valido = cpf.EndsWith(digito).ToString();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean Valida2(string rg)//RG válido
        {
            //tirando caracteres especias do rg
            rg = rg.Trim();
            rg = rg.Replace(".", "").Replace("-", "").Replace(",", "");

            //criando um array
            int[] n = new int[9];

            try
            {
                //colocando cada campo do rg em um respctivo lugar no array
                n[0] = Convert.ToInt32(rg.Substring(0, 1));
                n[1] = Convert.ToInt32(rg.Substring(1, 1));
                n[2] = Convert.ToInt32(rg.Substring(2, 1));
                n[3] = Convert.ToInt32(rg.Substring(3, 1));
                n[4] = Convert.ToInt32(rg.Substring(4, 1));
                n[5] = Convert.ToInt32(rg.Substring(5, 1));
                n[6] = Convert.ToInt32(rg.Substring(6, 1));
                n[7] = Convert.ToInt32(rg.Substring(7, 1));
                //verificando que o camando termina com x ou não
                if (rg.Substring(8, 1).Equals("x") || rg.Substring(8, 1).Equals("X"))
                {
                    //se terminar o ultimo array recebe 10
                    n[8] = 10;
                }
                else
                {
                    //senão recebe o que veio do rg
                    n[8] = Convert.ToInt32(rg.Substring(8, 1));
                }
            }
            catch (Exception)
            {
                return false;
            }
            //obtém cada um dos caracteres do rg

            //Aplica a regra de validação do RG, multiplicando cada digito por valores pré-determinados
            n[0] *= 2;
            n[1] *= 3;
            n[2] *= 4;
            n[3] *= 5;
            n[4] *= 6;
            n[5] *= 7;
            n[6] *= 8;
            n[7] *= 9;
            n[8] *= 100;

            //Valida o RG
            int somaFinal = n[0] + n[1] + n[2] + n[3] + n[4] + n[5] + n[6] + n[7] + n[8];
            //caso a divisão por 11 seja 0, ele é verdadeiro
            if ((somaFinal % 11) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
