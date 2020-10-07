from flask import Flask

app = Flask(__name__)

@app.route("/")
def hello_world():
    return "Hello World! <strong>Eu estou aprendendo Flask</strong>", 200

app.run()
