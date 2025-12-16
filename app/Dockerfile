
FROM debian:latest
WORKDIR /app
RUN apt update 
RUN apt install -y wget 
RUN wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN rm packages-microsoft-prod.deb

RUN  apt-get update && apt install -y aspnetcore-runtime-9.0

COPY /app/bin/Debug/net9.0/ . 


