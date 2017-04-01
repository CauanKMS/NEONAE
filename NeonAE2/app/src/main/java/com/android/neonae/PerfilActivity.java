package com.android.neonae;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;

import java.util.concurrent.ExecutionException;

import dao.PerfilBD;
import model.usuario;

public class PerfilActivity extends AppCompatActivity implements View.OnClickListener {

    EditText txtNome, txtDt, txtCpf, txtEmail, txtSenha, txtSexo;

    PerfilBD perfil = new PerfilBD(this);
    usuario usuTela;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil);

        try {
            txtCpf = (EditText) findViewById(R.id.txtCpf);
            txtDt = (EditText) findViewById(R.id.txtDt);
            txtEmail = (EditText) findViewById(R.id.txtEmail);
            txtNome = (EditText) findViewById(R.id.txtNome);
            txtSenha = (EditText) findViewById(R.id.txtSenhaPerfil);
            txtSexo = (EditText) findViewById(R.id.txtTipoSexo);


            usuTela = new usuario();

            perfil.execute().get();

            usuTela = perfil.getUsuClasse();

            txtDt.setText(usuTela.getDtnasc_usu());
            txtNome.setText(usuTela.getNome_usu());
            txtEmail.setText(usuTela.getEmail_usu());
            txtSenha.setText(usuTela.getSenha_usu());
            txtCpf.setText(usuTela.getCpf_usu());

            if(usuTela.getSx_usu().equals("m"))
                txtSexo.setText("Masculino");
            if(usuTela.getSx_usu().equals("f"))
                txtSexo.setText("Feminino");
            else
                txtSexo.setText("Outros");



        } catch (InterruptedException e) {
            e.printStackTrace();
        } catch (ExecutionException e) {
            e.printStackTrace();
        }


    }

    @Override
    public void onClick(View view) {

        switch (view.getId()) {

        }


    }
}
