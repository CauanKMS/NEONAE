package utils;

import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.URL;

import android.app.ProgressDialog;
import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.AsyncTask;

public class DownloadImagem extends AsyncTask<String, Void, Bitmap> {

	ProgressDialog dialog;
	Context context;

	Bitmap imagemURL;

	public Bitmap getImagemURL() {
		return imagemURL;
	}

	public void setImagemURL(Bitmap imagemURL) {
		this.imagemURL = imagemURL;
	}
			
	public DownloadImagem(Context context) {
		super();
		this.context = context;
	}

	@Override
	protected Bitmap doInBackground(String... params) {
		String urlString = params[0];

		try {
			URL url = new URL(urlString);
			HttpURLConnection conexao = (HttpURLConnection) url
					.openConnection();
			conexao.setRequestMethod("GET");
			conexao.setDoInput(true);
			conexao.connect();

			InputStream dados = conexao.getInputStream();
			imagemURL = BitmapFactory.decodeStream(dados);

		} catch (Exception e) {
			e.printStackTrace();
			imagemURL = null;
		}
		return imagemURL;
	}

}
