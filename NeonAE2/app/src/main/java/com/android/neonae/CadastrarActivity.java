package com.android.neonae;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.RadioGroup;

import dao.CadastrarBD;
import model.usuario;

public class CadastrarActivity extends AppCompatActivity implements View.OnClickListener{

    EditText txtNome, txtData, txtEmail, txtConfirSenha, txtSenha, txtCpf;
    ImageButton btnCadastrar, btnVoltarLogin;
    RadioGroup rgSexo;

    usuario usuClasse;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastrar);

        txtNome = (EditText) findViewById(R.id.txtNome);
        txtData = (EditText) findViewById(R.id.txtData);
        txtEmail = (EditText) findViewById(R.id.txtEmail);
        txtConfirSenha = (EditText) findViewById(R.id.txtConfSenha);
        txtSenha = (EditText) findViewById(R.id.txtSenha);
        txtCpf = (EditText) findViewById(R.id.txtCpf);
        rgSexo = (RadioGroup) findViewById(R.id.rgSexo);

        btnCadastrar = (ImageButton) findViewById(R.id.btnConcluirCad);
        btnVoltarLogin = (ImageButton) findViewById(R.id.btnVoltarLogin);

        btnVoltarLogin.setOnClickListener(this);
        btnCadastrar.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()) {
            case R.id.btnVoltarLogin:
                finish();
                break;

            case R.id.btnConcluirCad:

                CadastrarBD cad = new CadastrarBD(this);

                usuClasse = new usuario();


                int sxOP = rgSexo.getCheckedRadioButtonId();
                String tipoSexo;

                if (sxOP == R.id.rdFem) {
                    tipoSexo = "f";
                } else {
                    if (sxOP == R.id.rdMasc) {
                        tipoSexo = "m";
                    } else {
                        {
                            tipoSexo = "o";
                        }
                    }
                }

                usuClasse.setId_tusu(3);
                usuClasse.setNome_usu(txtNome.getText().toString());
                usuClasse.setDtnasc_usu(txtData.getText().toString());
                usuClasse.setEmail_usu(txtEmail.getText().toString());
                usuClasse.setSenha_usu(txtSenha.getText().toString());
                usuClasse.setCpf_usu(txtCpf.getText().toString());
                usuClasse.setSx_usu(tipoSexo);

                cad.setUsu(usuClasse);
                cad.execute();

                Intent tela = new Intent(CadastrarActivity.this, LogarActivity.class);
                startActivity(tela);

                break;


        }

    }
}
