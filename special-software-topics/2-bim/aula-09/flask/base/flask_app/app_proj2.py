from flask import Flask

app = Flask("NOME")

@app.route("/hello")
@app.route("/hello/<nome>")
@app.route("/hello/<nome>/<sobrenome>")
def echo_name(nome = None, sobrenome = None):

    if nome == None :
        nome = 'Visitante'
    if sobrenome == None :
        sobrenome = ' '

    return 'Ola internet: '+nome+' '+sobrenome, 200

app.run(debug=True, use_reloader=True)
