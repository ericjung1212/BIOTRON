
int trigPin = 11;    // Trigger pin location, pin 11 on arduino. trigPin connects to the part of the ultrasound sensor that sends out a signal
int echoPin = 12;    // Echo pin location, pin 12 on arduino. echoPin connects to the part of the sensor that receives the signal
long duration, cm, inches;
 
void setup() {
  //Serial Port begin
  Serial.begin (9600);
  //Define inputs and outputs
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
}
 
void loop() { //in arduino, the main() is usually a loop
  
  // The sensor is triggered by a HIGH pulse of 10 or more microseconds. HIGH is the measure of voltage going through, so can be seen as HIGH = ON and LOW = OFF.
  // Give a short LOW pulse beforehand to ensure a clean HIGH pulse:
  digitalWrite(trigPin, LOW); //trigPin is OFF
  delayMicroseconds(5); //delay
  digitalWrite(trigPin, HIGH); //trigPin in ON
  delayMicroseconds(10); //delay
  digitalWrite(trigPin, LOW); //trigPin is OFF
 
  // Read the signal from the sensor: a HIGH pulse whose
  // duration is the time (in microseconds) from the sending
  // of the ping to the reception of its echo off of an object.
  pinMode(echoPin, INPUT); //this pin is for input of data
  duration = pulseIn(echoPin, HIGH); //the echo mechanism gives a HIGH or ON pulse until it receives a signal, which it records as a duration while continuing to measure for the next one.
 
  // Convert the time into a distance
  cm = (duration/2) / 29.1;     // Divide by 29.1 or multiply by 0.0343
  inches = (duration/2) / 74;   // Divide by 74 or multiply by 0.0135

  //this part allows the data to be printed on the serial monitor, which we can access on the computer.
  Serial.print(inches);
  Serial.print("in, ");
  Serial.print(cm);
  Serial.print("cm");
  Serial.println();
  
  delay(250); //delay inbetween the prints of the data, so it's not too much. 
}
