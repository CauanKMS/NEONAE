package dao;


import android.app.ProgressDialog;
import android.content.Context;
import android.os.AsyncTask;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;

import model.usuario;
import utils.criptografia;
import utils.dados;

public class PerfilBD extends AsyncTask<Object, Object, Boolean> {

    Connection conexao;

    Context tela;

    ProgressDialog dialogo;

    criptografia cripto;

    private usuario usuClasse;

    public usuario getUsuClasse() {
        return usuClasse;
    }

    public void setUsuClasse(usuario usuClasse) {
        this.usuClasse = usuClasse;
    }


    public PerfilBD(Context tela) {
        super();
        this.tela = tela;
        cripto = new criptografia("NEON");
    }

    public Boolean connect() {

        try {
            Class.forName("com.mysql.jdbc.Driver").newInstance();

            conexao = DriverManager.getConnection(
                    "jdbc:mysql://172.16.37.113:3306/neonae", "root", "ALUNOS");
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
    }

    @Override
    protected Boolean doInBackground(Object... params) {
        // TODO Auto-generated method stub

        Boolean resp;

        connect();

        resp = perfil();

        return resp;
    }


    @Override
    protected void onPostExecute(Boolean result) {
        // TODO Auto-generated method stub
        super.onPostExecute(result);

        if (result == false)
            Toast.makeText(tela,
                    "ERRO na pesquisa!!!",
                    Toast.LENGTH_SHORT).show();

        disconnect();
    }

    public Boolean perfil() {
        try {

            ResultSet tab;
            String sql = "select * from usuario where id_usu=?";
            PreparedStatement comando = conexao.prepareStatement(sql);
            comando.setInt(1, dados.getIdUsuario());
            tab = comando.executeQuery();

            if (tab.next()) {

                usuClasse = new usuario();

                usuClasse.setId_usu(tab.getInt("id_usu"));
                usuClasse.setId_tusu(tab.getInt("id_tusu"));
                usuClasse.setNome_usu(cripto.decrypt(tab.getString("nome_usu")));
                usuClasse.setCpf_usu(cripto.decrypt(tab.getString("cpf_usu")));
                usuClasse.setEmail_usu(cripto.decrypt(tab.getString("email_usu")));
                usuClasse.setSenha_usu(cripto.decrypt(tab.getString("senha_usu")));
                usuClasse.setSx_usu(cripto.decrypt(tab.getString("sx_usu")));
                usuClasse.setDtnasc_usu(cripto.decrypt(tab.getString("dtnasc_usu")));

                return true;

            } else {

                usuClasse = null;
                return false;
            }

        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }

    }
}

