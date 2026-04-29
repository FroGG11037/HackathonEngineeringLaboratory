#include <LiquidCrystal_I2C.h> //работа с дисплеем
#include <SparkFun_SCD4x_Arduino_Library.h> //работа с датчиком CO2
#include <Wire.h> //I2C (датчик CO2 и LCD дисплей)
#include <OneWire.h> //работа с датчиком температуры DS18B20
#include <DallasTemperature.h> //работа с датчиком температуры DS18B20
#include <DHT.h> //работа с датчиком температуры и влажности DHT22

constexpr int DS18B20_PIN=A6; //пин датчика температуры DS18B20
constexpr int DHT22_PIN=A7; //пин датчика температуры и влажности DHT22
constexpr int GL5516_PIN=A0; //пин датчика мутности и освещения (фоторезистор) GL5516
constexpr int TiaoChongYi_PIN = 2; //пин светодиодного чипа TiaoChongYi
constexpr int TEC112706_PIN = 5; //пин элемента Пельтье
constexpr int BUTTONUP_PIN = A3;
constexpr int BUTTONDOWN_PIN = A4;
constexpr int MOTOR_DIR=A8;
constexpr int MOTOR_PWM=10;
constexpr int PUMP_PIN=4;
constexpr int HC12_SET_PIN=18;
constexpr int MOTOR2_DIR = A9;
constexpr int MOTOR2_PWM = 9;

//датчик температуры DS18B20
OneWire H20temp(DS18B20_PIN);
DallasTemperature H20sensor(&H20temp);

//датчик CO2 SCD41 
SCD4x CO2sensor;

//датчик температуры и влажности DHT22
DHT TempHumSensor(DHT22_PIN, DHT22);

//ЖК-дисплей 1602 I2C
LiquidCrystal_I2C  LCD(0x27, 16, 2);

unsigned long lastDebounceTime=0;
unsigned long lastUpdateRequest=0;
bool menuChanged=false;
bool sensorsUpdated=false;
bool isStringCompleted=false;
int currentScreen = 0;
String buffer="";

float waterTemp = 0;
unsigned int CO2Level = 0;
float airHumidity = 0;
float airTemp = 0;
int lightLevel = 0;

bool lastUpState = 0;
bool lastDownState =  0;
void setup() 
{
  pinMode(HC12_SET_PIN, OUTPUT);
  digitalWrite(HC12_SET_PIN, HIGH);

  Serial.begin(9600);
  Serial2.begin(9600);

  H20sensor.begin();
  H20sensor.setResolution(12);

  Wire.begin();
  if (CO2sensor.begin()) 
  {
  CO2sensor.startPeriodicMeasurement();
  }

  TempHumSensor.begin();

  LCD.init();
  LCD.backlight();

  pinMode(TiaoChongYi_PIN, OUTPUT);
  digitalWrite(TiaoChongYi_PIN,LOW);

  pinMode(TEC112706_PIN, OUTPUT);
   
  pinMode(BUTTONUP_PIN,INPUT_PULLUP);
  pinMode(BUTTONDOWN_PIN,INPUT_PULLUP);

  pinMode(MOTOR_PWM, OUTPUT);
  pinMode(MOTOR_DIR, OUTPUT);

  pinMode(MOTOR2_PWM, OUTPUT);
  pinMode(MOTOR2_DIR, OUTPUT);

  pinMode(PUMP_PIN,OUTPUT);


  UpdateSensors();
  UpdateDisplay();
}

void loop(){
  UpdateSensors(); //каждые 5 секунд
  SerialRead();
  ProcessCommand();
  Buttons();
  if (menuChanged||sensorsUpdated)
  {
    UpdateDisplay();
    menuChanged = false;
    sensorsUpdated=false;
  }
}

void SerialRead()
{
	while (Serial2.available() > 0 && !isStringCompleted)
	{
		char bufferChar = Serial2.read();
		if (bufferChar == '\n' || bufferChar == '\r')
		{
			isStringCompleted = true;
		}
		else
		{
				buffer += bufferChar;	
		}
	}
}

void ProcessCommand()
{
	if (isStringCompleted)
	{
		char command = buffer.charAt(0);
		int value = buffer.substring(1).toInt();
		switch (command)
		{
		case 'L':digitalWrite(TiaoChongYi_PIN,HIGH);
    break;
    case 'l':digitalWrite(TiaoChongYi_PIN,LOW);
    break;
    case 'M': 
    digitalWrite(MOTOR_DIR, HIGH); 
    analogWrite(MOTOR_PWM, value);
    break;
    case 'm': 
    digitalWrite(MOTOR_DIR, LOW); 
    analogWrite(MOTOR_PWM, value);
    break;
    case 'S':
    digitalWrite(MOTOR_DIR, LOW);  
    analogWrite(MOTOR_PWM, 0);   
    break;
    case 's':
    digitalWrite(MOTOR2_DIR, LOW); 
    analogWrite(MOTOR2_PWM, 0);
    break;
    case 'H': digitalWrite(TEC112706_PIN, HIGH);
    break;
     case 'h': digitalWrite(TEC112706_PIN, LOW);
    break;
    case 'P': digitalWrite(PUMP_PIN, HIGH);
    break;
    case 'p': digitalWrite(PUMP_PIN, LOW);
    break;
    case 'Y': 
    digitalWrite(MOTOR2_DIR, HIGH); 
    analogWrite(MOTOR2_PWM, value);
    break;
    case 'y': 
    digitalWrite(MOTOR2_DIR, LOW); 
    analogWrite(MOTOR2_PWM, value);
    break;
    }
		isStringCompleted = false;
		buffer = "";
	}
}

void Buttons()
{
  bool upState = !digitalRead(BUTTONUP_PIN);
  bool downState = !digitalRead(BUTTONDOWN_PIN);
  if (millis() - lastDebounceTime >= 50) 
  {    
    if (upState && !lastUpState) 
    {
      currentScreen--;
      if (currentScreen < 0) currentScreen = 2;
      menuChanged = true;
    }
    
    if (downState && !lastDownState) 
    {
      currentScreen++;
      if (currentScreen > 2) currentScreen = 0;
      menuChanged = true;
    }
    
    lastUpState = upState;
    lastDownState = downState;
    lastDebounceTime = millis();
  }
}

void UpdateSensors()
{  
  if (millis()-lastUpdateRequest>=5000)
  {
  H20sensor.requestTemperatures();
  waterTemp = H20sensor.getTempCByIndex(0);

  if (CO2sensor.readMeasurement()) 
  {
    CO2Level = CO2sensor.getCO2();
  } 

  airHumidity = TempHumSensor.readHumidity();
  airTemp = TempHumSensor.readTemperature();
  
  lightLevel = analogRead(GL5516_PIN);
  Serial2.print("DATA:");
  Serial2.print(round(waterTemp)); 
  Serial2.print(",");
  Serial2.print(round(CO2Level));  
  Serial2.print(",");
  Serial2.print(round(airHumidity)); 
  Serial2.print(",");
  Serial2.print(round(airTemp));  
  Serial2.print(",");
  Serial2.println(round(lightLevel));  
  Serial2.flush();
  sensorsUpdated=true;
  lastUpdateRequest=millis();
  }
}

void UpdateDisplay()
{
  LCD.clear();
  switch(currentScreen) 
  {
    case 0:
      DisplayAIR_HUM_TEMPMenu();
      break;
    case 1:
      DisplayH20TEMP_CO2Menu();
      break;
    case 2:
      DisplayLightMenu();
      break;
  }
}

void DisplayAIR_HUM_TEMPMenu()
{
    LCD.setCursor(0, 0);
    LCD.print("Humidity:");
    LCD.print(round(airHumidity));
    LCD.print("%");
    
    LCD.setCursor(0, 1);
    LCD.print("t AIR:");
    LCD.print(round(airTemp));
    LCD.print("C");
}

void DisplayH20TEMP_CO2Menu()
{
    LCD.setCursor(0, 0);
    LCD.print("t H20:");
    LCD.print(round(waterTemp));
    LCD.print("C");
    
    LCD.setCursor(0, 1);
    LCD.print("CO2:");
    LCD.print(CO2Level);
    LCD.print("ppm");
}

void DisplayLightMenu()
{
  LCD.setCursor(0, 0);
  LCD.print("LIGHT:");
  int lightPercent=map(lightLevel, 0, 1023, 0, 100);
  LCD.print(lightPercent);
  LCD.print("%");
}