# Dockerfile and the way of catching bugs. 
Here is my first experience with a Dockerfile creating on .NetCore App.

Сама документация Майкрософт: https://docs.microsoft.com/ru-ru/dotnet/core/docker/build-container?tabs=windows

Здесь я описал проблемы, с которыми столкнулся при пошаговом прохождении по документации от Майкрософт, и сообщил об этом ребзям из Docker: 
https://github.com/docker/buildx/issues/415

А вот видео на youtube, в котором я ВКРАТЦЕ излагаю проблему: https://www.youtube.com/watch?v=w-eJDx-Lq1g

![docker-error 1](https://user-images.githubusercontent.com/71845085/97424304-93401e00-1921-11eb-9109-47b9b531eb00.PNG)
![docker-error 2](https://user-images.githubusercontent.com/71845085/97424318-989d6880-1921-11eb-8913-d1549803f980.PNG)
![docker-error 3](https://user-images.githubusercontent.com/71845085/97424321-99ce9580-1921-11eb-8a4d-852952cb51d0.PNG)

![docker-error 8](https://user-images.githubusercontent.com/71845085/97424342-9f2be000-1921-11eb-87ac-cd4f0a931b77.PNG)

Та же ситуация на Ubuntu 20.04 в WSL2 по документации на сайте самого Docker:

![docker-error 4](https://user-images.githubusercontent.com/71845085/97424328-9affc280-1921-11eb-841c-d88fcf76f6f6.PNG)

А вот так ситуация выглядит в Windows & PowerShell по документации Майкрософт:

![docker-error 5](https://user-images.githubusercontent.com/71845085/97424333-9c30ef80-1921-11eb-8fa9-f802d8a64d76.PNG)
![docker-error 6](https://user-images.githubusercontent.com/71845085/97424336-9cc98600-1921-11eb-9c4d-095e931c2c34.PNG)
![docker-error 7](https://user-images.githubusercontent.com/71845085/97424340-9dfab300-1921-11eb-96da-beef5dcb8fa9.PNG)

1) Итак, мы создали .netCore приложение в C:\Users\vanger_biburat\source\repos\NetCore_Docker\App ;
2) Опубликовали его, предварительно проверив: dotnet publish -c Release ;
3) Убедились при помощи команды Get-ChildItem -Path C:\Users\vanger_biburat\source\repos\NetCore_Docker\App\bin\Release\netcoreapp3.1\publish -Force, что в указанной в команде директории был создан файл NetCore.Docker.dll ;
4) В папке с проектом (.csproj) создали текстовый файл без указания расширения Dockerfile с инструкциями для Docker'а;
5) Забилдили образ с названием counter-image нашего приложения: docker build -t counter-image -f Dockerfile.txt . ;

Обратите внимание! Мы, в отличие от примера в документации от Майкрософт, в команде УКАЗЫВАЕМ расширение Dockerfile: Dockerfile.txt. Иначе сам Docker его не видит!

6) Произвели однократный запуск контейнера: docker run -it --rm counter-image ;

Docker предоставляет единую команду docker run для создания и запуска контейнера. Она исключает необходимость в поочередном выполнении команд docker create и docker start. Вы также можете настроить ее для автоматического удаления контейнера при его остановке. Например, команда docker run -it --rm выполняет две операции. Сначала она автоматически подключается к контейнеру с помощью текущего терминала, а потом, после завершения работы контейнера, удаляет его.

![simpleNetCoreApp2](https://user-images.githubusercontent.com/71845085/97429341-59bee100-1928-11eb-9548-343739ab9652.PNG)
![simpleNetCoreApp](https://user-images.githubusercontent.com/71845085/97429344-5c213b00-1928-11eb-99ec-956d054111d0.PNG)
![simpleNetCoreApp1](https://user-images.githubusercontent.com/71845085/97429346-5cb9d180-1928-11eb-91e3-3d2383c1aefa.PNG)


Спасибо за уделённое время этому куску Г... ( ГитХаба)!
 Скорее всего, сейчас Вы смотрите на меня так же, но я только учусь!

![me](https://user-images.githubusercontent.com/71845085/97424264-86232f00-1921-11eb-9083-b05d2b951591.png)
