Team Members:
Franco Adonai
Roman Pereira Yost
Alvaro Garces

Running Services with Docker Compose
This README guides you through the steps to run frontend, backend, and database services using Docker Compose.

Preparation
Before you start, you will need to have Docker and Docker Compose installed on your machine. If you do not have them installed, you can find the installation instructions at the following links:

Docker: https://docs.docker.com/engine/install/
Docker Compose: https://docs.docker.com/compose/install/
Steps
Download Docker Images
Download the Docker images of the services using the following commands:
docker pull romanx91/frontend:latest
docker pull romanx91/backend:latest
docker pull romanx91/database:latest

Run Services with Docker Compose
Navigate to the directory where you created the docker-compose2.yml file and run the following command to start the services:
docker-compose up

This will start your services in the background and display the logs in the console.

Access the Services
Now you should be able to access your services on the ports you specified in the docker-compose.yml file. For example, if your frontend service is listening on port 4200, you can access it in your web browser at http://localhost:4200.
