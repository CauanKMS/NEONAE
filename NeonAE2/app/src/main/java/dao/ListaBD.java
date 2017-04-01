package dao;

import android.app.ProgressDialog;
import android.content.Context;
import android.os.AsyncTask;
import android.widget.Toast;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import model.eventolista;
import utils.criptografia;

public class ListaBD extends AsyncTask<Object, Object, Boolean> {

    Connection conexao;

    Context tela;

    ProgressDialog dialogo;

    criptografia cripto;

    List<eventolista> listaEven = new ArrayList<eventolista>();
    public List<eventolista> getListaEven() {
        return listaEven;
    }

    public void setListaEven(List<eventolista> listaEven) {
        this.listaEven = listaEven;
    }



    public ListaBD(Context tela) {
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

        resp = listarTudo();

        return resp;
    }



    @Override
    protected void onPostExecute(Boolean result) {
        // TODO Auto-generated method stub
        super.onPostExecute(result);

        if(result == false)
            Toast.makeText(tela,
                    "ERRO!!!",
                    Toast.LENGTH_SHORT).show();

        dialogo.dismiss();

        disconnect();
    }

    public Boolean listarTudo()
    {
        try{
            String sql = "select * from evento";
            PreparedStatement comando = conexao.prepareStatement(sql);
            ResultSet tab = comando.executeQuery();

            while(tab.next()){
                eventolista evento = new eventolista();

                evento.setId(tab.getInt("id_even"));
                evento.setNomeEven(cripto.decrypt(tab.getString("nome_even")));
                evento.setImg(cripto.decrypt(tab.getString("img_even")));

                listaEven.add(evento);
            }
            return true;

        }catch(SQLException e){
            e.printStackTrace();

            return false;
        }
    }

}
