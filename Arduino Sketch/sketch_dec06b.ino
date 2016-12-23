const int relay1 = 13;
const int relay2 = 12;
const int relay3 = 11;
const int relay4 = 10;
int incomingByte;

void setup() {
  // initialize serial communication:
  Serial.begin(9600);
  // initialize the LED pin as an output:
  pinMode(relay1, OUTPUT);
  pinMode(relay2, OUTPUT);
  pinMode(relay3, OUTPUT);
  pinMode(relay4, OUTPUT);
  digitalWrite(relay1, HIGH);
  digitalWrite(relay2, HIGH);
  digitalWrite(relay3, HIGH);
  digitalWrite(relay4, HIGH);       
}

void loop() {
  // see if there's incoming serial data:
  if (Serial.available() > 0) {
    // read the oldest byte in the serial buffer:
    incomingByte = Serial.read();
    
    if (incomingByte == 'A') {
      digitalWrite(relay1, HIGH);
    }    
    if (incomingByte == 'a') {
      digitalWrite(relay1, LOW);
    }
    if (incomingByte == 'B') {
      digitalWrite(relay2, HIGH);
    }    
    if (incomingByte == 'b') {
      digitalWrite(relay2, LOW);
    }
    if (incomingByte == 'C') {
      digitalWrite(relay3, HIGH);
    }    
    if (incomingByte == 'c') {
      digitalWrite(relay3, LOW);
    }
    if (incomingByte == 'D') {
      digitalWrite(relay4, HIGH);
    }    
    if (incomingByte == 'd') {
      digitalWrite(relay4, LOW);
    }    
  }
}
