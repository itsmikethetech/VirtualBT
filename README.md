# VirtualBT
VirtualBT is a Bluetooth server for Windows, designed to emulate input devices such as keyboards, mice, and game controllers.

The application leverages Windows Bluetooth Low Energy (through BluetoothLEExplorer) alongside the Windows GattServicesLibrary and SortedObservableCollection to function as a virtual Bluetooth input device. It aims to enable seamless connectivity with a wide range of devices, including smartphones and gaming consoles, that support Bluetooth input peripherals. Future enhancements will include support for mouse and gamepad emulation.

![image](https://github.com/user-attachments/assets/8b65ab9d-5251-4548-8508-420bed38fe9e)

![image](https://github.com/user-attachments/assets/9a8db4cf-554a-495d-8635-b314a6be9994)


# Currently supported features:

- Bluetooth Device Scanning and Pairing: Supports scanning and pairing with Bluetooth devices using a security PIN for authentication.
- Generic Input Device Connectivity: Connects to devices as a standard input peripheral.
- Keyboard Input Simulation: Sends keyboard input to the connected device while the application is in focus.

# Currently working on:

- Implementation of NXBT for Switch integration and Linux support. 
  ![image](https://github.com/user-attachments/assets/67bf9bb9-c2d3-48ed-8fa5-2a42ce448bcf)

# Special Thanks and Contributors

A big thank you goes out to all the contributors at the Brikwerk/nxbt and dekuNukem/Nintendo_Switch_Reverse_Engineering repositories! Almost all information pertaining to the innerworkings of the Nintendo Switch Controllers comes from the documentation and code in those repos. Without it, NXBT and this project wouldn't have been possible.

# Licencing

- All code, unless otherwise stated, is licensed under the GPL 3 License.
- Code by Microsoft is licensed as MIT.
- NXBT is licensed as MIT.
