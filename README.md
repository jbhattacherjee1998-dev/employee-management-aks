# Employee Management API - AKS Deployment Project

## Overview

This project demonstrates the deployment of an ASP.NET Core Web API to Azure Kubernetes Service (AKS) using Docker containers and Azure Container Registry (ACR).

The application is containerized using Docker, stored in Azure Container Registry, and deployed to AKS using Kubernetes Deployment and Service manifests.

---

## Architecture

.NET Web API
│
▼
Docker Image
│
▼
Azure Container Registry (ACR)
│
▼
AKS Cluster
│
▼
Kubernetes Deployment
│
▼
Service (LoadBalancer)
│
▼
Public Endpoint

---

## Technologies Used

* ASP.NET Core Web API
* Docker
* Kubernetes
* Azure Kubernetes Service (AKS)
* Azure Container Registry (ACR)
* Azure CLI
* kubectl

---

## Project Structure

employee-management-aks/

├── Controllers/

├── Properties/

├── k8s/

│   ├── deployment.yaml

│   └── service.yaml

├── Dockerfile

├── Program.cs

├── appsettings.json

├── appsettings.Development.json

├── employee-management-aks.csproj

└── README.md

---

## Folder Explanation

### Controllers

Contains API controllers and endpoints.

Example:

* EmployeeController.cs

Responsible for handling HTTP requests and returning responses.

---

### Program.cs

Application startup file.

Responsibilities:

* Configure Services
* Dependency Injection
* Middleware Configuration
* Routing
* Swagger Configuration

---

### appsettings.json

Stores application configuration values.

Examples:

* Connection Strings
* Logging Configuration
* API Settings

---

### Dockerfile

Used to build the Docker image.

Example flow:

1. Restore packages
2. Build application
3. Publish application
4. Create runtime image
5. Run application

Build Image:

docker build -t employee-management-api:v1 .

---

### k8s Folder

Contains Kubernetes manifests.

#### deployment.yaml

Responsible for:

* Pod Creation
* Replica Management
* Image Pulling
* Container Configuration

Example:

Replicas = 2

Image = employee-management-api:v1

Port = 80

---

#### service.yaml

Responsible for exposing application.

Type:

LoadBalancer

This creates a public IP for external access.

---

## Run Application Locally

Restore Packages

dotnet restore

Build

dotnet build

Run

dotnet run

Swagger URL

https://localhost:5001/swagger

---

## Docker Commands

Build Image

docker build -t employee-management-api:v1 .

Run Container

docker run -d -p 8080:80 employee-management-api:v1

Verify

docker ps

Access API

http://localhost:8080/swagger

---

## Azure Container Registry

Login

az acr login --name <acr-name>

Tag Image

docker tag employee-management-api:v1 <acr-name>.azurecr.io/employee-management-api:v1

Push Image

docker push <acr-name>.azurecr.io/employee-management-api:v1

---

## Azure Kubernetes Service

Create AKS Cluster

az aks create 
--resource-group aks-rg 
--name employee-aks 
--node-count 2 
--generate-ssh-keys

Connect Cluster

az aks get-credentials 
--resource-group aks-rg 
--name employee-aks

Verify

kubectl get nodes

---

## Deploy Application

Deploy Resources

kubectl apply -f k8s/

Verify Pods

kubectl get pods

Verify Deployment

kubectl get deployments

Verify Service

kubectl get svc

---

## Access Application

Retrieve External IP

kubectl get svc

Example Output

EXTERNAL-IP = 20.xx.xx.xx

Application URL

http://20.xx.xx.xx/swagger

---

## Learning Outcomes

This project demonstrates:

* Containerization using Docker
* Image management using Azure Container Registry
* Kubernetes Deployments
* Kubernetes Services
* AKS Cluster Management
* Application Deployment on Azure
* Microservices Deployment Concepts
* Cloud Native Application Hosting

---

## Future Enhancements

* Azure DevOps CI/CD Pipeline
* Helm Charts
* Ingress Controller
* Application Gateway
* Monitoring with Azure Monitor
* Horizontal Pod Autoscaling
* Key Vault Integration
* Terraform Infrastructure Deployment

---

## Author

Jonmenjoy Bhattacherjee

Azure DevOps | Cloud Engineer | .NET Developer
