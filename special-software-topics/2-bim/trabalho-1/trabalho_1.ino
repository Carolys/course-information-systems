#include <Servo.h>
Servo myservo;
int pos;
char leitura;
int pinoledverm = 13;
int acionamento;
int pinopir = 4;

void setup() {
  Serial.begin(9600);
  myservo.attach(9);
  pinMode(pinoledverm, OUTPUT);
  pinMode(pinopir, INPUT);
  pos = 90;
}

void loop() {

  if (Serial.available() > 0) {
    leitura = Serial.read();
    if (leitura == 'C') {
      digitalWrite(pinoledverm, LOW); // Apagar a led antes de andar novamente
      myservo.write(90);
      pos = 90;
      delay(15);
    }
    else if (leitura == 'E') {
      digitalWrite(pinoledverm, LOW);// Apagar a led antes de andar novamente
      pos = pos - 5;
      if (digitalRead(pinopir) == HIGH) { //SE A LEITURA DO PINO FOR IGUAL A HIGH, FAZ
        digitalWrite(pinoledverm, HIGH);
        if (pos < 0) {
          pos = 0;
        }
      }

      myservo.write(pos);
      delay(15);
    }
    else if (leitura == 'D') {
      digitalWrite(pinoledverm, LOW); // Apagar a led antes de andar novamente
      pos = pos + 5;
      if (digitalRead(pinopir) == HIGH) { //SE A LEITURA DO PINO FOR IGUAL A HIGH, FAZ
        digitalWrite(pinoledverm, HIGH);
        if (pos > 180) {
          pos = 180;
        }
      }
      myservo.write(pos);
      delay(15);
    }

    else if (leitura == 'A') {
      digitalWrite(pinoledverm, LOW); // Apagar a led antes de andar novamente
      for (pos = 0; pos <= 180; pos += 1) {
        if (digitalRead(pinopir) == HIGH) { //SE A LEITURA DO PINO FOR IGUAL A HIGH, FAZ
          digitalWrite(pinoledverm, HIGH);
          Serial.end();
        } else {
          leitura = Serial.read();
          myservo.write(pos);
          delay(25);
        }
      }
      for (pos = 180; pos >= 0; pos -= 1) {
        if (digitalRead(pinopir) == HIGH) { //SE A LEITURA DO PINO FOR IGUAL A HIGH, FAZ
          digitalWrite(pinoledverm, HIGH);
          Serial.end();
        } else {
          leitura = Serial.read();
          myservo.write(pos);
          delay(25);
        }
      }
    }
    else Serial.end(); // Fim da conexão
  }
}
