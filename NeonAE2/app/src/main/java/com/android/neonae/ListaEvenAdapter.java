package com.android.neonae;

import java.util.List;
import java.util.concurrent.ExecutionException;

import model.eventolista;
import utils.DownloadImagem;


import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class ListaEvenAdapter extends BaseAdapter {

	private LayoutInflater mInflater;
	private List<eventolista> listaEven;

	Context context;

	public ListaEvenAdapter(Context context, List<eventolista> listaEven) {
		super();
		this.context = context;
		this.mInflater = LayoutInflater.from(context);
		this.listaEven = listaEven;
	}

	/**
	 * conta a qtd de itens que foram carregados no banco de dados
	 */
	@Override
	public int getCount() {
		return listaEven.size();
	}

	/**
	 * retorna o objeto do tipo FUNCIONARIO, selecionado com
	 * o click na lista
	 */
	@Override
	public eventolista getItem(int arg0) {
		return listaEven.get(arg0);
	}

	/**
	 * retorno o id do objeto selecionado na lista
	 * id do banco de dados
	 */
	@Override
	public long getItemId(int arg0) {
		return listaEven.get(arg0).getId();
	}

	/**
	 * carrega o LISTVIEW com os itens do banco de dados
	 * usando os componentes que est�o no layout item
	 */
	@Override
	public View getView(int position, View view, ViewGroup arg2) {

		ItemSuporte itemHolder;

		// se a view estiver nula (nunca criada), adicionamos o layout nela.
		if (view == null) {

			// adiciona o layout para podermos pegar as views
			view = mInflater.inflate(R.layout.item_evento, null);

			// cria um item de suporte para n�o precisarmos sempre
			// adicionar as mesmas informacoes
			itemHolder = new ItemSuporte();
			itemHolder.lblNome = ((TextView) view.findViewById(R.id.lblNomeEven));
			itemHolder.imgFoto = ((ImageView) view.findViewById(R.id.imgFoto));

			// define os itens na view;
			view.setTag(itemHolder);
		} else {
			// se a view j� existe pega os itens.
			itemHolder = (ItemSuporte) view.getTag();
		}

		// pega os dados da lista		
		eventolista even = listaEven.get(position);

		// adiciona ao TEXTVIEW o nome do item
		itemHolder.lblNome.setText(even.getNomeEven());


		// carregando a imagem via url
		DownloadImagem imgCarregada = new DownloadImagem(context);

		try {
			// a informa��o do execute dever� ser carregada com 
			// o que est� armazenado no banco -> func.getImg() por exemplo
			imgCarregada.execute("http://").get();
		} catch (InterruptedException e) {
			e.printStackTrace();
		} catch (ExecutionException e) {
			e.printStackTrace();
		}

		// se for diferente de nula carrega a URL
		if (imgCarregada.getImagemURL() != null)
			itemHolder.imgFoto.setImageBitmap(imgCarregada.getImagemURL());
		else
			// caso contr�rio carrega uma imagem pr� definida
			itemHolder.imgFoto.setImageResource(R.drawable.sem_imagem);
		//////////////////////////////////////////////////////////////////

		// retorna a view com as informa��es
		return view;
	}

	/**
	 * Classe de suporte para os itens do layout.
	 * deve conter os mesmos itens do layout item,
	 * neste caso um IMAGEVIEW e um TEXTVIEW
	 */
	private class ItemSuporte {

		ImageView imgFoto;
		TextView lblNome;

	}
}
