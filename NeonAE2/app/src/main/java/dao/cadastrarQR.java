package dao;

import android.app.ProgressDialog;
import android.content.Context;
import android.os.AsyncTask;
import android.widget.Toast;

import model.QR;
import utils.criptografia;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

/**
 * Created by aluno on 28/10/2016.
 */

public class cadastrarQR extends AsyncTask<Object, Object, Boolean> {
    Connection conexao;
    Context tela;
    ProgressDialog dialogo;
    criptografia cripto;

    private QR QRClasse;

    public QR getQRClasse() {return QRClasse;}
    public void setQRClasse(QR QRClasse) {this.QRClasse = QRClasse;}

    public cadastrarQR(Context tela) {
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
    protected Boolean doInBackground(Object... objects) {

        Boolean resp;
        connect();
        resp = inserirQR();
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

    public Boolean inserirQR() {
        try {
            SimpleDateFormat sdf = new SimpleDateFormat("HH:mm:ss");
            Date hora = Calendar.getInstance().getTime();
            String dataFormatada = sdf.format(hora);

            String sql = "insert into qrcode values(0,?,?,?,?)";
            PreparedStatement comando = conexao.prepareStatement(sql);
            comando.setString(1, QRClasse.getLogin_qrc());
            comando.setString(2, QRClasse.getSenha_qrc());
            comando.setString(3, dataFormatada);
            comando.setInt(4, QRClasse.getAtivo_qrc());

            comando.execute();
            return true;
        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        }

    }
}
