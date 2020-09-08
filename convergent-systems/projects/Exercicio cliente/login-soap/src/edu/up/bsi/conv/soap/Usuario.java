package edu.up.bsi.conv.soap;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
public class Usuario {
	
	//buscartodos,bucar elemento especifico
	
	@XmlElement
	private String nome;
	
	@XmlElement
	private String senha;
	
	@XmlElement
	private int idade;
	
	@XmlElement
	private String cpf;
	
	@XmlElement
	private String telefone;
	
	public Usuario() {
		
	}
	
	public Usuario(String nome, String senha, int idade, String cpf, String telefone) {
		setNome(nome);
		setSenha(senha);
		setIdade(idade);
		setCpf(cpf);
		setTelefone(telefone);
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getSenha() {
		return senha;
	}

	public void setSenha(String senha) {
		this.senha = senha;
	}

	public int getIdade() {
		return idade;
	}

	public void setIdade(int idade) {
		this.idade = idade;
	}

	public String getCpf() {
		return cpf;
	}

	public void setCpf(String cpf) {
		this.cpf = cpf;
	}

	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}
	


}
