package br.com.edu.up.insertupdate.dao;

import android.arch.persistence.room.Dao;
import android.arch.persistence.room.Insert;
import android.arch.persistence.room.Query;

import br.com.edu.up.insertupdate.entities.Produto;

/**
 * Created by Aluno on 21/11/2017.
 */

    @Dao
    public interface ProdutoDao {

        @Query("SELECT * FROM Produto")
        public void receberProduto(Produto... produtos);

        //List<Empregado> getAll();

//        @Query("SELECT * FROM Empregado WHERE id='1'")
//        List<Empregado> loadAllByIds(int[] userIds);
//
//        @Query("SELECT * FROM user WHERE first_name LIKE :first AND "
//                + "last_name LIKE :last LIMIT 1")
//        Empregado findByName(String first, String last);

        @Insert
        public void inserirProduto(Produto... produtos);

    }
