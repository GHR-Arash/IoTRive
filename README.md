```mermaid
sequenceDiagram
    participant V as Vehicle (IoT Device)
    participant G as IoT Gateway
    participant TP as Telematics Processing Service
    participant DS as Data Storage
    participant NS as Notification Service
    participant U as User (Mobile/Web App)

    V->>G: Send telemetry data (MQTT/CoAP/HTTP)
    G->>TP: Forward telemetry data
    TP->>DS: Store processed data
    TP->>NS: Generate alert (if condition met)
    NS->>U: Send alert notification

    Note over V,G: Secure connection established
    Note over G,TP: Protocol translation (if needed)
    Note over TP: Data analysis & processing
    Note over NS,U: Alert based on user preferences

