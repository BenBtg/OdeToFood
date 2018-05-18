FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY ./publish .
EXPOSE 8081/tcp
ENV ASPNETCORE_URLS http://*:8081
ENTRYPOINT ["dotnet", "OdeToFood.dll"]