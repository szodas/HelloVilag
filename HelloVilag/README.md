# DevOps - Beadandó

![CI](https://github.com/szodas/HelloVilag/actions/workflows/ci.yml/badge.svg)

Gyurenka Richárd - X3I5VM

Egy egyszerű "Hello World" szintű app .NET 8-al

- HTTPS-n elérhető (8080), egy szöveges választ ad vissza
- trunk-based
- Build (lokál és konténer)
- konténerizálás dockerfile+futtatés fix 8080 porton

http://localhost:8080

futtatás lokálisan
dotnet run

#vagy explicit:
dotnet run --project ./HelloVilag.csproj

Loká build:
docker build -t hellovilag:v1 .


konténeres futtatás:

kódbeállítás program.cs-ben:
builder.WebHost.UseUrls("http://0.0.0.0:8080");

dockerfile:
EXPOSE 8080
ENV ASPNETCORE_URLS=http://0.0.0.0:8080

docker run --rm -p 8080:8080 hellovilag:v1

add CI badge

