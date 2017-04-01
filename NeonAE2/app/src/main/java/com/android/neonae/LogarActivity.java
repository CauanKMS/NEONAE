package com.android.neonae;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import java.util.concurrent.ExecutionException;

import dao.LoginBD;
import model.usuario;

import static com.android.neonae.R.id.btnCadastro;

public class LogarActivity extends AppCompatActivity implements View.OnClickListener {

    EditText txtEmail, txtSenha;
    Button btnLogin, btnCadastrar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_logar);

        btnLogin = (Button) findViewById(R.id.btnLogin);
        txtEmail = (EditText) findViewById(R.id.txtLogin);
        txtSenha = (EditText) findViewById(R.id.txtSenha);
        btnCadastrar = (Button) findViewById(btnCadastro);

        btnLogin.setOnClickListener(this);
        btnCadastrar.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {

        switch (view.getId()) {
            case R.id.btnLogin:
                usuario usuTela = new usuario();

                LoginBD logBD = new LoginBD(this);

                usuTela.setEmail_usu(txtEmail.getText().toString());
                usuTela.setSenha_usu(txtSenha.getText().toString());

                logBD.setUsuClasse(usuTela);

                try {
                    logBD.execute().get();
                } catch (InterruptedException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                } catch (ExecutionException e) {
                    // TODO Auto-generated catch block
                    e.printStackTrace();
                }


                if (logBD.getLogado() == true) {
                    Intent tela = new Intent(LogarActivity.this, MenuActivity.class);
                    startActivity(tela);
                } else {
                    txtEmail.setText("");
                    txtSenha.setText("");


                }
                break;

            case R.id.btnCadastro:
                Intent tela1 = new Intent(LogarActivity.this, CadastrarActivity.class);
                startActivity(tela1);

                break;


        }

    }
}
