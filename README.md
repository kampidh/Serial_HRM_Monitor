﻿# Serial HRM / SpO2 Monitor

![Screenshot](trendgraph.png)

A simple Windows Forms software to capture and monitor data from serial port. Heart rate and SpO2 data is provided by MAX30102 sensor through ESP32 based on a code from coniferconifer:
https://github.com/coniferconifer/ESP32_MAX30102_simple-SpO2_plotter

*Disclaimer:
For educational and recreational purpose only. NOT INTENDED FOR MEDICAL USE.*

## Prerequisites
- ESP32
- MH-ET LIVE MAX30102 Heart rate sensor
- Arduino with [SparkFun MAX301x Particle Sensor Library](https://github.com/sparkfun/SparkFun_MAX3010x_Sensor_Library)
- Windows 10 with .NET Framework 4.6.2

## Quick Setup Guide
- Upload the modified arduino code to ESP32 from the [provided sketch file](https://github.com/kampidh/Serial_HRM_Monitor/tree/master/ESP32_MAX30102_simple-SpO2_plotter-BLE_Mod) 
- Hook up the MAX30102 board to ESP32 (detailed guide on [coniferconifer's page](https://github.com/coniferconifer/ESP32_MAX30102_simple-SpO2_plotter)), *do not forget to solder the 3v3 jumper!*
- Add a thin sheet of plastic over the sensor. (The MAX30102 glass window is *quite thin and fragile*, handle it with care!)
- Use a rubber or velcro strap to attach the sensor to the finger snuggly, but not too tight. A good rule of thumb is make sure the sensor window sits flat with your skin.
- Connect the ESP32 to the PC and run the software.
- Select the proper COM port and click Connect. Make sure the data is displayed properly.

## Features
- **Real-time data acquisition**

Data from serial input is displayed as fast as possible.

![Data Page](datapage.png)


- **Streaming feature (OBS)**

Enable "Text output stream" to send the BPM and SpO2 data to a text file that can be used in OBS. Both raw and rounded format is available.
PPG Graph color is also customizable (right click the graph to see detailed config). Suit it for your stream! Use windows capture feature from OBS and adjust the crop correspondingly. *(Do not minimize the window when capturing the PPG Graph)*

![PPG](ppggraph.png)

PPG Graph tab

![Stream example](obsoverlay.jpg)

Example on OBS stream overlay


- **Trend graph & logging**

See the min and max value on a 5 minutes span graph on the application and the ability to log the data in .csv format to process it further.

![CSV Export](csvexport.png)


- **Save on exit**

Stream file path (txt) and PPG Graph config are saved on exit.


### LICENSED under Apache License 2.0
