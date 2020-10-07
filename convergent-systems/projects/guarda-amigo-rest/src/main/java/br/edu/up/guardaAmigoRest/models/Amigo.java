package br.edu.up.guardaAmigoRest.models;


import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

import org.hibernate.validator.constraints.NotBlank;

@Entity
public class Amigo {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private long id;
	
	@NotBlank
	private String nome;
	
	private String telefone;
	
	private String scr_foto;
	
	private String email;
	
	private String dt_aniversario;

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}

	public String getScr_foto() {
		return scr_foto;
	}

	public void setScr_foto(String scr_foto) {
		this.scr_foto = scr_foto;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getDt_aniversario() {
		return dt_aniversario;
	}

	public void setDt_aniversario(String dt_aniversario) {
		this.dt_aniversario = dt_aniversario;
	}
	
	 

}
