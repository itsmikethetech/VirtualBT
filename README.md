# VirtualBT
VirtualBT is a Bluetooth server for Windows, designed to emulate input devices such as keyboards, mice, and game controllers.

The application leverages Windows Bluetooth Low Energy (LE) alongside the Windows GattServicesLibrary and SortedObservableCollection to function as a virtual Bluetooth input device. It aims to enable seamless connectivity with a wide range of devices, including smartphones and gaming consoles, that support Bluetooth input peripherals. Future enhancements will include support for mouse and gamepad emulation.

# Currently supported features:

- Bluetooth Device Scanning and Pairing: Supports scanning and pairing with Bluetooth devices using a security PIN for authentication.
- Generic Input Device Connectivity: Connects to devices as a standard input peripheral.
- Keyboard Input Simulation: Sends keyboard input to the connected device while the application is in focus.
