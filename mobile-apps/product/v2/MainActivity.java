package br.com.edu.up.insertupdate;

import android.arch.persistence.room.Room;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import br.com.edu.up.insertupdate.database.AppDatabase;
import br.com.edu.up.insertupdate.entities.Produto;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }




    public void gravar(View view) {
        EditText id= (EditText) findViewById(R.id.editTextId);
        EditText nome=(EditText) findViewById(R.id.editTextNome);
        EditText descricao=(EditText) findViewById(R.id.editTextDecricao);
        EditText valor = (EditText)findViewById(R.id.editTextValor);

        String EnvId=id.getText().toString();  //transforma o texto do nome em String para poder ser trabalhado
        int idd = Integer.parseInt(EnvId);
        String EnvNome=nome.getText().toString();
        String EnvDescricao=descricao.getText().toString();
        String EnvValor=valor.getText().toString();
        double valorr = Double.parseDouble(EnvValor);


        final Produto produto= new Produto();//chama o User empregado para ter acesso as suas strings.
        produto.setId(idd);
        produto.setNome(EnvNome);
        produto.setDescricao(EnvDescricao);
        produto.setValor(valorr);
        /*empregado.setSenha(EnvSenha);*/



        new AsyncTask<Void, Void, Boolean>() {
            @Override
            protected Boolean doInBackground(Void... voids) {

                try{
                    //inserir no banco

                    AppDatabase db = Room.databaseBuilder(getApplicationContext(),
                            AppDatabase.class, "database-name").build();

                    db.ProdutoDao().inserirProduto(produto);

                }catch (Exception e)
                {
                    return false;
                }
                return true;
            }

            @Override
            protected void onPostExecute(Boolean gravou) {
                super.onPostExecute(gravou);

                if(gravou==true)
                {
                    Toast.makeText(MainActivity.this, "Cadastrado com sucesso!", Toast.LENGTH_LONG).show();
                }else
                {

                }
            }
        }.execute();




    }

}
