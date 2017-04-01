package dao;

import android.app.ProgressDialog;
import android.content.Context;
import android.os.AsyncTask;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import model.usuario;
import utils.criptografia;

public class CadastrarBD extends AsyncTask<Object, Object, Boolean> {

    Connection conexao;

    Context tela;

    ProgressDialog dialogo;

    criptografia cripto;

    usuario usu = new usuario();

    public usuario getUsu() {
        return usu;
    }

    public void setUsu(usuario usu) {
        this.usu = usu;
    }


    public CadastrarBD(Context tela) {
        super();
        this.tela = tela;
        cripto = new criptografia("NEON");
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

    public void disconnect() {
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
        dialogo.setMessage("Aguarde...");
        dialogo.show();
    }

    @Override
    protected Boolean doInBackground(Object... params) {
        // TODO Auto-generated method stub

        Boolean resp;

        connect();

        resp = insert();

        return resp;
    }


    @Override
    protected void onPostExecute(Boolean result) {
        // TODO Auto-generated method stub
        super.onPostExecute(result);

        if (result == true)
            Toast.makeText(tela,
                    "Dados cadastrados com sucesso!!!",
                    Toast.LENGTH_SHORT).show();
        else
            Toast.makeText(tela,
                    "ERRO no cadastro!!!",
                    Toast.LENGTH_SHORT).show();

        dialogo.dismiss();

        disconnect();
    }

    public Boolean insert() {
        try {

            String sql = "insert into usuario(id_usu,id_tusu,nome_usu,dtnasc_usu,email_usu,senha_usu,sx_usu,cpf_usu,ativo_usu) values(0,?,?,?,?,?,?,?,1)";
            PreparedStatement comando = conexao.prepareStatement(sql);
            comando.setInt(1, usu.getId_tusu());
            comando.setString(2, cripto.encrypt(usu.getNome_usu().getBytes()).replace("\n",""));
            comando.setString(3,  cripto.encrypt(usu.getDtnasc_usu().getBytes()).replace("\n",""));
            comando.setString(4, cripto.encrypt(usu.getEmail_usu().getBytes()).replace("\n",""));
            comando.setString(5, cripto.encrypt(usu.getSenha_usu().getBytes()).replace("\n",""));
            comando.setString(6, cripto.encrypt(usu.getSx_usu().getBytes()).replace("\n",""));
            comando.setString(7, cripto.encrypt(usu.getCpf_usu().getBytes()).replace("\n",""));

            comando.executeUpdate();

            return true;
        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }
    }
}