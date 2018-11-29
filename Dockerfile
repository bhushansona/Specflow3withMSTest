FROM microsoft/dotnet:2.1.401-sdk
ARG source
WORKDIR /app
COPY . /app
RUN dotnet test /app/Specflow3.0Check --logger "trx;LogFileName=scenario_tests.trx" --results-directory "TestResults"