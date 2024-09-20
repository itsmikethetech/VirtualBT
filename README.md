# VirtualBT
A Windows-host Bluetooth server designed to simulate input devices such as keyboards, mice, and gamepads.

The goal of this is to build upon Windows Bluetooth LE (along with the Windows GattServicesLibrary and SortedObservableCollection) to create a use-specific app that can act as a virtual Bluetooth device which can connect to any device (phone, game console, etc.) that supports it. Eventually, I would like to implement mouse and gamepad support. 

# Currently supported features:

- Scanning and Pairing to Bluetooth Devices using a Security Pin to confirm.
- Connecting to devices as a generic input device.
- Sending keyboard input to the device it is connected to (while the app is in focus).
