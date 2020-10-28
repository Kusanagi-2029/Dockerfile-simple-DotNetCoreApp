# Dockerfile and the way of catching bugs. 
Here is my first experience with a Dockerfile creating on .NetCore App.

Сама документация Майкрософт: https://docs.microsoft.com/ru-ru/dotnet/core/docker/build-container?tabs=windows

Здесь я описал проблемы, с которыми столкнулся при пошаговом прохождении по документации от Майкрософт, и сообщил об этом ребзям из Docker: 
https://github.com/docker/buildx/issues/415

![docker-error 1](https://user-images.githubusercontent.com/71845085/97424304-93401e00-1921-11eb-9109-47b9b531eb00.PNG)
![docker-error 2](https://user-images.githubusercontent.com/71845085/97424318-989d6880-1921-11eb-8913-d1549803f980.PNG)
![docker-error 3](https://user-images.githubusercontent.com/71845085/97424321-99ce9580-1921-11eb-8a4d-852952cb51d0.PNG)

![docker-error 8](https://user-images.githubusercontent.com/71845085/97424342-9f2be000-1921-11eb-87ac-cd4f0a931b77.PNG)

Та же ситуация на Ubuntu 20.04 в WSL2 по документации на сайте самого Docker:

![docker-error 4](https://user-images.githubusercontent.com/71845085/97424328-9affc280-1921-11eb-841c-d88fcf76f6f6.PNG)

А вот так ситуация выглядит в Windows & PowerShell:

![docker-error 5](https://user-images.githubusercontent.com/71845085/97424333-9c30ef80-1921-11eb-8fa9-f802d8a64d76.PNG)
![docker-error 6](https://user-images.githubusercontent.com/71845085/97424336-9cc98600-1921-11eb-9c4d-095e931c2c34.PNG)
![docker-error 7](https://user-images.githubusercontent.com/71845085/97424340-9dfab300-1921-11eb-96da-beef5dcb8fa9.PNG)
![simpleNetCoreApp](https://user-images.githubusercontent.com/71845085/97424386-afdc5600-1921-11eb-8d41-012b3950336e.PNG)

Спасибо за уделённое время этому куску Г ( ГитХаба)!
 Скорее всего, сейчас Вы смотрите на меня так же, но я только учусь!

![me](https://user-images.githubusercontent.com/71845085/97424264-86232f00-1921-11eb-9083-b05d2b951591.png)
