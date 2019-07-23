FROM microsoft/dotnet:2.2-sdk
WORKDIR /app

COPY .publish/MyWeb2 /app

RUN find /app

ENV ASPNETCORE_URLS http://+:5000
EXPOSE 5000

ENTRYPOINT [ "dotnet", "MyWeb2.dll" ]