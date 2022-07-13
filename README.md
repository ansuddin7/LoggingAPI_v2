# LoggingAPI
The following component diagram illustrates the desired software design for the Log API.
![alt text](https://github.com/ansuddin7/LoggingAPI/blob/main/Logging_API_Component_diagram.drawio.png?raw=true)

As part of the coding test I have implemented logging to the console and flat file. 

I have made the assumption that all DTO metadata is provided by the consumer of the API.

To support multiple logging locations I have used delegates. The registration of methods is centralized in the LogHandler.