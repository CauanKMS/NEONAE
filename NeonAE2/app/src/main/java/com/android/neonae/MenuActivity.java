package com.android.neonae;

import android.app.Activity;
import android.content.Intent;
import android.icu.text.SimpleDateFormat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.Toast;

import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

import java.util.Calendar;
import java.util.Date;

import dao.cadastrarQR;
import model.QR;
import utils.dados;

public class MenuActivity extends AppCompatActivity implements View.OnClickListener{

    ImageButton btnPerfil, btnEvento, btnSair, btnQRcODE;
    String login, senha, dt;
    int ativo= 1;

    QR QRTela;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        btnEvento = (ImageButton) findViewById(R.id.btnEventos);
        btnPerfil = (ImageButton) findViewById(R.id.btnPerfil);
        btnQRcODE = (ImageButton) findViewById(R.id.btnQrCode);
        btnSair = (ImageButton) findViewById(R.id.btnSair);



        btnEvento.setOnClickListener(this);
        btnQRcODE.setOnClickListener(this);
        btnSair.setOnClickListener(this);
        btnPerfil.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {

        switch (view.getId()){
            case R.id.btnPerfil:
                Intent tela = new Intent(MenuActivity.this,PerfilActivity.class);
                startActivity(tela);
                break;

            case R.id.btnQrCode:
                final Activity lol = this;
                IntentIntegrator integrator = new IntentIntegrator(lol);
                integrator.setDesiredBarcodeFormats(IntentIntegrator.QR_CODE_TYPES);
                integrator.setPrompt("Scan");
                integrator.setCameraId(0);
                integrator.setBeepEnabled(false);
                integrator.setBarcodeImageEnabled(false);
                integrator.initiateScan();
                break;


            case R.id.btnEventos:
                Intent tela1 = new Intent(MenuActivity.this, EventosActivity.class);
                startActivity(tela1);
                break;

            case R.id.btnSair:
                finish();
                break;
        }

    }

    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        IntentResult result = IntentIntegrator.parseActivityResult(requestCode, resultCode, data);
        if (result != null){
            if (result.getContents()== null){
                Toast.makeText(this, "Você cancelou o scaneamento!", Toast.LENGTH_LONG).show();

            }
            else {
                Toast.makeText(this, result.getContents(), Toast.LENGTH_LONG).show();
                cadastrarQR cad = new cadastrarQR(this);

                QRTela = new QR();

                QRTela.setLogin_qrc(dados.getLogin());
                QRTela.setSenha_qrc(dados.getSenha());
                QRTela.setDthr_qrc(dt);
                QRTela.setAtivo_qrc(Integer.parseInt(String.valueOf(ativo)));

                cad.setQRClasse(QRTela);
                cad.execute();


            }
        }
        else {

            super.onActivityResult(requestCode, resultCode, data);
        }
    }

}
