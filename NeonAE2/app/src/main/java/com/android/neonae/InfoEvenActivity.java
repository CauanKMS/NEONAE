package com.android.neonae;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.concurrent.ExecutionException;

import dao.PesquisarBD;
import model.evento;

public class InfoEvenActivity extends AppCompatActivity {

    TextView lblNomeEven, lblSubtipo, lblEmp, lblTipoEven, lblUf, lblCid, lblRua, lblNumLocal, lblNomeLocal,
            lblDetEven, lblHrIni, lblHrFin, lblDtIni, lblDtFin, lblStatus;

    PesquisarBD pesq;
    evento evenTela;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_info_even);

        try {
            lblCid = (TextView) findViewById(R.id.lblCid);
            lblDetEven = (TextView) findViewById(R.id.lblDetEven);
            lblDtFin = (TextView) findViewById(R.id.lblDtFin);
            lblDtIni = (TextView) findViewById(R.id.lblDtIni);
            lblEmp = (TextView) findViewById(R.id.lblEmp);
            lblHrFin = (TextView) findViewById(R.id.lblHrFin);
            lblHrIni = (TextView) findViewById(R.id.lblHrIni);
            lblNomeEven = (TextView) findViewById(R.id.lblNomeEven);
            lblNomeLocal = (TextView) findViewById(R.id.lblNomeLocal);
            lblNumLocal = (TextView) findViewById(R.id.lblNumLocal);
            lblRua = (TextView) findViewById(R.id.lblRua);
            lblSubtipo = (TextView) findViewById(R.id.lblSubtipo);
            lblTipoEven = (TextView) findViewById(R.id.lblTipoEven);
            lblUf = (TextView) findViewById(R.id.lblUf);
            lblStatus = (TextView) findViewById(R.id.lblStatus);

            pesq = new PesquisarBD(InfoEvenActivity.this);
            evenTela = new evento();

            pesq.execute().get();

            evenTela = pesq.getEvenClasse();

            lblUf.setText(evenTela.getUf());
            lblRua.setText(evenTela.getRua());
            lblCid.setText(evenTela.getCid());
            lblDetEven.setText(evenTela.getDetalhesEven());
            lblDtIni.setText(evenTela.getDataIni());
            lblDtFin.setText(evenTela.getDataFin());
            lblHrFin.setText(evenTela.getHrFin());
            lblHrIni.setText(evenTela.getHrIni());
            lblNomeEven.setText(evenTela.getNomeEven());
            lblNomeLocal.setText(evenTela.getNomeLocal());
            lblEmp.setText(evenTela.getNomeEmpEven());
            lblNumLocal.setText(evenTela.getNumLocal());
            lblSubtipo.setText(evenTela.getSubtEven());
            lblTipoEven.setText(evenTela.getTipoEven());

            if(evenTela.getStatus().equals("p"))
                lblStatus.setText("Privado");
            else
                lblStatus.setText("Aberto");

        } catch (InterruptedException e) {
            e.printStackTrace();
        } catch (ExecutionException e) {
            e.printStackTrace();
        }
    }
}
