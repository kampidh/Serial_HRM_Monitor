# Serial HRM / SpO2 Monitor Arduino Code
The code is based on coniferconifer's [Simple SpO2 plotter for MH-ET LIVE MAX30102 with BLE](https://github.com/coniferconifer/ESP32_MAX30102_simple-SpO2_plotter/tree/master/ESP32_MAX30102_simple-SpO2_plotter-BLE) with a couple of modifications:

- BLE disabled by default
- LED and sound indicator are also disabled
- Removing SpO2 reference lines
- IR and Red values are sent with 3 decimal points instead
- Adding START "<" and END ">" markers to serial data stream for better data parsing
