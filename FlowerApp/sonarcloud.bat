dotnet sonarscanner begin /o:"mihaelaamt" /k:"MihaelaAmt_FlowerShop" /d:sonar.host.url="https://sonarcloud.io"
dotnet build
dotnet sonarscanner end
pause