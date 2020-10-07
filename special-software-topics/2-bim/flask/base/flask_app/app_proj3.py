from flask import Flask
from flask import render_template

app = Flask("NOME")

@app.route("/template/<nome>")
def html_page(nome):
    return render_template("template.html", nome=nome)


app.run(debug=True, use_reloader=True)
