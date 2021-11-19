FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_URLS http://+:80
COPY bin/Debug/netcoreapp3.1 .
ENTRYPOINT ["dotnet", "ExpanseManager.dll"]