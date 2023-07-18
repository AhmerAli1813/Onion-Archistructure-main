# Onion-Architecture
Onion Architecture is based on the inversion of control principle. Onion Architecture is comprised of multiple concentric layers interfacing with each other towards the core that represents the domain. The architecture does not depend on the data layer as in classic multi-tier architectures but on the actual domain models.
# Domain-Entity-Layer
Domain Entity Layer deepest  level of the Onion Architecture Containing all Application Domain Entities
# Repository-Pattern
Repository Layer (Infrastructure)
The repository layer is between the Services and the model object. All Database migration and application data context object communication occurs here. It consists of a read & writes data access pattern for the database
# Service APIs
Services Layers
Services Layers Consists of exposable APIs, and are responsible for the communication between the Repository Layers and the main project. These layers also contain an entity business logic and the interface is maintained stand-for from the implementation loose coupling and separation.
# UI Main-Project
The user interface (UI) is nothing more than the front-end program that communicates with ApIs (Services)
