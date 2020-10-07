package com.thecatapi.api;

/**
 * Entidade baseada nos dados do WS do viacep.com
 */
public class Img {

	private String breeds;
    private String id;
    private String url;
    private String width;
    private String height;
    
    public String getBreeds() {
		return breeds;
	}

	public void setBreeds(String breeds) {
		this.breeds = breeds;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getUrl() {
		return url;
	}

	public void setUrl(String url) {
		this.url = url;
	}

	public String getWidth() {
		return width;
	}

	public void setWidth(String width) {
		this.width = width;
	}

	public String getHeight() {
		return height;
	}

	public void setHeight(String height) {
		this.height = height;
	}  

    @Override
    public String toString() {
        return "Imagem{" +
                "breeds='" + breeds + '\'' +
                ", id='" + id + '\'' +
                ", url='" + url + '\'' +
                ", width='" + width + '\'' +
                ", height='" + height + '\'' +
                '}';
    }
}
