package edu.up.bsi.bichinho.entity;

import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
@XmlAccessorType(XmlAccessType.FIELD)
public class ListaBichinhos {

	@XmlElement(name = "bichinhos")
	private List<Bichinho> bichinhos;

	public ListaBichinhos() {
	}
	public ListaBichinhos(List<Bichinho> bichinhos) {
		setBichinhos(bichinhos);
	}

	public List<Bichinho> getBichinhos() {
		return bichinhos;
	}

	public void setBichinhos(List<Bichinho> bichinhos) {
		this.bichinhos = bichinhos;
	}
	
	
}
