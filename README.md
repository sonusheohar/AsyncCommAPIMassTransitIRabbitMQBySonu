# 🧩 ASP.NET Core RabbitMQ Flow


This diagram illustrates how **PublisherAPI** and **ConsumerAPI** interact through **RabbitMQ** using **MassTransit** in an ASP.NET Core environment.
![Asyn cCommunication API MassTransit RabbitMQ By Sonu Flow Diagram](AsyncCommAPIMassTransitIRabbitMQBySonuFlowDiagram.png)


## ⚙️ Flow Overview

### **PublisherAPI**
- Handles HTTP requests via Controllers.
- Publishes messages using **MassTransit**.
- Sends a `MyMessage` object to RabbitMQ Exchange.
- Message is routed to the queue **my-weather-queue**.

### **RabbitMQ Server**
- Acts as a message broker.
- Stores messages until consumed.
- Ensures reliable delivery and decoupled communication.

### **ConsumerAPI**
- Registers `ConsumerServices` with MassTransit.
- Subscribes to **my-weather-queue**.
- Processes incoming messages asynchronously.

### **MassTransit**
- Simplifies RabbitMQ integration.
- Handles serialization, routing, and retries.
- Connects publisher and consumer seamlessly.

---

## 🔄 Message Flow Diagram

