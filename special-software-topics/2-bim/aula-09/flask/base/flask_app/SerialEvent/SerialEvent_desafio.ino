/*
   Serial Relay Controller

   Serial readings were extracted from
   http://www.arduino.cc/en/Tutorial/SerialEvent

   This code swiches pins according to a list of strings.
*/
#include <Servo.h>

Servo myservo;
String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete

//Relay channels
int ch1 = 13;
int ch2 = 11;
int ch3 = 10;
int array[] = {ch1, ch2, ch3};
int pos;

void setup() {
  myservo.attach(9);
  // Initialize pins
  for (int i = 0; i < 3; i++) {
    pinMode(array[i], OUTPUT);
  }
  pos = 90;
  // initialize serial:
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
  // reserve 200 bytes for the inputString:
  inputString.reserve(200);
}

void switchPin(int pin) {
  delay(200);
  if (digitalRead(pin)) {
    digitalWrite(pin, LOW);
  }
  else {
    digitalWrite(pin, HIGH);
  }
}

void loop() {
  // print the string when a newline arrives:
  if (stringComplete) {
    inputString.trim();
    Serial.println(inputString);

    if (inputString.equalsIgnoreCase("direita")) {
      pos = pos - 5;
      if (pos < 0) {
        pos = 0;
      }
      myservo.write(pos);
      delay(15);
      switchPin(ch1);
    };

    if (inputString.equalsIgnoreCase("esquerda")) {
      pos = pos + 5;
      if (pos > 180) {
        pos = 180;
      }
      myservo.write(pos);
      delay(15);
      switchPin(ch2);
    };

    if (inputString.equalsIgnoreCase("centro")) {
      myservo.write(90);
      pos = 90;
      delay(15);
      switchPin(ch3);

    };

    if (inputString.equalsIgnoreCase("todos")) {
      for (int i = 0; i < 3; i++) {
        switchPin(array[i]);
      }
    };

    // clear the string:
    inputString = "";
    stringComplete = false;
  }
}

/*
  SerialEvent occurs whenever a new data comes in the
  hardware serial RX.  This routine is run between each
  time loop() runs, so using delay inside loop can delay
  response.  Multiple bytes of data may be available.
*/
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }

  }
}
