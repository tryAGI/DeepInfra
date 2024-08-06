dotnet tool install --global openapigenerator.cli --prerelease
curl -o openapi.yaml https://api.deepinfra.com/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
  echo "Failed, exiting..."
  exit 1
fi
rm -rf Generated
oag generate openapi.yaml \
  --namespace DeepInfra \
  --clientClassName DeepInfraApi \
  --targetFramework net8.0 \
  --output Generated