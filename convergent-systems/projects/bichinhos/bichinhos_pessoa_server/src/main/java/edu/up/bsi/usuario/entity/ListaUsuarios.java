package edu.up.bsi.usuario.entity;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;


@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
public class ListaUsuarios {

	@XmlElement(name = "usuarios")
	private List<Usuario> usuarios;

	public ListaUsuarios() {
	}
	public ListaUsuarios(List<Usuario> usuarios) {
		setUsuarios(usuarios);
	}

	public List<Usuario> getUsuarios() {
		return usuarios;
	}

	public void setUsuarios(List<Usuario> usuarios) {
		this.usuarios = usuarios;
	}
	
	
}
