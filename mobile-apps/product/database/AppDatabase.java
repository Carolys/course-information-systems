package br.com.edu.up.insertupdate.database;


import android.arch.persistence.room.Database;
import android.arch.persistence.room.RoomDatabase;

import br.com.edu.up.insertupdate.dao.ProdutoDao;
import br.com.edu.up.insertupdate.entities.Produto;

/**
 * Created by Aluno on 21/11/2017.
 */

@Database(entities = {Produto.class}, version = 1)
public abstract class AppDatabase extends RoomDatabase {
    public abstract ProdutoDao ProdutoDao();
}

