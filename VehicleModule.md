```mermaid
graph TD
    A[Vehicle IoT Device Mind Map] --> B[Vehicle Integration]
    A --> C[IoT Device Features]
    A --> D[Communication Protocols]
    A --> E[Architecture Components]
    A --> F[Security & Compliance]

    B --> B1[Communication Ports]
    B --> B2[Vehicle Standards]
    B1 --> B1A[OBD-II]
    B1 --> B1B[CAN Bus]
    B1 --> B1C[Ethernet]
    B2 --> B2A[ISO 15765 - CAN]
    B2 --> B2B[SAE J1939]
    B2 --> B2C[ISO 11898 - CAN]

    C --> C1[Telemetry Data]
    C --> C2[Diagnostic Information]
    C --> C3[Real-Time Location]
    C --> C4[Vehicle Health Monitoring]

    D --> D1[MQTT]
    D --> D2[HTTP/HTTPS]
    D --> D3[CoAP]
    D --> D4[Bluetooth]
    D --> D5[LTE/4G/5G]

    E --> E1[Hardware]
    E --> E2[Software]
    E1 --> E1A[Sensors]
    E1 --> E1B[GPS Module]
    E1 --> E1C[Communication Module]
    E2 --> E2A[Firmware]
    E2 --> E2B[Data Processing]
    E2 --> E2C[Security]
    E2 --> E2D[Cloud Integration]

    F --> F1[Data Encryption]
    F --> F2[Authentication & Authorization]
    F --> F3[Regulatory Standards]


*
