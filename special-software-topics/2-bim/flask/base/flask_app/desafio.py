import serial
from flask import Flask, request, render_template
app = Flask(__name__)
app.debug = False
_serial = serial.Serial('com3', 9600)
channels = {
    "direita\r\n": "success",
    "esquerda\r\n": "success",
    "centro\r\n": "success",
}

def switch(name):
    if (name in channels):
        if channels[name] == "success":
            channels[name] = "success"
        else:
            channels[name] = "success"

@app.route("/", methods=['GET', 'POST'])
def index():
    action = None
    if request.method == 'POST':
        if request.form['action']:
            action = "{action}".format(action=request.form['action'])
            _serial.write(action.encode('ascii'))
            switch(action.lower());

    print (channels)
    return render_template('index.html', action=action, channels=channels)

if __name__ == "__main__":
    _serial = serial.Serial('com3', 9600)
    app.run()
