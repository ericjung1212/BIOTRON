#define SENSOR_PIN A1; //analog pin, takes the analog input of the FSR of 0 - 1023
#define OUT_PIN A0; //the one pin that does not connect to the multiplexer
#define muxPin1 10; //these three pins define the multiplexer inputs and the cycles.
#define muxPin2 11;
#define muxPin3 12;
#define LEDpin 13; //the pin to control threshold LED
double valueVoltage;
double valueResistance;
double valueResistor = 1000000; // insert value of resistors
double valueConductance;
double valueForce;

void setup() {
  Serial.begin(9600); //baud rate 9600
  pinMode(SENSOR_PIN, INPUT); //analog pin is the input
  pinMode(OUT_PIN, INPUT);
  pinMode(muxPin1, OUTPUT); //the mux pins are OUTPUT as they cycle through the multiplexer
  pinMode(muxPin2, OUTPUT);
  pinMode(muxPin3, OUTPUT);
  pinMode(LEDpin, INPUT);
  digitalWrite(LEDpin, LOW); //sets threshole LED to off at start
}

void loop() {
  for (i = 0, i < 8, i++) //for loops 8 times, for 8 values.
  {
    int value = cycle_mux(i); //calls to mux cycling method and receives a value.

    value = map(valueVoltage, 0, 1023, 5000);
    valueResistance = 5000 - valueVoltage;
    valueResistance *= 10 000;
    valueResistance /= valueVoltage;
    valueConductance = valueResistor / valueResistance;

    if (valueConductance <= 1000) {
      valueForce = valueConductance / 80;
      send_string(valueForce); //sends above value to the method that sends the values to the serial port
    }else {
      valueForce = valueConductance - 1000;
      valueForce /= 30;
      send_string(valueForce)
    }   
  }
  int outreading = analogRead(OUT_PIN);
  send_string(OUT_PIN);

  if (Serial.available())
  {
     char val = Serial.read();

     if (val = 'a') //When threshold is exceeded, the GUI sends the char 'a' triggering the LED to light up
     {
        digitalWrite(LEDpin, HIGH);
     }

     if (val = 'b') //When user needs to reset system and turn off light, GUI sends the char 'b' to turn off LED
     {
      digitalWrite(LEDpin, LOW);
     }     
  }
  
  delay(500);
}

int cycle_mux(int channel) { //method to cycle through the multiplexer 8 times. 
  digitalWrite(muxPin0, bitRead(channel, 0)); 
  digitalWrite(muxPin1, bitRead(channel, 1)); 
  digitalWrite(muxPin2, bitRead(channel, 2));

  int muxValue = analogRead(SENSOR_PIN);

  return muxValue;
}

void send_string( int printvalue ){
  Serial.print(printvalue); //prints value
  Serial.print(@); //seperates each value with a '@'
}
