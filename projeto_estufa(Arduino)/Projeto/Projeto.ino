#include <FS.h>
#include <WiFiManager.h>
#include <WiFi.h>
#include <DNSServer.h>
#include <WebServer.h>
#include <SPI.h>
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <HardwareSerial.h>

#define SCREEN_WIDTH 128
#define SCREEN_HEIGHT 64
#define OLED_RESET -1
#define SCREEN_ADDRESS 0x3C

#define LED_AQUECEDOR 25 
#define LED_TOK 26 
#define LED_REFRIGERADOR 27
#define LED_ALARME 32
#define LED_UMIDIFICADOR 12 
#define PINO_SENSOR 35

float temp_padrao = 50;
float histerese = 10;
float tempAlta = 0;
float tempBaixa = 0;
int humid = 0;
int alarme = 0;
float temp, temp1, faixa1, faixa2;
long valormv;

Adafruit_SSD1306 tela(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);

WebServer server(80);

void handleRoot()
{
  String html = "<!DOCTYPE html>";
  html += "<html><head>";
  html += "<meta charset='utf-8'>";
  html += "<link rel='icon' href='favicon-32x32.ico'>";
  html += "<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>";
  html += "<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css' integrity='sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO' crossorigin='anonymous'>";
  html += "<link href='https://fonts.googleapis.com/css?family=Racing+Sans+One&display=swap' rel='stylesheet'>";
  html += "<link rel='stylesheet' type='text/css' href='css/style.css'>";
  html += "<link rel='stylesheet' type='text/css' href='css/font.css'>";
  html += "<title>Termostato 3000</title>";
  html += "<style>";
  html += "input[type='number'] { font-size: 150%; text-align: center; }";
  html += "input[type='checkbox'], .form-check-label { font-size: 150%; }";
  html += ".label-text { font-size: 200%; }";
  html += ".input-value { font-size: 120%; }";
  html += "</style>";
  html += "<script>";
  html += "function submitForm() {";
  html += "  var form = document.getElementById('config-form');";
  html += "  var xhr = new XMLHttpRequest();";
  html += "  xhr.onreadystatechange = function() {";
  html += "    if (xhr.readyState === 4 && xhr.status === 200) {";
  html += "      var response = xhr.responseText;";
  html += "      var successMsg = document.getElementById('success-msg');";
  html += "      successMsg.style.display = 'block';";
  html += "      setTimeout(function() {";
  html += "        successMsg.style.display = 'none';";
  html += "      }, 2000);";
  html += "    }";
  html += "  };";
  html += "  xhr.open('POST', '/save', true);";
  html += "  xhr.send(new FormData(form));";
  html += "}";
  html += "</script>";
  html += "</head><body class='text-center'>";
  html += "<nav class='navbar navbar-expand-lg navbar-dark'>";
  html += "<div class='container'>";
  html += "<a class='navbar-brand' href='#'>Configuração do Sistema</a>";
  html += "</div>";
  html += "</nav>";
  html += "<div class='container mt-5'>";
  html += "<form id='config-form'>";
  html += "<div class='form-group'>";
  html += "<label for='temp' class='label-text'>Temperatura Padrão:</label>";
  html += "<input type='number' class='form-control' id='temp' name='temp' value='" + String(temp_padrao) + "'><br>";
  html += "</div>";
  html += "<div class='form-group'>";
  html += "<label for='histerese' class='label-text'>Histerese:</label>";
  html += "<input type='number' class='form-control' id='histerese' name='histerese' value='" + String(histerese) + "'><br>";
  html += "</div>";
  html += "<div class='form-group form-check'>";
  html += "<input type='checkbox' class='form-check-input' id='umidificador' name='umidificador' value='1' " + String(humid == 1 ? "checked" : "") + ">";
  html += "<label class='form-check-label' for='umidificador'>Umidificador</label>";
  html += "</div>";
  html += "<div class='form-group form-check'>";
  html += "<input type='checkbox' class='form-check-input' id='alarme' name='alarme' value='1' " + String(alarme == 1 ? "checked" : "") + ">";
  html += "<label class='form-check-label' for='alarme'>Alarme</label>";
  html += "</div>";
  html += "<button type='button' class='btn btn-primary' onclick='submitForm()'>Salvar</button>";
  html += "</form>";
  html += "<div id='success-msg' style='display: none; margin-top: 10px; color: green;'>Configurações salvas com sucesso!</div>";
  html += "</div>";
  html += "<div style='position: fixed; bottom: 10px; right: 10px;'>";
  html += "<p>Prof. Marcos Chaves</p>";
  html += "<p>Pedro Silva e Victor Hugo</p>";
  html += "</div>";
  html += "<div style='position: fixed; bottom: 10px; left: 10px;'>";
  html += "Conectado a " + WiFi.SSID();
  html += "</div>";
  html += "</body></html>";

  server.send(200, "text/html", html);

  if (server.hasArg("temp"))
  {
    temp_padrao = server.arg("temp").toFloat();
  }

  if (server.hasArg("histerese"))
  {
    histerese = server.arg("histerese").toFloat();
  }

  if (server.hasArg("umidificador"))
  {
    humid = server.arg("umidificador").toInt();
  }

  if (server.hasArg("alarme"))
  {
    alarme = server.arg("alarme").toInt();
  }
}


void handleSave()
{
  if (server.hasArg("temp"))
  {
    temp_padrao = server.arg("temp").toFloat();
  }

  if (server.hasArg("histerese"))
  {
    histerese = server.arg("histerese").toFloat();
  }

  if (server.hasArg("umidificador"))
  {
    humid = server.arg("umidificador").toInt();
  }
  else
  {
    humid = 0;
  }

  if (server.hasArg("alarme"))
  {
    alarme = server.arg("alarme").toInt();
  }
  else
  {
    alarme = 0;
  }

  String html = "<html><body>";
  html += "<h1>Configuração Salva!</h1>";
  html += "<p>As configurações foram salvas com sucesso.</p>";
  html += "</body></html>";

  server.send(200, "text/html", html);
}

HardwareSerial SerialESP(0);
float receivedVoltage;
char nomeWifi[15] = "JACKSON";
char senhaWifi[15] = "jackoutliers";

void setup()
{
  SerialESP.begin(115200);
  Serial.begin(115200);
  pinMode(LED_ALARME, OUTPUT);
  pinMode(LED_UMIDIFICADOR, OUTPUT);
  pinMode(LED_REFRIGERADOR, OUTPUT);
  pinMode(LED_TOK, OUTPUT);
  pinMode(LED_AQUECEDOR, OUTPUT);
  WiFiManager wifiManager;
  WiFiManagerParameter custom_nomeWifi("nomeWifi", "Nome do WiFi", nomeWifi, 15);
  WiFiManagerParameter custom_senhaWifi("senhaWifi", "Senha do WiFi", senhaWifi, 15);
  wifiManager.addParameter(&custom_nomeWifi);
  wifiManager.addParameter(&custom_senhaWifi);
  wifiManager.autoConnect();

  strcpy(nomeWifi, custom_nomeWifi.getValue());
  strcpy(senhaWifi, custom_senhaWifi.getValue());

  tela.begin(SSD1306_SWITCHCAPVCC, SCREEN_ADDRESS);
  tela.clearDisplay();
  tela.setTextSize(1);
  tela.setTextColor(SSD1306_WHITE);
  tela.setCursor(0, 0);
  tela.display();

  server.on("/", handleRoot);
  server.on("/save", handleSave);

  server.begin();
}

void loop()
{
  if (SerialESP.available())
  {
    String receivedData = SerialESP.readStringUntil('\n');
    receivedVoltage = receivedData.toFloat();

    Serial.print("Valor da tensão: ");
    Serial.println(receivedVoltage);
  }
  server.handleClient();

  temp1 = (receivedVoltage * 50);
  valormv = analogRead(PINO_SENSOR);
  temp = (valormv / 10) - 50;
  tempAlta = temp_padrao + histerese;
  tempBaixa = temp_padrao - histerese;

  if (humid == 1)
  {
    digitalWrite(LED_UMIDIFICADOR, HIGH);
  }
  else
  {
    digitalWrite(LED_UMIDIFICADOR, LOW);
  }
  if (alarme == 1 && (temp > tempAlta || temp < tempBaixa)) {
    digitalWrite(LED_ALARME, HIGH);
  }
  else
  {
    digitalWrite(LED_ALARME, LOW);
  }

  if (temp >= tempAlta)
  {
    digitalWrite(LED_TOK, LOW);
    digitalWrite(LED_AQUECEDOR, LOW);
    digitalWrite(LED_REFRIGERADOR, HIGH);
  }

  if (temp <= tempAlta && temp >= tempBaixa)
  {
    digitalWrite(LED_TOK, HIGH);
    digitalWrite(LED_AQUECEDOR, LOW);
    digitalWrite(LED_REFRIGERADOR, LOW);
  }

  if (temp <= tempBaixa)
  {
    digitalWrite(LED_TOK, LOW);
    digitalWrite(LED_REFRIGERADOR, LOW);
    digitalWrite(LED_AQUECEDOR, HIGH);
  }

  tela.clearDisplay();
  tela.setCursor(0, 0);
  tela.print("Temp: ");
  tela.println(temp);
  tela.print("Padrao: ");
  tela.println(temp_padrao);
  tela.print("T. menor permi.:");
  tela.println(tempBaixa);
  tela.print("T. maior permi.:");
  tela.println(tempAlta);
  tela.display();
  delay(1000);
}