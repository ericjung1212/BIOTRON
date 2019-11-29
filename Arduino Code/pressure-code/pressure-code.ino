#define SENSOR_PIN A0; //analog pin, takes the analog input of the FSR of 0 - 1023
#define OUT_PIN A1; //the one pin that does not connect to the multiplexer
#define muxPin1 10; // these three pins define the multiplexer inputs and the cycles.
#define muxPin2 11;
#define muxPin3 12;

void setup() {
  Serial.begin(9600); //baud rate 9600
  pinMode(SENSOR_PIN, INPUT); //analog pin is the only input
  pinMode(OUT_PIN, INPUT);
  pinMode(muxPin1, OUTPUT); //the mux pins are OUTPUT as they cycle through the multiplexer
  pinMode(muxPin2, OUTPUT);
  pinMode(muxPin3, OUTPUT);
}

void loop() {
  for (i = 0, i < 8, i++) //for loops 8 times, for 8 values.
  {
    int value = cycle_mux(i); //calls to mux cycling method and receives a value.
    
    send_string(value); //sends above value to the method that sends the values to the serial port
  }
  int outreading = analogRead(OUT_PIN);
  send_string(OUT_PIN);
    
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
