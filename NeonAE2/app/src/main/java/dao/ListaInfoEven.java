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
import java.util.ArrayList;
import java.util.List;

import model.evento;
import utils.PesqEven;
import utils.criptografia;


public class ListaInfoEven extends AsyncTask<Object, Object, Boolean> {

    Connection conexao;

    Context tela;

    ProgressDialog dialogo;

    criptografia cripto;

    private List<evento> listaEven = new ArrayList<>();

    public List<evento> getListaEven() {
        return listaEven;
    }

    public void setListaEven(List<evento> listaEven) {
        this.listaEven = listaEven;
    }



    public ListaInfoEven(Context tela) {
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

        dialogo = new ProgressDialog(tela);
        dialogo.setMessage("Aguarde ...");
        dialogo.show();
    }

    @Override
    protected Boolean doInBackground(Object... params) {
        // TODO Auto-generated method stub

        Boolean resp;

        connect();

        listarTudo();

        return null;
    }


    @Override
    protected void onPostExecute(Boolean result) {
        // TODO Auto-generated method stub
        super.onPostExecute(result);

        dialogo.dismiss();

        disconnect();
    }

    public Boolean listarTudo() {
        try {

            Date dataTMP;
            SimpleDateFormat formatoData = new SimpleDateFormat("dd/MM/yyyy");

            Date dataTMP1;
            SimpleDateFormat formatoData1 = new SimpleDateFormat("dd/MM/yyyy");

            String sql = "select * from evento e inner join " +
                    "tipo_evento ev on e.id_teve=ev.id_teve " +
                    "inner join subtipo_evento sb " +
                    "on e.id_subt=sb.id_subt inner join status_evento st on e.id_st=st.id_st inner join cliente_emp ep on e.id_emp=ep.id_emp" +
                    "where id_even=? and ativo_even=2";
            PreparedStatement comando = conexao.prepareStatement(sql);
            comando.setInt(1, PesqEven.getId());
            ResultSet tab = comando.executeQuery();

            while (tab.next()) {
                evento evento = new evento();

                evento.setId(tab.getInt("id_even"));
                evento.setCid(cripto.decrypt(tab.getString("cid_even")));
                evento.setDetalhesEven(cripto.decrypt(tab.getString("detalhes_even")));
                evento.setHrFin(tab.getString("fimhr_even"));
                evento.setHrIni(tab.getString("starthr_even"));
                evento.setNomeEmpEven(cripto.decrypt(tab.getString("nome_emp")));
                evento.setNomeEven(cripto.decrypt(tab.getString("nome_even")));
                evento.setNomeLocal(cripto.decrypt(tab.getString("nomelocal_even")));
                evento.setNumLocal(cripto.decrypt(tab.getString("numlocal_even")));
                evento.setRua(cripto.decrypt(tab.getString("rua_even")));
                evento.setStatus(cripto.decrypt(tab.getString("tipo_st")));
                evento.setSubtEven(cripto.decrypt(tab.getString("descr_subt")));
                evento.setTipoEven(cripto.decrypt(tab.getString("descr_teve")));
                evento.setUf(cripto.decrypt(tab.getString("uf_even")));

                dataTMP = tab.getDate("fimdt_even");
                evento.setDataFin(formatoData.format(dataTMP));

                dataTMP1 = tab.getDate("startdt_even");
                evento.setDataIni(formatoData1.format(dataTMP1));

                listaEven.add(evento);
            }
            return true;

        } catch (SQLException e) {
            e.printStackTrace();

            return false;
        }
    }
}
