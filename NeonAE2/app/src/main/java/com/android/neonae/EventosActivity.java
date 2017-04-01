package com.android.neonae;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import java.util.List;
import java.util.concurrent.ExecutionException;

import dao.ListaBD;
import utils.PesqEven;
import model.eventolista;

public class EventosActivity extends Activity implements AdapterView.OnItemClickListener {

    ListaBD listar;
    ListView lvEventos;

    List<eventolista> listaEven;
    ListaEvenAdapter adListEven;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_eventos);

        try {
            lvEventos = (ListView) findViewById(R.id.lvEvento);

            listar = new ListaBD(this);

            listar.execute().get();

            listaEven = listar.getListaEven();

            adListEven = new ListaEvenAdapter(this, listaEven);

            lvEventos.setAdapter(adListEven);

            lvEventos.setOnItemClickListener(this);

        } catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        } catch (ExecutionException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
    }

    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {

        eventolista evento = adListEven.getItem(i);

       // Toast.makeText(this, "Evento: " + evento.getNomeEven() + "ID: " + evento.getId(),
            //    Toast.LENGTH_LONG).show();

        PesqEven.setId(evento.getId());

        Intent tela = new Intent(EventosActivity.this, InfoEvenActivity.class);
        startActivity(tela);

    }


}
