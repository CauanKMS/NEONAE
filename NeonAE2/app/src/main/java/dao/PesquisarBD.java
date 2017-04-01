package dao;


import android.app.ProgressDialog;
import android.content.Context;
import android.os.AsyncTask;

import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;

import model.evento;
import utils.PesqEven;
import utils.criptografia;

public class PesquisarBD extends AsyncTask<Object, Object, Boolean> {

    Connection conexao;

    Context tela;

    ProgressDialog dialogo;

    criptografia cripto;

    private evento evenClasse;

    public evento getEvenClasse() {
        return evenClasse;
    }

    public void setEvenClasse(evento evenClasse) {
        this.evenClasse = evenClasse;
    }


    public PesquisarBD(Context tela) {
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

        resp = pesq();

        return resp;
    }


    @Override
    protected void onPostExecute(Boolean result) {
        // TODO Auto-generated method stub
        super.onPostExecute(result);

        disconnect();
    }

    public Boolean pesq() {

        try {
            Date dataTMP;
            SimpleDateFormat formatoData = new SimpleDateFormat("dd/MM/yyyy");

            Date dataTMP1;
            SimpleDateFormat formatoData1 = new SimpleDateFormat("dd/MM/yyyy");

            String sql = ("select * from evento e inner join tipo_evento ev on e.id_teve=ev.id_teve " +
                    "inner join subtipo_evento sb on e.id_subt=sb.id_subt " +
                    "inner join status_evento st on e.id_st=st.id_st " +
                    "inner join cliente_emp ep on e.id_emp=ep.id_emp where id_even=?");
            PreparedStatement comando = conexao.prepareStatement(sql);
            comando.setInt(1, PesqEven.getId());

            ResultSet tab = comando.executeQuery();

            if (tab.next()) {
                evenClasse = new evento();

                evenClasse.setId(tab.getInt("id_even"));
                evenClasse.setCid(cripto.decrypt(tab.getString("cid_even")));
                evenClasse.setDetalhesEven(cripto.decrypt(tab.getString("detalhes_even")));
                evenClasse.setHrFin(tab.getString("fimhr_even"));
                evenClasse.setHrIni(tab.getString("starthr_even"));
                evenClasse.setImg(cripto.decrypt(tab.getString("img_even")));
                evenClasse.setNomeEmpEven(cripto.decrypt(tab.getString("nome_emp")));
                evenClasse.setNomeEven(cripto.decrypt(tab.getString("nome_even")));
                evenClasse.setNomeLocal(cripto.decrypt(tab.getString("nomelocal_even")));
                evenClasse.setNumLocal(cripto.decrypt(tab.getString("numlocal_even")));
                evenClasse.setRua(cripto.decrypt(tab.getString("rua_even")));
                evenClasse.setStatus(cripto.decrypt(tab.getString("tipo_st")));
                evenClasse.setStatusEven(tab.getString("ativo_even"));
                evenClasse.setSubtEven(cripto.decrypt(tab.getString("descr_subt")));
                evenClasse.setTipoEven(cripto.decrypt(tab.getString("descr_teve")));
                evenClasse.setUf(cripto.decrypt(tab.getString("uf_even")));

                dataTMP = tab.getDate("fimdt_even");
                evenClasse.setDataFin(formatoData.format(dataTMP));

                dataTMP1 = tab.getDate("startdt_even");
                evenClasse.setDataIni(formatoData1.format(dataTMP1));

                return true;
            } else {

                evenClasse = null;
                return false;
            }

        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }
    }
}


