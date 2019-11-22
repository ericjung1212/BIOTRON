int fsr1pin = 0;
int fsr2pin = 1;
int fsr1Reading;
int fsr2Reading;

void setup() {
  Serial.begin(9600);

}

void loop() {
  fsr1Reading = analogRead(fsr1pin);
  fsr2Reading = analogRead(fsr2pin);
  Serial.print("Analog reading from FSR 1 is: ");
  Serial.print(fsr1Reading);
  Serial.print("Analog reading from FSR 2 is: ");
  Serial.print(fsr2Reading);
  Serial.println("--------------------");
  delay(1000);
  

}
