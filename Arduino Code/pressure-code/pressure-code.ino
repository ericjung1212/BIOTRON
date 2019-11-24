#define SENSOR_PIN A0; //analog pin, takes the analog input of the FSR of 0 - 1023
#define muxPin1 10; // these three pins define the multiplexer inputs and the cycles.
#define muxPin2 11;
#define muxPin3 12;

void setup() {
  Serial.begin(9600); //baud rate 9600
  pinMode(SENSOR_PIN, INPUT); //analog pin is the only input
  pinMode(muxPin1, OUTPUT); //the mux pins are OUTPUT as they cycle through the multiplexer
  pinMode(muxPin2, OUTPUT);
  pinMode(muxPin3, OUTPUT);
}

void loop() {
  for (i = 0, i < 9, i++) //for loops 9 times, for 9 values.
  {
    int value = cycle_mux(i); //calls to mux cycling method and receives a value.
    
    send_string(value); //sends above value to the method that sends the values to the serial port
  }
  delay(1000); //NEED TO ASK ANDREA: delay is put here so that each string send per seconds is all 9 values at once. Or should it be 1 of the 9 values sent per second, so a 9 second cycle?
}

int cycle_mux(int channel) { //method to cycle through the multiplexer 9 times. 
  digitalWrite(muxPin0, bitRead(channel, 0)); // these three digital writes cycle through all possible 3-bit binary values, which there are NINE of. This cycles the mux 9 times for 9 different inputs.
  digitalWrite(muxPin1, bitRead(channel, 1)); //I guess cycling through the values and giving them to the mux changes the "channel"?
  digitalWrite(muxPin2, bitRead(channel, 2));

  int muxValue = analogRead(SENSOR_PIN); //the mux value is sent, before it cycles back to get a new 3-bit value, changing the channel therefore a new value.

  return muxValue;
}

void send_string( int printvalue ){
  Serial.print(printvalue); //prints value
  Serial.print(@); //seperates each value with a '@'
}
