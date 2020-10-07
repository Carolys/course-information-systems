package br.edu.up.guardaAmigoRest.models;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "user_tb")
public class User implements Serializable{


	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Integer id;
	
	@NotNull
	@Column(name = "full_name")
	private String name;
	
	@NotNull
	@Column(name = "e_mail")
	private String email;
	
	@NotNull
	@Column(name = "password")
	private String psw;
	
	public User(){
	}

	public User(Integer id, String name, String email, String psw) {
		super();
		this.id = id;
		this.name = name;
		this.email = email;
		this.psw = psw;
	}


	
}