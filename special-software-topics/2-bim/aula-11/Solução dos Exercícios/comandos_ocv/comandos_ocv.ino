#define led1 13
#define led2 12
#define bot 2
char leitura;

void setup() {
  Serial.begin(9600);
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(bot, INPUT);
}

void loop() {
  if (digitalRead(bot) == HIGH) {
    Serial.println("X");
    while (digitalRead(bot) == HIGH) {
    }
  }
  else{
    Serial.println(".");
    delay(100);
  }
  if (Serial.available() > 0) {
    leitura = Serial.read();
    if (leitura == 'E') {
      digitalWrite(led1, HIGH);
      digitalWrite(led2, LOW);
    }
    else if (leitura == 'D') {
      digitalWrite(led1, LOW);
      digitalWrite(led2, HIGH);
    }
    else if (leitura == 'Z') {
      digitalWrite(led1, LOW);
      digitalWrite(led2, LOW);
    }
    else Serial.end(); // Fim da conexão
  }
}
