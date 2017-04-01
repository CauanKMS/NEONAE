package dao;

import android.app.ProgressDialog;
import android.content.Context;

import android.os.AsyncTask;
import android.os.Build;

import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import model.usuario;
import utils.criptografia;
import utils.dados;

public class LoginBD extends AsyncTask<Object, Object, Boolean> {

    Connection conexao;

    Context tela;

    ProgressDialog dialogo;

    criptografia cripto;

    Boolean logado;

    public Boolean getLogado() {
        return logado;
    }

    public void setLogado(Boolean logado) {
        this.logado = logado;
    }

    public LoginBD(Context tela) {
        super();
        this.tela = tela;
        cripto = new criptografia("NEON");
    }

    usuario usuClasse = new usuario();

    public usuario getUsuClasse() {
        return usuClasse;
    }

    public void setUsuClasse(usuario usuClasse) {
        this.usuClasse = usuClasse;
    }


    public Boolean connect() {

        try {
            Class.forName("com.mysql.jdbc.Driver").newInstance();

            conexao = DriverManager.getConnection("jdbc:mysql://172.16.37.113:3306/neonae", "root", "ALUNOS");
            return true;
        } catch (Exception e) {
            e.printStackTrace();
            return false;
        }
    }

    public void disconnect(){
        try {
            conexao.close();
        } catch (SQLException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }

    @Override
    protected void onPreExecute() {
        // TODO Auto-generated method stub
        super.onPreExecute();

        dialogo = new ProgressDialog(tela);
        dialogo.setMessage("Aguarde ...");
        dialogo.show();
    }

    @Override
    protected Boolean doInBackground(Object... params) {
        // TODO Auto-generated method stub

        Boolean resp;

        connect();
        resp = logar();

        return resp;
    }

    @Override
    protected void onPostExecute(Boolean result) {
        // TODO Auto-generated method stub
        super.onPostExecute(result);

        if(result == false)
            Toast.makeText(tela,
                    "Usuario nao cadastrado!!!",
                    Toast.LENGTH_SHORT).show();

        dialogo.dismiss();

        disconnect();
    }


    private Boolean logar() {
        try
        {
            SimpleDateFormat sdf = new SimpleDateFormat("HH:mm:ss");
            Date hora = Calendar.getInstance().getTime();
            String dataFormatada = sdf.format(hora);

            ResultSet tabelaMemoria;
            String sql = "select * from usuario where email_usu=? and senha_usu=?";
            PreparedStatement comando = conexao.prepareStatement(sql);
            comando.setString(1, cripto.encrypt(usuClasse.getEmail_usu().getBytes()).replace("\n",""));
            comando.setString(2, cripto.encrypt(usuClasse.getSenha_usu().getBytes()).replace("\n",""));
            tabelaMemoria = comando.executeQuery();

            if (tabelaMemoria.next())
            {
                logado = true;
                dados.setIdUsuario(tabelaMemoria.getInt("id_usu"));
                dados.setLogin(tabelaMemoria.getString("email_usu"));
                dados.setSenha(tabelaMemoria.getString("senha_usu"));
                dados.setHr(dataFormatada);
                return true;
            }
            else
            {
                logado = false;
                return false;
            }
        }
        catch(SQLException e)
        {
            e.printStackTrace();
            return false;
        }

    }



}