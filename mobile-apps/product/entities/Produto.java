package br.com.edu.up.insertupdate.entities;

import android.arch.persistence.room.ColumnInfo;
import android.arch.persistence.room.Entity;
import android.arch.persistence.room.PrimaryKey;

/**
 * Created by Aluno on 21/11/2017.
 */



    @Entity
    public class Produto {

        public int getId() {
            return id;
        }

        public void setId(int id) {
            this.id = id;
        }

        @PrimaryKey
        private int id;

        public String getNome() {
            return nome;
        }

        public void setNome(String nome) {
            this.nome = nome;
        }

        @ColumnInfo(name = "nome")
        private String nome;

        public String getDescricao() {
            return descricao;
        }

        public void setDescricao(String descricao) {
            this.descricao = descricao;
        }

        @ColumnInfo(name = "descricao")
        private String descricao;

        public double getValor() {
            return valor;
        }

        public void setValor(double valor) {
            this.valor = valor;
        }

        @ColumnInfo(name = "valor")
        private double valor;

    }
