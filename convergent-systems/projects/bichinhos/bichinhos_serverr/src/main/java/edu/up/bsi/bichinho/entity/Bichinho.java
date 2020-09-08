package edu.up.bsi.bichinho.entity;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
public class Bichinho {

	@XmlElement
	private String nome;
	
	@XmlElement
	private String raca;
	
	@XmlElement
	private int idade;
	
	@XmlElement
	private String genero;
	
	public String img;
	
	@XmlElement
	private String cep; 
	
	@XmlElement
	private String telefone; 
	
	public Bichinho() {
		
	}
	
	public Bichinho(String nome, String raca, int idade, String genero, String cep, String telefone) {
		setNome(nome);
		setRaca(raca);
		setIdade(idade);
		setGenero(genero);
		setCep(cep);
		setTelefone(telefone);

	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getRaca() {
		return raca;
	}

	public void setRaca(String raca) {
		this.raca = raca;
	}

	public int getIdade() {
		return idade;
	}

	public void setIdade(int idade) {
		this.idade = idade;
	}

	public String getGenero() {
		return genero;
	}

	public void setGenero(String genero) {
		this.genero = genero;
	}

	public String getImg() {
		return img;
	}

	public void setImg(String img) {
		this.img = img;
	}
	
	public String getCep() {
		return cep;
	}

	public void setCep(String cep) {
		this.cep = cep;
	}
	
	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}

}


